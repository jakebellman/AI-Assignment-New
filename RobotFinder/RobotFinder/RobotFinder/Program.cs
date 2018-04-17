

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RobotFinder
{

	class program
	{
		

		static void Main(string[] args)
		{
			FieldData newField = new FieldData();

			   string Selection = "0";
				bool finished = false;
				
			DepthSearch newDepthsearch = new DepthSearch(newField);



			Console.WriteLine("Please Select Search Algorithym:\n 1: Depth-First Search\n2: Breadth-first search\n3:Greedy best-first\n4: A*(Astar)");

			do  
			{
				if(Selection == "1")
				{
					//newDepthsearch;

					finished = true;
				}
				if(Selection == "2")
				{
					finished = true;
				}
				if(Selection == "3")
				{
					finished = true;
				}
				if(Selection == "4")
				{
					finished = true;
				}

			} while (finished == false);
				
			Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();

		}

	}

}