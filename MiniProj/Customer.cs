using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProj
{
    class Customer
    {
        protected string custAccount;
        protected string custName;
        protected double amtBalance;
        protected string cusPin;

        public string cAccount
        {
            get { return custAccount; }
            set { custAccount = value; }
        }
        public string cName
        {
            get { return custName; }
            set { custName = value ; }
        }
        public double cBalance
        {
            get { return amtBalance; }
            set { amtBalance = value; }
        }
        public string cPin
        {
            get { return cusPin; }
            set { cusPin = value; }
        }
        public Customer()
        {
            //testing init
            cAccount = "666666"; cName = "Peter"; cBalance =500; cPin = "666666";
        }
        public Customer(string acc, string cname, double cbalance,string cpin) 
        {
            cAccount = acc; cName = cname; cBalance = cbalance; cPin = cpin;
        }

        public bool isAccValid (string accCheck)
        {
            
            int result;
            if (int.TryParse(accCheck, out result) && accCheck.Length==6)
            {
                return true;
            }
            else
            {
                return false;//not an int
            }
        }

        public virtual bool WithdrawBal(double withdraw)
        {
            if (withdraw <= cBalance)
            {
               
                cBalance -= withdraw;
                return true;
            }
            else return false; ;
        }
        public virtual void DepositBal(double deposit)
        {
            cBalance += deposit;
        }
        public double CalculateInterest()
        {
            double monthlyInterest;
            if (cBalance < 3000)
            {
                monthlyInterest = cBalance * 0.025 / 12;
            }
            else
            {
                monthlyInterest = 3000 * 0.025 / 12 + (cBalance - 3000) * 0.035 / 12;
            }
            return monthlyInterest;
        }
        public virtual string printOD()
        {
            return null;
        }
     
    }

    class SpecialCustomer : Customer
    {
        private double overdraft=0;
        private double tempValue = 0;
        public SpecialCustomer(string acc, string cname, double cbalance, string cpin) : base(acc, cname, cbalance,cpin)
        {
            overdraft = 2000;   
        }

        public override bool WithdrawBal(double withdraw)
        {
            tempValue = cBalance - withdraw;
            if (tempValue < 0)
            {
                cBalance = 0;
                overdraft += tempValue;
            }
            else { cBalance -= withdraw; Console.WriteLine("Else{0}", cBalance); }
            return true;
        }
        public override void DepositBal(double deposit)
        {
            if(overdraft!=2000)
            {
                tempValue = deposit + overdraft;
                if (tempValue > 2000)
                {
                    overdraft = 2000;
                    cBalance += (tempValue - overdraft);
                }
                else overdraft += deposit;
                    
            }
            else cBalance += deposit;
        }
        public override string printOD()
        {
            return string.Format("Your overdraft is : {0} ", overdraft);
        }
    }

 


}


