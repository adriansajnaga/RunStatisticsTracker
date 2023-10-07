﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RunStatisticsTracker
{
    public abstract class UserBase     : iUser

    {
        public UserBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract Statistics GetStatistics();

        public void ReadDistance(string distance)
        {

            if (double.TryParse(distance, out double distanceDouble) && distanceDouble > 0)
            {
                SaveNewRecord(distanceDouble);

                if (distanceDouble > 319.614) 
                {
                    Console.WriteLine($"\u001b[32mBravo! Pobiłeś rekord świata!\u001b[32m");
                    Console.WriteLine("\u001b[33mAby kontynuować naciśnij dowolny przycisk.\n \u001b[0m");
                    Console.ReadLine();
                } 
                else if (distanceDouble == 42.195)
                {
                    Console.WriteLine($"\u001b[32mBravo! Przebiegłeś maraton!\u001b[32m");
                    Console.WriteLine("\u001b[33mAby kontynuować naciśnij dowolny przycisk.\n \u001b[0m");
                    Console.ReadLine();
                }
                else if (distanceDouble == 21.0975)
                {
                    Console.WriteLine($"\u001b[32mBravo! Przebiegłeś półmaraton\u001b[32m");
                    Console.WriteLine("\u001b[33mAby kontynuować naciśnij dowolny przycisk.\n \u001b[0m");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine($"Nieprawidłowa liczba");
                Console.ReadLine();

            }
        }

        public abstract void SaveNewRecord(double distance);

        public abstract bool StatExists();
    }
}