using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class LinkedAccount : BankAccount, IBanking
    {
        List<float> linkedAccounts;

        public LinkedAccount(int idOwner)
            : base(idOwner)
        {
            this.linkedAccounts = new List<float>();

            TestAccounts();
            RecalculationAmount();
        }

        private void TestAccounts()
        {
            this.linkedAccounts.Add(0f);
            this.linkedAccounts.Add(-7.38f);
            this.linkedAccounts.Add(12.5f);
        }

        private void RecalculationAmount()
        {
            this.CurrentAmount = SumAccountAmount();
        }

        private float SumAccountAmount()
        {
            float sumAmount = 0f;

            foreach (float amount in linkedAccounts)
            {
                sumAmount += amount;
            }

            return sumAmount;
        }

        private int IndexOfMaxAccountAmount()
        {
            float maxAmount = linkedAccounts[0];

            foreach(float amount in linkedAccounts)
            {
                if(amount > maxAmount)
                {
                    maxAmount = amount;
                }
            }

            return linkedAccounts.IndexOf(maxAmount);
        }

        private int IndexOfMinAccountAmount()
        {
            float minAmount = linkedAccounts[0];

            foreach (float amount in linkedAccounts)
            {
                if (amount < minAmount)
                {
                    minAmount = amount;
                }
            }

            return linkedAccounts.IndexOf(minAmount);
        }

        public void PutMoney(float replenishmentAmount)
        {
            this.linkedAccounts[IndexOfMinAccountAmount()] += replenishmentAmount;
            RecalculationAmount();
            Messages.Info_ReplenishmentNotification(replenishmentAmount, this.CurrentAmount);
        }

        public bool WithdrawMoney(float withdrawalAmount)
        {
            bool balanceMinus;
            this.linkedAccounts[IndexOfMaxAccountAmount()] -= withdrawalAmount;
            RecalculationAmount();

            Messages.Info_WithdrawingNotification(withdrawalAmount, this.CurrentAmount);

            if (this.CurrentAmount < 0)
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
