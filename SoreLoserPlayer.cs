using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception???? Catch exception in the else if condition when player loses to the other player
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{Name} suspiciously waits for the other player to take their turn.");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    Console.WriteLine($"{other.Name} Wins!");
                    Console.WriteLine($"{Name} accuses other player: {other.Name} is cheating! I want a rematch! >:(");  
                }
                catch 
                {
                    Console.WriteLine($"{Name} accuses other player: {other.Name} is cheating! I want a rematch! >:("); 
                }
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }  
    }
}

