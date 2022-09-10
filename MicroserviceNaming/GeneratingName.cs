using System;
using Newtonsoft.Json;

namespace MicroserviceNaming
{
    public class GeneratingName
    {

        private static string loadedJson;

        public static void loadJson(string json)
        {
            json = loadedJson;
        }
        
        public static string getGeneratedName() //vystup
        {
            return loadedJson;
        }
        
    }
}