using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {

        class SantaList
        {

            string name;
            string gift;

            public SantaList(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for SantaList

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }

        static void Main(string[] args)
        {
            //Anna wants new earrings for Christmas....

            List<SantaList> myGifts = new List<SantaList>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                SantaList newGifts = new SantaList(tempArray[0], tempArray[1]);
                myGifts.Add(newGifts);
            }

            foreach (SantaList giftsFromList in myGifts)
            {
                Console.WriteLine($"{giftsFromList.Name} wants {giftsFromList.Gift} for Christmas.");
            }

            Console.WriteLine("Merry Christmas and a Happy New Year!");
        }


        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");

            }
        }


        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Koolistuff\...\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;

        }
        
    }

}
