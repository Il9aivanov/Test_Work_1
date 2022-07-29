string[] first_array = { "123", "oil", "24", "joker", "album" };
int countSTR = 0;
for (int i = 0; i < first_array.Length; i++)
{
    if (first_array[i].Length <= 3)
    {
        countSTR++;
    }
}

string[] second_array = new string[countSTR];
string next = String.Empty;
int second_size = 0;

for (int i = 0; i < first_array.Length; i++)
{
    if (first_array[i].Length <= 3)
    {
        next = first_array[i];
        second_array[second_size] = next;
        second_size++;
    }
}
PrintArray(second_array);
void PrintArray(string[] array)
{
    for (int i = 0; i < second_array.Length; i++)
    {
        Console.Write(second_array[i] + " ");
    }
}