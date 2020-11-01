using ATM_BO;
using ATM_DBL;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace ATM_BLL
{
   public class ATMbll
    {
        public void saveDeposit(ATMbo bdep)
        {
            if (bdep.dep!=0)
            {
                bdep.balance = bdep.balance + bdep.dep;
                ATMdbl dal = new ATMdbl();
                dal.saveDeposit(bdep);
            }
            else
            {
                Console.WriteLine("You have not deposited money");
            }
            
        }
       /* public void sign(ATMbo bpin)
        {
           if(bpin.pin1==bpin.pin2)
            {
                ATMdbl dal = new ATMdbl();
                dal.signup(bpin);
                Console.WriteLine("Your Account Has Been Successfully Created!");
                
            }
           else
            {
                Console.WriteLine("Your Pin is not matched with confirmed pin!");
            }
        }*/

        
        
            public void CreateAccount(ATMbo bcre, string filename)
            {
                string login = bcre.log;
                int pin = bcre.pin1;
                string name = bcre.holder;
                int accountno = bcre.ac_no;
                int balance = bcre.balance;
                string stat = bcre.status;

                   ATMdbl dal = new ATMdbl();
                     dal.Create(bcre);

             }

        public void login(ATMbo blog)
        {

             string username = blog.user;
              int pin = blog.pin1;
             /* while ((blog.user!= null) || (blog.pin1 != 0))
              {
                  if( blog.log==login &&blog.pin1 =pin )
                  {

                  }
                  else 
                  {
                      Console.WriteLine("Your username or pin is wrong");
                  }
              }*/
            ATMdbl dal = new ATMdbl();
            dal.Login(blog);
        }
        public void viewReports()
        {
            ATMdbl dal = new ATMdbl();
            dal.viewReports();
        }

        public void deleteacc(ATMbo bdel)
        {
            int line_to_delete = bdel.ac_no;
            DeleteDirectoryOption.ThrowIfDirectoryNonEmpty.CompareTo(line_to_delete);
            while (bdel.ac_no >0)
            {
                if (bdel.ac_no == line_to_delete)
                { ATMdbl dal = new ATMdbl();
                    dal.deleteACC(bdel);
                }
                else
                {
                    Console.WriteLine("Your Input wrong ");
                }
            }
          
        }

        public void fastbal(ATMbo fbl)
        {
          
            if (fbl.dep !=0)
            {
                fbl.balance = fbl.balance - fbl.dep;
                ATMdbl dal = new ATMdbl();
                dal.saveFast(fbl);
            }
            else
            {
                Console.WriteLine("You have not that much balance");
            }
        }

        public void normaltbal(ATMbo fbl)
        {

            if (fbl.dep != 0)
            {
                fbl.balance = fbl.balance - fbl.dep;
                ATMdbl dal = new ATMdbl();
                dal.saveNormal(fbl);
            }
            else
            {
                Console.WriteLine("You have not that much balance");
            }
        }

        public void displaybal(ATMbo dpb)
        {
            ATMdbl dal = new ATMdbl();
            dal.displayBalance(dpb);
        }

    }
}
