using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shurupov21
{
    internal class BuyerInfo : Client
    {
        public string buyerPhoneNumber { get; set; }
        public string buyerEmail { get; set; }
        public string buyerCreditCardNumber { get; set; }
        public BuyerInfo(int id, string name, string surname, string patronymic, DateTime birthday, char gender, int age, string phone, string email, string creditCardNumber)
                     : base(id, name, surname, patronymic, birthday, gender, age)  // параметры передаются в конструктор базового класса, т.е. при вызове конструктора данного класса мы вызовем и заполним поля базового класса Person
        {
            buyerPhoneNumber = phone;
            buyerEmail = email;
            buyerCreditCardNumber = creditCardNumber;
        }
    }
}
