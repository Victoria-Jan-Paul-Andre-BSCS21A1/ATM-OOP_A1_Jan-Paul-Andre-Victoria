using System;

class Program
{
    static void Print(string output)
    {
        Console.WriteLine(output);
    }
    static void Main(string[] args)
    {
        int curBalance = 1000;

        while (true)
        {
            try
            {
                Print("\nATM Simulation\n");
                Print("1. Check Balance \n2. Deposit Money\n3. Withdraw Money\n4. Exit");
                Console.Write("\nSelect an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice < 1 || choice > 4)
                {
                    Print("\nInvalid Choice, choose again!");
                }
                else if (choice == 1)
                {
                    Print("\nYour current balance is: " + curBalance);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the money you want to deposit: ");
                    int depositMoney = Convert.ToInt32(Console.ReadLine());

                    if (depositMoney < 0)
                    {
                        Print("\nError, Invalid Input \nTry again.");
                    }
                    else
                    {
                        curBalance += depositMoney;
                        Print("\nDeposit Success! Your new balance is: " + curBalance);
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter the money you want to withdraw: ");
                    int withdrawMoney = Convert.ToInt32(Console.ReadLine());

                    if (withdrawMoney < 0 || withdrawMoney > curBalance)
                    {
                        Print("\nError, Invalid Input \nTry again.");
                    }
                    else
                    {
                        curBalance -= withdrawMoney;
                        Print("\nWithdraw Success! Your new balance is: " + curBalance);
                    }
                }
                else if (choice == 4)
                {
                    Print("\nYou chose Exit, the program will now terminate.");
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
