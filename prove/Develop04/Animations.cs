class Animations{
    int duration;

    private List<string> animations = new List<string>()
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

    }
}