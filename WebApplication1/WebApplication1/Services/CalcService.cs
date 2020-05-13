using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class CalcService : ICalc
    {
        public int value { get; private set; }
        public int value2 { get; private set; }

        public CalcService()
        {
            var rand = new Random();

            value = rand.Next(0, 10);
            value2 = rand.Next(0, 10);

        }

        public int Plus()
        {
            return value + value2;
        }

        public int Min()
        {
            return value - value2;
        }

        public int Div()
        {
            try
            {
                var divResult = value / value2;
                return divResult;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }

        public int Multi()
        {
            return value * value2;
        }

    }
}
