using ATM_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_DBL
{
    public class ATMdbl : Baselayer
    {
        public void saveDeposit(ATMbo bdep)
        {
            string text = $"{bdep.balance}";
            saveDep(text, "ATM.csv");
        }
        public void saveFast(ATMbo fbl)
        {
            //string text = $"{fbl.balance}";
            int text = fbl.balance;
            savefast(text, "ATM.csv");
        }
        public void saveNormal(ATMbo fbl)
        {
            string text = $"{fbl.balance}";
           // savefast(text, "ATM.csv");
        }
        public void Create(ATMbo bpin)
        {
           
            string text = $"{bpin.ac_no},{bpin.user},{bpin.pin1} ,{bpin.holder},{bpin.balance},{bpin.status}";
            CreateAccount(text, "ATM.csv");
        }
        public void Login(ATMbo blog)
        {
            string text = $"{blog.user},{blog.pin1}";
           // string text = blog.user;
            //int p = blog.pin1;
            login(text, "ATM.csv");
        }

        public void viewReports()
        {
            viewreport("ATM.csv");
        }

        public void displayBalance(ATMbo dpb)
        {
            string text =$"{ dpb.ac_no}";
            DisplayBal("ATM.csv",text);
        }

        public void deleteACC(ATMbo bdel)
        {
            //string text = $"{bdel.ac_no}";
            int text = bdel.ac_no;
            delete("ATM.csv", text, "Temp.csv");

        }
    }
}
