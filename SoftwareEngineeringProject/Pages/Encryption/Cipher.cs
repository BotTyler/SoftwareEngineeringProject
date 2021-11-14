using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace SoftwareEngineeringProject.Pages.Encryption
{
        /// <summary>
        /// Cipher is a wrapper of System.Security.Cryptography.SymmetricAlgorithm classes
        /// and simplifies the interface. It supports customized SymmetricAlgorithm as well.
        /// </summary>
        public class Cipher
        {
            /// <remarks>
            /// Supported .Net intrinsic SymmetricAlgorithm classes.
            /// </remarks>
            public enum SymmProvEnum : int
            {
                DES, RC2, Rijndael
            }

            private SymmetricAlgorithm mobjCryptoService;

            /// <remarks>
            /// Constructor for using an intrinsic .Net SymmetricAlgorithm class.
            /// </remarks>
            public Cipher(SymmProvEnum NetSelected)
            {
                switch (NetSelected)
                {
                    case SymmProvEnum.DES:
                        mobjCryptoService = new DESCryptoServiceProvider();
                        break;
                    case SymmProvEnum.RC2:
                        mobjCryptoService = new RC2CryptoServiceProvider();
                        break;
                    case SymmProvEnum.Rijndael:
                        mobjCryptoService = new RijndaelManaged();
                        break;
                }
            }

            /// <remarks>
            /// Constructor for using a customized SymmetricAlgorithm class.
            /// </remarks>
            public Cipher(SymmetricAlgorithm ServiceProvider)
            {
                mobjCryptoService = ServiceProvider;
            }

            /// <remarks>
            /// Depending on the legal key size limitations of a specific CryptoService provider
            /// and length of the private key provided, padding the secret key with space character
            /// to meet the legal size of the algorithm.
            /// </remarks>
            private byte[] GetLegalKey(string Key)
            {
                string sTemp;
                sTemp = Key.PadRight(mobjCryptoService.LegalKeySizes[0].MinSize / 8, ' ').Substring(0, mobjCryptoService.LegalKeySizes[0].MaxSize / 8);

                // convert the secret key to byte array
                return ASCIIEncoding.ASCII.GetBytes(sTemp);
            }

            private byte[] ConvertStringToByteArray(string stringToConvert)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                return encoding.GetBytes(stringToConvert);
                //return (new UnicodeEncoding()).GetBytes(stringToConvert);
            }

            private string ConvertByteArrayToString(byte[] arrayToConvert)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                return encoding.GetString(arrayToConvert);
                //return (new UnicodeEncoding()).GetBytes(stringToConvert);
            }

            public string Encrypt(string Source, string Key)
            {
                //byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(System.Web.HttpUtility.UrlEncode(Source));
                byte[] bytIn = ConvertStringToByteArray(System.Convert.ToBase64String(ConvertStringToByteArray(Source)));
                // create a MemoryStream so that the process can be done without I/O files
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                byte[] bytKey = GetLegalKey(Key);

                // set the private key
                mobjCryptoService.Key = bytKey;
                mobjCryptoService.IV = bytKey;

                // create an Encryptor from the Provider Service instance
                ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();

                // create Crypto Stream that transforms a stream using the encryption
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);

                // write out encrypted content into MemoryStream
                cs.Write(bytIn, 0, bytIn.Length);
                cs.FlushFinalBlock();

                // get the output and trim the '\0' bytes
                byte[] bytOut = ms.GetBuffer();
                int i = 0;
                for (i = 0; i < bytOut.Length; i++)
                    if (bytOut[i] == 0)
                        break;

                // convert into Base64 so that the result can be used in xml
                return System.Convert.ToBase64String(bytOut, 0, i);
            }

            public string Decrypt(string Source, string Key)
            {
                // convert from Base64 to binary
                byte[] bytIn = System.Convert.FromBase64String(Source);
                // create a MemoryStream with the input
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

                byte[] bytKey = GetLegalKey(Key);

                // set the private key
                mobjCryptoService.Key = bytKey;
                mobjCryptoService.IV = bytKey;

                // create a Decryptor from the Provider Service instance
                ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();

                // create Crypto Stream that transforms a stream using the decryption
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);


                // read out the result from the Crypto Stream
                System.IO.StreamReader sr = new System.IO.StreamReader(cs);
                string sEncoded = sr.ReadToEnd();

                return ConvertByteArrayToString(System.Convert.FromBase64String(sEncoded));
                //return System.Web.HttpUtility.UrlDecode(sEncoded);
            }
        }
    }


