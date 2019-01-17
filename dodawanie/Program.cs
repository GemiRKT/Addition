using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodawanie
{
    class Program
    {
        static void Main(string[] args)
        {

            int FirstNumber = 0;
            int SecondNumber = 0;
            int MaxNumber = 10;
            int LowNumber = 0;
            int Sum;
            
           
            
            Console.WriteLine("Witamy w dodwaniu");

            do
            {
                try
                {
                    Console.WriteLine("Podaj Pierwsza Liczbe 0-10: ");
                    int GetNumber = int.Parse(Console.ReadLine());

                    if (GetNumber <= MaxNumber && GetNumber > LowNumber)
                    {
                        
                        break;

                    }
                    else
                        FirstNumber = GetNumber;
                    Console.WriteLine("nie Poprawana liczba sprobuj ponownie");



                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);


                }
                catch (OverflowException OverEx)
                {
                    Console.WriteLine(OverEx.Message);


                }
                catch (ArithmeticException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);


                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Coœ posz³o nie tak");


                }
            } while (true);


            do
            {
                try
                {
                    Console.WriteLine("Podaj druga Liczbe 0-10: ");
                    int GetNumber = int.Parse(Console.ReadLine());


                    if (GetNumber <= MaxNumber && GetNumber > LowNumber)

                    {
                        break;

                    }
                    else
                        SecondNumber = GetNumber;
                    Console.WriteLine("nie Poprawana liczba sprobuj ponownie");


                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);

                }
                catch (OverflowException OverEx)
                {
                    Console.WriteLine(OverEx.Message);

                }
                catch (ArithmeticException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);

                }
                catch (Exception Ex)
                {
                    
                    Console.WriteLine("Coœ posz³o nie tak");
                }
                

            }
            while (true);



            Sum = FirstNumber + SecondNumber;
                Console.WriteLine("Wynik dodawania to : " + Sum + "");
                Console.ReadKey();
            



        }
    }
}
