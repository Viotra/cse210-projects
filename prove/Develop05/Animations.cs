class Animations
{
    private List<string> _spinnerAnimations = new List<string>()
    {
        "/",
        "-",
        "\\",
        "|"
    };
    private List<int> _bonusPoints = new List<int>()
    {
        5, 25, 50, 150, 500, 5, 25, 50, 150, 5, 25, 50, 5, 25, 5
    };
    public void Spinner(double duration = 1.5)
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

    public int BonusPoints()
    {
        Random random = new Random();
        int randomIndex = random.Next(_bonusPoints.Count - 1);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime = new DateTime();

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            
            foreach (int number in _bonusPoints)
            {   
                Console.Write("BONUS POINTS! " + number);
                Thread.Sleep(200);
                Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");
            }
        }
        return _bonusPoints[randomIndex];
    }
}