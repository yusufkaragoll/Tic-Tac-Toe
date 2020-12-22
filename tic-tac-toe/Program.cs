using System;

namespace tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playermoves = new string[9];
            Console.WriteLine("what is the state of the 1st field?");
            Console.WriteLine("what is the state of the 2nd field?");
            Console.WriteLine("what is the state of the 3rd field?");
            Console.WriteLine("what is the state of the 4th field?");
            Console.WriteLine("what is the state of the 5th field?");
            Console.WriteLine("what is the state of the 6th field?");
            Console.WriteLine("what is the state of the 7th field?");
            Console.WriteLine("what is the state of the 8th field?");
            Console.WriteLine("what is the state of the 9th field?");


            playermoves[0] = (Console.ReadLine());
            playermoves[1] = (Console.ReadLine());
            playermoves[2] = (Console.ReadLine());
            playermoves[3] = (Console.ReadLine());
            playermoves[4] = (Console.ReadLine());
            playermoves[5] = (Console.ReadLine());
            playermoves[6] = (Console.ReadLine());
            playermoves[7] = (Console.ReadLine());
            playermoves[8] = (Console.ReadLine());
            //output
            Console.ReadLine();


            Console.WriteLine($" {playermoves[0]} | {playermoves[1]} | {playermoves[2]}");
            Console.WriteLine("- -+- -+- -");
            Console.WriteLine($" {playermoves[3]} | {playermoves[4]} | {playermoves[5]}");
            Console.WriteLine("- -+-  -+- o-");
            Console.WriteLine($" {playermoves[6]} | {playermoves[7]} | {playermoves[8]}");
            //hata cikmasinin sebebi semi colon koymadim diye
            //hocanin yaptiklarini tek tek uygula hata ciktiginda no al hocaya sor
            Console.WriteLine();
            Console.WriteLine("Game Over!");
        }


        }
    }

