using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowyDodawacz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;

            String Operator = "";
            Console.WriteLine("Witamy w SuperNowym Liczydle 2019");

            Sprawdz number = new Sprawdz();
            
            int FirstNum = number.SprawdzLiczby(Num);
 
            Pobrania Op = new Pobrania();
            String Oper =Op.PobierzOperator(Operator);

            int SecondNum = number.SprawdzLiczby(Num);

            Wybor end = new Wybor();
            end.Wybordzialania(FirstNum, SecondNum, Oper);
            Console.ReadKey();
        }
    }


    class Dzialania
    {
        int Wynik;
        

        public int Dodawanie(int FirstNum, int SecondNum)
        {
            Wynik =FirstNum + SecondNum;
            Console.WriteLine("Wynik dodawania wynosi : " + Wynik + "");
            return Wynik;
        }
        public int Odejmowanie(int FirstNum, int SecondNum)
        {
            Wynik = FirstNum - SecondNum;
            Console.WriteLine("Wynik odejmowania wynosi : " + Wynik + "");
            return Wynik;
        }
        public int Mnozenie(int FirstNum, int SecondNum)
        {
            Wynik = FirstNum * SecondNum;
            Console.WriteLine("Wynik mnozenia wynosi : " + Wynik + "");
            return Wynik;
        }
        public int Dzielenie(int FirstNum, int SecondNum)
        {
            try
            {
                Wynik = FirstNum / SecondNum;    
                Console.WriteLine("Wynik dzielenia wynosi : " + Wynik + "");
                return Wynik;
            }
            catch (DivideByZeroException)
            { };
            return Wynik;
            
        }


        
    }
    class Wybor : Dzialania
    {
        public void Wybordzialania(int FirstNum, int SecondNum, string Operator)
        {


            switch (Operator)
            {
                case "+": { Dodawanie(FirstNum, SecondNum); break; }
                case "-": { Odejmowanie(FirstNum, SecondNum); break; }
                case "*": { Mnozenie(FirstNum, SecondNum); break; }
                case "/": { Dzielenie(FirstNum, SecondNum); break; }

            }
        }
    }


    class Pobrania
    {
        public string Number = "";



        public int TakeNumber(int Num)
        {
            Console.WriteLine("Prosze wpisac liczbe: ");
            Number = Console.ReadLine();
            Num = int.Parse(Number);
            return Num;
        }
        public string PobierzOperator(string Operator)
        {
            string[] Operatory = { "+", "-", "*", "/" };
            string exit = "";
            Console.WriteLine("Prosze nacisnac Operatora Dzialania: ");
            Console.WriteLine("-");
            Console.WriteLine("+");
            Console.WriteLine("*");
            Console.WriteLine("/");
            do
            {
                Operator = Console.ReadLine();
                if (Operatory.Contains(Operator))
                {
                    exit = "exit";
                    return Operator;
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybor, wybierz +,- lub * ");
                }
            } while (exit != "exit");
            return Operator;
        }


    }
    class Sprawdz:Pobrania
    {
        public int SprawdzLiczby(int Num)
        {
            string end = "";
            
           do
            {
                try
                {
                   Num =  TakeNumber(Num);
                   
                    end = "end";


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
                    Console.WriteLine("Coś poszło nie tak");
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
            } while (end != "end");
            return Num;
            
        }
        
    }
   

}

