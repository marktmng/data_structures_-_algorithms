namespace AlgorithmsDataStructures.Stack
{
	public class Stack
	{
        public int MaxSize { get; set; } // Array stack you need a maxsize to init array

        public string[] StackArray { get; set; } // this holds our array

        public int Top { get; set; } // this keeps track of the top

        public Stack(int size) 
        { 
            this.MaxSize = size; // This holds constructor value
            this.StackArray = new string[this.MaxSize]; // Creates array with size
            this.Top = -1; // we give top -1 because array is zero index; if we don't it will skip first element
        }

        public void Push(string item)
        {
            Top++; // increment by 1
            StackArray[Top] = item;
        }

        public string Pop()
        {
            int old_top = Top; // Think this is the placeholder
            Top--; // This is decrement for the new top
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }
    }
}
