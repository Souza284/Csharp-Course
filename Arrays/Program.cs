#region Unidimensional Arrays - Vector

int[] numbers = new int[5];

numbers[0] = 4;
numbers[1] = 7;
numbers[2] = 23;
numbers[3] = 432;
numbers[4] = 8;
numbers[4] = 77;

Console.WriteLine(numbers[3]);

#endregion

#region Bidimensional Arrays - Matrix

int[,] biNumbers = new int[3, 3];

biNumbers[0,0] = 10;
biNumbers[1,0] = 12;

Console.Write($"[ {biNumbers[0,0]} ]");
Console.Write($"[ {biNumbers[1,0]} ]");

#endregion
