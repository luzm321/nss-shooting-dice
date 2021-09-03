using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> tauntList = new List<string>()
        {
            "You have the worst luck playing against me!",
            "You call that a roll?! How pathetic! :(",
            "You are not worthy to play against me!",
            "Prepare to lose!!! >:D",
            "You can't beat me, just 'roll away'! Haha!"
        };

        // method that generates random taunt from list for player to select
        public void TauntPlayers()
        {
           int randomTaunt = new Random().Next(tauntList.Count);
           var creativeTaunt = tauntList[randomTaunt];
           Console.WriteLine($"{creativeTaunt}");
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.Write($"{Name} taunts other player: "); TauntPlayers(); // invoking method that randomly generates a taunt from list
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}