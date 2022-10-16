Console.Write("Введите данные ввиде слов, набора символов, набора цыфр, через пробел: ");
string text = Console.ReadLine();
string[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] array2 = new string[array.Length];