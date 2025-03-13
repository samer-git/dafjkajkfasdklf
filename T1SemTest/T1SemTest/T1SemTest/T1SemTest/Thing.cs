using System;

namespace T1SemTest
{
	public abstract class Thing
	{
		private string _name;

		public Thing(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}

		public abstract int Size();
		public abstract void Print();
	}
}

