using System;

namespace NetEssentialExerciseNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add basic information
            DataManager.AddBasicUsers();

            //Test for Normal Account
            NormalAccount normalAccount = DataManager.users[0].bankAccount as NormalAccount;
            normalAccount.ShowAccountInformation();

            normalAccount.PutMoney(3.17f);
            normalAccount.WithdrawMoney(4f);
            normalAccount.WithdrawMoney(3f);

            Messages.Blank_lines();

            //Test for Overdrawable Account
            OverdrawableAccount overdrawableAccount = DataManager.users[1].bankAccount as OverdrawableAccount;
            overdrawableAccount.ShowAccountInformation();

            overdrawableAccount.PutMoney(3.17f);
            overdrawableAccount.WithdrawMoney(4f);
            overdrawableAccount.WithdrawMoney(3f);

            Messages.Blank_lines();

            //Test for Linked Account
            LinkedAccount linkedAccount = DataManager.users[2].bankAccount as LinkedAccount;
            linkedAccount.ShowAccountInformation();

            linkedAccount.PutMoney(3.17f);
            linkedAccount.WithdrawMoney(4f);
            linkedAccount.WithdrawMoney(3f);
        }
    }
}
