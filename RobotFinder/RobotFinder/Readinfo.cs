using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobotFinder
{
	public class ReadFromFile
	{
		

		public ReadFromFile()
		{
			List<String> lines = File.ReadAllLines(@"C:\Users\Archie\Desktop\RobotFinder\WriteText.txt").ToList();


			System.Console.WriteLine("Contents of WriteLines2.txt = ");
			foreach (string line in lines)
			{
				// Use a tab to indent each line of the file.
				Console.WriteLine("\t" + line);
			}

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
	}

}
