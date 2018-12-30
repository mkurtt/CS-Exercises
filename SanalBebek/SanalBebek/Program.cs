using System;
using System.Threading;

namespace SanalBebek
{
    class Program
    {
        static Random rnd = new Random();

        //EASY COLORED WRITING FUNCTION
        static void Write(Object str, Colors c)
        {
            if (c == Colors.DarkCyan) Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (c == Colors.Green) Console.ForegroundColor = ConsoleColor.Green;
            else if (c == Colors.Red) Console.ForegroundColor = ConsoleColor.Red;
            else if (c == Colors.White) Console.ForegroundColor = ConsoleColor.White;
            else if (c == Colors.Blue) Console.ForegroundColor = ConsoleColor.Blue;
            else if (c == Colors.Yellow) Console.ForegroundColor = ConsoleColor.Yellow;
            else if (c == Colors.DarkYellow) Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write($"{str}");
            Console.ResetColor();
        }
        enum Colors
        {
            DarkCyan,
            Green,
            Red,
            White,
            Blue,
            Yellow,
            DarkYellow
        }
        //EASY COLORED WRITING FUNCTION END


        // CLASS PET
        class Pet
        {
            public Events currentEvent { get; set; }
            public string petMessage { get; set; }
            public bool isDead { get; set; }
            public int eventTimer { get; set; 


            private double health;
            public double Health
            {
                get { return health; }
                set
                {
                    if (value > 100)
                        health = 100;
                    else if (value < 0)
                    {
                        health = 0;
                    }
                    else
                        health = value;
                }
            }

            private int hunger { get; set; }
            public int Hunger
            {
                get { return hunger; }
                set
                {
                    if (value > 100)
                        hunger = 100;
                    else if (value < 0)
                    {
                        hunger = 0;
                    }
                    else
                        hunger = value;
                }
            }

            private int stress;
            public int Stress
            {
                get { return stress; }
                set
                {
                    if (value > 100)
                        stress = 100;
                    else if (value < 0)
                    {
                        stress = 0;
                    }
                    else
                        stress = value;
                }
            }

            private int energy;
            public int Energy
            {
                get { return energy; }
                set
                {
                    if (value > 100)
                        energy = 100;
                    else if (value < 0)
                    {
                        energy = 0;
                    }
                    else
                        energy = value;
                }
            }        

            private int hygiene;
            public int Hygiene
            {
                get { return hygiene; }
                set
                {
                    if (value > 100)
                        hygiene = 100;
                    else if (value < 0)
                    {
                        hygiene = 0;
                    }
                    else
                        hygiene = value;
                }
            }

            //CONSTRUCTOR
            public Pet()
            {
                this.currentEvent = Events.Idle;
                this.Health = 100;
                this.Hunger = 70;
                this.Energy = 100;
                this.Stress = 0;
                this.Hygiene = 100;
                this.petMessage = "Hello!";
                this.eventTimer = 0;
                this.isDead = false;
            }

            //PERFORMING THE CURRENT ACTION
            public void Action()
            {
                switch (this.currentEvent)
                {
                    case Events.Idle:
                        this.Idle();
                        break;
                    case Events.Sleeping:
                        this.Sleeping();
                        break;
                    case Events.Eating:
                        this.Eating();
                        break;
                    case Events.Playing:
                        this.Playing();
                        break;
                    case Events.Bathing:
                        this.Bathing();
                        break;
                    default:
                        break;
                }
                eventTimer++;
                if (this.eventTimer == 4)
                {
                    this.eventTimer = 0;
                    this.currentEvent = Events.Idle;
                }
            }

            public void UpdateHealth()
            {
                if (this.Hunger == 0)
                {
                    if (this.Hygiene == 0 && this.Stress == 100)
                        this.Health -= 0.8;
                    else if (this.Hygiene == 0 || this.Stress == 100)
                        this.Health -= 0.5;
                    else
                        this.Health -= 0.3;
                }
                if (this.currentEvent == Events.Sleeping || this.currentEvent == Events.Eating)
                {
                    this.Health++;
                }
                if (this.Health == 0)
                {
                    this.isDead = true;
                }
            }

            public void Idle()
            {
                this.Energy -= 3;
                this.Hunger -= 3;
                this.Stress += 3;
                this.Hygiene -= 3;
                this.UpdateMessage();
                this.UpdateHealth();
            }

            public void Sleeping()
            {
                this.Energy += 10;
                this.Hunger -= 10;
                this.Stress += 7;
                this.Hygiene -= 2;
                this.UpdateMessage();
                this.UpdateHealth();
            }

            public void Eating()
            {
                this.Energy += 3;
                this.Hunger += 10;
                this.Stress += 3;
                this.Hygiene -= 8;
                this.UpdateMessage();
                this.UpdateHealth();
            }

            public void Playing()
            {
                this.Energy -= 10;
                this.Hunger -= 8;
                this.Stress -= 13;
                this.Hygiene -= 7;
                this.UpdateMessage();
                this.UpdateHealth();
            }

            public void Bathing()
            {
                this.Energy += 2;
                this.Hunger -= 8;
                this.Stress += 5;
                this.Hygiene += 23;
                this.UpdateMessage();
                this.UpdateHealth();
            }

            public void UpdateMessage()
            {
                if(this.Health == 0){
                    this.petMessage = "Aarrgggggg!";\
                }
                else
                {
                    if (currentEvent == Events.Idle)
                    {
                        if (this.Stress < 50)
                            this.petMessage = "Pufff";
                        else if (this.Energy < 50)
                            this.petMessage = "*Yawns*";
                        else if (this.Hygiene < 50)
                            this.petMessage = "*Sniff* Iak!";
                        else if (this.Hunger < 30)
                            this.petMessage = "Gurrlll";
                        else this.petMessage = ":D";
                    }
                    else if (currentEvent == Events.Eating)
                    {
                        this.petMessage = "Yum Yum Yum";
                    }
                    else if (currentEvent == Events.Bathing)
                    {
                        this.petMessage = "";
                    }
                    else if (currentEvent == Events.Playing)
                    {
                        this.petMessage = "Yippee ki-yay";
                    }
                    else if (currentEvent == Events.Sleeping)
                    {
                        this.petMessage = "zZzZz...";
                    }
                }
            }
        }
        // CLASS PET END

        
        static Pet myPet = new Pet();
        
