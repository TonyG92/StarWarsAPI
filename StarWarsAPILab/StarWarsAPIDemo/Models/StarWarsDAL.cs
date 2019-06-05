using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Linq;
using System.IO;

namespace StarWarsAPIDemo.Models
{
    public class StarWarsDAL
    {
        public static string GetData(string url)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                StreamReader data = new StreamReader(response.GetResponseStream());
                string dataString = data.ReadToEnd();
                return dataString;
            }
            return null;
        }

        public static Person GetPerson(int i)
        {
           string data = GetData($"https://swapi.co/api/people/{i}/");

            Person person = new Person(data);
            return person;
        }
        public static Planet GetPlanet(int i)
        {
            string data = GetData($"https://swapi.co/api/planets/{i}/");

            Planet planet = new Planet(data);
            return planet;
        }
    }
}