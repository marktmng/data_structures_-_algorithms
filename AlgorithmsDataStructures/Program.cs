using AlgorithmsDataStructures.LinkedList; // LinkeList imported
using AlgorithmsDataStructures.Stack; // Stack imported
using AlgorithmsDataStructures.Queue; // Queue imported
//using AlgorithmsDataStructures.BinarySearch; // Binary Search imported
using AlgorithmsDataStructures.BinarySearchTree;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling; // Binary Search imported
using AlgorithmsDataStructures.HashTable; // HashTable imported






// // Linked List ::::::::

//LinkedList linkedList = new LinkedList(); // put the breakpoint here
//linkedList.InsertFirst(1);
//linkedList.InsertFirst(2);
//linkedList.InsertFirst(3);
//linkedList.InsertFirst(4);

//linkedList.DeleteFirst();
//linkedList.DeleteFirst();

//linkedList.InsertLast(546);
//linkedList.InsertLast(3434);

//linkedList.DisplayList();

// // Stack ::::::::

//Stack stack = new Stack(10);  // put the breakpoint here

//for (int i = 0; i < 3; i++)
//{
//	stack.Push("Squirtle");
//	stack.Push("Pickachu");
//	stack.Push("Charmander");

//	while(!stack.isEmpty())
//	{
//		var var = stack.Pop();
//		Console.WriteLine(var);
//	}
//}


// // Queue ::::::::

//Queue queue = new Queue(10); // put breakpoint here

//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);

//queue.Dequeue();
//queue.Dequeue();

//queue.Peek();


//// // Binary Search ::::::::
//int[] intArray = { -22, -15, 2, 7, 20, 30, 54}; // put breakpoint here

//Console.WriteLine(BinarySearch(intArray, 2));

//int BinarySearch(int[] array, int value)
//{
//	int start = 0;
//		int end = intArray.Length;

//	while (start < end) // start end + while less than is going criss crossing
//	{
//		int midpoint = (start + end) / 2; // put in parenthesis because add them incorrect

//		if (intArray[midpoint] == value) // search the middle of the book
//		{
//			return midpoint;
//		}

//		else if (intArray[midpoint] < value)
//		{
//			start = midpoint +1;
//		}

//		else
//		{
//			end = midpoint;
//		}
//	}
//	return -1;
//}


//// // Binary Search Tree ::::::::

//BinarySearchTree bst = new BinarySearchTree();

//bst.Insert(7, "Squirtle");
//bst.Insert(23, "Ekans");
//bst.Insert(151, "Mew");
//bst.Insert(4, "Charmander");
//bst.Insert(1, "Bulbasaur");

//Console.WriteLine(bst.Find(151)); // this is what we are going to search

//int value  = 0; // joker value to see entire value


//// // Bubble Search ::::::::

//int[] intArray = new int[] { 6, 5, 1, 7, 2, 4 };

////Console.WriteLine(BubbleSort(intArray));
//int[] value = BubbleSort(intArray);
//int joker = 0;

//int[] BubbleSort(int[] array) // breakpoint
//{
//	// hold temporary swap variable, think state;
//	int temp = 0;

//	// iterates over entire loop MANY times
//	for (int pointer = 0; pointer < array.Length; pointer++)
//	{
//		// forms the "box" that does the comparison
//		for(int sort = 0; sort < array.Length - 1; sort++)
//		{
//			// this checks to see if left side is larger then the right
//			if (array[sort] > array[sort + 1])
//			{
//				// swap 
//				// We store variable as temp so we dont overwrite it when we swap
//				temp = array[sort + 1];
//				// put left variable in the right
//				array[sort +1] = array[sort];
//				// put the right variable in the left
//				array[sort] = temp;
//			}
//		}
//	}
//	return array;
//}


//// // Recursion ::::::::

// example one 
//PartyFunction(); // breakpoint


//void PartyFunction()
//{
//	var val = Guid.NewGuid();
//	PartyFunction();
//}

//var val = 0;

// example two 
//MinusByOne(5);

//void MinusByOne(int n)
//{
//	// base case is goiung to prevent a stack overflow
//	if(n != 0)
//	{
//		MinusByOne(n - 1);
//	}
//	// all these function is going to execute, store state, Then they are going to minus
//	Console.WriteLine("Call:" + n);
//}

//// Factorial

//Console.WriteLine(RecurseiveFactorial(5));

//int RecurseiveFactorial(int num)
//{
//	if (num == 0)
//	{
//		return 1;
//	}

//	return num * RecurseiveFactorial(num - 1);
//}

//IterativeFactorial(5);

//int IterativeFactorial(int num)
//{
//	if (num == 0)
//	{
//		return 1;
//	}


//	int factorial = 1;
//	for(int i = 0; i <= num; i++)
//	{
//		factorial = factorial * i;
//	}
//	return factorial;

//	// 1 x 1;
//	// 1 x 2;
//	// 1 x 2 x 3;
//	// 1 x 2 x 3 x 4;
//}

//// // Hash Table ::::::::

HashTable hashTable = new HashTable(); // breakpoint
hashTable.Set("Teddy", "056-778-6987");
hashTable.Set("Steve", "344-87-6587");
hashTable.Set("Jessica", "098-756-8767");
hashTable.Set("Sara", "246-333-6578");
hashTable.Set("Jennifer", "789-357-96322");

Console.WriteLine(hashTable.Get("Teddy"));
Console.WriteLine(hashTable.Get("Steve"));
Console.WriteLine(hashTable.Get("Jessica"));
Console.WriteLine(hashTable.Get("Sara"));
Console.WriteLine(hashTable.Get("Jennifer"));