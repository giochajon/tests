using System;

namespace bubbling
{
	class MainClass
	{
	
		static void bubbleSort(int []arr) 
		{ 
			int n = arr.Length; 
			for (int i = 0; i < n - 1; i++) 
				for (int j = 0; j < n - i - 1; j++) 
					if (arr[j] > arr[j + 1]) 
				{ 
					// swap temp and arr[i] 
					int temp = arr[j]; 
					arr[j] = arr[j + 1]; 
					arr[j + 1] = temp; 
				} 
		} 
	
		 void printArray(int []arr)  //this function goes through the array to test and print 
		{ 
			int n = arr.Length; 
			for (int i = 0; i < n; ++i) 
				Console.Write(arr[i] + " "); 
			Console.WriteLine(); 
				
		} 
		
	
		public int  largestNumber(int []arr) 
		{ 
			int n = arr.Length; 
			for (int i = 0; i < n - 1; i++) 
				for (int j = 0; j < n - i - 1; j++) 
					if (arr[j] > arr[j + 1]) 
				{ 
					// swap temp and arr[i] 
					int temp = arr[j]; 
					arr[j] = arr[j + 1]; 
					arr[j + 1] = temp; 
					return (arr[3]);
				} 
		} 
	
	
		
		
		public static void Main (string[] args)
		{
			int []arreglo = {5, 34, 12, 5};
			int result;
		    // printArray(arreglo);  
		    //bubbleSort(arreglo);
			//Console.WriteLine(arreglo[3]); //print last element
			result = largestNumber(arreglo);
			Console.WriteLine (result);
		}
		
		
	}
}
