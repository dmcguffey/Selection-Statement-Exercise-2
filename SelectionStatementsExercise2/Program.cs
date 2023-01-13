namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "art":
                    Console.WriteLine("I love to draw!");
                    break;
                case "math":
                    Console.WriteLine("You must love numbers!");
                    break;
                case "science":
                    Console.WriteLine("That's too broad! You must like them all!");
                    break;
                case "gym":
                    Console.WriteLine("There's nothing like feeling the burn!");
                    break;
                case "english":
                    Console.WriteLine("I love a good book!");
                    break;
                default:
                    Console.WriteLine("That's a new one! I'll have to look into it.");
                    break;
            }
        }
    }
}