using System;

namespace largestNumber
{



    

	class MainClass
	
	{
	
	
		static int largestNumber (int a, int b,int c,int d) 
		{
		 int lNum;
		    //lNum = a+b;
		    
		    if (a > b) 
			{
			lNum = a;
			}		
			else   
			{
				if (b > c)
				{ lNum = b; }
			else 
			
					if (c > d)
				{ lNum = c; }
				else 
			lNum = d;
			}
		    
		    
			return lNum;
			
		}
	
	
	
	
	
	
		public static void Main (string[] args)
		{
			Console.WriteLine (largestNumber(1,4,3,5));
		}
	}
}
