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
            String FirstNumber = "";
            String SecondNumber = "";
            int Sum;
            int FirstNum = 0;
            int SecondNum = 0;
            String con = "";
            Console.WriteLine("Witamy w dodwaniu");

            do
            {
                try
                {
                    Console.WriteLine("Podaj Pierwsza Liczbe 0-10: ");
                    FirstNumber = Console.ReadLine();
                    FirstNum = int.Parse(FirstNumber);



                    if (FirstNum > 10 || FirstNum < 0)
                    {
                        Console.WriteLine("nie Poprawana liczba sprobuj ponownie");

                    }
                    else
                        con = "wkoncuRaz";

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
            } while (con != "wkoncuRaz");


            do
            {
                try
                {
                    Console.WriteLine("Podaj druga liczbe 0-10: ");
                    SecondNumber = Console.ReadLine();
                    SecondNum = int.Parse(SecondNumber);

                    if (SecondNum > 10 || SecondNum < 0)
                    {
                        Console.WriteLine("nie Poprawana liczba sprobuj ponownie");

                    }
                    else
                        con = "wkoncuDwa";

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
            while (con != "wkoncuDwa");

             

                Sum = FirstNum + SecondNum;
                Console.WriteLine("Wynik dodawania to : " + Sum + "");
                Console.ReadKey();
            



        }
    }
}
