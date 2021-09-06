// using Internal;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.ComponentModel.Design.Serialization;
using System;

namespace ResultRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int students = rd.Next(10, 15);
            int failed = 0;
            int passed = 0;
            int average = 0;


            Console.WriteLine("There are " + students + " students in this class.");

            for(int i = 1; i <= students; i++)
            {
                int score = rd.Next(1,100);

                if(score >= 70)
                {
                    passed++;
                }
                else if(score >= 50 && score <= 69)
                {
                    average++;
                }
                else
                {
                    failed++;
                }

                Console.WriteLine("Student " + i + " scored: " + score);
            }

            Console.WriteLine(passed + " students passed.");
            Console.WriteLine(average + " students got average.");
            Console.WriteLine(failed + " students failed.");
       }
    }
}
