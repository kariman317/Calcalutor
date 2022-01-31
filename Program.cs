using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subtract subtract = new Subtract();
            AddClass add = new AddClass();
            subtract.Subtract_Num(5, 8);
            add.Add(8, 9);
        }
    }
}
