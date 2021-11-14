﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    public class UserInfoLogin
    {
        public UserInfoLogin()
        {

        }

        [BindProperty]
        public string _id { get; set; } // used as an identified for the update method

        [BindProperty]
        [Required(ErrorMessage = "Username is Required!")]
        //[JsonProperty("Username")]
        public string Username { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password required!")]
        [DataType(DataType.Password)]
        //[JsonProperty("Password")]
        public string Password { get; set; }

        public void cleanLoginUser()
        {
            this._id = "";
            this.Username = "";
            this.Password = "";
        }


        private char[] forbiddenChars = new char[] { '<', '>', ',', '.', '{', '}', '[', ']', '%', '&', '/', ' ', '+', '-', '`', '~' , '\"', '\'', '?', ':', ';', '#', '$', '^','*','(',')'};

        public bool verifyUsernameIntegrity()
        {

            foreach(char a in forbiddenChars)
            {
                if (Username.Contains(a))
                {
                    return false;
                }
            }

            return true;
        }

        public bool verifyPasswordIntegrity()
        {

            foreach (char a in forbiddenChars)
            {
                if (Password.Contains(a))
                {
                    return false;
                }
            }

            return true;
        }

    }


}
