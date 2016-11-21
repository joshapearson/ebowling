using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebowling
	{
	class Program
		{
		static void Main(string[] args)
			{
			Random rnd = new Random();
			int pins = rnd.Next(1, 10);
			int[] frames = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		

			Console.WriteLine("Welcome To E-Bowling, please enter a player name");
			string playerName = Console.ReadLine();

			Console.WriteLine("Hello {0}, let's bowl!", playerName);
			Console.WriteLine("to Start a new game, please press enter.");

			string key = Console.ReadKey().Key.ToString();
			for (int i = 0; i < 10; i++)				  
				{
				i++;
				if (key == "")
				Console.WriteLine("Throwing Ball");
				Console.WriteLine(" you hit {0} Pins", pins);
				Console.WriteLine(" frame number is {0}", i);
				Console.ReadLine();
				}
				
				}
			
			}

			 
		}
