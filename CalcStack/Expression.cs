using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStack
{
    internal class Expression
    {
       
        public string operators = "+-*/";

        public string[] Splitter(string dataStr)
        {

            if (dataStr.Contains("(") && dataStr.Contains(")"))
            {
                string[] data = dataStr.Split(new char[] { '(', ')' });
                return data;
            }
            else
            {
                string[] data = dataStr.Split(' ');
                return data;
            }

        }

        public int GetResult(string dataInStr)
        {
            Stack<string>stack= new Stack<string>();
             string[] data= Splitter(dataInStr);

            for (int i = 0; i < data.Length; i++)
            {
                string[] data2= Splitter(data[i]);
                string operation = null;
                for (int j = 0; j < data2.Length; j++)
                {

                    string token = data2[j];
                    

                    if (operators.IndexOf(token) == -1)
                    {
                        stack.Push(token);
                    }
                    else
                    {
                        operation = token;
                    }

                    if (stack.Count == 2)
                    {
                        int number2 = Convert.ToInt32(stack.Pop());
                        int number1 = Convert.ToInt32(stack.Pop());

                        int opNumb = operators.IndexOf(operation);
                        switch (opNumb)
                        {
                            case 0:
                                stack.Push((number1 + number2).ToString());
                                break;
                            case 1:
                                stack.Push((number1 - number2).ToString());
                                break;
                            case 2:
                                stack.Push((number1 * number2).ToString());
                                break;
                            case 3:
                                stack.Push((number1 / number2).ToString());
                                break;
                        }
                    }

                }
            }
            int result = Convert.ToInt32( stack.Pop());
            return result;


        }


    }
}
