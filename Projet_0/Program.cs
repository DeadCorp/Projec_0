using System;
using static exchange_letter.exchange_letter;

namespace Projet_0
{
    internal class Program {
        

        private static void Main() {
            foreach (var VARIABLE in ExchangeFirstLetter(" раз два ")) {
                Console.Write(VARIABLE + " ");
            }
            Console.WriteLine("651I512671");
            
            

            Console.ReadKey();
        }
    }
}