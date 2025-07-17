using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_9_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat objCat_1 = new Cat();
            objCat_1.Sound_Abs();
            objCat_1.Eat_Reg();
        }
    }
}
