public class Probar
{
    private string _something;

    public Probar(string something)
    {
        _something = something;
    }

    public void WriteSomething()
    {
        Console.WriteLine(_something);
    }
}