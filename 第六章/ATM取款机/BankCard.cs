using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM取款机
{
    public class BankCard
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ID { get; set; }
        public double levelMoney { get; set; }

        public virtual double Bank(double mom)
        {
            double money = levelMoney - mom;
            return money;
        }
    }
}
