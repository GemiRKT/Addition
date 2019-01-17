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
            int FirstNum;
            int SecondNum;           
            int Num = 0;
            int wybor = 0;
            string wyborstring = "";
            string exit = "";
            

            Console.WriteLine("Witamy w dzialaniach");
            Console.WriteLine("Podaj Pierwsza Liczbe : ");
            FirstNum = PobierzLiczbe(Num);
            do
            {
                try
                {
                    Console.WriteLine("Wybierz operacje wpisujac liczbe: ");
                    Console.WriteLine("1.Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    wyborstring = Console.ReadLine();
                    wybor = int.Parse(wyborstring);

                    switch (wybor)
                    {

                        case 1:
                            {
                                Console.WriteLine("Podaj Druga Liczbe : ");
                                SecondNum = PobierzLiczbe(Num);
                                Dzialania wynik = new Dzialania();
                                wynik.Dodawanie(FirstNum, SecondNum);
                                exit = "exit";
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Podaj Druga Liczbe : ");
                                SecondNum = PobierzLiczbe(Num);
                                Dzialania wynik = new Dzialania();
                                wynik.Odejmowanie(FirstNum, SecondNum);
                                exit = "exit";
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Podano bledny znak/liczbe wybierz ponownie 1 lub 2.");
                                break;
                            }
                    }
                }

                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (OverflowException OverEx)
                {
                    Console.WriteLine(OverEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (ArithmeticException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Coœ posz³o nie tak");
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
        } while (exit != "exit");

        }
        static int PobierzLiczbe(int Num)
        {

            String Number = "";
            String con = "";

            do
            {
                    try
                    {

                        Number = Console.ReadLine();
                        Num = int.Parse(Number);
                        con = "wkoncu";
                    }
                    catch (FormatException fEx)
                    {
                        Console.WriteLine(fEx.Message);
                        Console.WriteLine("Wpisz Liczbe Ponownie: ");
                    }
                    catch (OverflowException OverEx)
                    {
                        Console.WriteLine(OverEx.Message);
                        Console.WriteLine("Wpisz Liczbe Ponownie: ");
                    }
                    catch (ArithmeticException ArgEx)
                    {
                        Console.WriteLine(ArgEx.Message);
                        Console.WriteLine("Wpisz Liczbe Ponownie: ");
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine("Coœ posz³o nie tak");
                        Console.WriteLine("Wpisz Liczbe Ponownie: ");
                    }
            } while (con != "wkoncu");
            return Num;
        }

        

        class Dzialania
        {
                         
            public int Dodawanie(int FirstNum ,int SecondNum)
            {
                int wynik;
                wynik = FirstNum + SecondNum;
                Console.WriteLine("Wynik Dodawania to : " + wynik + "");
                Console.WriteLine("Nacisnij dowolny klawisz aby wyjsc");
                Console.ReadKey();
                
                return wynik;

            }
            public int Odejmowanie(int FirstNum, int SecondNum)
            {
                int wynik;
                wynik = FirstNum - SecondNum;
                Console.WriteLine("Wynik Odejmowania to : " + wynik + "");
                Console.WriteLine("Nacisnij dowolny klawisz aby wyjsc");
                Console.ReadKey();
                
                return wynik;

            }
        }
    }
}





        






