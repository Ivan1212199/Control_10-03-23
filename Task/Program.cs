string[] ArrayOne = new string[5] {"123", "23", "hello", "world", "res"};
string[] ArrayTwo = new string[ArrayOne.Length];
void SecondArrayWithIF(string[] ArrayOne, string[] ArrayTwo)
{
    for (int i = 0; i  <ArrayOne.Length; i++)
    {
    if(ArrayOne[i].Length  <= 3)
        {
        ArrayTwo[i] = ArrayOne[i];
        i++;
        }
    }
}
void PrintArray(string[] array)
{
    for    (int i = 0;   i<ArrayOne.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(ArrayOne, ArrayTwo);
PrintArray(ArrayTwo);