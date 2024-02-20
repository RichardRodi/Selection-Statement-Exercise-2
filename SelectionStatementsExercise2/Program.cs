namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in School?");
            string studentAnswer = Console.ReadLine();
            switch (studentAnswer) 
            {
                case "Math":
                    Console.WriteLine("Math is Stupid");
                    break;
                case "History":
                    Console.WriteLine("History never repeats itself");
                    break;
                case "English":
                    Console.WriteLine("English I speak it good");
                    break;
                case "Physical Education":
                case "PE":
                case "Phys Ed":
                    Console.WriteLine("Physical Education is the only right answer");
                    break;
                case "Home Economics":
                case "Home Ec":
                    Console.WriteLine("Home Economics, who can afford a home anyway");
                    break;
                default:
                    Console.WriteLine("This is not a subject");
                    break;
            }
        }
    }
}