using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class DataManager
    {
        public static List<User> users = new List<User>();
        public static List<BankAccount> bankAccounts = new List<BankAccount>();

        public static int GetMaxIdBankAccount()
        {
            int maxId = 0;

            foreach(BankAccount bankAccount in bankAccounts)
            {
                if (bankAccount.IdAccount > maxId)
                    maxId = bankAccount.IdAccount;
            }

            return maxId + 1;
        }

        public static int GetMaxIdUser()
        {
            int maxId = 0;

            foreach (User user in users)
            {
                if (user.IdUser > maxId)
                    maxId = user.IdUser;
            }

            return maxId + 1;
        }

        public static void AddBasicUsers()
        {
            var iurieStarenco = new User("Iurie", "Starenco");
            users.Add(iurieStarenco);

            var mariaAndreiteva = new User("Maria", "Andreiteva");
            users.Add(mariaAndreiteva);

            var olgaUngureanu = new User("Olga", "Ungureanu");
            users.Add(olgaUngureanu);

            var normalAccount = new NormalAccount(iurieStarenco.IdUser);
            bankAccounts.Add(normalAccount);

            var overdrawableAccount = new OverdrawableAccount(mariaAndreiteva.IdUser);
            bankAccounts.Add(overdrawableAccount);

            var linkedAccount = new LinkedAccount(olgaUngureanu.IdUser);
            bankAccounts.Add(linkedAccount);
        }

        public static User GetUserById(int idUser)
        {
            foreach (User user in DataManager.users)
            {
                if (user.IdUser == idUser)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
