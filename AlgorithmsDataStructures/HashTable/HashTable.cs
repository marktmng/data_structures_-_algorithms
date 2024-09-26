using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.HashTable
{
	public class HashTable
	{
        public string[] _hashTable { get; set; }

		public HashTable() 
		{
			_hashTable = new string[10];
		}

		public string Get(string key)
		{
			int hashedKey = _hash(key);
			return _hashTable[hashedKey];
		}

		// this is a VERY VERY weak hashing algorithm
		private int _hash(string key)

		{
			return key.Length % _hashTable.Length;
		}
		public void Set(string key, string value)
		{
			// key is going to hashed
			int hashedKey = _hash(key);
            if (_hashTable[hashedKey] != null)
            {
				Console.WriteLine("SOrry hash collison has occured");
            }
			else
			{
				_hashTable[hashedKey] = value;
			}
        }
    }
}
