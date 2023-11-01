using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projects_3.Classes
{
    internal class Car
    {
        public string model { get; set; }
        public int year { get; set; }
        private bool engineStarted = false;

        public Car(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
        public void StartEngine()
        {
            engineStarted = true;
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            engineStarted = false;
            Console.WriteLine("Engine stopped.");
        }
}
}
