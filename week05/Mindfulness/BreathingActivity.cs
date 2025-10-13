using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
        //  Base constructor has already defined the name and the description
    }

    protected override void PerformActivity()
    {
        int totalSeconds = GetDuration(); // It gets how long the session's gonna last from the user input on the activity class
        int timeElapsed = 0;              // How much time has passed
        bool inhaling = true;             // true = inhale, false = exhale

        // Duration of each phase (breath in or breath out) in seconds
        int phaseDuration = 4; // it can be changed to 3, 5, etc.

        Console.WriteLine(); // blank line

        // While there is still time...
        while (timeElapsed < totalSeconds)
        {
            // Choose what message is being shown
            if (inhaling)
            {
                Console.WriteLine("Breath in...");
            }
            else
            {
                Console.WriteLine("Breath out...");
            }

            // Calculate how much time it can be used in the phase
            int remainingTime = totalSeconds - timeElapsed;
            int actualPhaseTime = Math.Min(phaseDuration, remainingTime);

            // Shows countdown during the phase
            ShowCountDown(actualPhaseTime);

            // Updates elapsed time
            timeElapsed += actualPhaseTime;

            // Change of phase
            inhaling = !inhaling;
        }


    }

}