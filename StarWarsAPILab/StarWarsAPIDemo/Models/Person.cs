using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StarWarsAPIDemo.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string HomePlanet { get; set; }

        public Person(string APIText)
        {
            JObject person = JObject.Parse(APIText);

            Name = (string)person["name"];

            string species = StarWarsDAL.GetData((string)person["species"][0]);
            JObject speciesOBJ = JObject.Parse(species);
            Species = (string)speciesOBJ["name"];

            Gender = (string)person["gender"];

            string homePlanet = StarWarsDAL.GetData((string)person["homeworld"]);
            JObject homePlanetOBJ = JObject.Parse(homePlanet);
            HomePlanet = (string)homePlanetOBJ["name"];

        }
    }
}