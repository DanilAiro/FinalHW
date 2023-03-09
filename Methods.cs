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
      while(!int.TryParse(Console.ReadLine(), out i))
      {
        Console.Write("Не смогли получить целое число, повторите");
      }

      return i;
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

      for(int i = 0; i < random.Next(1, 7); i++)
      {
        word += array[random.Next(0, array.Length)];
      }

      return word;
    }
  #endregion

  #region MethodsForProgram

  #endregion
}