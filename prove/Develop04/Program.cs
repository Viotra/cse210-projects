using System;

class Program
{
    public static CountdownEvent test = new CountdownEvent(1);
    static void Main(string[] args)
    {
        Console.Clear();
        // Console.Write("Hello Develop04 World!");
        // Thread.Sleep(2000);
        // Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        // Console.Write("-_-");
        // Thread.Sleep(2000);
        // Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        // Console.Write("▬_-");
        // Thread.Sleep(2000);
        // Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        // Console.Write("▬_▬");

        // List<string> animations = new List<string>()
        // {
        //     "-_-",
        //     "▬_▬",
        //     "■_■",
        //     "▬_▬"
        // };

        // Breathing newactivity = new Breathing();
        // Animations animation = new Animations(newactivity.GetDuration());

        // string userInput = "";

        // while (userInput != "stop")
        // {

        //     foreach (string s in animations)
        //     {
        //         Console.Write(s);
        //         Thread.Sleep(350);
        //         Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        //     }
        //     userInput = Console.ReadLine();
        // }

        
        new Thread(Timer).Start();
        new Thread(Menu1).Start();

        test.Wait();
    }
    public static void Menu1()
    {
        Menu mainMenu = new Menu();
        mainMenu.MenuStart();
    }
    public static void Timer()
    {
        Thread.Sleep(200);
        Console.WriteLine("test complete.");
        test.Signal();
    }
}