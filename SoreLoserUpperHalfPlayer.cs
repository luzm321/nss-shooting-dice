using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize that is always in the upper half of the possible rolls:
            // Default value of DiceSize is 6, so dividing variable by 2 and passing halved result as a parameter and the initial value
            // of DiceSize as a second parameter to the Next() method ensures the rolls will always be between 4 and 6:
            return new Random().Next((DiceSize/2), DiceSize) + 1;
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{Name} always rolls in the upper half of the possible rolls, how fortunate! :)");
            Console.WriteLine($"{Name} vigilantly waits for the other player to take their turn.");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins! Hail Hydra!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    Console.WriteLine($"{other.Name} Wins!");
                    Console.WriteLine($"{Name} accuses other player: Nein! {other.Name} is a charlatan! >:(");  
                }
                catch 
                {
                    Console.WriteLine($"{Name} accuses other player: Nein! {other.Name} is a charlatan! >:("); 
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