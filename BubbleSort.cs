using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCapstone
{

	class Program
	{
		public class GenericList<T>
		{
			// nested class of nodes for Sorter
			private class Node
			{
				public Node(T t)
				{
					next = null;
					data = t;
				}

				private Node next;
				public Node Next
				{
					get { return next; }
					set { next = value; }
				}

				private T data;

				public T Data
				{
					get { return data; }
					set { data = value; }
				}

                internal int CompareTo(Node next)
                {
                    if(next==null) return 1; //if next is null, this value is greater
					if (Convert.ToDouble(Data) > Convert.ToDouble(next.Data)) return 1; //this value is greater
					else if (Convert.ToDouble(Data) < Convert.ToDouble(next.Data)) return -1; //this value is lesser
					else return 0; //the values are equal
                }
            }
			private Node head;
			private int count;
			
			// constructor
			public GenericList()
			{
				head = null;
				count = 0;
			}

			public void Add(T input)
			{
				Node n = new Node(input);
				n.Next = head;
				head = n;
				count++;
			}

			//enumerator to help BubbleSort() and PrintList()
			public IEnumerator<T> GetEnumerator()
			{
				Node current = head;
				while (current != null)
				{
					yield return current.Data;
					current = current.Next;
				}
			}

			public void BubbleSort()
			{
				int moves = 0;
				do
				{
					moves = 0;
					Node current = head;
					while (current.Next!=null)
					{
						if (current.CompareTo(current.Next) > 0) // if current if greater, this returns 1
						{
							T temp = current.Data;
							current.Data = current.Next.Data;
							current.Next.Data = temp;
							moves++;
						}
					}
				} while (moves != 0); //if there were no moves made this pass, then this array is sorted now
			}

			public void PrintList()
			{
				foreach (T item in this)
				{
					Console.Write(item + " ");
				}
			}
		}

		// driver method
		public static void Main(string[] args)
		{
			Console.WriteLine("Specify what data type you would like to sort.\nEnter '1' for integer.\nEnter '2' for double.\nEnter '3' for string.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			switch (userInput)
			{
				case 1:
					GenericList<int> intList = new GenericList<int>();
					Console.WriteLine("Enter list of integers separated by commas (ex. 1,2,3):");
					string userInts = Console.ReadLine();
					List<string> intSorter = userInts.Split(',').ToList<string>();
					
					foreach (string x in intSorter)//populate sorter with int values
					{
						intList.Add(Convert.ToInt32(x));
					}

					intList.BubbleSort();
					intList.PrintList();
					break;
				case 2:
					GenericList<double> doubList = new GenericList<double>();
					
					//populate sorter with doubles
					//bubblesort here
					foreach (double i in doubList)
					{
						System.Console.Write(i + " ");
					}
					break;
				case 3:
					GenericList<string> stringList = new GenericList<string>();
					
					//populate sorter with strings
					//bubblesort here
					foreach (string i in stringList)
					{
						System.Console.Write(i + " ");
					}
					break;
				default:
					Console.WriteLine($"An unexpected value ({userInput}), please try again.");
					break;

			}
		}
	}
}
