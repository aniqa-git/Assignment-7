using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_8
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            Console.ReadLine();
            var MethodId = 3;
            Console.WriteLine((ShippingMethod)MethodId);
            Console.ReadLine();
        }
    }
}
