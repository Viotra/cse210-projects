using System;

class Program
{
    public static CountdownEvent test = new CountdownEvent(1);
    static void Main(string[] args)
    {
        Console.Clear();
        Menu mainMenu = new Menu();
        mainMenu.MenuStart();
        Console.Clear();
    }
}