        enum Events
        {
            Idle,
            Sleeping,
            Eating,
            Playing,
            Bathing
        }
        
        //CAT ANIMATIONS
        static string CatImage(int i)
        {
            if (i % 2 == 0)
                return "   ██          ██           ███████████   \n   █▒█        █▒█          █XXXXXXXXXXX█  \n  █▒███    ███▒█          █XXXXXXXXXXXXX█ \n  █▒████████▒▒█               " + myPet.petMessage + "            \n  █▒████▒▒█▒▒██          █XXXXXXXXXXXX█   \n  ████▒▒▒▒▒████         ██████████████    \n   █▒▒▒▒▒▒▒████        \n  █▒▒▒▒▒▒▒▒████      █     \n ██▒█▒▒▒▒▒█▒▒████  █▒█\n █▒█●█▒▒▒█●█▒▒███ █▒▒█\n █▒▒█▒▒▒▒▒█▒▒▒██ █▒▒█\n  █▒▒▒=▲=▒▒▒▒███ ██▒█\n  ██▒▒█♥█▒▒▒▒███  ██▒█\n    ███▒▒▒▒████    █▒█\n      ██████        ███\n       █▒▒████      ██\n       █▒▒▒▒▒████  ██\n       █▒██▒██████▒█\n       █▒███▒▒▒█████\n     █▒████▒▒▒▒████\n      █▒███▒██████  ";
            else if (i == 1)
                return "                            ███████████    \n  ██          ██           █XXXXXXXXXXX█     \n  █▒█        █▒█          █XXXXXXXXXXXXX█    \n █▒███    ███▒█               " + myPet.petMessage + "           \n █▒████████▒▒█           █XXXXXXXXXXXX█      \n █▒████▒▒█▒▒██          ██████████████       \n ████▒▒▒▒▒████            \n  █▒▒▒▒▒▒▒████      █     \n █▒▒▒▒▒▒▒▒████    █▒█     \n██▒█▒▒▒▒▒█▒▒████ █▒▒█\n█▒█●█▒▒▒█●█▒▒████▒▒█\n█▒▒█▒▒▒▒▒█▒▒▒██ ██▒█\n █▒▒▒=▲=▒▒▒▒███  ██▒█\n ██▒▒█♥█▒▒▒▒███   █▒█\n   ███▒▒▒▒████     ███\n     ████████       ██\n       █▒▒▒▒▒████  ██\n       █▒██▒██████▒█\n       █▒███▒▒▒█████\n     █▒████▒▒▒▒████\n      █▒███▒██████  ";
            else
                return "                            ███████████      \n    ██          ██         █XXXXXXXXXXX█     \n    █▒█        █▒█        █XXXXXXXXXXXXX█    \n   █▒███    ███▒█             " + myPet.petMessage + "            \n   █▒████████▒▒█         █XXXXXXXXXXXX█      \n   █▒████▒▒█▒▒██        ██████████████       \n   ████▒▒▒▒▒████           \n    █▒▒▒▒▒▒▒████     █     \n   █▒▒▒▒▒▒▒▒████   █▒█\n  ██▒█▒▒▒▒▒█▒▒█████▒▒█\n  █▒█●█▒▒▒█●█▒▒███▒▒█\n  █▒▒█▒▒▒▒▒█▒▒▒████▒█\n   █▒▒▒=▲=▒▒▒▒███ ██▒█\n   ██▒▒█♥█▒▒▒▒███  █▒█\n     ███▒▒▒▒████    ███\n       ██████       ██\n       █▒▒▒▒▒████  ██\n       █▒██▒██████▒█\n       █▒███▒▒▒█████\n     █▒████▒▒▒▒████\n      █▒███▒██████  ";


        }

