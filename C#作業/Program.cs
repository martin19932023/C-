using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_作業());
        }
    }
}

//class program 
//{
//    static void Main(string[] args)
//    { 
//    Random random = new Random();
//        bool PlayAgain = true;
//        int min = 1;
//        int max = 100;
//        int guess;
//        int number;
//        int guesses;
//        string response;

//        while (PlayAgain)
//        {
//            guess = 0;
//            guesses = 0;
//            response = "";
//            number = random.Next(min, max+1);
//            while (guess != number)
//            {
//                Console.WriteLine("guess a number between " + min + " - " + max + "  :  ");
//                guess = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("guess: " + guess);
//                if (guess > number)
//                {
//                    Console.WriteLine(guess + "is too high !");
//                }
//                else if (guess < number)
//                {
//                    Console.WriteLine(guess + "is too low !");
//                }
//                guesses++;
//                Console.WriteLine(" Number: " +  number);
//                Console.WriteLine(" You Win!!");
//                Console.WriteLine(" Guesses: " + guesses);
//                Console.WriteLine(" Would you like to play again?(Y/N) : ");
//                response= Console.ReadLine();
//                response = response.ToUpper();

//                if (response == "Y")
//                {
//                    PlayAgain = true;
//                }
//                else
//                {
//                    PlayAgain = false;
//                }
//            }

//            Console.WriteLine("Thanks for playing!!   ... I guess@@");
//            Console.ReadKey();
//        }









//    Console.ReadKey();

//    }
//}
