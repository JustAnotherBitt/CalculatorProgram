class Program
{
    static void Main()
    {
        double n1 = 0;
        double n2 = 0;
        double result = 0;
        string operation = "";
        string answer = "";

        do
        {


            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.Write("Enter the first number: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation: ");
            Console.WriteLine("\n\t+ : add\n\t- : subtract\n\t* : multiply\n\t/ : division");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = n1 + n2;
                    Console.WriteLine($"{n1} + {n2} = {result}");
                    break;

                case "-":
                    result = n1 - n2;
                    Console.WriteLine($"{n1} - {n2} = {result}");
                    break;

                case "*":
                    result = n1 * n2;
                    Console.WriteLine($"{n1} * {n2} = {result}");
                    break;

                case "/":
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result}");
                    break;

                default:
                    Console.WriteLine("That is not a valid operation");
                    break;
            }

            Console.WriteLine("Do you want to continue? (Y/N)");
            answer = Console.ReadLine().ToUpper();

        }while(answer == "Y");

    Console.WriteLine("Bye");

    }
}