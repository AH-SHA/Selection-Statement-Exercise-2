namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine();
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("That's mine too!");
                    break;
                case "Science":
                    Console.WriteLine("I'm not so fond of that one.");
                    break;
                case "History":
                    Console.WriteLine("That's a blast from the past!");
                    break;
                case "English":
                    Console.WriteLine("Pero, Usted hable espanol?");
                    break;
                case "Geography":
                    Console.WriteLine("I guess you don't need to use a GPS!");
                    break;
                default:
                    Console.WriteLine($"What do you like about {favoriteSubject}?");
                    break;

            }

        }     
    }
}