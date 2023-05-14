class Listing : Activity
{
    List<string> prompts = new List<string>()
    {
        "What are some things you appreciate about yourself? ",
        "What are some sights you wish to see? ",
        "Who made you smile today? ",
        "What emotions did you feel today? ",
        "Who are the people closest to you? ",
        "What are your biggest fears? ",
        "Things that I'm grateful for? "
    };

    public Listing()
        : base("Listing Activity")
        {
            _instructions = "During this activity, you will write down anything that comes to your mind within the set time";
        }

    public void RunListingActivity()
    {
        StartActivity();
        int duration = GetDuration();
        Animations animations = new Animations();
        animations.CountdownTimer();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddMinutes(duration);
        DateTime currentTime = new DateTime();

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count - 1);
        string randomPrompt = prompts[randomIndex];
        Console.WriteLine(randomPrompt);

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.ReadLine();
        }
        
        WriteEndMessage();
    }
}