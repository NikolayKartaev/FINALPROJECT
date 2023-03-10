Console.Clear();
Console.Write("Введите некоторый текст: ");
string[] text = Console.ReadLine()!.Split().ToArray();
Console.WriteLine();
Console.WriteLine($"Первоначальный массив строк: [{String.Join(", ", text)}]");

int count = 0;
for (int i = 0; i < text.Length; i++)
{
    if (text[i].Length <= 3)
    {
        count++;
    }
}

string[] text2 = new string[count];
for (int j = 0; j < text2.Length; j++)
{
    for (int k = 0; k < text.Length; k++)
    {
        if (text[k].Length <= 3)
        {
            text2[j] = text[k];
            j++;
        }
    }
}
Console.WriteLine();

Console.Write($"Итоговый массив строк: [{String.Join(", ", text2)}]");

