internal class Main
{
  Tasks t = new Tasks();
  Methods m = new Methods();
  public void MainProgram()
  {
    Console.Clear();
    bool isWork = true;

    while (isWork)
    {
      Console.WriteLine($"Данная программа отсортирует ваш массив по длине, до 3 символов включительно.{Environment.NewLine}"
                      + $"Для начала напишите \"Start\"{Environment.NewLine}"
                      + $"Для выхода напишите \"Exit\"");
      
      string s = m.ReadString("ваш выбор").ToLower();
      if (s == "start" || s == "s" || s == "ы")
      {
        t.MainTask();
      }
      else if (s == "exit" || s == "e" || s == "у")
      {
        isWork = m.ToExit();
      }
      else
      {
        Console.WriteLine("Команда не распознана, нажмите любую клавишу для повтора");
        Console.ReadKey();
      }
    }
  }
}