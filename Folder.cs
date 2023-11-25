using System;
namespace T1_oop
{
	public class Folder:Thing
	{
		private List<Thing> _contents;
		
		public Folder(string name):base(name)
		{
			_contents = new List<Thing>();
			
		}

		public void Add(Thing toAdd)
		{
			_contents.Add(toAdd);
		}
		public override int Size()
		{
			int i = 0;

			foreach (Thing file in _contents)
			{
				i += file.Size();
			}
			return i;
		}

		public override void Print()
		{

			if (_contents.Count == 0)
			{
				Console.WriteLine("The folder '" + Name + "' is empty!");
			}
			else
			{
				
				Console.WriteLine("The folder '" + Name + "' contains " + Size() + " bytes total:");
                foreach (Thing t in _contents)
				{
					t.Print();
				}
                
            }
		}
	}
}

