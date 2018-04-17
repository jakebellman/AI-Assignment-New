using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RobotFinder
{
	public  class Collision
	{
		private FieldData _fieldData;
		public Collision(FieldData fieldData)
		{
			_fieldData = fieldData;

		}

		public bool CheckGoal(int xcurrent,int ycurrent)
		{
			if((xcurrent == _fieldData.xg) && (ycurrent == _fieldData.yg)) return true; // checks if current position is in goal state

			else 
				return false;
		}

		public bool InsideArea(int xnext,int ynext)
		{
			if( (xnext <= _fieldData.N) && (ynext <= _fieldData.M) && (ynext >= 0) && (xnext >= 0))
			{return true;
			}
			else
			{
				return false;
			}
		}



		public bool ValidArea(int xnext,int ynext)
		{ 

			bool _areavalid = true;

			if(InsideArea(xnext,ynext) == true)
			{
				for ( int i = 0; i < _fieldData.xs.Count; i++)
				{
					for( int j = 0; j < _fieldData.width[i];j++)
					{
						for( int k = 0; k < _fieldData.height[i]; k++)
						{
							
							if (((_fieldData.xs[i]+ j) == xnext) && ((_fieldData.ys[i]+ k) == ynext))
							{
								_areavalid = false; 
								Console.WriteLine("block found");
								Console.ReadKey();
							}

						}
					}

				}
			}
			else
			{
				_areavalid = false;
			}


			return _areavalid;
		}

	}
}
