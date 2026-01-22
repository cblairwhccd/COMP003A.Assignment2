namespace COMP003A.Assignment2;

class Program
{
    static void PrintLabel(string str)
    {
        Console.WriteLine();
        Console.WriteLine(str);
        Console.WriteLine(new string('-', str.Length));
    }

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

        /* Compute calculations */
        double sum = n1 + n2;
        double average = (n1 + n2) / 2.0;
        double difference = n1 - n2;
        double product = n1 * n2;
        double quotient = n1 / n2;

        /* Print name */
        PrintLabel("Name Formats");
        Console.WriteLine("Using concatenation: " + lastName + ", " + firstName);
        Console.WriteLine($"Using interpolation: {lastName}, {firstName}");
    }
}