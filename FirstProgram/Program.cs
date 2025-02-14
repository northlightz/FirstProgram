namespace FirstProgram
{
    class Program
    {
        private protected const string MainMenuText =
            @"
            You have launched the 'Exercise Pack' application
            This application contains algorithms turned-code in which you can review
            Here is our list of algorithms:
            1 - Summation of two numbers
            2 - Recognizing if a number is odd or even
            3 - Recognizing the larger number in three given numbers (non decimal numbers.)
            4 - Find if a number is divisible by 5
            5 - Finding the absolute value of a number
            6 - Finding out if your grade is of passing or failing one (above 12 is passing, below (and equal to 12) is failing)
            7 - Finding out the Area & Circumference of a Circle by giving the radius value

            To exit this application,           press the X button
                                                                 ";
        private protected const string AfterAlgoMenuText =
            @"
            If you want to try this again,      press the R button.
            Otherwise, to exit into the menu,   press the M button.
            To exit the program completely,     press the X button.";
        private protected const string TwelvePad = "            ";

        public static void EndofAlgoExecution(Action restartAlgorithm)
        {
            while (true)
            {
                Console.WriteLine(AfterAlgoMenuText);
                char userKeyInput = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (userKeyInput)
                {
                    case 'R':
                        Console.Clear();
                        restartAlgorithm();
                        return; // Exit after restarting to prevent infinite loop

                    case 'M':
                        Console.Clear();
                        MainMenu();
                        return;

                    case 'X':
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input! Please try again.");
                        Thread.Sleep(800);
                        Console.Clear();
                        break;
                }
            }
        }

        static void Main()
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine(MainMenuText);
            var userKeyInput = Console.ReadKey(true).KeyChar;
            switch (userKeyInput)
            {
                case '1':
                    SumAlgo(); // Correctly call SumAlgo method
                    break;
                case '2':
                    IsNumberEvenOrOddAlgo();
                    break;
                case '3':
                    WhichBiggerinThree();
                    break;
                case '4':
                    IsDivisbleByFiveAlgo();
                    break;
                case '5':
                    AbsValueOfNumberAlgo();
                    break;
                case '6':
                    IsGradeNumberPassingOrFailingAlgo();
                    break;
                case '7':
                    AreaAndCircumferenceOfCircleBasedOnRadius();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input! Please try again.");
                    Thread.Sleep(800);
                    Console.Clear();
                    MainMenu();
                    break;
            }
            if (userKeyInput == 'X' || userKeyInput == 'x')
            {
                Environment.Exit(0);
            }
        }

        public static void SumAlgo() // algo 1
        {
            Console.Write($"{TwelvePad}Please Enter your two numbers one after eachother: ");
            int fNum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{TwelvePad}Now the second number: ");
            var sNum = Convert.ToInt32(Console.ReadLine());
            var sumNum = fNum + sNum;
            Console.Write($"{TwelvePad}The summation of the given numbers is {sumNum}.\n");
            EndofAlgoExecution(SumAlgo);
        }

        public static void IsNumberEvenOrOddAlgo() // algo 2
        {
            Console.Write($"{TwelvePad}Please Enter your number: "); // empty space because i need to pad the text
            var userNumInput = Convert.ToInt32(Console.ReadLine());
            if (userNumInput % 2 == 0)
            {
                Console.Write($"{TwelvePad}Your number is even.\n");
            }
            else
            {
                Console.Write($"{TwelvePad}your number is odd.\n");
            }
            EndofAlgoExecution(IsNumberEvenOrOddAlgo);
        }

        public static void WhichBiggerinThree() // algo 3
        {
            Console.Write($"{TwelvePad}Please enter your first number: ");
            var firstUserNum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{TwelvePad}Please enter your second number: ");
            var secondUserNum = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{TwelvePad}Please enter your third number: ");
            var thirdUserNum = Convert.ToInt32(Console.ReadLine());

            static int FindBiggestNumber(int firstNum, int secondNum, int thirdNum)
            {
                var largerNumberInTwo = 0;
                var largerNumberInThree = 0;
                if (firstNum > secondNum)
                {
                    largerNumberInTwo = firstNum;
                    if (largerNumberInTwo > thirdNum)
                    {
                        largerNumberInThree = largerNumberInTwo;
                    }
                    else
                    {
                        largerNumberInThree = thirdNum;
                    }
                }
                else
                {
                    largerNumberInTwo = secondNum;
                    if (largerNumberInTwo > thirdNum)
                    {
                        largerNumberInThree = largerNumberInTwo;
                    }
                    else
                    {
                        largerNumberInThree = thirdNum;
                    }
                }
                return largerNumberInThree;
            }
            int biggestNumber = FindBiggestNumber(firstUserNum, secondUserNum, thirdUserNum);
            Console.Write(
                $"\n{TwelvePad}The largest number in the three numbers you gave was {biggestNumber}"
            );
            EndofAlgoExecution(WhichBiggerinThree);
        }

        public static void IsDivisbleByFiveAlgo() // algo 4
        {
            Console.Write($"{TwelvePad}Enter your number: ");
            var userNumInput = Convert.ToInt32(Console.ReadLine());
            if (userNumInput % 5 == 0)
            {
                Console.Write($"\n{TwelvePad}Your number is divisble by five.");
            }
            else
            {
                Console.Write($"\n{TwelvePad}Your number is not divisble by five.");
            }
            EndofAlgoExecution(IsDivisbleByFiveAlgo);
        }

        public static void AbsValueOfNumberAlgo() // algo 5
        {
            Console.Write($"{TwelvePad}Please enter your number: ");
            var userNumInput = Convert.ToInt32(Console.ReadLine());
            var numInputAbs = Math.Abs(userNumInput);
            Console.Write(
                $"{TwelvePad}This is the absolute value of your given number: {numInputAbs}."
            );
            EndofAlgoExecution(AbsValueOfNumberAlgo);
        }

        public static void IsGradeNumberPassingOrFailingAlgo() // algo 6
        {
            Console.Write($"{TwelvePad}Please enter the grade number: ");
            var userNumInput = Convert.ToInt32(Console.ReadLine());
            if (userNumInput > 12)
            {
                Console.Write($"{TwelvePad}Your grade is of passing score.");
            }
            else
            {
                Console.Write($"{TwelvePad}Your grade is below passing score. you've failed.");
            }
            EndofAlgoExecution(IsGradeNumberPassingOrFailingAlgo);
        }

        public static void AreaAndCircumferenceOfCircleBasedOnRadius() // algo 7
        {
            Console.Write($"{TwelvePad}Please enter the radius value: ");
            var userNumInput = Convert.ToInt32(Console.ReadLine());
            var AreaOfCircle = Math.PI * userNumInput * userNumInput;
            var CircumferenceOfCircle = 2 * Math.PI * userNumInput;
            Console.Write(
                $"{TwelvePad}The radius you entered was {userNumInput}.\n{TwelvePad}based on that, your circle has the area of {AreaOfCircle:F2}\n{TwelvePad}and the Circumference of {CircumferenceOfCircle:F2}."
            );
            EndofAlgoExecution(AreaAndCircumferenceOfCircleBasedOnRadius);
        }
    }
}
