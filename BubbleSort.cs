using System;

namespace CSharpCapstone
{
	class Program
	{
		//sorts an array using Bubble Sort algorithm
		public static int[] bubbleSort(int[] arr)
		{
			int moves = 0;
			do
			{
				moves = 0;
				int n = arr.Length;
				for (int i = 0; i < n - 1; i++)
				{
					int j = i + 1;
					if (arr[i] > arr[j])
					{
						int temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
						moves++;
					}
				}
			} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
			return arr;
		}

		// prints an array
		public static void printArray(int[] arr)
		{
			int n = arr.Length;
			Console.Write("{ ");
			for (int count = 0; count < n - 1; count++)
			{
				Console.Write(arr[count] + ", ");
			}
			Console.Write(arr[n - 1] + " }");
		}

		// driver method
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter amount of integers to sort:");
			string userInput = Console.ReadLine();
			int n = Convert.ToInt32(userInput);
			int[] userArr = new int[n];

			Console.WriteLine("Please enter one integer value at a time.");
			for (int count = 0; count < n; count++)
			{
				Console.WriteLine("Integer {0}:", count);
				userInput = Console.ReadLine();
				userArr[count] = Convert.ToInt32(userInput);
			}
			Console.Write("Unsorted Array: ");
			printArray(userArr);
			Console.WriteLine();
			userArr = bubbleSort(userArr);
			Console.Write("Sorted Array: ");
			printArray(userArr);
		}
	}
}
