using System;

namespace largestNumber
{



    

	class MainClass
	
	{
	
	
		static int largestNumber (int a, int b,int c,int d)
		{
			int lNum = a;
			if (b > lNum) lNum = b;
			if (c > lNum) lNum = c;
			if (d > lNum) lNum = d;
			return lNum;
		}
	
	
	
	
	
	
		public static void Main (string[] args)
		{
			Console.WriteLine (largestNumber(1,4,3,5));
		}
	}
}
