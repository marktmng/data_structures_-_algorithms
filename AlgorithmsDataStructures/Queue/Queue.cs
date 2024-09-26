﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Queue
{
	public class Queue
	{
		public int MaxSize { get; set; } // Sets the number of elements because this is an array
        public int[] QueueArray { get; set; } // Actual array we will store elements in
        public int Front { get; set; } // Index to keep track of front
        public int Rear { get; set; } // Index to keep track of adds
        public int NItems { get; set; } // this will keep track of the lenght

        public Queue(int size) 
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
        }

        // somebody is going into chick fila line
        public void Enqueue(int item)
        {
            // increment our pointer
            Rear++;
            // insert into where the rear was incremented
            QueueArray[Rear] = item;
            // increment the length
            NItems++;
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];
        }
    }
}
