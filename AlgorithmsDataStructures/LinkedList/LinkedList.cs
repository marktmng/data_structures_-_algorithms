

namespace AlgorithmsDataStructures.LinkedList
{
	public class LinkedList
	{
        public Node? First { get; set; }

		public void InsertFirst(int Data)
		{
			// Create the node
			Node newNode = new Node();
			// Put the data in the node
			newNode.Data = Data;
			// Put the old node in next
			newNode.Next = First;
			
			First = newNode;// Make the first the new node
		}

		public Node DeleteFirst()
		{
			// Assign the temporary variable
			Node temp = First;
			// Assign the next node
			First = First.Next;
			return temp;
		}

		public void DisplayList()
		{
			Console.WriteLine("Iterating thru list...");
			Node current = First; // assign a current node
			while (current != null) // make a while loop
			{
				current.DisplayNode();
				current = current.Next;
			}
		}

		public void InsertLast(int data)
		{
			Node current= First;
			while (current.Next != null)
			{
				current = current.Next;
			}
			Node newNode = new Node();
			newNode.Data = data;
			current.Next = newNode;
		}
    }
}
