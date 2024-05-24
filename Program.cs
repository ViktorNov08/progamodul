using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace EmployeeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"C:\Users\Viktor.Novosad\source\repos\progaas\progaas\employees.xml:");
            string inputXmlFilePath = Console.ReadLine();

            if (!File.Exists(inputXmlFilePath))
            {
                Console.WriteLine("Файл не знайдено");
                return;
            }

            
            Console.WriteLine(@"C:\Users\Viktor.Novosad\source\repos\progaas\progaas\sorted_employes.xmll:");
            string outputXmlFilePath = Console.ReadLine();

           
            Console.WriteLine(@"C:\Users\Viktor.Novosad\source\repos\progaas\progaas\employees.txt:");
            string outputTxtFilePath = Console.ReadLine();

         
            

       
        class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public DateTime HireDate { get; set; }
        }
    }
}


