using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM取款机
{
    public class LocalCard : BankCard
    {
        public LocalCard() { }
        public LocalCard(string id, string password, double levelMoney, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Password = password;
            this.levelMoney = levelMoney;
        }
        public override double Bank(double mom)
        {
            double money = levelMoney - mom;
            return money;
        }
    }
}
