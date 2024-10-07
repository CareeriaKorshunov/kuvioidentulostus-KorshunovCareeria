namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ask user for the square size
            Console.Write("Kuinka ison neliön haluat tehdä: ");

            // Read user input and convert to integer
            TulostaNelio(int.Parse(Console.ReadLine()));
        }

        // Method to print the square
        public static void TulostaNelio(int sivunPituus)
        {
            // Initialize an empty string to store the square pattern
            string kuvio = "";
            // Outer loop to handle the rows
            for (int i = 0; i < sivunPituus; i++)
            {
                // Inner loop to handle the columns
                for (int j = 0; j < sivunPituus; j++)
                {
                    // If the current position is on the border, print a star '*'
                    if (j == 0 || j == (sivunPituus - 1) || i == 0 || (i + 1) == sivunPituus)
                    {
                        kuvio += "*";
                    }
                    else
                    {
                        // Otherwise, print a space
                        kuvio += " ";
                    }
                }

                // Add a newline after each row
                kuvio += "\n";

            }

            // Print the final pattern to the console
            Console.WriteLine(kuvio);
        }
    }
    }
