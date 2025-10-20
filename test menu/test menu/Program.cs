namespace test_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            char x;
            do
            {
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]\r\n| _   _ ||  o  ||  _  |    |  |  |  | |  | |      ||  |  |    |  o  |    |  |  ||     ||  D  )(   \\_  /  [_ \r\n|");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]\r\n| _   _ ||  o  ||  _  |    |  |  |  | |  | |      ||  |  |    |  o  |    |  |  ||     ||  D  )(   \\_  /  [_ \r\n|  \\_/  ||     ||  |  |    |  |  |  | |  | |_|  |_||  _  |    |     |    |  _  ||  O  ||    /  \\__  ||    _]\r\n");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]\r\n| _   _ ||  o  ||  _  |    |  |  |  | |  | |      ||  |  |    |  o  |    |  |  ||     ||  D  )(   \\_  /  [_ \r\n|  \\_/  ||     ||  |  |    |  |  |  | |  | |_|  |_||  _  |    |     |    |  _  ||  O  ||    /  \\__  ||    _]\r\n|   |   ||  _  ||  |  |    |  `  '  | |  |   |  |  |  |  |    |  _  |    |  |  ||     ||    \\  /  \\ ||                                                                                                            ");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]\r\n| _   _ ||  o  ||  _  |    |  |  |  | |  | |      ||  |  |    |  o  |    |  |  ||     ||  D  )(   \\_  /  [_ \r\n|  \\_/  ||     ||  |  |    |  |  |  | |  | |_|  |_||  _  |    |     |    |  _  ||  O  ||    /  \\__  ||    _]\r\n|   |   ||  _  ||  |  |    |  `  '  | |  |   |  |  |  |  |    |  _  |    |  |  ||     ||    \\  /  \\ ||   [_ \r\n|   |   ||  |  ||  |  |     \\      /  |  |   |  |  |  |  |    |  |  |    |  |  ||     ||  .  \\ \\    |");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(" ___ ___   ____  ____       __    __  ____  ______  __ __       ____      __ __   ___   ____    _____   ___ \r\n|   |   | /    ||    \\     |  |__|  ||    ||      ||  |  |     /    |    |  |  | /   \\ |    \\  / ___/  /  _]\r\n| _   _ ||  o  ||  _  |    |  |  |  | |  | |      ||  |  |    |  o  |    |  |  ||     ||  D  )(   \\_  /  [_ \r\n|  \\_/  ||     ||  |  |    |  |  |  | |  | |_|  |_||  _  |    |     |    |  _  ||  O  ||    /  \\__  ||    _]\r\n|   |   ||  _  ||  |  |    |  `  '  | |  |   |  |  |  |  |    |  _  |    |  |  ||     ||    \\  /  \\ ||   [_ \r\n|   |   ||  |  ||  |  |     \\      /  |  |   |  |  |  |  |    |  |  |    |  |  ||     ||  .  \\ \\    ||     |\r\n|___|___||__|__||__|__|      \\_/\\_/  |____|  |__|  |__|__|    |__|__|    |__|__| \\___/ |__|\\_|  \\___||_____|\r\n                                                                                                            ");
                ClearFromLine(20);
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(@"                                Menu:
                 ---------------------------------------------
                            1 |  Play Game (Story Mode)
                              |
                            2 |  Instructions
                              |
                            3 |  Credits
                              |
                            4 |  Level Select
                              |
                            0 |  Exit Game
            ");

                x = Convert.ToChar(Console.ReadLine());
                ClearFromLine(20);
                Console.SetCursorPosition(0, 10);
                switch (x)
                {
                    case '1':
                        Task1(args);
                        break;

                    case '2':
                        Task2(args);
                        break;

                    case '3':
                        Task3(args);
                        break;

                    case '4':
                        Task4(args);
                        break;

                    case '0':
                        break;
                    default:
                        Console.WriteLine("                                Invalid input, please try again.");
                        Thread.Sleep(500);
                        break;
                }

            } while (x != '0');

        }

        public static void Task1(string[] args)
        {
            Level1();
            Level2();
            Level3();
            Level4();
            Level5();
            Level6();

        }

        public static void Task2(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"             




                                        Instructions / How to play:
            



                               This Game is a RPG Fighter Game, Each Level
                               Will Have You Fighting Different Characters
                                
                                 You Will Have To Pick Different Attacks,
                              Each Attack Deals a Different Amount Of Damage
                                 And You Cannot Use The Same Attack Twice



                                       --------------------------
                                       |        Moves:          |
                                       --------------------------
                                       | Press U to uppercut,   |
                                       | Press R to Roundhouse, |
                                       | Press S to Sword Slash |
                                       -------------------------- 
                                             
            ");
            Console.WriteLine("                                Press Enter to return to the menu");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Task3(string[] args)
        {
            Console.WriteLine("This is task 3");
            Console.WriteLine("                                Press Enter to return to the menu");
            Console.ReadLine();

        }

        public static void Task4(string[] args)
        {
            Console.WriteLine("This is task 4");
            char y;
            do
            {
                ClearFromLine(20);
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(@"                                Level Select Menu:
                                ---------------------------------------------
                                            1 |  Level 1
                                              |
                                            2 |  Level 2
                                              |
                                            3 |  Level 3
                                              |
                                            4 |  Level 4
                                              |
                                            5 |  Level 5
                                              |
                                            6 |  Level 6
                                              |
                                            0 |  Exit Game
            ");

                y = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (y)
                {
                    case '1':
                        Level1();
                        break;

                    case '2':
                        Level2();
                        break;

                    case '3':
                        Level3();
                        break;

                    case '4':
                        Level4();
                        break;
                    case '5':
                        Level5();
                        break;
                    case '6':
                        Level6();
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("                                Invalid input, please try again.");
                        Thread.Sleep(500);
                        break;
                }

            } while (y != '0');

        }

        public static void Level1()
        {

        }
        public static void Level2()
        {

        }
        public static void Level3()
        {

        }

        public static void Level4()
        {

        }
        public static void Level5()
        {

        }
        public static void Level6()
        {

        }

        static void ClearFromLine(int startLine)
        {
            // Always move to the start line first, so we never erase above it
            for (int i = startLine; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            // Put cursor back at startLine ready to draw new frame
            Console.SetCursorPosition(0, startLine);
        }
    }
}
    

