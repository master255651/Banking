using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class Messages
    {
        public static void Info_AccountInformation(float currentAmount)
        {
            Console.WriteLine($"You have $ {Math.Round(currentAmount,2)} in your account now.");
        }

        public static void Info_WithdrawingNotification(float withdrawalAmount, float currentAmount)
        {
            Console.WriteLine($"{Math.Round(withdrawalAmount, 2)}$ has been successfully withdrawn from the account. Current amount: {Math.Round(currentAmount, 2)}$");
        }

        public static void Info_ReplenishmentNotification(float replenishmentAmount, float currentAmount)
        {
            Console.WriteLine($"Your account has been successfully credited with {Math.Round(replenishmentAmount, 2)}. Current amount: {Math.Round(currentAmount, 2)}$");
        }

        public static void Warning_NegativeAmount(float currentAmount)
        {
            Console.WriteLine($"Caution, your account has gone negative! Current amount: {Math.Round(currentAmount, 2)}$");
        }

        public static void Error_NegativeAmount()
        {
            Console.WriteLine("Not enough money in the account");
        }

        public static void Blank_lines()
        {
            Console.WriteLine("\n\n");
        }
    }
}