        //MAIN LOOP TO KEEP THE GAME WORKING
        static void ActiveEvent()
        {
            int eventWaiter = rnd.Next(4);
            int AnimationIndex = 0;
            do
            {
                if(isDead) break;
                AnimationIndex++;
                if (AnimationIndex == 4) AnimationIndex = 0;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(CatImage(AnimationIndex));
                ShowStats();
                myPet.Action();
                Thread.Sleep(1000);
            } while (true);
        }

        //DISPLAYING STAT BARS
        static void ShowStatBars(string stat, Colors A)
        {
            Program.Write("| ", A);
            double StatValue = 0;
            int i;
            switch (stat)
            {
                case "Health":
                    StatValue = myPet.Health;
                    break;
                case "Hunger":
                    StatValue = myPet.Hunger;
                    break;
                case "Hygiene":
                    StatValue = myPet.Hygiene;
                    break;
                case "Energy":
                    StatValue = myPet.Energy;
                    break;
                case "Stress":
                    StatValue = myPet.Stress;
                    break;
            }
            for (i = 0; i < StatValue/2; i++)
            {
                Program.Write("▒", A);
            }

            for (i = 0; i < 100 - StatValue ; i++)
            {
                if(i%2 == 0)
                Program.Write(" ", A);
            }
            if (i % 2 == 0) Program.Write(" | ", A);
            else Program.Write("| ", A);
        }

        static void informCurrentEvent()
        {
            Console.WriteLine("");
            switch (myPet.currentEvent)
            {
                case Events.Idle:
                    Program.Write("\tIdle\t\t\t\t\t\t\t\t\t", Colors.Red);
                    break;
                case Events.Sleeping:
                    Program.Write($"\tSleeping - {4 - myPet.eventTimer} sec left\t\t\t\t\t", Colors.Red);
                    break;
                case Events.Eating:
                    Program.Write($"\tEating - {4 - myPet.eventTimer} sec left\t\t\t\t\t\t", Colors.Red);
                    break;
                case Events.Playing:
                    Program.Write($"\tPlaying - {4 - myPet.eventTimer} sec left / should be overwritten\t", Colors.Red);
                    break;
                case Events.Bathing:
                    Program.Write($"\tBathing - {4 - myPet.eventTimer} sec left\t\t\t\t\t\t",Colors.Red);
                    break;
                default:
                    break;
            }
        }

        //DISPLAYING STAT VALUES
        static void ShowStats()
        {
            Colors A = new Colors();
            Program.Write("Pet Stats:\n", Colors.DarkCyan);

            Program.Write("   Health: ", Colors.Blue);
            if (myPet.Health > 70) A = Colors.Green;
            else if (myPet.Health > 30) A = Colors.DarkYellow;
            else A = Colors.Red;
            Program.Write(myPet.Health.ToString("0.0") + " \t", A);
            ShowStatBars("Health", A);

            informCurrentEvent();

            Program.Write("\n[E]at-Hunger: ", Colors.Blue);
            if (myPet.Hunger > 60) A = Colors.Green;
            else if (myPet.Hunger > 20) A = Colors.DarkYellow;
            else A = Colors.Red;
            Program.Write(myPet.Hunger + " \t", A);
            ShowStatBars("Hunger", A);

            Program.Write("\n[B]ath-Hygiene: ", Colors.Blue);
            if (myPet.Hygiene > 60) A = Colors.Green;
            else if (myPet.Hygiene > 30) A = Colors.DarkYellow;
            else A = Colors.Red;
            Program.Write(myPet.Hygiene + " \t", A);
            ShowStatBars("Hygiene", A);

            Program.Write("\n[S]leep-Energy: ", Colors.Blue);
            if (myPet.Energy > 70) A = Colors.Green;
            else if (myPet.Energy > 30) A = Colors.DarkYellow;
            else A = Colors.Red;
            Program.Write(myPet.Energy + " \t", A);
            ShowStatBars("Energy", A);

            Program.Write("\n[P]lay-Stress: ", Colors.Blue);
            if (myPet.Stress < 20) A = Colors.Green;
            else if (myPet.Stress < 60) A = Colors.DarkYellow;
            else A = Colors.Red;
            Program.Write(myPet.Stress + " \t", A);
            ShowStatBars("Stress", A);
            
        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 50);


            //2ND THREAD TO PERFORM THE GAME ACTION
            Thread t2 = new Thread(new ThreadStart(ActiveEvent));
            t2.Start();


            //FIRST THREAD TO READ THE KEY TO CHANGE CURRENT EVENT
            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.E:
                        if (myPet.currentEvent == Events.Idle)
                        {
                            myPet.currentEvent = Events.Eating;
                        }
                        break;
                    case ConsoleKey.S:
                        if (myPet.currentEvent == Events.Idle)
                        {
                            myPet.currentEvent = Events.Sleeping;
                        }
                        break;
                    case ConsoleKey.P:
                        myPet.eventTimer = 0;
                        myPet.currentEvent = Events.Playing;
                        break;
                    case ConsoleKey.B:
                        if (myPet.currentEvent == Events.Idle)
                        {
                            myPet.currentEvent = Events.Bathing;
                        }
                        break;
                }
            }

        }
    }
}
