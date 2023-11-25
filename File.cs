using System;
namespace T1_oop
{
	public class File : Thing
	{
		private string _extension;
		private int _size;

		public File(string name, string extension, int size) : base(name)
		{
			_size = size;
			_extension = extension;
		}

		public override int Size()
		{
			return _size;
		}
		public override void Print()
		{
			
			string filedesc = "File '" + Name + "." + _extension + "' -- " + _size + " bytes";
			Console.WriteLine(filedesc);
			
			
		}
		
	}
}

