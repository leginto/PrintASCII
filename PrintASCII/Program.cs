using System;

namespace PrintASCII
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ASCII a = new ASCII ();

			a.PrintAllAscii (180);


		}
	}

	public class ASCII
	{
		public void PrintAllAscii(int limit)
		{
			for (int i = 0; i <= limit; i++) {
				Console.WriteLine ("{0} --> {1}", i, (char)i);
			}
		}

	}

}
