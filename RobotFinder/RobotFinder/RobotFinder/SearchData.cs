using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RobotFinder
{
	public class SearchData
	{
		private int[] _CurrentPosition;
		private int[] _PreviousPosition;
		private List<int[,]> _DeadPositions;

		public SearchData()
		{
			
		}
	}
}
