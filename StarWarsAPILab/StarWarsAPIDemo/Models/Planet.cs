using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarWarsAPIDemo.Models
{
    public class Planet
    {
        public string Name { get; set; }

        public Planet(string APIText)
        {
            JObject planet = JObject.Parse(APIText);

            Name = (string)planet["name"];

        }
    }
}