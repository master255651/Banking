using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    interface IBanking
    {
        void PutMoney(float replenishmentAmount);
        bool WithdrawMoney(float withdrawalAmount);
    }
}
