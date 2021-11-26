using Nancy.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Pages.Database
{
    /*
     * Database that contains all the event information.
     * Does not contain any registration information just the events.
     * The Event.cs class is the helper function for this database.
     */
    public class EventDB
    {

        private string BaseDatabaseUrl = "https://userinfo-3e1c.restdb.io/rest/event";
        private string apiKey;

        public EventDB(string apiKey)
        {
            this.apiKey = apiKey;
        }
        private string formatEventParam(Event regEvent)
        {
            //"{\"Username\":\"" + regEvent.Username + "\",\"Password\":\"" + regEvent.Password + "\"}"
            string param = "{";
            param += "\"EventName\":\""+regEvent.EventName+"\",";
            param += "\"EventDate\":\"" + regEvent.EventDate.ToString("MM/dd/yyyy") + "\",";
            param += "\"EventDescription\":\"" + regEvent.EventDescription + "\",";
            param += "\"Owner_ID\":\"" + regEvent.Owner_ID + "\",";
            param += "\"EventLocation\":\"" + regEvent.EventLocation + "\",";
            param += "\"NumberOfSlots\":\"" + regEvent.NumberOfSlots + "\",";
            param += "\"AvailableSlots\":\"" + regEvent.AvailableSlots + "\"";
            

            param += "}";
            return param;
        }
        public bool insertEvent(Event regEvent)
        {
            var client = new RestClient(BaseDatabaseUrl);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");

            request.AddParameter("application/json", formatEventParam(regEvent), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;
        }

        public bool updateEvent(Event updateEvent)
        {
            string updateUrl = BaseDatabaseUrl + "/" + updateEvent._id + "";
            var client = new RestClient(updateUrl);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", formatEventParam(updateEvent), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;
        }

        public bool deleteEvent(string _id)
        {
            var deleteUrl = BaseDatabaseUrl + "/" + _id + "";
            var client = new RestClient(deleteUrl);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);

            return response.IsSuccessful;
        }

        public Event[] selectAllEvents()
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
                Event[] eventList = js.Deserialize<Event[]>(response.Content);
                return eventList;
            }
            else
            {
                return null;
            }
        }

        public Event[] selectEvents(string search)
        {
            //q={ "user_id": {"$regex" :"bc"}}
            string QueryDatabaseUrl = BaseDatabaseUrl + "?q={ \"EventName\": {\"$regex\" :\""+search+"\"}}";

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Event[] userList = js.Deserialize<Event[]>(response.Content);
                return userList;
            }
            else
            {
                return null;
            }


        }

        public Event selectEventByID(string _id)
        {
            //q={ "user_id": {"$regex" :"bc"}}
            string QueryDatabaseUrl = BaseDatabaseUrl + "/" +_id;

            var client = new RestClient(QueryDatabaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", this.apiKey);
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {

                JavaScriptSerializer js = new JavaScriptSerializer();
                Event userList = js.Deserialize<Event>(response.Content);
                return userList;
            }
            else
            {
                return null;
            }


        }
    }
}
