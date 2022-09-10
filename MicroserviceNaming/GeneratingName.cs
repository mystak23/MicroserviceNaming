using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MicroserviceNaming
{
    public class GeneratingName
    {

        private string loadedJson;

        public void loadJson(string json)
        {
            json = loadedJson;
        }

        public void generateName()
        {
            dynamic data = JObject.Parse(loadedJson);
            string category = string.Concat(data.Category);
            string subcategory = string.Concat(data.Subcategory);
            //string description = string.Concat(data.Description);

            loadedJson = category + ": " + subcategory;
        }
        
        public string getGeneratedName() //vystup
        {
            return loadedJson;
        }
        
        public class UseCase
        {
            public string Category {
                get;
                set;
            }
            public string Subcategory {
                get;
                set;
            }
            public string Description {
                get;
                set;
            }
        }
    }
}