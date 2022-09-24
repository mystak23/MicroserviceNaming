using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MicroserviceNaming
{
    public class GeneratingName
    {

        private string loadedJson;

        private string title;
        private string logsource;
        private string tags;
        private string description;

        public void loadJson(string json)
        {
            json = loadedJson;
        }

        public void generateName()
        {
            dynamic data = JObject.Parse(loadedJson);
            title = string.Concat(data.Title);
            logsource = string.Concat(data.LogSource);
            tags = string.Concat(data.Tags);
            description = string.Concat(data.Description);
        }

        //techto 5 metod bude obsahovat algoritmy pro prevody napriklad 
        
                //linux -> lin
                //microsoft -> mcsft
                //attack impact 12345 -> neuspesna prihlaseni -> failed_login
                
                //atd...
        
        private string getLes1()
        {
            return "os";
        }
        
        private string getLes2()
        {
            return "win";
        }
        
        private string getVendor()
        {
            return "mcsft";
        }
        
        private string getCategory()
        {
            return "malware";
        }
        
        private string getTitle()
        {
            return "trojan";
        }
        
        public string getGeneratedName() //vystup
        {
            //potom se tam vygeneruji pomoci metod vyse
            
            string les1 = getLes1(); //nt, sa, oa
            string les2 = getLes2(); //lin, mac, gaya - os
                                    //router, switch, firewall, nids ... - nt
            string vendor = getVendor(); //other, kasp, ...
            string category = getCategory();
            string title = getTitle();

            loadedJson = les1 + "_" + les2 + "_"+ vendor + "_"+ category + "-" + title;
            
            return loadedJson;
        }
        
    }
}