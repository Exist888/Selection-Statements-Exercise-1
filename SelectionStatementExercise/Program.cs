namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Initialize Variables
            var r = new Random();
            var favNumber = r.Next(1, 21);
            int userInput;
            
            //Prompt User to Guess Number
            Console.WriteLine("Can you guess my favorite number?\n" +
                              "It is between 1 and 20.\n" +
                              "Give it a try:");
            
            //Receive User Input
            //Create a Loop to Repeat Prompt if User is Incorrect
            //Create If Else If Else to Reply to User Input
            do
            {
                userInput = int.Parse(Console.ReadLine());
            
                if (userInput > favNumber)
                {
                    Console.WriteLine("You answer is too high!\n" +
                                      "Try again:");
                }
                
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Your answer is too low!\n" +
                                      "Try again:");
                }

                else
                {
                    Console.WriteLine("Nice! You guessed correctly!\n" +
                                      "You get a trophy.");
                }
                
            } while (favNumber != userInput);
           
            
            
            
        }
    }
}
