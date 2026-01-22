namespace COMP003A.Assignment2;

class Program
{
    static void Main()
    {
        /* Get information */
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter number 1: ");
        string number1 = Console.ReadLine();
        Console.Write("Enter number 2: ");
        string number2 = Console.ReadLine();

        /* Parse numerical input (assume valid input) */
        double n1 = double.Parse(number1);
        double n2 = double.Parse(number2);
    }
}