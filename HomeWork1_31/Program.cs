using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleControl
{
    

    class Program
    {
        //описание города
        public struct City
        {
           public string CityName;
           public int CityPopulation;
           public int CityArea;
           public double Density;
        }
        static void Main(string[] args)
        {
           
            //ввод данных Kharkiv=1431000,350;Kiev=2804000,839;Las Vegas=603400,352
            string InputData = Console.ReadLine();
            int CityNum = 0;
            for (int i = 0; i < InputData.Length; i++)
            {
                if (InputData[i] == '=')
                {
                    CityNum++;
                }
                
            }
            City[] city = new City[CityNum];
            string variable="";
            for (int i = 0,a=0; i <InputData.Length; i++)
            {
                if(InputData[i]=='=')
                {
                    city[a].CityName = variable;
                    string newV = "";
                    variable = newV;
                    i++;
                    
                }
                if (InputData[i] == ',')
                {
                    
                    city[a].CityPopulation = int.Parse(variable);
                    string newV = "";
                    variable = newV;
                    i++;
                }
                if (InputData[i] == ';')
                {
                    city[a].CityArea = int.Parse(variable);
                    string newV = "";
                    variable = newV;
                    i++;
                    a++;
                }
                if (InputData.Length - 1 == i)
                {
                    city[a].CityArea = int.Parse(variable);
                    string newV = "";
                    variable = newV;
                    break;
                }

                variable += InputData[i];
              

            }

            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine(city[c].CityName);
                Console.WriteLine(city[c].CityPopulation);
                Console.WriteLine(city[c].CityArea);
            }
            string MaxName = "";
            int MaxPopulation = 0;
            for (int k = 0; k < 3; k++)
            {
                if (city[k].CityName.Length > MaxName.Length)
                {
                    MaxName = city[k].CityName;
                }
                if (city[k].CityPopulation > MaxPopulation)
                {
                    MaxPopulation = city[k].CityPopulation;
                }
            }
            for (int k = 0; k <city.Length; k++)
            {                
                   city[k].Density = (double)city[k].CityPopulation / (double)city[k].CityArea;          
            }

            Console.WriteLine("MaxPopulation= " + MaxPopulation);
            Console.WriteLine("LongestCityName= " + MaxName);
            
            for (int d = 0; d <city.Length; d++)
            {
                Console.WriteLine("Density:");
                Console.WriteLine(city[d].Density);
            }

        }
    }
}