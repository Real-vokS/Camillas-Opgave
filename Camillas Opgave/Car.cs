using Camillas_Opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camillas_Opgave
{
    class Car : Vehicle
    {
        private string registrationnumber;
        private string registrationYear;
        private IEngine engine;


        GearBox gearBox;
        Wheel[] wheel = new Wheel[4];


        public void Start()
        {
            if(engine is IGasolineEngine gasolineEngine)
            {

            }
        }

        internal Car()
        {

        }

        public Car(string color)
        {

        }
        public Car(string color, float size)
        {

        }

    }
}
