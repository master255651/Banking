using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class OverdrawableAccount : BankAccount, IBanking
    {
        public OverdrawableAccount(int idOwner)
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
            bool balanceMinus;
            this.CurrentAmount -= withdrawalAmount;

            Messages.Info_WithdrawingNotification(withdrawalAmount, this.CurrentAmount);

            if(this.CurrentAmount < 0)
            {
                balanceMinus = false;
                Messages.Warning_NegativeAmount(this.CurrentAmount);
            }
            else
            {
                balanceMinus = true;
            }
            return balanceMinus;
        }
    }
}
