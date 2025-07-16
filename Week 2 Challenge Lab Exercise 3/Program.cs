namespace Week_2_Challenge_Lab_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number to be displayed
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            // Get the width of the triangle
            Console.Write("\nEnter the desired width: ");
            int triangleWidth = Convert.ToInt16(Console.ReadLine());

            // Outer loop will create a new line for each iteration and subtract the index
            for (int i = triangleWidth; i > 0; i--)
            {
                // Inner loop will display the number on the same line with each iteration.
                // It will iterate as long as the index of the inner loop is less than that of the outer loop.
                Console.WriteLine("\n");
                for (int j = 0; j < i; j++)
                {

                    Console.Write(number);
                }
            }
        }
    }
}
