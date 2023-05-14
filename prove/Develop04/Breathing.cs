class Breathing : Activity
{

    public Breathing() 
        : base("Breathing Activity")
        {
            _instructions = "We will take some time to relax by slowly breathing inward, and then outward.";
        }

    public void RunBreathingActivity()
    {
        StartActivity();
        int duration = GetDuration();

        Animations blinkAnimation = new Animations();
        Animations breathing = new Animations(duration * 60);
        breathing.CountdownTimer();

        blinkAnimation.RunBlinkAnimation();
        breathing.Breathe();
        blinkAnimation.RunBlinkAnimation();
        WriteEndMessage();

    }

}