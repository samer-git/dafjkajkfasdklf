using System;

namespace T1SemTest
{
	public class Folder : Thing
	{
		private List<Thing> _contents;

		public Folder(string name) : base(name)
		{
			_contents = new List<Thing>();
		}

		public void Add(Thing toAdd)
		{
			_contents.Add(toAdd);
		}

		public override int Size()
		{
			int size = 0;
			foreach(Thing i in _contents)
			{
				size += i.Size();
			}

			return size;
		}

		public override void Print()
		{
			if(_contents.Count() <= 0)
			{
				Console.WriteLine("The folder '" + Name + "' is empty!");
			}
			else
			{
				Console.WriteLine("The folder '" + Name + "' contains " + Size().ToString() + " bytes total:");

				int index = 0;
				foreach(Thing itm in _contents)
				{
					index += 1;
					Console.Write(index.ToString() + ". ");
					itm.Print();
				}
			}
		}
	}
}

