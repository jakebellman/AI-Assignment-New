
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RobotFinder
{
	enum  Direction  
	{
		Right,
		Left,
		Up,
		Down,
	}
	public class DepthSearch
	{
		private int _xc,_yc, _xn,_yn;
		
		public DepthSearch(FieldData newfieldData)
		{
			_xc = 2;
			_yc = 3;
			_xn = newfieldData.x1;
			_yn = newfieldData.y1;
			Direction Previous = Direction.Down;
			Stack<int> Nodes = new Stack<int>();


			Collision Collisions = new Collision(newfieldData);

			do 
			{
				

				if(Collisions.ValidArea(_xc ,_yc+1)) 
				{
					Previous = Direction.Up;
					_yc += 1 ;
					Console.WriteLine("X pos{0},Y pos{1}",_xc,_yc);
				}
					        
				else if((Collisions.ValidArea(_xc - 1 ,_yc)))
				{
					Previous = Direction.Left;
					_xc -= 1;

				}    	


				else if((Collisions.ValidArea(_xc ,_yc - 1)))
				{
					Previous = Direction.Down;
					_yc -= 1;
					Console.WriteLine("X pos{0},Y pos{1}",_xc,_yc);	
				}
				        
				 else if(Collisions.ValidArea(_xc + 1,_yc))
				{
					
					Previous = Direction.Right;
					_yc += 1;
					Console.WriteLine("{0},{1}",_xc,yc);	       
				}
				        
			

			} while (Collisions.CheckGoal(_xc, _yc) == false);
			Console.WriteLine("is in goalstate");
					        Console.ReadKey();

		}






		public int xc //Current Position X
		{
			get
			{
				return _xc;
			}

			set
			{
				_xc = value;
			}
		}
		public int yc //Current Position Y
		{
			get
			{
				return _yc;
			}

			set
			{
				_yc = value;
			}
		}

		public int xn //Next Position X
		{
			get
			{
				return _xc;
			}

			set
			{
				_xc = value;
			}
		}
		public int yn //Next Position Y
		{
			get
			{
				return _yn;
			}

			set
			{
				_yn = value;
			}
		}
	}
}
