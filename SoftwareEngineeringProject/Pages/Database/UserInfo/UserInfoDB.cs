using Microsoft.Extensions.Configuration;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
     * The use of http request will be used for every standard database function.
     */
    public class UserInfoDB
    {
        private string BaseDatabaseUrl = "https://userinfo-3e1c.restdb.io/rest/userinformation";
        private string apiKey;

       /* you can get the apikey/setup the object by using the following line:
        * UserInfoDB db = new UserInfoDB(_configuration["ApiKey:DefaultKey"]);
        * see LoginPage.cshtml.cs for an example
        */
        public UserInfoDB(string apiKey)
        {
            this.apiKey = apiKey;
        }

        // post request to insert a user into the database
        public int insertUser(UserInfoLogin user)
        {
            var client = new RestClient(BaseDatabaseUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"Username\":\""+user.Username+"\",\"Password\":\""+user.Password+"\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            ResponseStatus rs = response.ResponseStatus;
            bool success = response.IsSuccessful;
            if (rs == ResponseStatus.Completed && success == true)
            {
                return 0; // completed
            }else if(rs == ResponseStatus.Completed && success == false)
            {
                return 1; // username already exist
            }
            else
            {
                return 2; // network error
            }
        }

        public bool deleteUser(UserInfoLogin user)
        {
            var deleteUrl = BaseDatabaseUrl + "/"+user._id+"";
            var client = new RestClient(deleteUrl);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }

        // Not sure if this works
        public bool updateUserPassword(UserInfoLogin user, string newPassword)
        {
            string updateUrl = BaseDatabaseUrl + "/" + user._id + "";
            var client = new RestClient(updateUrl);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"Password\":\""+newPassword+"\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }

        public UserInfoLogin[] getAllUsers()
        {
            var client = new RestClient(BaseDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                UserInfoLogin[] userList = js.Deserialize<UserInfoLogin[]>(response.Content);
                return userList;
            }
            else
            {
                return null;
            }
        }

        public UserInfoLogin[] getUsersByUsername(string username)
        {
            string QueryDatabaseUrl = BaseDatabaseUrl + "?q={\"Username\": \"" + username + "\"}";

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                UserInfoLogin[] userList = js.Deserialize<UserInfoLogin[]>(response.Content);
                return userList;
            }
            else
            {
                return null;
            }
        }

        public bool validateUserInformation(UserInfoLogin loginUser)
        {
            UserInfoLogin[] listOfUsers = getUsersByUsername(loginUser.Username);
            foreach(UserInfoLogin user in listOfUsers) {
                if (loginUser.Username.Equals(user.Username) && loginUser.Password.Equals(user.Password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
