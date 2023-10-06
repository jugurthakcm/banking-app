using System;
using Banking;

bool exit = false;
string? option;
Account newAccount = new();


while (!exit)
{
    Console.Clear();
    Functions.MainMenu();
    Console.Write("> ");
    option = Console.ReadLine();
    if (option == null || option.Trim() != "")
    {
        switch (option)
        {
            case "0":
                exit = true;
                break;

            //1. Create new account
            case "1":
                Console.Clear();
                Console.WriteLine("Create an account");
                Console.WriteLine("----------------------------");

                string? inputRead;
                string name = "";
                double initialAmount = 0;
                bool exitLoop = false;

                while (!exitLoop)
                {
                    Console.Write("Enter Your Name: ");
                    inputRead = Console.ReadLine();
                    if (inputRead == null || inputRead.Trim() == "")
                    {
                        Console.WriteLine("Your name can't be empty");
                        continue;
                    }
                    name = inputRead;
                    exitLoop = true;
                }

                exitLoop = false;

                while (!exitLoop)
                {
                    Console.Write("Enter Your Initial Amount: ");
                    inputRead = Console.ReadLine();
                    if (inputRead == null || inputRead.Trim() == "")
                    {
                        Console.WriteLine("Your initial amount can't be empty");
                        continue;
                    }

                    if (double.TryParse(inputRead, out initialAmount))
                    {
                        if (initialAmount >= 0) exitLoop = true;
                        else
                        {
                            Console.WriteLine("The initial can't be negative");
                            continue;
                        }
                    }

                }

                newAccount = new(name, initialAmount);

                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                break;

            //2. Check account status 
            case "2":
                Console.Clear();

                Console.WriteLine("Account Status");
                Console.WriteLine("----------------------------");

                newAccount.CheckStatus();

                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                break;


            //3. Make deposit
            case "3":
                Console.Clear();

                Console.WriteLine("Deposit Money");
                Console.WriteLine("----------------------------");

                double deposit = 0;
                exitLoop = false;
                while (!exitLoop)
                {
                    Console.Write("Please enter the amount you want to deposit: ");
                    inputRead = Console.ReadLine();
                    if (inputRead == null || inputRead.Trim() == "")
                    {
                        Console.WriteLine("Your deposit amount can't be empty");
                        continue;
                    }

                    if (double.TryParse(inputRead, out deposit)) exitLoop = true;

                }

                newAccount.MakeDeposit(deposit);

                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                break;

            //4. Withdraw money
            case "4":
                Console.Clear();

                Console.WriteLine("Withdraw Money");
                Console.WriteLine("----------------------------");

                double withdraw = 0;
                exitLoop = false;
                while (!exitLoop)
                {
                    Console.Write("Please enter the amount you want to withdraw: ");
                    inputRead = Console.ReadLine();
                    if (inputRead == null || inputRead.Trim() == "")
                    {
                        Console.WriteLine("Your withdraw amount can't be empty");
                        continue;
                    }

                    if (double.TryParse(inputRead, out withdraw)) exitLoop = true;

                }

                newAccount.Withdraw(withdraw);

                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                break;
            default:
                exit = true;
                break;
        }
    }





}


