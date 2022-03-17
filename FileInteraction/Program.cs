using System;
using System.Collections.Generic;
using System.IO;

namespace FileInteraction
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] text = {"Hi", "hello dere", "Sonzzy", "Whatzup Boi"};

            // Echo "text" >> ./filename.txt
            // take this string "text" , convert ti 
            // > or >> is a stream redirect

            string path = @".\Testfile.txt";
            Console.WriteLine(path);


            if( !File.Exists(path) )
            {
                File.WriteAllLines(path, text);
            }
          

            else { 
                File.AppendAllLines(path, text);
            }

            string[] lines = System.IO.File.ReadAllLines(@".\Testfile.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of Testfile.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }


            Person StudMan = new Person("Foley", 55.5, 21);

            Console.WriteLine(StudMan.height);

            Console.WriteLine("Studman is " + StudMan.age + "years old");


            Console.WriteLine("Studman is " + StudMan.GrowUp() + "years old");
//slide the read part in here later
        }
    }


}
