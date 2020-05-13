using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface ICalc
    {
        int value { get; }
        int value2 { get; }

        int Plus();
        int Min();
        int Div();
        int Multi();
    }
}
