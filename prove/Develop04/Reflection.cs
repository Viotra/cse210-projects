class Reflection : Activity
{
    private List<string> _initialQuestions = new List<string>()
    {
        "--Imagine a time in your life that you were under a lot of stress.--",
        "--Remember a time in your life when you were extremely happy.--",
        "--Think of a time that you were extremely sad.--",
        "--Bring your thoughts back to a day you witnessed the Hand of God.--"
    };

    private List<string> _stressQuestions = new List<string>()
    {
        "What caused the situation?",
        "Who was present?",
        "How did you handle the situation?",
        "Could you have done something differently?",
        "Is there anyone that you still need to apologize to?"
    };
    private List<string> _happyQuestions = new List<string>()
    {
        "Who were you with?",
        "What were you doing?",
        "Why were you happy?",
        "What else makes you feel this way?",
        "How can you feel this way every day?"
    };
    private List<string> _sadQuestions = new List<string>()
    {
        "How long ago was this?",
        "What caused you to feel sad?",
        "How did you begin to feel better?",
        "Did anyone help you along the way?",
        "How can this experience make you a better person?"
    };
    private List<string> _spiritualQuestions = new List<string>()
    {
        "How often do you witness things like this?",
        "Why do you believe God revealed this to you?",
        "What were your emotions at the time?",
        "How does this help fortify your testimony to this day?",
        "Who could benefit from hearing this story?"
    };
    public Reflection()
        : base("Reflection Activity")
        {
            _instructions = "The reflection activity will give you ideas to ponder on with followup questions."
            + " Please take your time to really consider each question.";
        }

    public bool GetFollowUp(List<string> questions, Animations animations)
    {
        if (questions.Count == 0)
        {
            return true;
        }
        else
        {
            Random random = new Random();
            int randomIndex = random.Next(questions.Count - 1);
            Console.Write(questions[randomIndex]);
            animations.Spinner(20);
            Console.WriteLine();
            questions.RemoveAt(randomIndex);
            return false;
        }
    }
    public void ReflectionActivity()
    {
        StartActivity();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddMinutes(duration);
        DateTime currentTime = new DateTime();
        Random random = new Random();
        int randomIndex = random.Next(_initialQuestions.Count - 1);
        Animations animations = new Animations();

        string reflection = _initialQuestions[randomIndex];
        Console.WriteLine(reflection);
        Thread.Sleep(5000);
        Console.Write("Press enter when ready. ");
        Console.ReadLine();
        animations.CountdownTimer();  
        Console.Clear();

        bool empty = false;

        while (currentTime < futureTime && empty == false)
        {
            currentTime = DateTime.Now;

            switch (randomIndex)
            {

                case 0:
                    empty = GetFollowUp(_stressQuestions, animations);
                    break;
                case 1:
                    empty = GetFollowUp(_happyQuestions, animations);
                    break;
                case 2:
                    empty = GetFollowUp(_sadQuestions, animations);
                    break;
                case 3:
                    empty = GetFollowUp(_spiritualQuestions, animations);
                    break;
            }
        }
    }
}