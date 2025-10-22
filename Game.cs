using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace studioTeam
{
    internal class Game
    {
        const int HUDLines = 6; // Global Reserve top lines for HUD and health bars
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, Welcome to Black X Tech!");

            //playerHitsComputer();
            //Console.ReadLine();
            //Level6();

            // Frame 1
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





            Thread.Sleep(2000);




            // Frame 2
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
            Thread.Sleep(3000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine(@"             




                                  The morning is calm and warm over out farm.
                                     The fields glow in the soft light,
                                  and the animals move quietly around the barn.
                              I step outside, taking in the gentle start to the day
            



                               

            
                                         

                                                                        
            ");

            Thread.Sleep(5000);


            // Frame 3
            //Console.Clear();
            //Console.WriteLine(@"                                       




            //         |>>>                     |>>>
            //         |                        |
            //     _  _|_  _                _  _|_  _
            //    | |_| |_| |              | |_| |_| |
            //     \  .      /              \  .      /
            //       \_______/                \_______/
            //        |     |-----.      .----|     |
            //        |     |     |      |    |     |
            //        |     |     |      |    |     |
            //        |     |     |      |    |     |
            //          _|_____|_____|__  __|____|_____|_
            //         |________________||________________|
            //");
            //Thread.Sleep(1500);
            //Console.Clear();
            Console.WriteLine("    *     *       *     *     *   *   *         *     *       *     *     *   *   *");
            Console.WriteLine(" *       *     *       *     *      *    *     *       *     *     *   *   *");
            Console.WriteLine("    *           *    *       *     *  *           *    *       *     * ");
            Console.WriteLine();


            Console.WriteLine("        . --- .                       ___________                   ");
            Console.WriteLine("       /       \\                    /            \\                 ");
            Console.WriteLine("       | \\  /  |                   /______________\\                ");
            Console.WriteLine("       |       |                   |   _    |_|   |                ");
            Console.WriteLine("       |   ^   |                   |__|_|_________|                 ");
            Console.WriteLine("        \\  _  /    /                  | |                          ");
            Console.WriteLine("         -----    /                  /   /                        ");
            Console.WriteLine("          | |    /                 /      /                        ");
            Console.WriteLine("         / | \\  /                /         /                      ");
            Console.WriteLine("        /  |  \\/                /          /                        ");
            Console.WriteLine("___________|__/________________/           /______________________");
            Console.WriteLine("          / \\                                                   ");
            Console.WriteLine("         /   \\                                                  ");
            Console.WriteLine("        /     \\                                                 ");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine(@"             




                                What is that in the distance it looks dangerous

                                ""Who are you and what are you doing at my house""

            
                                         

                                                                        
            ");
            Thread.Sleep(3000);
            Console.Clear();

            Console.WriteLine("    *     *       *     *     *   *   *         *     *       *     *     *   *   *");
            Console.WriteLine(" *       *     *       *     *      *    *     *       *     *     *   *   *");
            Console.WriteLine("    *           *    *       *     *  *           *    *       *     * ");
            Console.WriteLine();


            Console.WriteLine("       &&&                 _____                  &&& ");
            Console.WriteLine("      &&&&&               /     \\                &&&&&");
            Console.WriteLine("     &&&&&&&             |  o o  |              &&&&&&& ");
            Console.WriteLine("    &&&&&&&&&            |   ^   |             &&&&&&&&&  ");
            Console.WriteLine("      |||||              | \\___/ |              |||||   ");
            Console.WriteLine("      |||||               \\_____/               |||||    ");
            Console.WriteLine("      |||||                / | \\                |||||    ");
            Console.WriteLine("      |||||               /  |  \\               |||||");
            Console.WriteLine("                         /   |   \\              ||||| ");
            Console.WriteLine("                            / \\      ");
            Console.WriteLine("                           /   \\     ");
            Console.WriteLine("                          /     \\    ");
            Console.WriteLine("                         /       \\   ");

            // Ground (grass)
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();


            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine(@"             




                                  ""I'm here to kill you""
            



                               

            
                                         

                                                                        
            ");
            Thread.Sleep(3000);


            int ComputerHealth = 100, PlayerHealth = 100, damage = 0;
            bool playerTurn = true, playerWin = false;

            Random rand = new Random();

            Console.WriteLine("                    WELCOME TO THE BATTLE TO DEATH!!!");
            Console.WriteLine("");
            Console.WriteLine("                    Press any key to begin...");

            Console.ReadKey();

            Console.Clear();
            //Below is an example ive written to show how to call the method function for the moves
            // Draw the HUD first
            DrawHUD(PlayerHealth, ComputerHealth, playerTurn, PlayerHealth);

            // Show starting messages under HUD
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine(@"
                                         Welcome To Level 1!
                                      
                                      Press any key to continue                        
                         ");

            UpdateHealthBars(PlayerHealth, ComputerHealth);

            // Get input
            char keyInput = Char.ToUpper(Console.ReadKey().KeyChar);
            damage = Moves(keyInput);
            ComputerHealth -= damage;

            // Main battle loop
            while (ComputerHealth > 0 && PlayerHealth > 0)
            {
                // Update health bars only
                Console.SetCursorPosition(0, 3);
                UpdateHealthBars(PlayerHealth, ComputerHealth);

                // Clear animation/message area
                ClearFromLine(6);
                Console.SetCursorPosition(0, 6);

                if (playerTurn)
                {
                    idle();
                    damage = playersTurn();
                    ComputerHealth -= damage;

                    // Show animation
                    ClearFromLine(6);
                    Console.SetCursorPosition(0, 6);
                    playerHitsComputer(PlayerHealth, ComputerHealth);
                    Console.SetCursorPosition(0, 3);
                    UpdateHealthBars(PlayerHealth, ComputerHealth);
                    playerTurn = false;
                    whosPlaying(playerTurn);
                    playerWin = true;
                }
                else
                {
                    idle();
                    damage = computersTurn();
                    PlayerHealth -= damage;

                    // Show animation
                    ClearFromLine(6);
                    Console.SetCursorPosition(0, 6);
                    computerHitsPlayer(PlayerHealth, ComputerHealth);
                    Console.SetCursorPosition(0, 3);
                    UpdateHealthBars(PlayerHealth, ComputerHealth);
                    playerTurn = true;
                    whosPlaying(playerTurn);
                    playerWin = false;
                }
            }

            // End of battle
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            if (playerWin)
            {
                Console.WriteLine("                    YOU Defeated The Challenger!!");
            }
            else
            {
                Console.WriteLine("                    YOU LOSE!!!");
            }

            Console.WriteLine("                    Press any key to continue...");
            Console.ReadKey();

        
            //this is where the method will go for level 2
            Level2(ComputerHealth, PlayerHealth, damage, playerTurn, playerWin);
            //this is where the method will go for level 3
            Level3(ComputerHealth, PlayerHealth, damage, playerTurn, playerWin);
            //this is where the method will go for level 4
            Level4(damage, ComputerHealth);
            //this is where the method will go for level 5

            //this is where the method will go for level 6
            Level6();

        }

        public static void Level2(int ComputerHealth, int PlayerHealth, int damage, bool playerTurn, bool playerWin)
        {
            ComputerHealth = 100;
            PlayerHealth = 125;
            damage = 0;
            playerTurn = true;
            playerWin = false;

            // Draw the HUD first
            DrawHUD(PlayerHealth, ComputerHealth, playerTurn, PlayerHealth);

            // Show starting messages under HUD
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine(@"            You Picked Up His ChestPlate!          
                                             +25 Health!

                                     Your Pretty Good at Fighting");

            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine(@"
                                         Welcome To Level 2!
                                     A New Challenger Has Appeared!
                         ");

            UpdateHealthBars(PlayerHealth, ComputerHealth);

            // Get input
            char keyInput = Char.ToUpper(Console.ReadKey().KeyChar);
            damage = Moves(keyInput);
            ComputerHealth -= damage;

            // Main battle loop
            while (ComputerHealth > 0 && PlayerHealth > 0)
            {
                // Update health bars only
                Console.SetCursorPosition(0, 3);
                UpdateHealthBars(PlayerHealth, ComputerHealth);

                // Clear animation/message area
                ClearFromLine(6);
                Console.SetCursorPosition(0, 6);

                if (playerTurn)
                {
                   idle();
                    damage = playersTurn();
                    ComputerHealth -= damage;

                    // Show animation
                    ClearFromLine(6);
                    Console.SetCursorPosition(0, 6);
                    
                    playerHitsComputer(PlayerHealth, ComputerHealth);

                    playerTurn = false;
                    whosPlaying(playerTurn);
                    playerWin = true;
                }
                else
                {
                    idle();
                    damage = computersTurn();
                    PlayerHealth -= damage;

                    // Show animation
                    ClearFromLine(6);
                    Console.SetCursorPosition(0, 6);
                    computerHitsPlayer(PlayerHealth, ComputerHealth);

                    playerTurn = true;
                    whosPlaying(playerTurn);
                    playerWin = false;
                }
            }

            // End of battle
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            if (playerWin)
            {
                Console.WriteLine("                    YOU Defeated The Challenger!!");
            }
            else
            {
                Console.WriteLine("                    YOU LOSE!!!");
            }

            Console.WriteLine("                    Press any key to continue...");
            Console.ReadKey();

            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                    You Picked Up His Sharp New Sword \nYou Now Do 5 Extra Damage!");
            Console.WriteLine("                    Press any key to continue to level 3...");
        }


        public static void Level3(int ComputerHealth, int PlayerHealth, int damage, bool playerTurn, bool playerWin)
        {
            ComputerHealth = 85;
            PlayerHealth = 75;
            damage = 0;
            playerTurn = true;
            playerWin = false;

            //some light reaading to explain the newDamage variable
            int newDamage = 5; // Extra damage from the new sword, This is local ONLY to level 3, you will need to modify the Moves method to accept this extra damage 

            Console.WriteLine("Press U to uppercut, R to Roundhouse or S to Sword Slash");
            char keyInput = Char.ToUpper(Console.ReadKey().KeyChar);
            damage = Moves(keyInput, newDamage); // like this, passing in the newDamage variable so it gets added to the damage calculation in the moves method
            ComputerHealth -= damage;


            //continue the rest of level 3 code here, similar to level 1 and 2 but make sure to call Moves with the newDamage variable :) -bw
            Console.WriteLine("           You Sharpened       ");
            Console.WriteLine("          Finally! A Worthy Opponent!   ");
            Console.WriteLine("     Use Your New Sword To Slay The Challenger!");
            Console.WriteLine("");
        }


        //Caden
        public static void Level4(int ComputerHealth, int damage)
        {
            bool gameRunning = true;

            Thread timerThread = new Thread(() =>
            {
                Thread.Sleep(10000);
                gameRunning = false;
            });

            timerThread.Start();

            while (gameRunning)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        damage++;
                        DrawPowerBar(damage, ComputerHealth);
                    }
                }
            }

            Console.Clear();
            Console.WriteLine("GAME OVER SCREEN");
            Console.WriteLine();

            Console.WriteLine(ComputerHealth >= damage ? "YOU WIN!" : "YOU LOSE!");

            void DrawPowerBar(int damage, int ComputerHealth)
            {
                Console.Clear();
                Console.WriteLine("Powerbar");

                int barLength = 50;

                int filled = (int)((double)damage / ComputerHealth * barLength);
                filled = Math.Min(filled, barLength);

                string bar = "[" + new string('#', filled) + new string('-', barLength - filled) + "]";

                Console.WriteLine(bar);
                Console.WriteLine($"Might: {damage}/{ComputerHealth}");
            }
        }




        //Himanshu
        public static void Level5()
        {
            //Write your code for level 5 here

            Random rand = new Random();

            int playerHealth = 100;
            int computerHealth = 150; // Increased difficulty
            int chargeMeter = 0;
            int playerPotions = 2;
            bool blockNextHit = false;


            {
                Console.WriteLine("LEVEL 5: THE FINAL CHALLENGE!!!");
                Console.WriteLine("Press any key to enter the arena...");
                Console.ReadKey();
                Console.Clear();

                int turnCount = 0;
                bool playerTurn = true;
                bool playerWin = false;

                while (playerHealth > 0 && computerHealth > 0)
                {

                    Console.WriteLine();

                    if (playerTurn)
                    {
                        turnCount++;
                        Console.WriteLine("Your Turn!");
                        int damage = playersTurn();
                        computerHealth -= damage;
                        Console.WriteLine($"\nYou did {damage} damage!");
                        chargeMeter = Math.Min(chargeMeter + 1, 3);
                        Thread.Sleep(1000);
                        playerTurn = false;
                        playerWin = true;
                    }
                    else
                    {
                        Console.WriteLine("Computer's Turn!");
                        int damage = computersTurn();
                        playerHealth -= damage;
                        Console.WriteLine($"\nComputer did {damage} damage!");
                        Thread.Sleep(1000);
                        playerTurn = true;
                        playerWin = false;
                    }

                    Console.Clear();

                    int PlayerTurn()
                    {
                        Console.WriteLine("Choose your move:");
                        Console.WriteLine("U = Uppercut (5-15), R = Roundhouse (10-20), S = Sword Slash (15-25)");
                        Console.WriteLine("B = Block (Reduce next dmg), H = Use Health Potion");
                        if (chargeMeter >= 3)
                            Console.WriteLine("X = Special Move (30-50 damage)");

                        char input = Char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();

                        switch (input)
                        {
                            case 'U': return RandomDamage(5, 15);
                            case 'R': return RandomDamage(10, 20);
                            case 'S': return RandomDamage(15, 25);
                            case 'X':
                                if (chargeMeter >= 3)
                                {
                                    Console.WriteLine("You unleash your SPECIAL MOVE!!");
                                    chargeMeter = 0;
                                    return RandomDamage(30, 50);
                                }
                                else
                                {
                                    Console.WriteLine("Special move not charged!");
                                    return 0;
                                }
                            case 'B':
                                Console.WriteLine("You brace yourself to block the next attack!");
                                // Block sets a flag we simulate in enemy attack
                                bool blockNextHit = true;
                                return 0;
                            case 'H':
                                if (playerPotions > 0)
                                {
                                    int heal = rand.Next(20, 35);
                                    playerHealth = Math.Min(playerHealth + heal, 100);
                                    playerPotions--;
                                    Console.WriteLine($"You drank a potion and restored {heal} HP! Potions left: {playerPotions}");
                                }
                                else
                                {
                                    Console.WriteLine("No potions left!");
                                }
                                return 0;
                            default:
                                Console.WriteLine("Invalid move! You fumbled!");
                                return 0;
                        }
                    }
                    playerHitsComputer(playerHealth,computerHealth);



                    int ComputerTurn()
                    {
                        Thread.Sleep(1500);

                        int choice = rand.Next(0, 5);

                        if (playerHealth < 30 && rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine("Computer uses a strong attack while you're weak!");
                            return FinalDamage(RandomDamage(20, 35));
                        }

                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("Computer uses Uppercut!");
                                return FinalDamage(RandomDamage(5, 15));
                            case 1:
                                Console.WriteLine("Computer uses Roundhouse!");
                                return FinalDamage(RandomDamage(10, 20));
                            case 2:
                                Console.WriteLine("Computer uses Sword Slash!");
                                return FinalDamage(RandomDamage(15, 25));
                            case 3:
                                if (rand.Next(0, 4) == 0)
                                {
                                    Console.WriteLine("Computer uses Special Move!");
                                    return FinalDamage(RandomDamage(25, 45));
                                }
                                else
                                    goto case 0;
                            case 4:
                                Console.WriteLine("Computer hesitates... You get lucky!");
                                return 0;
                            default:
                                return 0;
                        }
                    }
                    computerHitsPlayer(playerHealth,computerHealth);

                    int FinalDamage(int rawDamage)
                    {
                        if (blockNextHit)
                        {
                            Console.WriteLine("You blocked the attack! Damage reduced.");
                            blockNextHit = false;
                            return rawDamage / 2;
                        }

                        // Critical hit chance
                        if (rand.Next(0, 10) == 0)
                        {
                            Console.WriteLine("**CRITICAL HIT!!**");
                            return (int)(rawDamage * 1.5);
                        }

                        return rawDamage;
                    }

                    int RandomDamage(int min, int max)
                    {
                        return rand.Next(min, max + 1);
                    }

                    void UpdateHealthBars()
                    {
                        Console.WriteLine($"Player Health:   [{new string('#', playerHealth / 10).PadRight(10)}] {playerHealth}/100");
                        Console.WriteLine($"Computer Health: [{new string('#', computerHealth / 15).PadRight(10)}] {computerHealth}/150");
                        Console.WriteLine($"Charge Meter: {chargeMeter}/3   Potions: {playerPotions}");
                    }


                    void EndGameSummary(bool playerWon, int turns)
                    {
                        Console.Clear();
                        if (playerWon)
                        {
                            Console.WriteLine("🏆 YOU WIN LEVEL 5!!! 🏆");
                            Console.WriteLine("You have proven your strength against the ultimate foe!");
                        }
                        else
                        {
                            Console.WriteLine("💀 YOU HAVE BEEN DEFEATED... 💀");
                            Console.WriteLine("The computer reigns supreme... for now.");
                        }

                        Console.WriteLine($"\n--- Battle Stats ---");
                        Console.WriteLine($"Turns Taken: {turns}");
                        Console.WriteLine($"Potions Used: {2 - playerPotions}");
                        Console.WriteLine($"Charge Meter at End: {chargeMeter}/3");
                        Console.WriteLine("\nPress any key to exit...");
                        Console.ReadKey();

                    }
                }
            }

        }
        
        


        //Paul
        public static void Level6()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                        Welcome to level 6... ");
            Console.WriteLine("                        ");
            Console.WriteLine("                    You have teleported to the year 3848 ");
            Console.WriteLine("                     ");
            Console.WriteLine("            You must now defeat the space invaders to return home! ");
            Console.WriteLine("                     ");
            Console.WriteLine("          Press any key to continue to Space Invaders... ");
            Console.ReadKey();
            Console.Clear();

            PlaySpaceInvaders();
        }

        public static void PlaySpaceInvaders()
        {
            int playerPos = 10;
            int enemyX = 10;
            int enemyY = 2;
            int bulletX = -1;
            int bulletY = -1;
            int enemyBulletX = -1;
            int enemyBulletY = -1;
            bool gameOver = false;
            int playerLives = 3;
            int enemyLives = 3;
            int enemyDirection = 1;
            int moveTimer = 0;
            Random rand = new Random();
            int shootTimer = 0;
            string winner = "";

            Console.CursorVisible = false;

            while (!gameOver)
            {

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.LeftArrow && playerPos > 0)
                        playerPos--;
                    if (key == ConsoleKey.RightArrow && playerPos < 18)
                        playerPos++;
                    if (key == ConsoleKey.Spacebar && bulletY == -1)
                    {
                        bulletX = playerPos + 1;
                        bulletY = 18;
                    }
                    if (key == ConsoleKey.Escape)
                    {
                        gameOver = true;
                        winner = "Nobody";
                    }
                }

                // Move enemy side to side
                moveTimer++;
                if (moveTimer > 5)
                {
                    enemyX += enemyDirection;

                    // Change direction at edges
                    if (enemyX <= 0 || enemyX >= 18)
                        enemyDirection *= -1;

                    moveTimer = 0;
                }

                // Enemy shoots randomly
                shootTimer++;
                if (shootTimer > 15 && enemyBulletY == -1 && rand.Next(0, 3) == 0)
                {
                    enemyBulletX = enemyX + 1;
                    enemyBulletY = enemyY + 3;
                    shootTimer = 0;
                }

                // Update player bullet
                if (bulletY > -1)
                {
                    bulletY--;
                    if (bulletY < 0)
                        bulletY = -1;
                }

                // Update enemy bullet
                if (enemyBulletY > -1)
                {
                    enemyBulletY++;
                    if (enemyBulletY > 23)
                        enemyBulletY = -1;
                }

                // Check player bullet collision with enemy
                if (bulletX >= enemyX && bulletX <= enemyX + 2 &&
                    bulletY >= enemyY && bulletY <= enemyY + 2)
                {
                    enemyLives--;
                    bulletY = -1;
                    if (enemyLives <= 0)
                    {
                        gameOver = true;
                        winner = "Player";
                    }
                }

                // Check enemy bullet collision with player
                if (enemyBulletX >= playerPos && enemyBulletX <= playerPos + 2 &&
                    enemyBulletY >= 19 && enemyBulletY <= 20)
                {
                    playerLives--;
                    enemyBulletY = -1;
                    if (playerLives <= 0)
                    {
                        gameOver = true;
                        winner = "Enemy";
                    }
                }

                // Draw
                Console.Clear();

                // Draw enemy health bar
                Console.SetCursorPosition(enemyX, enemyY - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[");
                for (int i = 0; i < enemyLives; i++)
                    Console.Write("=");
                for (int i = enemyLives; i < 3; i++)
                    Console.Write(" ");
                Console.Write("]");
                Console.ResetColor();

                // Draw enemy (3x3)
                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write(" V ");
                Console.SetCursorPosition(enemyX, enemyY + 1);
                Console.Write("<O>");
                Console.SetCursorPosition(enemyX, enemyY + 2);
                Console.Write("/ \\");

                // Draw player bullet
                if (bulletY > -1)
                {
                    Console.SetCursorPosition(bulletX, bulletY);
                    Console.Write("|");
                }

                // Draw enemy bullet
                if (enemyBulletY > -1)
                {
                    Console.SetCursorPosition(enemyBulletX, enemyBulletY);
                    Console.Write("*");
                }

                // Draw player (3x2)
                Console.SetCursorPosition(playerPos, 19);
                Console.Write(" ^ ");
                Console.SetCursorPosition(playerPos, 20);
                Console.Write("<M>");

                // Draw player health bar
                Console.SetCursorPosition(playerPos, 21);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[");
                for (int i = 0; i < playerLives; i++)
                    Console.Write("=");
                for (int i = playerLives; i < 3; i++)
                    Console.Write(" ");
                Console.Write("]");
                Console.ResetColor();

                // Draw HUD
                Console.SetCursorPosition(0, 24);
                Console.Write($"Enemy Health: {enemyLives}/3 | Arrow Keys=Move, Space=Shoot");

                System.Threading.Thread.Sleep(100);
            }

            if (winner == "Player")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     🎉 YOU WIN! 🎉");
                Console.WriteLine();
                Console.WriteLine("     Victory is yours!");
                Console.WriteLine("     Enemy destroyed!");
            }
            else if (winner == "Enemy")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     💀 THE ENEMY WINS! 💀");
                Console.WriteLine();
                Console.WriteLine("     You were destroyed!");
            }

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ResetColor();
            Console.WriteLine();
            Console.CursorVisible = true;
        }


        public static int playersTurn()
        {
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("                    Press U to uppercut, R to Roundhouse or S to Sword Slash");
            char keyInput = Char.ToUpper(Console.ReadKey().KeyChar);
            int damage = Moves(keyInput);
            Console.Write($"\n                    You did {damage} damage!");
            Thread.Sleep(1000);
            return damage;
        }
        public static int computersTurn()
        {
            Random rand = new Random();
            char[] moves = { 'U', 'R', 'S' };
            int index = rand.Next(moves.Length);

            char computerMove = moves[index];
            
            int damage = Moves(computerMove);
            switch (computerMove)
            {
                case 'U':
                    Console.SetCursorPosition(0, 25);
                    Console.Write($"                    Computer used Upper Cut and did {damage} damage!");
                    break;
                case 'R':
                    Console.SetCursorPosition(0, 25);
                    Console.Write($"                    Computer used Round House and did {damage} damage!");
                    break;
                case 'S':
                    Console.SetCursorPosition(0, 25);
                    Console.Write($"                    Computer used Sword Slash and did {damage} damage!");
                    break;
            }
            Thread.Sleep(1000);
            return damage;
        }



        public static int Moves(char key, int newDamage = 0 )
        {
            int damage = 0;
            int damageBonus = newDamage;

            Random rand = new Random();
            switch (key)
            {
                case 'U':
                    damage = rand.Next(15) + damageBonus;
                    break;
                case 'R':
                    damage = rand.Next(20) + damageBonus;
                    break;
                case 'S':

                    damage = rand.Next(25) + damageBonus;
                    break;
                default:
                    damage = 0;
                    break;

            }
            return damage;
            
        }


        public static void playerHitsComputer(int PlayerHealth, int ComputerHealth)
        {
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("        . --- .                                                                                _____       ");
            Console.WriteLine("       /       \\                                                                              /     \\      ");
            Console.WriteLine("       | \\  /  |                                                                             |  o o  |       ");
            Console.WriteLine("       |       |                                                                             |   ^   |       ");
            Console.WriteLine("       |   ^   |                                                                              \\ \\_/ /      ");
            Console.WriteLine("        \\  _  /    /                                                                           -----         ");
            Console.WriteLine("         -----    /                                                                             |||       ");
            Console.WriteLine("          | |    /                                                                             / | \\        ");
            Console.WriteLine("         / | \\  /                                                                             /  |  \\          ");
            Console.WriteLine("        /  |  \\/                                                                                 |        ");
            Console.WriteLine("           |  /                                                                                 / \\   ");
            Console.WriteLine("          / \\                                                                                  /   \\   ");
            Console.WriteLine("         /   \\                                                                                /     \\   ");
            Console.WriteLine("        /     \\                                                                              /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("             . --- .                                                                             _____       ");
            Console.WriteLine("            /       \\                                                                           /     \\      ");
            Console.WriteLine("            | \\  /  |                                                                          |  o o  |       ");
            Console.WriteLine("            |       |                                                                          |   ^   |       ");
            Console.WriteLine("            |   ^   |                                                                           \\ \\_/ /      ");
            Console.WriteLine("             \\  _  /    /                                                                        -----         ");
            Console.WriteLine("              -----    /                                                                          |||       ");
            Console.WriteLine("               | |    /                                                                          / | \\        ");
            Console.WriteLine("              / | \\  /                                                                          /  |  \\          ");
            Console.WriteLine("             /  |  \\/                                                                              |        ");
            Console.WriteLine("                |  /                                                                              / \\   ");
            Console.WriteLine("               / \\                                                                               /   \\   ");
            Console.WriteLine("              /   \\                                                                             /     \\   ");
            Console.WriteLine("             /     \\                                                                           /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                      . --- .                                                                    _____       ");
            Console.WriteLine("                     /       \\                                                                  /     \\      ");
            Console.WriteLine("                     | \\  /  |                                                                 |  o o  |       ");
            Console.WriteLine("                     |       |                                                                 |   ^   |       ");
            Console.WriteLine("                     |   ^   |                                                                  \\ \\_/ /      ");
            Console.WriteLine("                      \\  _  /    /                                                               -----         ");
            Console.WriteLine("                       -----    /                                                                 |||       ");
            Console.WriteLine("                        | |    /                                                                 / | \\        ");
            Console.WriteLine("                       / | \\  /                                                                 /  |  \\          ");
            Console.WriteLine("                      /  |  \\/                                                                     |        ");
            Console.WriteLine("                         |  /                                                                     / \\   ");
            Console.WriteLine("                        / \\                                                                      /   \\   ");
            Console.WriteLine("                       /   \\                                                                    /     \\   ");
            Console.WriteLine("                      /     \\                                                                  /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .                                                         _____       ");
            Console.WriteLine("                                /       \\                                                       /     \\      ");
            Console.WriteLine("                                | \\  /  |                                                      |  o o  |       ");
            Console.WriteLine("                                |       |                                                      |   ^   |       ");
            Console.WriteLine("                                |   ^   |                                                       \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /    /                                                    -----         ");
            Console.WriteLine("                                  -----    /                                                      |||       ");
            Console.WriteLine("                                   | |    /                                                      / | \\        ");
            Console.WriteLine("                                  / | \\  /                                                      /  |  \\          ");
            Console.WriteLine("                                 /  |  \\/                                                          |        ");
            Console.WriteLine("                                    |  /                                                          / \\   ");
            Console.WriteLine("                                   / \\                                                           /   \\   ");
            Console.WriteLine("                                  /   \\                                                         /     \\   ");
            Console.WriteLine("                                 /     \\                                                       /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .           _____       ");
            Console.WriteLine("                                /       \\         /     \\      ");
            Console.WriteLine("                                | \\  /  |        |  o o  |       ");
            Console.WriteLine("                                |       |  |     |   ^   |       ");
            Console.WriteLine("                                |   ^   |  |      \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /  |        -----         ");
            Console.WriteLine("                                  -----    |         |||       ");
            Console.WriteLine("                                   | |_____T        / | \\        ");
            Console.WriteLine("                                  / |              /  |  \\          ");
            Console.WriteLine("                                 /  |                 |        ");
            Console.WriteLine("                                    |               / \\   ");
            Console.WriteLine("                                   / \\             /   \\   ");
            Console.WriteLine("                                  /   \\           /     \\   ");
            Console.WriteLine("                                 /     \\         /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);



            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .                     '   '  '                       ");
            Console.WriteLine("                                /       \\               '    ~      ~                   ");
            Console.WriteLine("                                | \\  /  |             ~   ~     ' ~  '     ");
            Console.WriteLine("                                |       |             ~   '   ~  ~   ' ~           ");
            Console.WriteLine("                                |   ^   |              ~    '   ~           ");
            Console.WriteLine("                                 \\  _  /            ----- '     '  '                    ");
            Console.WriteLine("                                  -----               |||                                     ");
            Console.WriteLine("                                   | |               / | \\                       ");
            Console.WriteLine("                                  / | \\   ' ' ' '  /  |  \\                         ");
            Console.WriteLine("                                 /  | -\\|--------     |                       ");
            Console.WriteLine("                                    |     ' ' ' '    / \\                                 ");
            Console.WriteLine("                                   / \\              /   \\                                 ");
            Console.WriteLine("                                  /   \\            /     \\                              ");
            Console.WriteLine("                                 /     \\          /       \\               ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);
        }

        public static void computerHitsPlayer(int PlayerHealth, int ComputerHealth)
        {
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("        . --- .                                                                                _____       ");
            Console.WriteLine("       /       \\                                                                              /     \\      ");
            Console.WriteLine("       | \\  /  |                                                                             |  o o  |       ");
            Console.WriteLine("       |       |                                                                             |   ^   |       ");
            Console.WriteLine("       |   ^   |                                                                              \\ \\_/ /      ");
            Console.WriteLine("        \\  _  /    /                                                                           -----         ");
            Console.WriteLine("         -----    /                                                                             |||       ");
            Console.WriteLine("          | |    /                                                                             / | \\        ");
            Console.WriteLine("         / | \\  /                                                                             /  |  \\          ");
            Console.WriteLine("        /  |  \\/                                                                                 |        ");
            Console.WriteLine("           |  /                                                                                 / \\   ");
            Console.WriteLine("          / \\                                                                                  /   \\   ");
            Console.WriteLine("         /   \\                                                                                /     \\   ");
            Console.WriteLine("        /     \\                                                                              /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("             . --- .                                                                             _____       ");
            Console.WriteLine("            /       \\                                                                           /     \\      ");
            Console.WriteLine("            | \\  /  |                                                                          |  o o  |       ");
            Console.WriteLine("            |       |                                                                          |   ^   |       ");
            Console.WriteLine("            |   ^   |                                                                           \\ \\_/ /      ");
            Console.WriteLine("             \\  _  /    /                                                                        -----         ");
            Console.WriteLine("              -----    /                                                                          |||       ");
            Console.WriteLine("               | |    /                                                                          / | \\        ");
            Console.WriteLine("              / | \\  /                                                                          /  |  \\          ");
            Console.WriteLine("             /  |  \\/                                                                              |        ");
            Console.WriteLine("                |  /                                                                              / \\   ");
            Console.WriteLine("               / \\                                                                               /   \\   ");
            Console.WriteLine("              /   \\                                                                             /     \\   ");
            Console.WriteLine("             /     \\                                                                           /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                      . --- .                                                                    _____       ");
            Console.WriteLine("                     /       \\                                                                  /     \\      ");
            Console.WriteLine("                     | \\  /  |                                                                 |  o o  |       ");
            Console.WriteLine("                     |       |                                                                 |   ^   |       ");
            Console.WriteLine("                     |   ^   |                                                                  \\ \\_/ /      ");
            Console.WriteLine("                      \\  _  /    /                                                               -----         ");
            Console.WriteLine("                       -----    /                                                                 |||       ");
            Console.WriteLine("                        | |    /                                                                 / | \\        ");
            Console.WriteLine("                       / | \\  /                                                                 /  |  \\          ");
            Console.WriteLine("                      /  |  \\/                                                                     |        ");
            Console.WriteLine("                         |  /                                                                     / \\   ");
            Console.WriteLine("                        / \\                                                                      /   \\   ");
            Console.WriteLine("                       /   \\                                                                    /     \\   ");
            Console.WriteLine("                      /     \\                                                                  /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .                                                         _____       ");
            Console.WriteLine("                                /       \\                                                       /     \\      ");
            Console.WriteLine("                                | \\  /  |                                                      |  o o  |       ");
            Console.WriteLine("                                |       |                                                      |   ^   |       ");
            Console.WriteLine("                                |   ^   |                                                       \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /    /                                                    -----         ");
            Console.WriteLine("                                  -----    /                                                      |||       ");
            Console.WriteLine("                                   | |    /                                                      / | \\        ");
            Console.WriteLine("                                  / | \\  /                                                      /  |  \\          ");
            Console.WriteLine("                                 /  |  \\/                                                          |        ");
            Console.WriteLine("                                    |  /                                                          / \\   ");
            Console.WriteLine("                                   / \\                                                           /   \\   ");
            Console.WriteLine("                                  /   \\                                                         /     \\   ");
            Console.WriteLine("                                 /     \\                                                       /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .            _____       ");
            Console.WriteLine("                                /       \\         /     \\      ");
            Console.WriteLine("                                | \\  /  |        |  o o  |       ");
            Console.WriteLine("                                |       |        |   ^   |       ");
            Console.WriteLine("                                |   ^   |         \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /    /      -----         ");
            Console.WriteLine("                                  -----    /        |||       ");
            Console.WriteLine("                                   | |    /        / | \\        ");
            Console.WriteLine("                                  / | \\  /        /  |  \\          ");
            Console.WriteLine("                                 /  |  \\/            |        ");
            Console.WriteLine("                                    |  /            / \\   ");
            Console.WriteLine("                                   / \\             /   \\   ");
            Console.WriteLine("                                  /   \\           /     \\   ");
            Console.WriteLine("                                 /     \\         /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .            _____       ");
            Console.WriteLine("                                /       \\         /     \\      ");
            Console.WriteLine("                                | \\  /  |        |  o o  |       ");
            Console.WriteLine("                                |       |        |   ^   |       ");
            Console.WriteLine("                                |   ^   |         \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /|          -----         ");
            Console.WriteLine("                                  -----  |           |||       ");
            Console.WriteLine("                                   | |   |   (((O-----| \\        ");
            Console.WriteLine("                                    |----T            |  \\          ");
            Console.WriteLine("                                    |                 |        ");
            Console.WriteLine("                                    |                / \\   ");
            Console.WriteLine("                                   / \\             /   \\   ");
            Console.WriteLine("                                  /   \\           /     \\   ");
            Console.WriteLine("                                 /     \\         /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);

            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                 . --- .            _____       ");
            Console.WriteLine("                                /       \\         /     \\      ");
            Console.WriteLine("                                | \\  /  |        |  o o  |       ");
            Console.WriteLine("                                |       |        |   ^   |       ");
            Console.WriteLine("                                |   ^   |         \\ \\_/ /      ");
            Console.WriteLine("                                 \\  _  /|          -----         ");
            Console.WriteLine("                                  -----  |           |||       ");
            Console.WriteLine("                                   | |   |(((   O-----| \\        ");
            Console.WriteLine("                                    |----T            |  \\          ");
            Console.WriteLine("                                    |                 |        ");
            Console.WriteLine("                                    |                / \\   ");
            Console.WriteLine("                                   / \\             /   \\   ");
            Console.WriteLine("                                  /   \\           /     \\   ");
            Console.WriteLine("                                 /     \\         /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);

            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("                                                    _____       ");
            Console.WriteLine("                                                   /     \\      ");
            Console.WriteLine("                               '   ' '            |  o o  |       ");
            Console.WriteLine("                          '    '  ' '  '          |   ^   |       ");
            Console.WriteLine("                               '' '                \\ \\_/ /      ");
            Console.WriteLine("                              ' '   ' '             -----         ");
            Console.WriteLine("                                 '     '             |||       ");
            Console.WriteLine("                                  (((           O-----| \\        ");
            Console.WriteLine("                                    |----T            |  \\          ");
            Console.WriteLine("                                    |                 |        ");
            Console.WriteLine("                                    |                / \\   ");
            Console.WriteLine("                                   / \\             /   \\   ");
            Console.WriteLine("                                  /   \\           /     \\   ");
            Console.WriteLine("                                 /     \\         /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Thread.Sleep(300);


        }

        //Health Bar Method has color and is called with: HealthBar(PlayerHealth, ComputerHealth);
        // ===== HUD + Console Display Methods =====

        static void DrawHUD(int playerHealth, int computerHealth, bool turn, int newHealth)
        {
            Console.SetCursorPosition(0, 0);
            Console.ResetColor(); // this is the HUD, its 6  tall
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine($"Turn: {whosPlaying(turn)}                          guy who fights n shit                                               ");
            Console.WriteLine("========================================================================================================================");
            Console.Write("PLAYER HEALTH: ");
            DrawColoredBar(playerHealth, newHealth);
            Console.Write("COMPUTER HEALTH: ");
            DrawColoredBar(computerHealth);
            Console.WriteLine("========================================================================================================================");

            // Move cursor below HUD for animations or messages
            Console.SetCursorPosition(0, HUDLines);
        }
        static string whosPlaying(bool turn) //method for displaying whos turn it is
        {
            string whoTurn;

            if (turn == true)
                whoTurn = "PLAYER";
            else
                whoTurn = "COMPUTER";
            
            return whoTurn;

        }
        static void DrawColoredBar(int health, int newHealth = 100)
        {
            health = Math.Clamp(health, 0, 100);

            int totalBars = 20; // Wider bar for readability
            int filledBars = (int)Math.Round(health / 5.0);

            if (health > 60)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (health > 30)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            string bar = "[" + new string('#', filledBars) + new string(' ', totalBars - filledBars) + $"] {health,3}%";
            Console.WriteLine(bar);
            Console.ResetColor();
        }

        static void UpdateHealthBars(int playerHealth, int computerHealth)
        {
            // Save current cursor position
            int currentCursorTop = Console.CursorTop;

            // Draw player health on line 3
            Console.SetCursorPosition(0, 3);
            Console.Write("PLAYER HEALTH:   ");
            DrawColoredBar(playerHealth, 125);

            // Draw computer health on line 4
            Console.SetCursorPosition(0, 4);
            Console.Write("COMPUTER HEALTH: ");
            DrawColoredBar(computerHealth);

            // Restore cursor position
            Console.SetCursorPosition(0, currentCursorTop);
        }


        static void ClearBelowHUD()
        {
            ClearFromLine(HUDLines);
            Console.SetCursorPosition(0, HUDLines);
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

        static void idle() {
            ClearFromLine(6);
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("        . --- .                                                                                _____       ");
            Console.WriteLine("       /       \\                                                                              /     \\      ");
            Console.WriteLine("       | \\  /  |                                                                             |  o o  |       ");
            Console.WriteLine("       |       |                                                                             |   ^   |       ");
            Console.WriteLine("       |   ^   |                                                                              \\ \\_/ /      ");
            Console.WriteLine("        \\  _  /    /                                                                           -----         ");
            Console.WriteLine("         -----    /                                                                             |||       ");
            Console.WriteLine("          | |    /                                                                             / | \\        ");
            Console.WriteLine("         / | \\  /                                                                             /  |  \\          ");
            Console.WriteLine("        /  |  \\/                                                                                 |        ");
            Console.WriteLine("           |  /                                                                                 / \\   ");
            Console.WriteLine("          / \\                                                                                  /   \\   ");
            Console.WriteLine("         /   \\                                                                                /     \\   ");
            Console.WriteLine("        /     \\                                                                              /       \\    ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
        }
        static void WriteBelowHUD(string message)
        {
            ClearBelowHUD();
            Console.SetCursorPosition(0, HUDLines);
            Console.WriteLine(message);
        }
    }
}
