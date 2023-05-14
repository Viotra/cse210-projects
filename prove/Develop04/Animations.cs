class Animations{
    double _duration;

    private List<string> _blinkAnimations = new List<string>()
        {
            "-_-",
            "▬_▬",
            "■_■",
            "▬_▬"
        };
    private List<string> _breatheAnimatations = new List<string>()
    {
        "^.^",
        "^o^",
        "^O^"
    };
    private List<string> _spinnerAnimations = new List<string>()
    {
        "/",
        "-",
        "\\",
        "|"
    };
    public Animations()
    {
        _duration = 5;
    }
    public Animations(int duration)
    {
        _duration = duration;
    }

    public void RunBlinkAnimation()
    {
        while (_duration > 0) 
        {
            foreach (string animation in _blinkAnimations)
            {
                Console.Write(animation);
                Thread.Sleep(500);
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                _duration = (_duration - 0.5);
            }
        }   
    }

    public void Breathe()
    {
        while (_duration > 0)
        {
            Console.Clear();
            Console.WriteLine("Breathe In");

            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    Console.Write(_breatheAnimatations[i]);
                }
                else
                {
                    Console.Write(_breatheAnimatations[i]);
                    Thread.Sleep(500);
                    Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                }
            }

            Thread.Sleep(3500);
            Console.Clear();

            Console.WriteLine("Breathe Out");

            for (int i = 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(_breatheAnimatations[i]);
                }
                else
                {
                    Console.Write(_breatheAnimatations[i]);
                    Thread.Sleep(500);
                    Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
                }    
            }

            Thread.Sleep(3500);

            _duration = (_duration - 10);
        }
    }

    public void Spinner(double duration)
    {
        while (duration > 0)
        {
            foreach (string animation in _spinnerAnimations)
            {
                Console.Write(animation);
                Thread.Sleep(200);
                Console.Write("\b \b");
                duration = (duration - 0.2);
            }
        }
    }

    public void CountdownTimer()
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.Write("Beginning activity in: " + i.ToString());
            Thread.Sleep(1000);
            Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
        }
    }
}