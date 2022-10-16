Console.Write("Введите данные ввиде слов, набора символов, набора цыфр, через пробел: ");
string text = Console.ReadLine();
string[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array.Length];
void CheckArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}