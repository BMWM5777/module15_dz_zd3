using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace module15_dz_zd3
{
    class Program
    {
        static void Main()
        {
            string originalString = "Salam, Reflection!";
            int startIndex = 7;
            int length = 10;

            Type stringType = typeof(string);
            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            if (substringMethod != null)
            {
                object result = substringMethod.Invoke(originalString, new object[] { startIndex, length });
                Console.WriteLine($"Substring: {result}");
            }
        }
    }
}
