using System;

namespace CSharp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WorldDo you want to go out?");
            var input = Console.ReadLine();

            switch(input){
                case "Y":
                {
                    Console.WriteLine("Ok, exit");
                    break;
                }
                case "X":
                case "N":
                {
                    Console.WriteLine("Ok exit xD");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Option");
                    break;
                }
            }
        }
    }
}
