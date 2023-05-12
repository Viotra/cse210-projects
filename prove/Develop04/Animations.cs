class Animations{
    int duration;

    private List<string> _blinkAnimations = new List<string>()
        {
            "-_-",
            "▬_▬",
            "■_■",
            "▬_▬"
        };

    public Animations(int _duration)
    {
        duration = _duration;
    }

    CountdownEvent test = new CountdownEvent(1);

    public void RunBlinkAnimation()
    {
        foreach (string animation in _blinkAnimations)
        {
            Console.Write(animation);
            Thread.Sleep(350);
            Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        }
    }
}