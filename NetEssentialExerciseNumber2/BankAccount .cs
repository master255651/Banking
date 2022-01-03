using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    abstract class BankAccount
    {
        public int IdAccount { get; set; }
        public int IdOwner { get; set; }
        public float CurrentAmount { get; set; }

        public BankAccount(int idOwner)
        {
            this.IdAccount = DataManager.GetMaxIdBankAccount();
            this.IdOwner = idOwner;
            this.CurrentAmount = 0;

            DataManager.GetUserById(idOwner).bankAccount = this;
        }

        public void ShowAccountInformation()
        {
            Messages.Info_AccountInformation(this.CurrentAmount);
        }
    }
}
