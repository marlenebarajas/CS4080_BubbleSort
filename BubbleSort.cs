using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCapstone
{
	class Sorter
	{
		/**Method Overloading used for BubbleSort() so that we can call this method regardless of data type (between int, double, and string).**/
		public static void BubbleSort(List<int> list, char choice)
		{
			int moves = 0;
			switch (choice)
			{
				case 'a': //ascending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i] > list[j]) //returns 1 if list[i] is greater than list[j]
							{
								int temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
				case 'd': //descending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i] < list[j]) //returns -1 if list[i] is less than list[j]
							{
								int temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
			}
		}

		public static void BubbleSort(List<double> list, char choice)
		{
			int moves = 0;
			switch (choice)
			{
				case 'a': //ascending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i] > list[j]) //returns 1 if list[i] is greater than list[j]
							{
								double temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
				case 'd': //descending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i] < list[j]) //returns -1 if list[i] is less than list[j]
							{
								double temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
			}
		}

		public static void BubbleSort(List<string> list, char choice)
		{
			int moves = 0;
			switch (choice)
			{
				case 'a': //ascending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i].CompareTo(list[j]) > 0) //returns 1 if list[i] is greater than list[j]
							{
								string temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
				case 'd': //descending order
					do
					{
						moves = 0;
						int n = list.Count;
						for (int i = 0; i < n - 1; i++)
						{
							int j = i + 1;
							if (list[i].CompareTo(list[j]) < 0) //returns -1 if list[i] is less than list[j]
							{
								string temp = list[i];
								list[i] = list[j];
								list[j] = temp;
								moves++;
							}
						}
					} while (moves != 0);//if there were no moves made this pass, then this array is sorted now
					break;
			}
		}

		/**Method Overloading used for PrintList() so that we can call this method regardless of data type (between int, double, and string).**/
		public static void PrintList(List<int> list)
		{
			int n = list.Count;
			Console.Write("{ ");
			for (int count = 0; count < n - 1; count++)
			{
				Console.Write(list[count] + ", ");
			}
			Console.Write(list[n - 1] + " }");
		}
		
		public static void PrintList(List<double> list)
		{
			int n = list.Count;
			Console.Write("{ ");
			for (int count = 0; count < n - 1; count++)
			{
				Console.Write(list[count] + ", ");
			}
			Console.Write(list[n - 1] + " }");
		}

		public static void PrintList(List<string> list)
		{
			int n = list.Count;
			Console.Write("{ ");
			for (int count = 0; count < n - 1; count++)
			{
				Console.Write(list[count] + ", ");
			}
			Console.Write(list[n - 1] + " }");
		}

		// driver method
		public static void Main(string[] args)
		{
			Console.WriteLine("Specify what data type you would like to sort.\nEnter '1' for integer.\nEnter '2' for double.\nEnter '3' for string.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			char order;
			switch (userInput)
			{
				case 1:
					Console.WriteLine("Enter list of integers separated by commas (ex. 1,2,3):");
					string userInts = Console.ReadLine();
					List<string> intInput = userInts.Split(',').ToList();
					List<int> intSorter = new List<int>();
					foreach (string item in intInput)
					{
						intSorter.Add(Convert.ToInt32(item));
					}
					Console.WriteLine("Enter 'a' for sorting into ascending order.\nEnter'd' for sorting into descending order.");
					order = Convert.ToChar(Console.ReadLine());
					switch (order)
					{
						case 'a':
							BubbleSort(intSorter, 'a');
							PrintList(intSorter);
							break;
						case 'd':
							BubbleSort(intSorter, 'd');
							PrintList(intSorter);
							break;
						default:
							Console.WriteLine($"An unexpected value ({order}), please try again.");
							break;
					}
					break;

				case 2:
					Console.WriteLine("Enter list of doubles separated by commas (ex. 1.0,2.0,3.0):");
					string userDoubles = Console.ReadLine();
					List<string> doubInput = userDoubles.Split(',').ToList();
					List<double> doubSorter = new List<double>();

					foreach (string item in doubInput)
					{
						doubSorter.Add(Convert.ToDouble(item));
					}
					Console.WriteLine("Enter 'a' for sorting into ascending order.\nEnter'd' for sorting into descending order.");
					order = Convert.ToChar(Console.ReadLine());
					switch (order)
					{
						case 'a':
							BubbleSort(doubSorter, 'a');
							PrintList(doubSorter);
							break;
						case 'd':
							BubbleSort(doubSorter, 'd');
							PrintList(doubSorter);
							break;
						default:
							Console.WriteLine($"An unexpected value ({order}), please try again.");
							break;
					}
					break;

				case 3:
					Console.WriteLine("Enter list of strings separated by commas (ex. One,Two,Three):");
					string userStrings = Console.ReadLine();
					List<string> stringSorter = userStrings.Split(',').ToList();

					Console.WriteLine("Enter 'a' for sorting into ascending order.\nEnter'd' for sorting into descending order.");
					order = Convert.ToChar(Console.ReadLine());
					switch (order)
					{
						case 'a':
							BubbleSort(stringSorter, 'a');
							PrintList(stringSorter);
							break;
						case 'd':
							BubbleSort(stringSorter, 'd');
							PrintList(stringSorter);
							break;
						default:
							Console.WriteLine($"An unexpected value ({order}), please try again.");
							break;
					}
					break;
				default:
					Console.WriteLine($"An unexpected value ({userInput}), please try again.");
					break;

			}
		}
	}
}
