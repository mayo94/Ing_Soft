using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codificador
{
    class Program
    {
        static void Main(string[] args)
        {

           
    
      
            string mensaje = args[1];
            char[] letras = mensaje.ToCharArray();
           
            if (args[0]=="d")
            {
                Console.Write("Mensaje a decodificar: " + mensaje );
                Console.Write("\nMensaje decodificar: ");

                for (int j=0;j<letras.Length; j++)
                {
                    
                    switch (letras[j])
                    {
                        case 'p':
                            Console.Write('a');
                            break;
                        case 'r':
                            Console.Write('b');
                            break;
                        case 'j':
                            Console.Write('c');
                            break;
                        case 'i':
                            Console.Write('d');
                            break;
                        case 'ñ':
                            Console.Write('e');
                            break;
                        case 't':
                            Console.Write('f');
                            break;
                        case 'g':
                            Console.Write('g');
                            break;
                        case 'c':
                            Console.Write('h');
                            break;
                        case 'o':
                            Console.Write('i');
                            break;
                        case 'x':
                            Console.Write('j');
                            break;
                        case 'b':
                            Console.Write('k');
                            break;
                        case 'n':
                            Console.Write('l');
                            break;
                        case 'y':
                            Console.Write('m');
                            break;
                        case 's':
                            Console.Write('n');
                            break;
                        case 'w':
                            Console.Write('ñ');
                            break;
                        case 'd':
                            Console.Write('o');
                            break;
                        case 'e':
                            Console.Write('p');
                            break;
                        case 'm':
                            Console.Write('q');
                            break;
                        case 'h':
                            Console.Write('r');
                            break;
                        case 'u':
                            Console.Write('s');
                            break;
                        case 'v':
                            Console.Write('t');
                            break;
                        case 'l':
                            Console.Write('u');
                            break;
                        case 'z':
                            Console.Write('v');
                            break;
                        case 'f':
                            Console.Write('w');
                            break;
                        case 'q':
                            Console.Write('x');
                            break;
                        case 'k':
                            Console.Write('y');
                            break;
                        case 'a':
                            Console.Write('z');
                            break;
                        case ' ':
                            Console.Write(' ');
                            break;
                    }
                }
             }
         
             else 

                if (args[0] == "c")
                    {
                        Console.Write("\nMensaje a codificar: " + mensaje);
                        Console.Write("\nMensaje codificado: ");

                        for (int j = 0; j < letras.Length; j++)
                        {

                            switch (letras[j])
                            {
                                case 'a':
                                    Console.Write('p');
                                    break;
                                case 'b':
                                    Console.Write('r');
                                    break;
                                case 'c':
                                    Console.Write('j');
                                    break;
                                case 'd':
                                    Console.Write('i');
                                    break;
                                case 'e':
                                    Console.Write('ñ');
                                    break;
                                case 'f':
                                    Console.Write('t');
                                    break;
                                case 'g':
                                    Console.Write('g');
                                    break;
                                case 'h':
                                    Console.Write('c');
                                    break;
                                case 'i':
                                    Console.Write('o');
                                    break;
                                case 'j':
                                    Console.Write('x');
                                    break;
                                case 'k':
                                    Console.Write('b');
                                    break;
                                case 'l':
                                    Console.Write('n');
                                    break;
                                case 'm':
                                    Console.Write('y');
                                    break;
                                case 'n':
                                    Console.Write('s');
                                    break;
                                case 'ñ':
                                    Console.Write('w');
                                    break;
                                case 'o':
                                    Console.Write('d');
                                    break;
                                case 'p':
                                    Console.Write('e');
                                    break;
                                case 'q':
                                    Console.Write('m');
                                    break;
                                case 'r':
                                    Console.Write('h');
                                    break;
                                case 's':
                                    Console.Write('u');
                                    break;
                                case 't':
                                    Console.Write('v');
                                    break;
                                case 'u':
                                    Console.Write('l');
                                    break;
                                case 'v':
                                    Console.Write('z');
                                    break;
                                case 'w':
                                    Console.Write('f');
                                    break;
                                case 'x':
                                    Console.Write('q');
                                    break;
                                case 'y':
                                    Console.Write('k');
                                    break;
                                case 'z':
                                    Console.Write('a');
                                    break;
                                case ' ':
                                    Console.Write(' ');
                                    break;
                            }
                        }                
                }
            }
    }
}
