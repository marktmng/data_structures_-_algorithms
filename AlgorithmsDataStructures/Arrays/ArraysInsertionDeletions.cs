//// // ----- Arrays Part A  --------
//// Array Insertions $ Deletions

//// Inserting a the End of an Array

//int[] intArray = new int[10];

//// make a variable to keep the length because .Length is based off capacity and does not rack the actual index
//int length = 0;

//// this adds data for us
//for (int i = 0; i < 8; i++)
//{
//	intArray[length] = i + 1;
//	length++;
//}

////intArray[length] = 8;
////length++;

//// Inserting at the start of an array

////for (int i = 3; i >= 0; i--)
////{
////	// this is moving over all the values;
////	intArray[i + 1] = intArray[i];
////}

////intArray[0] = 20;

////int value = 0;


//// // inserting anywhere in array
//for (int i = 4; i >= 2; i--)
//{
//	// shift each element one position to the right
//	intArray[i + 1] = intArray[i];
//}

//intArray[2] = 8;

//int value = 0;

//// // ----- Arrays Part B  --------
//// Array Insertions $ Deletions

//// deleting from the end of the Array
//int[] intArray = new int[9];

//int length = 0;

//for (int i = 0; i < 6; i++)
//{
//	intArray[length] = i;
//	length++;
//}

//length--;

//for (int i = 0; i < length; i++)
//{
//	Console.WriteLine(intArray[i]);
//}


//// deleting from the start of the Array

//int[] intArray = new int[9];

//int length = 0;

//for (int i = 0; i < 6; i++)
//{
//	intArray[length] = i;
//	length++;
//}

//// length--;

//for (int i = 1; i < length; i++)
//{
//	intArray[i - 1] = intArray[i];
//}

//length--;

//for (int i = 0; i < length; i++)
//{
//	Console.WriteLine(intArray[i]);
//}

//// deleting from the anywhere of the Array

//int[] intArray = new int[9];

//int length = 0;

//for (int i = 0; i < 6; i++)
//{
//	intArray[length] = i;
//	length++;
//}

//for (int i = 3; i < length; i++)
//{
//	intArray[i - 1] = intArray[i];
//}

//length--;

//for (int i = 0; i < length; i++)
//{
//	Console.WriteLine(intArray[i]);
//}

