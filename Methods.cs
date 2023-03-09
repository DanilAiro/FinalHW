internal class Methods
{
  #region MethodsForTasks
    public string ReadString(string argument)
    {
      Console.Write($"Введите {argument}: ");
      return Console.ReadLine();
    }

    public int ReadInt(string argument)
    {
      int i;
      Console.Write($"Введите {argument}: ");

      while(!int.TryParse(Console.ReadLine(), out i))
      {
        Console.Write("Не смогли получить целое число, повторите");
      }

      return i;
    }

    public void PrintArray(string[] array, string arg)
    {
      Console.Write($"{arg} ");

      for (int i = 0; i < array.Length; i++)
      {
        if (i == array.Length - 1)
        {
          Console.WriteLine($"{array[i]}");
        }
        else
        {
          Console.Write($"{array[i]}, ");
        }
      }
    }

    public string[] GetFilledArrayOfString(int length)
    {
      string[] array = new string[length];

      for (int i = 0; i < length; i++)
      {
        array[i] = ReadString("элемент массива");
      }

      return array;
    }

    public string[] GetRandomlyFilledArray(int length)
    {
      string[] array = new string[length];

      for (int i = 0; i < length; i++)
      {
        array[i] = GetRandomWord();
      }

      return array;
    }

    public string GetRandomWord()
    {
      Random random = new Random();
      string word = String.Empty;
      string[] array = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", 
                                     "j", "k", "l", "m", "n", "o", "p", "q", "r", 
                                     "s", "t", "u", "v", "w", "x", "y", "z", "0", 
                                     "1", "2", "3", "4", "5", "6", "7", "8", "9"};
      int minRandom = 1;
      int maxRandom = 7;

      for(int i = 0; i < random.Next(minRandom, maxRandom); i++)
      {
        word += array[random.Next(0, array.Length)];
      }

      return word;
    }

    public string[] GetArrayOfStringLessThanLength(int length, string[] arr)
    {
      string[] array = new string[GetCountOfWordLessThanLength(length, arr)];
      int k = 0;

      for (int j = 0; j < arr.Length; j++)
      {
        if (arr[j].Length < 4)
        {
          array[k] = arr[j];
          k++;
        }
      }

      return array;
    }

    public int GetCountOfWordLessThanLength(int length, string[] arr)
    {
      int count = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i].Length < length) count++;
      }

      return count;
    }
  #endregion

  #region MethodsForProgram

  public bool ToExit()
  {
    return false;
  }

  #endregion
}