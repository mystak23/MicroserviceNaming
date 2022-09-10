using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MicroserviceNaming;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args) 
    {
        string input = @"{
        'Category':'neco',
        'Subcategory':'neco',
        'Description':'neco'
        }";
        
        //https://www.c-sharpcorner.com/article/working-with-json-string-in-C-Sharp/
        
        GeneratingName.loadJson(input);
        
        string useCaseName = GeneratingName.getGeneratedName();
        
        Console.WriteLine("Use case name: " + useCaseName);
    }
}
    
