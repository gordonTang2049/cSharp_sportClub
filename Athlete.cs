using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QutChampionship_n11267283
{
    internal class Athlete
    {
        public static char[] _eventCodes = { 'T', 'B', 'S', 'R', 'G' };
        public static string[] _eventDescription = { "Tennis", "Badminton", "Swimming", "Running", "Gymnastic" };
        private string name;
        private char eventCode;
        private string eventDescription;

        public string Name
        {
            get { return name; }
        }

        public char EventCode
        {
            get { return eventCode; }
        }

        public string EventDescription
        {
            get { return eventDescription; }
        }



        public Athlete(string name, char eventCode)
        {
            this.name = name;

            if (eventCode == _eventCodes[0])
            {
                this.eventCode = _eventCodes[0];
                this.eventDescription = _eventDescription[0];

            }
            else if (eventCode == _eventCodes[1])
            {

                this.eventCode = _eventCodes[1];
                this.eventDescription = _eventDescription[1];

            }
            else if (eventCode == _eventCodes[2])
            {

                this.eventCode = _eventCodes[2];
                this.eventDescription = _eventDescription[2];

            }
            else if (eventCode == _eventCodes[3])
            {

                this.eventCode = _eventCodes[3];
                this.eventDescription = _eventDescription[3];

            }
            else if (eventCode == _eventCodes[4])
            {

                this.eventCode = _eventCodes[4];
                this.eventDescription = _eventDescription[4];

            }
            else
            {
                this.eventCode = 'I';
                this.eventDescription = "Invalid";
            }

        }

        public void Display()
        {

            Console.WriteLine("Those are the event codes");
            for (int i = 0; i < _eventCodes.Length; i++)
            {
                Console.Write($"{_eventCodes[i].ToString()} ");
            }
            Console.WriteLine();
            for (int i = 0; i < _eventDescription.Length; i++)
            {
                Console.Write($"{_eventDescription[i].ToString()} ");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter one of the Corresponding event code");
        }

        public override string ToString()
        {
            return (Name + " has type event code **" + EventCode + "** which event is **" + EventDescription + "** \n");
        }
    }
}
