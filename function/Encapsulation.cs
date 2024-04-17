using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    public class Bank
    {
        int acctblan = 199000;
        string name = "rohan";
        int acctnum = 1232;

        public void setblanc(int setblac , string Name ,int Acctnum)
        {
            acctblan = setblac;
            name = Name;
            acctnum = Acctnum;
        }

        public void getblanc()
        {
            Console.WriteLine($"your current balance is {acctblan} \n your name is {name} \n your account number is {acctnum}");
        }
    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.setblanc(20200 , "yousuf" ,12321);
            bank.getblanc();
        }
    }
}
