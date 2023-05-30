using System;



namespace Lab4

{

    internal class Program

    {

        static void Main(string[] args)

        {

            string sentence = "Alfred bought the apples but Alfred forgot that Alfred sold the apples";

            string[] words = sentence.Split(' ');



            Console.WriteLine(sentence);

            Console.WriteLine("\nWords that appear only once:");



            foreach (string word in words)

            {

                if (sentence.IndexOf(word) == sentence.LastIndexOf(word))

                {

                    Console.WriteLine("-" + word);

                }

            }

            Console.WriteLine();

        }

    }

} // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
