using Camillas_Opgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camillas_Opgave
{
    class Bicycle : IBreakable
    {
        private string registrationnumber;


        public Bicycle(int numberOfWheels)
        {
            for(int i = 0; i < numberOfWheels; i++)
            {
               new Wheel();
            }
        }

        public void Break()
        {
            throw new NotImplementedException();
        }
    }
}
