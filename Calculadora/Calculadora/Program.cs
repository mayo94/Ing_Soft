using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = args.Length;
            bool com;
            com = true;

            string[] vector = new string[x];
            for (int i = 0; i < x-1 ; i++)
            {
                if (args[i] == args[i + 1])
                    com = false;
            }

            if (com)
            {
                double operacion;
                Console.Write("\nexpresión a evaluar: ");
                for (int i = 0; i < x; i++)
                {
                    vector[i] = args[i];
                    Console.Write(args[i]);
                }

               
                for (int i = 0; i < x; i++)
                {
                    if (vector[i] == "/")
                    {
                        operacion = double.Parse(vector[i - 1]) / double.Parse(vector[i + 1]);
                        x -= 2;
                        vector[i - 1] = operacion.ToString();
                        for (int j = i; j < x; j++)
                        {
                            vector[j] = vector[j + 2];
                        }
                    }
                }

                for (int i = 0; i < x; i++)
                {
                    if (vector[i] == "*")
                    {
                        operacion = double.Parse(vector[i - 1]) * double.Parse(vector[i + 1]);
                        x -= 2;
                        vector[i - 1] = operacion.ToString();
                        for (int j = i; j < x; j++)
                        {
                            vector[j] = vector[j + 2];
                        }
                    }
                }


                for (int i = 0; i < x; i++)
                {
                    if (vector[i] == "-")
                    {
                        operacion = double.Parse(vector[i - 1]) - double.Parse(vector[i + 1]);
                        x -= 2;
                        vector[i - 1] = operacion.ToString();
                        for (int j = i; j < x; j++)
                        {
                            vector[j] = vector[j + 2];
                        }
                    }
                }


                for (int i = 0; i < x; i++)
                {
                    if (vector[i] == "+")
                    {
                        operacion = double.Parse(vector[i - 1]) + double.Parse(vector[i + 1]);
                        x -= 2;
                        vector[i - 1] = operacion.ToString();
                        for (int j = i; j < x; j++)
                        {
                            vector[j] = vector[j + 2];
                        }
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Resultado:" + vector[0]);

            }

            else
            {

                Console.WriteLine("\nresultado: expresión incorrecta");
   

            }

            Console.Read();



                //Console.Write("\nresultado: "+vector[0]);
          
            
        }
    }
}
