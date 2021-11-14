using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    /*
     * This class will be using a NoSql database.
     * In other words, no formal creation of a datbase object is needed.
     * The use of http request will be used for every function.
     */
    public class UserInfoDB
    {

        public UserInfoDB()
        {

        }
        public void insertUser(UserInfo user)
        {

        }

        public void deleteUser(UserInfo user)
        {

        }

        public void updateUser(UserInfo user)
        {

        }

        public UserInfo[] getUsers()
        {
            UserInfo[] a = { new UserInfo() };
            var client = new RestClient("https://userinfo-3e1c.restdb.io/rest/userinformation");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "f7472ab661999bbedef1720ddd6e72a54f99d");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            return a;
        }

        public bool validateUserInformation(UserInfo loginUser)
        {
            string username = ""; // change when i get the json file
            string password = ""; // change when i get the json file

            if(loginUser.UName.Equals(username) && loginUser.PWord.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
