using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QutChampionship_n11267283
{
    internal class Program
    {
        static void validateNumOfParticipants(out int numOfParticipants)
        {
            int.TryParse(Console.ReadLine(), out numOfParticipants);

            if (numOfParticipants < 0 | numOfParticipants > 30)
            {

                Console.WriteLine("The value you are enter is invalid, please enter number between 0 and 30");
                numOfParticipants = -1;
            }

        }

        static void revDisplay(int numOfParticipants)
        {

            Console.WriteLine(numOfParticipants * 20);

        }



        static void Main(string[] args)
        {
            int numOfParticipants = -1;
            char eventCodeInput;
            Athlete display = new Athlete("", 'i');


            Console.WriteLine("please enter Paricipants number between 0 and 30");

            while (numOfParticipants == -1)
            {
                validateNumOfParticipants(out numOfParticipants);
            }

            revDisplay(numOfParticipants);

            Athlete[] athletes = new Athlete[numOfParticipants];

            Console.WriteLine("==============================");
            Console.WriteLine("Requirement d. ");
            Console.WriteLine("==============================");
            for (int i = 0; i < numOfParticipants; i++)
            {

                Console.WriteLine("Please enter your name");
                string name = Console.ReadLine();
                display.Display();
                Char.TryParse(Console.ReadLine(), out eventCodeInput);

                athletes[i] = new Athlete(name, eventCodeInput);

                Console.WriteLine(athletes[i].ToString());

            }
            Console.WriteLine("==============================");
            Console.WriteLine("Requirement e. ");
            Console.WriteLine("==============================");

            foreach (Athlete a in athletes)
            {

                if (a.EventCode == 'I')
                {
                    Console.WriteLine($"{a.Name} has entered an invalid event code");
                }
                else
                {

                   Console.WriteLine(a.ToString());
                }

            }





        }
    }
}
