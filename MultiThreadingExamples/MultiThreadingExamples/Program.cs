using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExamples
{
    class Program
    {

        //Feature 1
        static void Main(string[] args)
        {
            //Join example
            JoinExample.Call();
            Console.Read();
        }
    }
}
