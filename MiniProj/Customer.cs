using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProj
{
    class Customer
    {
        protected int custAccount;
        protected string custName;
        protected double amtBalance;
        protected int cusPin;

        public int cAccount
        {
            get { return custAccount; }
        }
        public string cName
        {
            get { return custName; }
        }
        public double cBalance
        {
            get { return amtBalance; }
        }
        public double cPin
        {
            get { return cusPin; }
        }
        public Customer()
        {
            //testing init
            custAccount = 666666; custName = "Peter"; amtBalance =500; cusPin = 666666;
        }
        public Customer(int acc, string cname, double cbalance,int cpin) 
        {
            custAccount = acc; custName = cname; amtBalance = cbalance; cusPin = cpin;
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
            if (withdraw <= amtBalance)
            {
               
                amtBalance -= withdraw;
                return true;
            }
            else return false; ;
        }
        public virtual void DepositBal(double deposit)
        {
            amtBalance += deposit;
        }
        public double CalculateInterest()
        {
            double monthlyInterest;
            if (amtBalance < 3000)
            {
                monthlyInterest = amtBalance * 0.025 / 12;
            }
            else
            {
                monthlyInterest = 3000 * 0.025 / 12 + (amtBalance - 3000) * 0.035 / 12;
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
        public SpecialCustomer(int acc, string cname, double cbalance, int cpin) : base(acc, cname, cbalance,cpin)
        {
            overdraft = 2000;   
        }

        public override bool WithdrawBal(double withdraw)
        {
            tempValue = amtBalance - withdraw;
            if (tempValue < 0)
            {
                amtBalance = 0;
                overdraft += tempValue;
            }
            else { amtBalance -= withdraw; Console.WriteLine("Else{0}", amtBalance); }
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
                    amtBalance += (tempValue - overdraft);
                }
                else overdraft += deposit;
                    
            }
            else amtBalance += deposit;
        }
        public override string printOD()
        {
            return string.Format("Your overdraft is : {0} ", overdraft);
        }
    }

 


}


