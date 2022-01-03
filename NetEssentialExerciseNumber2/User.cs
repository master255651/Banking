using System;
using System.Collections.Generic;
using System.Text;

namespace NetEssentialExerciseNumber2
{
    class User
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BankAccount bankAccount { get; set; }

        public User(string firstName, string lastName)
        {
            this.IdUser = DataManager.GetMaxIdUser();
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
