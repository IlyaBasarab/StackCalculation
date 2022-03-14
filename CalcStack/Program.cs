using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data2 = "10 * 20 + 100";
            string data2 = "(20 + 30) * 100 + 50";

            Expression expression = new Expression();
            Console.WriteLine(expression.GetResult(data2));

        }
    }
}
