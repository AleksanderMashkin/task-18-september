Console.WriteLine("Сколько слов вы хотите записать в программу?");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вписывайте " + N +  " слов");
string[] array1 = new string [N];
string[] array2 = new string [N];
int length2 = 0;
Console.WriteLine();
for (int i = 0; i < N; i++)
{
    array1[i] = Console.ReadLine();
}
for (int i = 0; i < N; i++)
{
    Console.WriteLine(array1[i]);
}
Console.WriteLine();
for (int j = 0; j < array1.Length; j++)
{
    if (array1[j].Length <= 3)
    {
        array2[length2] = array1[j];
        length2++;
    }
}
for (int i = 0; i < length2; i++)
{
    Console.WriteLine(array2[i]);
}

