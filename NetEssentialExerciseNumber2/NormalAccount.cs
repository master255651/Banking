using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class NormalAccount : BankAccount, IBanking
    {
        public NormalAccount(int idOwner)
            : base(idOwner)
        {
            
        }

        public void PutMoney(float replenishmentAmount)
        {
            this.CurrentAmount += replenishmentAmount;
            Messages.Info_ReplenishmentNotification(replenishmentAmount, this.CurrentAmount);
        }

        public bool WithdrawMoney(float withdrawalAmount)
        {
            bool success;

            if (this.CurrentAmount >= withdrawalAmount)
            {
                this.CurrentAmount -= withdrawalAmount;
                success = true;
                Messages.Info_WithdrawingNotification(withdrawalAmount, this.CurrentAmount);
            }
            else
            {
                success = false;
                Messages.Error_NegativeAmount();
            }

            return success;
        }
    }
}
