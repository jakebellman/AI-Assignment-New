using System;
namespace RobotFinder
{
	public class Space
	{
		bool _visited ;
		bool _available;
		bool _goalstate ;
		int _node;
		int _x;
		int _y;

		public Space(int x,int y)
		{
			_visited = false;
			_available = true;
			_node = 0;
			_goalstate = false;
			_x = x;
			_y = y;

		}

		public int X
		{
			get
			{
				return _x;
			}

			set
			{
				_x = value;
			}
		}

		public int Y
		{
			get
			{
				return _y;
			}

			set
			{
				_y = value;
			}
		}
		public bool Visited
		{
			get
			{
				return _visited;
			}

			set
			{
				_visited = value;
			}
		}
		public bool Available
		{
			get
			{
				return _available;
			}

			set
			{
				_available = value;
			}
		}
		public int Node
		{
			get
			{
				return _node;
			}

			set
			{
				_node = value;
			}
		}
		public bool GoalState
		{
			get
			{
				return _goalstate;
			}

			set
			{
				_goalstate = value;
			}
		}

	}
}
