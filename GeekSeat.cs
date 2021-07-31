using System;
using System.Collections;

namespace GeekSeat
{
public class WitchProblem
{
    class Person
    {
        public string Name {get;set;}
        public int Aod {get;set;}
        public int Yod {get;set;}
        public int Boy {get;set;}
        public void SetInfo(string Name, int Aod, int Yod, int Boy)
        {
            this.Name = Name;
            this.Aod = Aod;
            this.Yod = Yod;
            this.Boy = Yod - Aod;
        }
    }

    class WitchSolver
    {
         static void Main(string[] args)
        {
            
            Person[] DataPerson = new Person[2];
            DataPerson[0] = new Person();
            DataPerson[1] = new Person();

            DataPerson[0].SetInfo("Salim", 10, 12, 0);
            DataPerson[1].SetInfo("Rudy", 13, 17, 0);
            decimal sumKoy = 0; 
            int villagers = 0;
            foreach(Person person in DataPerson)
            {
                Console.WriteLine("Data Person: ");
			    Console.WriteLine("\tName                   : " + person.Name  );
			    Console.WriteLine("\tAge of death           : " + person.Aod   );
                Console.WriteLine("\tYear of death          : " + person.Yod   );
			    Console.WriteLine("\tBorn of year           : " + person.Boy   );
                int n1 = 0;
                int n2 = 1;
                int year = 1;
                if(person.Boy < 0)
                {
                    year = -1;
                }else
                {
                    year = person.Boy;
                }

                for (int i = 1; i <= year; i++) 
                {
                    if(i == 1)
                    {
                        villagers = 1;
                        if(i == year)
                        {
                            Console.WriteLine("\tPeople killed on year  : " + villagers  );
                        }
                    }
                    else
                    {
                        villagers = n1 + n2 + 1;
                        if(i == year)
                        {
                            Console.WriteLine("\tPeople killed on year  : " + villagers  );
                        }
                        n1=n2;    
                        n2=villagers;
                    }
                }
                sumKoy += villagers;
                Console.WriteLine("\tTotal person           : " + DataPerson.Length  );
                decimal  avg = Math.Round(sumKoy/DataPerson.Length, 2);
                Console.WriteLine("\tAverages number is     : {0}", avg);
            }
        }
    }
}
}


