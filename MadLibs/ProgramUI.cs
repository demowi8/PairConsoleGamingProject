using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class AdventureGames
    {
        public void Run()
        {
            Display();
            Adventure();
            StoryTime();
        }
            bool isRunning = true;
        public void Display()
        {
            while (isRunning)
            {

                Console.WriteLine("Do you want to play 1. Adventure Games or 2. Story Time? Type 1 or 2 and press enter.");
                string Input = Console.ReadLine();
                Console.Clear();
                switch (Input)
                {
                    case "1":
                        Adventure();
                        break;
                    case "2":
                        StoryTime();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                }
                Console.Clear();
            }
        }
        public void Adventure()
        {

            Console.WriteLine("Greetings you have entered the game where anything can happen!");
            Console.WriteLine("When you are ready press enter!");
            Console.ReadLine();
            Console.WriteLine("You have just woken up inn the middle of the woods the last thing you remember you were crash landing in the middle of a forest in Canada.");
            Console.WriteLine("Please choose your weapon. Your choies are a Knife or a Hatchet.");
            string weaponChoice = Console.ReadLine().ToLower();
            if (weaponChoice == "hatchet")
            {
                Console.WriteLine("Congrats you have just found a Hatchet.\n" +
                    " Press Enter.");
                Console.ReadLine();
            }
            else if (weaponChoice == "knife")
            {
                Console.WriteLine("Congrats you have just found a Knife.\n" +
                    "Press Enter.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You must pick a knife or hatchet!");
                Console.ReadLine();
            }


            Console.WriteLine("You notice the burning plane in the distance to the east and you noice lights shining bright in the west. Which way do you want to go, east or west?");
            string direction = Console.ReadLine().ToLower();
            if (direction == "east")
            {
                Console.WriteLine("You have just been attacked by a Grizzly Bear. You get away using your weaponn but you are injured. \nPress Enter to continue...");
                Console.ReadLine();
            }
            else if (direction == "west")
            {
                Console.WriteLine("You found a natural spring, which you can use to replenish your resources. \n Press Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You must pick east or west");
                Console.ReadLine();
            }
            Console.WriteLine("Congratulations you made it through your first day.");
            Console.ReadLine();
        }
        public void StoryTime()
        {
            //Give it a Title
            Console.WriteLine("What is the title of your favorite movie? ");

            string title = Console.ReadLine();

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("How are you feeling today?");
            string feeling = Console.ReadLine();
            Console.WriteLine("Do you like smooth sticky or fuzzy? ");
            string texture = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your favorite hobby? ");
            string action = Console.ReadLine();
            Console.WriteLine("What do you like to do on the weekend?");
            string activity = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is your dream vaction destination? ");
            string place = Console.ReadLine();
            Console.WriteLine("Whats your favorite childhood toy? ");
            string thing = Console.ReadLine();
            Console.Clear();


            Console.WriteLine("What is your favorite Animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite Food?");
            string food = Console.ReadLine();
            Console.WriteLine("What is your favorite Fruit?");
            Console.Clear();


            string fruit = Console.ReadLine();
            Console.WriteLine("Who is your favorite superhero: ");
            string superhero = Console.ReadLine();
            Console.WriteLine("Enter a random country: ");
            string country = Console.ReadLine();
            Console.WriteLine("What is your favorite dessert: ");
            string dessert = Console.ReadLine();
            Console.WriteLine("What is you favorite a year? ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Pick a number between 1 and 3!");
            string userInput = Console.ReadLine();
            Console.Clear();


            // The template for the story:
            Console.WriteLine("This is your story:");

            string story = $"This morning {name} woke up feeling {feeling}. 'It is going to be a {texture} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {place}, which made all the {fruit}s very {texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {thing}s ruled the world.";

            string story2 = $"A(n) {animal} in {place} was arrested this morning after he {activity} a in front of {superhero}. {name}, had a history of {action}, but no one-not even his {animal} ever imagined he'd be {color} with a {thing} stuck in his {dessert}." +
                $"I always thought he was {feeling}, but I never thought he'd do something like this. Even the amazing {superhero} was surprised. After a brief {action}, cops followed him to a {food} restaurant, where he reportedly {action} in the fry machine." +
                $"In {year}, a woman was charged with a similar crime. But rather than {activity} with a {fruit}, she {action} with a dog from {country}. Either way, we imagine that after witnessing him {activity} with a {thing} there are probably a whole lot of {animal}s that  are going to need some therapy.";

            string story3 = $"Hi! My name is {name} and I have a secret to share with you. I'm normal person by day, and a {animal} by night. Only you and my best friend {superhero} knows my secret. You may be wondering how this happened? Well, one night I was {action} at home, and then BOOM! The lights went out and {superhero} showed up. He/She said in a booming voice, because your favorite color is {color} you have been chosen to be a {dessert}. My mission is to save the people of {country} by doing my favorite things : {activity} {action} and did I say {activity}. This may sound easy, but it is no walk in the park. It requires hard work and {thing}. My weakness is eating {food}. They are gross!! Keep that away from me! I save the world every night. But when I wake up in the morning, I go back to my normal life at Eleven Fifty Academy.";
            //Print the story:
            switch (userInput)
            {
                case "1":
                    Console.WriteLine(story);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine(story2);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine(story3);
                    Console.ReadLine();
                    break;
            }


        }
    }
}

