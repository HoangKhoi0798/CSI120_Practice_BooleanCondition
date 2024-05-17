namespace CSI120_Practice_BooleanCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // CSI 120 - Computer Programming 1
            // Code Practice - Booleans and Conditions
            Menu();
            
        }// Main

        public static void Temperature()
        {
            Console.Write("Enter temperature: ");


            try
            {
                string userInput = Console.ReadLine();
                decimal userTemp = decimal.Parse(userInput);

                // Setting up conditions

                if (userTemp > 76) 
                {
                    Console.WriteLine("It's T-shirt and shorts time");
                }
                else if (userTemp >= 69 && userTemp <= 75)
                {
                    Console.WriteLine("It's comfortable out. A shirt and jeans will work");
                }
                else if (userTemp >= 51 && userTemp <= 68)
                {
                    Console.WriteLine("It's starting to get cold. A sweater should work");
                }
                else if (userTemp >= 33 && userTemp <= 50)
                {
                    Console.WriteLine("It's really cold out, bring a jacket");
                }
                else
                {
                    Console.WriteLine("That's freezing, be careful out there.");
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                Menu();
            }

        }// Temperature End

        public static void EvenOdd()
        {
            Console.Write("Enter an integer number: ");
            int userNum = 0;
            bool isValid = false;
            
            try
            {
                
                while (!isValid) // Check for integer number
                {
                    string userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out userNum);

                    if (int.TryParse(userInput, out userNum))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }

                }

                int userCheck = userNum % 2;

                if (userCheck == 0) // Number type condition
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex);
                Console.WriteLine();
                Menu();
            }
        } // Even Odd check end

        public static void LeapYear()
        {
            Console.Write("Enter a year in integer number: ");
            int userYear = 0;
            bool isValid = false;

            try
            {

                while (!isValid) // Check for integer number
                {
                    string userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out userYear);

                    if (int.TryParse(userInput, out userYear))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid number: ");
                    }

                }

                int userCheck4 = userYear % 4;
                int userCheck400 = userYear % 400;
                int userCheck100 = userYear % 100;

                if ((userCheck4 == 0 && userCheck400 == 0) || (userCheck4 == 0 && userCheck100 !=0)) // Year type condition
                {
                    Console.WriteLine($"{userYear} is a leap year!");
                }
                else
                {
                    Console.WriteLine($"{userYear} is not a leap year!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex);
                Menu();
            }
        }

        public static void Menu()
        {
            try 
            { 
            Console.WriteLine("Selection Menu");
            Console.WriteLine("1 - Temperature Check");
            Console.WriteLine("2 - Even/Odd Check");
            Console.WriteLine("3 - Leap Year Check");
            Console.Write("Enter your selection: ");
            string userInput = Console.ReadLine();
            if (userInput == "1") // Checking choices
                {
                    Temperature();
                }
            else if (userInput == "2")
                {
                    EvenOdd();
                }
            else if (userInput == "3")
                {
                    LeapYear();
                }
            else
                {
                    Console.WriteLine("Invalid");
                    Menu(); // Return back to menu if choice does not match
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }// Menu End

    } // Class

} // Name
