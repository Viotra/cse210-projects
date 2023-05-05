using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("James", "4", "12", "Whosoever shall break these laws shall find no place in the kingdom of God.");
        scripture.ReadScripture();
    }
}