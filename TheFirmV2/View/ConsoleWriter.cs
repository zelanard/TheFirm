using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.View
{
    public static class ConsoleWriter
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg.ToString());
        }

        public static void Wait()
        {
            Console.ReadKey();
        }
    }
}
