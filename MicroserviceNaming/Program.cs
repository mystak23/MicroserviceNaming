using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        string usecase = getOneUseCase(input);

        //je potreba si definovat, zda microservice udela jen jeden name a bude se volat neustale, nebo zde bude nejaky loop
        
       /* bool condition = true; //potreba kdyztak definovat

        while (condition)
        {
            string usecase = getOneUseCase(input);
        }*/
    }

 
    private static string getOneUseCase(string input)
    {
        GeneratingName generatingName = new GeneratingName();
        generatingName.loadJson(input);
        return generatingName.getGeneratedName();
    }
 }
    
