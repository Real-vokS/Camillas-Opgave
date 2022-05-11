using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camillas_Opgave.Interfaces
{
    class Toyota : IGasolineEngine, IBreakable
    {
        private float capacity;


        public Toyota(float capacity)
        {

        }

        public void Break()
        {
            throw new NotImplementedException();
        }

        public void Inject()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }
    }
}
