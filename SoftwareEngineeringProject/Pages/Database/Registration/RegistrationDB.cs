﻿using Nancy.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    /*
     * Database that contains all the registration information.
     * Does not contain any information about event just the UserID and the EventID
     * The RegistrationDB.cs class is the helper function for this database.
     */
    public class RegistrationDB
    {

        private string BaseDatabaseUrl = "https://userinfo-3e1c.restdb.io/rest/registration";
        private string apiKey;

        public RegistrationDB(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public bool insertRegistration(Registration reg)
        {
            var client = new RestClient(BaseDatabaseUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"UserInfo_ID\":\"" + reg.UserInfo_ID + "\",\"Event_ID\":\"" + reg.Event_ID + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            ResponseStatus rs = response.ResponseStatus;
            return response.IsSuccessful;
            
        }

        public bool updateRegistration(Registration reg)
        {
            string updateUrl = BaseDatabaseUrl + "/" + reg._id + "";
            var client = new RestClient(updateUrl);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"UserInfo_ID\":\"" + reg.UserInfo_ID + "\",\"Event_ID\":\"" + reg.Event_ID + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;
        }

        public bool deleteRegistration(string id)
        {
            var deleteUrl = BaseDatabaseUrl + "/" + id + "";
            var client = new RestClient(deleteUrl);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }

        public Registration[] selectUserRegisteredEventByUserID(string userID)
        {
            // q={ "status": "A" }
            string QueryDatabaseUrl = BaseDatabaseUrl + "?q={ \"UserInfo_ID\": \""+userID+"\" }";

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Registration[] userRegistrationList = js.Deserialize<Registration[]>(response.Content);
                return userRegistrationList;
            }
            else
            {
                return null;
            }

        }

        public Registration[] selectUserRegisteredEventByEventID(string eventID)
        {
            // q={ "status": "A" }
            string QueryDatabaseUrl = BaseDatabaseUrl + "?q={ \"Event_ID\": \"" + eventID + "\" }";

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Registration[] userRegistrationList = js.Deserialize<Registration[]>(response.Content);
                return userRegistrationList;
            }
            else
            {
                return null;
            }

        }

        public Registration[] selectUserRegisteredEventByUserIDAndEventID(string userID, string eventID)
        {
            // q={ "status": "A" }
            string QueryDatabaseUrl = BaseDatabaseUrl + "?q={ \"Event_ID\": \"" + eventID + "\" , \"UserInfo_ID\":\""+userID+"\"}";

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Registration[] userRegistrationList = js.Deserialize<Registration[]>(response.Content);
                return userRegistrationList;
            }
            else
            {
                return null;
            }

        }

        // this will get the registration by its unqiue registration number
        public Registration selectRegistrationByID(string _id)
        {
            string QueryDatabaseUrl = BaseDatabaseUrl + "/"+_id;

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Registration userRegistrationList = js.Deserialize<Registration>(response.Content);
                return userRegistrationList;
            }
            else
            {
                return null;
            }
        }

        public Registration[] selectAllRegisteredEvents()
        {
            var client = new RestClient(this.BaseDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Registration[] userRegistrationList = js.Deserialize<Registration[]>(response.Content);
                return userRegistrationList;
            }
            else
            {
                return null;
            }
        }
    }
}
