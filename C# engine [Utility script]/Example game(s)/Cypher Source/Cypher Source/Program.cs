﻿//8\"\"\"\"8                               8\"\"\"\"8
//8    \" e  eeeee e   e eeee eeeee     8      eeeee e   e eeeee  eeee eeee
//8e     8  8   8 8   8 8    8   8     8eeeee 8  88 8   8 8   8  8  8 8
//88     8e 8eee8 8eee8 8eee 8eee8e        88 8   8 8e  8 8eee8e 8e   8eee
//88   e 88 88    88  8 88   88   8    e   88 8   8 88  8 88   8 88   88
//88eee8 88 88    88  8 88ee 88   8    8eee88 8eee8 88ee8 88   8 88e8 88ee

//----------------------Credits----------------------
//Lead Programmer(s): ST3VI3 RICHI3 (Alex Stephenson)
//                    Soldier_engie-demo
//---------------------------------------------------

using System;
using System.IO;
using System.Threading;
using Apollo;

namespace Cypher_Source
{
    class Program
    {
        private static string[] SaveData = null;
        private static Thread GameTimeThread = null;
        private static string difficulty = "UNSET";
        static void Main(string[] args)
        {
            string version = "0.1.5";
            var random = Apollo.utility.random;
            bool DeveloperMode = false;
            Console.WriteLine("APOLL0 text test.");
            try
            {
                Text.print(true, "Hello World");
                Console.WriteLine("Test successful!");
            }
            catch
            {
                Console.WriteLine("Test failed.");
                Thread.Sleep(5000);
                Environment.Exit(-1);
            }
            Text.print(true, "Loading recourses");
            bool PizzaEE = false;
            System.Media.SoundPlayer pizzatime = null;
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] == "-pizza")
                {
                    pizzatime = new System.Media.SoundPlayer(@"pizza.wav");
                    PizzaEE = true;
                }
                if (args[i] == "-dev")
                {
                    DeveloperMode = true;
                }
                if (args[i] == "-save_Test")
                {
                    SaveData = new string[6];
                    SaveData[0] = "name";
                    SaveData[1] = "EGName";
                    SaveData[2] = "Stage";
                    SaveData[3] = "1";
                    SaveData[4] = "Version";
                    SaveData[5] = version;
                    Savefiles.Save("Test", SaveData);
                    Environment.Exit(0);
                }
                if (args[i] == "-load_Test")
                {
                    SaveData = Savefiles.Load("Test");
                    for (int j = 0; j < SaveData.Length; j++)
                    {
                        Console.WriteLine(SaveData[j]);
                    }
                    Console.ReadLine();
                }
                if (args[i] == "-Novid")
                {
                    goto NoVid;
                }
            }
            Console.Clear();
            Text.print(true, "Generic BIOS copyright 1987.");
            Text.print(true, "");
            Text.print(true, "Running RAM check...");
            time.sleep(1200);
            Text.print(true, "4GB detected");
            Console.Clear();
            Console.Beep();
            Text.print(true, "Boot from CD/DVD");
            time.sleep(250);
            Text.print(true, "Boot from USB");
            time.sleep(100);
            Text.print(false, "boot from HDD");
            time.sleep(150);
            Console.Clear();
            Text.print(false, "Loading operating system");
            time.sleep(2500);
            Console.Clear();
            utility.title("Cipher Source");
            Text.print(true, "8\"\"\"\"8                               8\"\"\"\"8                        ");
            Text.print(true, "8    \" e  eeeee e   e eeee eeeee     8      eeeee e   e eeeee  eeee eeee  ");
            Text.print(true, "8e     8  8   8 8   8 8    8   8     8eeeee 8  88 8   8 8   8  8  8 8      ");
            Text.print(true, "88     8e 8eee8 8eee8 8eee 8eee8e        88 8   8 8e  8 8eee8e 8e   8eee   ");
            Text.print(true, "88   e 88 88    88  8 88   88   8    e   88 8   8 88  8 88   8 88   88     ");
            Text.print(true, "88eee8 88 88    88  8 88ee 88   8    8eee88 8eee8 88ee8 88   8 88e8 88ee   ");
            Text.print(true, " ");
            title_slogan_animation();
            Text.print(true, " ");
            NoVid:
            Text.typefast(false, "press any key to play.");
            Console.ReadKey(true);
            Console.Clear();
            Text.print(true, "Encryption is a fallacy.");
            time.sleep(100);
            Console.Clear();
            Text.print(false, "Save name? ");
            string SavName = Console.ReadLine();
            string name;
            if (File.Exists(SavName + ".svp") == true)
            {
                SaveData = Savefiles.Load(SavName);
                goto SaveSkip;
            }
            Text.print(false, "Character name? ");
            name = Console.ReadLine();
            if (name == "")
            {
                var RNGName = random.Next(0, 10);
                if (RNGName == 0)
                {
                    name = "Jimmy";
                }
                if (RNGName == 1)
                {
                    name = "Bob";
                }
                if (RNGName == 2)
                {
                    name = "Billy";
                }
                if (RNGName == 3)
                {
                    name = "Bin Man Bob";
                }
                if (RNGName == 4)
                {
                    name = "Sally";
                }
                if (RNGName == 5)
                {
                    name = "Jessica";
                }
                if (RNGName == 6)
                {
                    name = "Jeff";
                }
                if (RNGName == 7)
                {
                    name = "Jacob";
                }
                if (RNGName == 8)
                {
                    name = "Katie";
                }
            }

            if (SavName == "")
            {
                SavName = "Save";
                while (File.Exists(SavName + ".svp") == true)
                {
                    int s = 0;
                    s++;
                    SavName = "Save" + s.ToString();
                }
            }
            Text.print(false, "Getting variables");
            int Stage = 1;
            SaveData = new string[6];
            SaveData[0] = "name";
            SaveData[1] = "EGName";
            SaveData[2] = "Stage";
            SaveData[3] = "1";
            SaveData[4] = "Version";
            SaveData[5] = version;
            Text.print(false, "..Creating save");
            Savefiles.Save(SavName, SaveData);
            Text.print(false, "..starting");
            SaveSkip:
            name = SaveData[1];
            Stage = Int32.Parse(SaveData[3]);
            if (PizzaEE == true)
            {
                pizzatime.PlayLooping();
            }
            if (Stage == 1)
            {
                tutorial(SavName);
            }
        }
        private static void title_slogan_animation()
        {
            Text.print(false, "                      ");
            Text.print(false, "E");
            time.sleep(100);
            Text.print(false, "n");
            time.sleep(100);
            Text.print(false, "c");
            time.sleep(100);
            Text.print(false, "r");
            time.sleep(100);
            Text.print(false, "y");
            time.sleep(100);
            Text.print(false, "p");
            time.sleep(100);
            Text.print(false, "t");
            time.sleep(150);
            Text.print(false, "i");
            time.sleep(200);
            Text.print(false, "o");
            time.sleep(250);
            Text.print(false, "n");
            time.sleep(500);
            Text.print(false, " ");
            time.sleep(100);
            Text.print(false, "i");
            time.sleep(250);
            Text.print(false, "s");
            time.sleep(100);
            Text.print(false, " ");
            time.sleep(500);
            Text.print(false, "o");
            time.sleep(50);
            Text.print(false, "n");
            time.sleep(100);
            Text.print(false, "l");
            time.sleep(100);
            Text.print(false, "y");
            time.sleep(250);
            Text.print(false, " ");
            time.sleep(250);
            Text.print(false, "a");
            time.sleep(500);
            Text.print(false, " ");
            time.sleep(100);
            Text.print(false, "f");
            time.sleep(100);
            Text.print(false, "a");
            time.sleep(100);
            Text.print(false, "l");
            time.sleep(250);
            Text.print(false, "l");
            time.sleep(150);
            Text.print(false, "a");
            time.sleep(100);
            Text.print(false, "c");
            time.sleep(100);
            Text.print(false, "y");
            time.sleep(500);
            Text.print(false, ".");
            time.sleep(1000);
            Text.print(true, " ");
        }
        private static void tutorial(string SavName)
        {
            var random = Apollo.utility.random;
            string[] SaveData = Savefiles.Load(SavName);
            string name = SaveData[1];
            //string difficulty = SaveData[7];
            int gametime = 0; //how long it has been in seconds since timer starts
            bool timerenabled = true;
            GameTimeThread = new Thread(() =>
            {
                while (timerenabled == true)
                {
                    gametime = gametime + 1;
                    time.sleep(1000);
                }
            });
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Text.type(true, "Imagine you are in 1991.");
            Text.type(true, "You are an amateur hacker who chose a group named 'Cipher'.");
            time.sleep(1000);
            Text.type(true, "Here is your test.");
            Apollo.Text.newline();
            Text.print(false, "Home/" + name + "> ");
            time.sleep(1000);
            Text.type(true, "clear");
            time.sleep(250);
            Console.Clear();
            Text.print(false, "Home/" + name + "> ");
            time.sleep(1000);
            Text.type(true, "ssh 124.268.1.26");
            time.sleep(250);
            Text.print(true, "Connecting to: " + "'124.268.1.26'");
            time.sleep(random.Next(0, 10000));
            Text.print(true, "Connected");
            time.sleep(500);
            S1Restart:
            Text.newline();
            Text.print(true, "Message from 124.268.1.26: Welcome to the Cipher test server.");
            Text.print(true, "This server will give you a series of tests ranging from easy to hard.");
            Text.print(true, "This will set your skill level so we can send you missons of your'e difficulty.");
            Text.print(true, "Type 'start' to start the test");
            Text.newline();
            CommandFail:
            Text.print(false, "Home/" + name + "> ");
            string Command = Console.ReadLine();
            if (Command == "start")
            {
                goto Continue;
            }
            if (Command == "exit")
            {
                Environment.Exit(0);
            }
            if (Command == "help")
            {
                time.sleep(250);
                Text.newline();
                Text.print(true, "Current available commands:");
                Text.print(true, "start");
                Text.print(true, "help");
                Text.print(true, "exit");
                Text.newline();
                time.sleep(250);
                goto CommandFail;
            }
            if (Command == "") { goto CommandFail; }
            else
            {
                Text.print(true, "Unknown command: '" + Command + "'");
                goto CommandFail;
            }
            Continue:
            GameTimeThread.Start();
            Text.newline();
            Text.print(true, "Message from 124.268.1.26: The timer has started. We'll start out with simple stuff, then get harder as we go.");
            Text.print(true, "Fist you need to open your'e cracker. At the moment you only have a simple one but you can buy better & faster ones later.");
            Text.newline();
            Console.ForegroundColor = ConsoleColor.Blue;
            Text.print(true, "Open cracker by trping 'XCrack'");
            Console.ForegroundColor = ConsoleColor.Green;
            Text.newline();
            CommandFail2:
            Text.print(false, "Home/" + name + "> ");
            Command = Console.ReadLine();
            if (Command == "XCrack")
            {
                goto Continue2;
            }
            if (Command == "exit")
            {
                Environment.Exit(0);
            }
            if (Command == "help")
            {
                time.sleep(250);
                Text.newline();
                Text.print(true, "Current available commands:");
                Text.print(true, "Help");
                Text.print(true, "XCrack");
                Text.print(true, "restart");
                Text.print(true, "exit");
                Text.newline();
                time.sleep(250);
                goto CommandFail;
            }
            if (Command == "restart")
            {
                goto S1Restart;
            }
            else
            {
                Text.print(true, "Unknown command: '" + Command + "'");
                goto CommandFail2;
            }
            Continue2:
            Text.newline();
            Text.print(true, "XCrack");
            Text.print(true, "Copyright to MrBitz.");
            Text.newline();
            Text.print(true, "Connection found, starting automaticly");
            Text.newline();
            Text.print(false, "Crack: [==");
            time.sleep(500);
            Text.print(false, "================================================");
            time.sleep(500);
            Text.print(true, "==================================================]");
            Text.newline();
            Text.print(true, "Username: admin");
            Text.print(true, "Password: 123456");
            Text.newline();
            Console.ForegroundColor = ConsoleColor.Blue;
            Text.print(true, "Type 'login to log in. (obviously)'");
            Console.ForegroundColor = ConsoleColor.Green;
            CommandFail3:
            Text.print(false, "Home/" + name + "> ");
            Command = Console.ReadLine();
            if (Command == "login")
            {
                goto Continue3;
            }
            if (Command == "exit")
            {
                Environment.Exit(0);
            }
            if (Command == "help")
            {
                time.sleep(250);
                Text.newline();
                Text.print(true, "Current available commands:");
                Text.print(true, "Help");
                Text.print(true, "login");
                Text.print(true, "restart");
                Text.print(true, "exit");
                Text.newline();
                time.sleep(250);
                goto CommandFail3;
            }
            if (Command == "restart")
            {
                goto S1Restart;
            }
            else
            {
                Text.print(true, "Unknown command: '" + Command + "'");
                goto CommandFail3;
            }
            Continue3:
            time.sleep(250);
            Text.print(false, "login as: ");
            string puzz1_username = Console.ReadLine();
            Text.print(false, "Password for "+puzz1_username+": ");
            string puzz1_passwd = Console.ReadLine();
            if (puzz1_username == "admin")
            {
                for (var i = 0; i < 6; i++)
                {
                    if (puzz1_passwd == "123456")
                    {
                        goto puzz1FinalStage;
                    }
                }
            }
            else
            {
                Text.print(true, "Access denied");
                goto CommandFail3;
            }
            puzz1FinalStage:
            Text.print(true, "Ok, your'e in. The following things should be simple, if you know the basic command line.");
            Text.print(true, "It is just a simple file transfer.");
            Text.newline();
            Console.ForegroundColor = ConsoleColor.Blue;
            Text.print(true, "Type 'dir', then open 'File downloader' by typing 'FDownload'");
            Console.ForegroundColor = ConsoleColor.Green;
            Text.newline();
            CommandFail4:
            Text.print(false, "root/admin/"+"> ");
            Command = Console.ReadLine();
            if (Command == "FDownload")
            {
                goto Continue4;
            }
            if (Command == "dir")
            {
                Text.newline();
                Text.print(true, "Direcory listing of root/admin");
                Text.newline();
                Text.print(true, "TestInfo.txt");
                Text.newline();
                goto CommandFail4;
            }
            if (Command == "exit")
            {
                Environment.Exit(0);
            }
            if (Command == "help")
            {
                time.sleep(250);
                Text.newline();
                Text.print(true, "Current available commands:");
                Text.print(true, "Help");
                Text.print(true, "dir");
                Text.print(true, "FDownload");
                Text.print(true, "restart");
                Text.print(true, "exit");
                Text.newline();
                time.sleep(250);
                goto CommandFail3;
            }
            if (Command == "restart")
            {
                goto S1Restart;
            }
            else
            {
                Text.print(true, "Unknown command: '" + Command + "'");
                goto CommandFail4;
            }
            Continue4:
            Text.print(true, "File Download (FDOownload)    Copyright to SampleName.");
            FileNotFound:
            Text.newline();
            Text.print(false, "File to download:");
            string FTD = Console.ReadLine();
            if (FTD == "TestInfo.txt")
            {
                Text.print(false, "Downloading file " + FTD);
                for (var i = 0; i <= 3; i++)
                {
                    time.sleep(250);
                    Text.print(false, ".");
                }
                Text.newline();
                Text.print(true, "File downloaded!");
            }
            if (FTD == "Testinfo")
            {
                Text.print(true, "Looking for file '" + FTD + "...");
                time.sleep(100);
                Text.print(true, "Found file: 'TestInfo.txt'.");
                time.sleep(50);
                Text.print(false, "Downloading file " + FTD + ".txt");
                for (var i = 0; i <= 3; i++)
                {
                    time.sleep(250);
                    Text.print(false, ".");
                }
                Text.newline();
                Text.print(true, "File downloaded!");
            }
            else
            {
                Text.print(true, "Error: File not found.");
                goto FileNotFound;
            }
            Text.newline();
            Console.ForegroundColor = ConsoleColor.Blue;
            Text.print(true, "Type exit disconnect & finish your task");
            Console.ForegroundColor = ConsoleColor.Green;
            CommandFail5:
            Text.newline();
            Text.print(false, "Root/admin/" + ">");
            Command = Console.ReadLine();
            if (Command == "exit")
            {
                goto Continue5;
            }
            else if (Command == "help")
            {
                Text.newline();
                Text.print(true, "Current available commands:");
                Text.print(true, "help");
                Text.print(true, "exit");
                goto CommandFail5;
            }
            else
            {
                Text.newline();
                Text.print(true, "Unknown command: '" + Command + "'");
                goto CommandFail5;
            }
            Continue5:
            Text.newline();
            time.sleep(250);
            Text.print(true, "Disconnecting from: '124.268.1.26' ");
            Text.print(true, "Disconnected.");
            EndingCommandReset:
            Text.print(false, "home/" + name + "/");
            Command = Console.ReadLine();
            Command = Command.ToLower();
            if (Command == "help")
            {
                Text.print(true, "Help - Provides help on a spesific command.");
                Text.print(true, "Nano - Basic text editor, allows documents to be veiwed and edited.");
                goto EndingCommandReset;

            }

        }
    }
}
