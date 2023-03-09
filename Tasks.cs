internal class Tasks
{
Methods m = new Methods();

  public void MainTask()
  {
    Console.WriteLine($"{Environment.NewLine}Как хотите заполнить массив:{Environment.NewLine}"
                    + $"1. Вручную{Environment.NewLine}"
                    + $"2. Случайным образом");
    string number = m.ReadString("номер варианта");

    if (number == "1" || number == "2")
    {
      switch (number)
      {
        case "1":
          TaskManualy();
          Console.ReadKey();
          break;

        case "2":
          TaskRandomly();
          Console.ReadKey();
          break;
      }
    }
    else
    {
      Console.WriteLine("Нет такого значения, поэтому заполним случайным образом");

      TaskRandomly();
      Console.ReadKey();
    }
  }

  public void TaskManualy()
  {
    Console.WriteLine();
    int maxLength = 4;
    
    string[] array = m.GetFilledArrayOfString(m.ReadInt("длину массива"));
    m.PrintArray(array, "Изначальный массив:");

    string[] arr = m.GetArrayOfStringLessThanLength(maxLength, array);
    m.PrintArray(arr, "Итоговый массив:");
    Console.WriteLine();
  }

  public void TaskRandomly()
  {
    Console.WriteLine();
    int maxLength = 4;

    string[] array = m.GetRandomlyFilledArray(m.ReadInt("длину массива"));
    m.PrintArray(array, "Изначальный массив:");

    string[] arr = m.GetArrayOfStringLessThanLength(maxLength, array);
    m.PrintArray(arr, "Итоговый массив:");
    Console.WriteLine();
  }
}