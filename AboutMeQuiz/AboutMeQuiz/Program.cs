using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = StartQuiz();

            Console.WriteLine(ArmedForcesQuestion());

            if (PineappleQuestion() == false)
            {
                Console.WriteLine("You got that wrong in a big way.");
            }
            else
            {
                Console.WriteLine("You're correct!!");
            }

           
            int userGuessedForSiblings = NumberOfSiblings();
            Console.WriteLine($"You gussed {userGuessedForSiblings} and i have 2, a brother and twin sister");

            GuessStateVisited();

            string favoriteColorGuess = GuessMyFavoriteColor();
            Console.WriteLine($"if your guess of {favoriteColorGuess} is purpil you got it right!");
            

            Console.WriteLine(ExitMessage(userName));
            Console.ReadLine();
        }

        static string StartQuiz()//function to start quiz with user.
        {
            Console.WriteLine("Welcome to my About Me Quiz");
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName} let's start the Quiz");
            return userName;
        }

        static string ArmedForcesQuestion()//first Question 
        {
            Console.WriteLine("Was i in the Military? please answer with a yes or no");
            string userAnswer = Console.ReadLine().ToLower().Trim(); // puts input from console to variable then lowercases it and removes whitespace for comparison

            if (userAnswer == "yes" || userAnswer == "y")//compares if the user input was correct and returns approprate string. 
            {
                return "Correct from 2004 till 2008";
            }
            else
            {
                return "I joined the military after high school in 2004";
            }
           
        }

        static bool PineappleQuestion()//second Question 
        {

            Console.WriteLine("true or false. Do i Like Pineapple?");
            string pinappleQuestionAnswer = Console.ReadLine().ToLower().Trim();

            return pinappleQuestionAnswer == "true" ? true : false; //returns true if they type in true for answer and false if they don't.

        }

        static int NumberOfSiblings()
        {
            Console.WriteLine("How many siblings do you think i have? Please use your number keys to enter valid number.");
            int guessedNumberOfSiblings = Convert.ToInt32(Console.ReadLine().Trim());
            return guessedNumberOfSiblings;
        }

        static string[] GuessStateVisited()
        {
            int guesses = 5;
            string[] userGussedArray = new string[5];

            string[] myStatesVisited = new string[] { "washington", "oregon", "california", "idaho", "montana", "wyoming", "colorado", "arizona", "alaska" };

            while (guesses > 0 )
            {
                Console.WriteLine($"Please try and guess a state I have been to. you have {guesses} tries");
                string stateUserGuessed = Console.ReadLine().ToLower().Trim();
                userGussedArray[guesses -1] = stateUserGuessed;
                guesses--;

                for (int i = 0; i < myStatesVisited.Length; i++)
                {
                    if (stateUserGuessed == myStatesVisited[i])
                    {
                    Console.WriteLine("You got a correct answer");
                    return userGussedArray;
                    }
                }
            }
            Console.WriteLine("Sorry you ran out of guesses.");
            return userGussedArray;

        }

        static string GuessMyFavoriteColor()
        {
            Console.WriteLine("Try and guesse my favorite color?");
            string userColorGuesse = Console.ReadLine().ToLower().Trim();
            return userColorGuesse;
        }

        static string ExitMessage(string user)
        {
            return $"Thanks for playing my quiz game {user}";
        }

    }
}
