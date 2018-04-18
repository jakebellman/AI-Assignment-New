
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RobotFinder
{
	enum  Commands 
	{
		Right,
		Left,
		Up,
		Down,
		Push,
		Pop,
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


			Stack<int> _nodes = new Stack<int>();
			Stack<Commands> _commands = new Stack<Commands>(); // Holds Commands used by Depth Search

			List<int> number_of_nodes; // Holds the total 
			List<Stack<int>> _alltrees = new List<Stack<int>>(); // contains all stacks for tree routes


			Collision Collisions = new Collision(newfieldData);

			do 
			{



				if(Collisions.ValidArea(_xc ,_yc+1)) // Check if moving up is possible
				{

					_yc += 1 ; // move up
					_commands.Push(Commands.Up);
					Console.WriteLine("X pos{0},Y pos{1}",_xc,_yc);
				}
					        
				else if((Collisions.ValidArea(_xc - 1 ,_yc))) // Check Move left
				{


					_xc -= 1; // move left
					_commands.Push(Commands.Left);

				}    	


				else if((Collisions.ValidArea(_xc ,_yc - 1))) //Check move down
				{
					
					_yc -= 1; // move down
					Console.WriteLine("X pos{0},Y pos{1}",_xc,_yc);	
					_commands.Push(Commands.Down);
				}
				        
				 else if(Collisions.ValidArea(_xc + 1,_yc)) // Check move right
				{
					

					_yc += 1; // move right
					Console.WriteLine("{0},{1}",_xc,yc);
					_commands.Push(Commands.Right);
				}
				else 
				{
					if(_commands.Peek() != Commands.Pop)
					{
						_alltrees.Add(_nodes); // When a tree is dead the stack information is added to all tree's 
					}

					_nodes.Pop(); // Removes The top node from stack and adds it to _oldnode
					foreach(Space s in newfieldData.AllSpaces) // cycles through all Spaces to look for previous node
					{
						
						if(s.Node == _nodes.Peek())
						{
							_xc = s.X; // makes previous node's coordinates equal to current position
							_yc = s.Y;
						}
					}

					
						
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
