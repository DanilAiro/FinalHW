internal class Tasks
{
Methods m = new Methods();

  public void MainTask()
  {
    Console.WriteLine($"Как хотите заполнить массив:{Environment.NewLine}"
                    + $"1. Вручную{Environment.NewLine}"
                    + $"2. Случайным образом");
    string number = m.ReadString("номер варианта");

    switch (number)
    {
      case "1":
        
        break;

      case "2":

        break;
    }
  }
}