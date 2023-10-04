using System;
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
                    Console.WriteLine($"Rekord");
                    Console.ReadLine();
                    // event jestes rekordzistą świata
                } 
                else if (distanceDouble == 42.195)
                {
                    Console.WriteLine($"Cały");
                    Console.ReadLine();
                    // event bravo przebiegłeś maraton
                }
                else if (distanceDouble == 21.0975)
                {
                    Console.WriteLine($"Pół");
                    Console.ReadLine();
                    // event bravo przebiegłeś półmaraton
                }

            }
            else
            {
                Console.WriteLine($"Nieprawidłowa liczba");
                Console.ReadLine();
                //throw new System.NotImplementedException();
                // event nieprawidłowy dystans

            }
        }

        public abstract void SaveNewRecord(double distance);

        public abstract bool StatExists();
    }
}