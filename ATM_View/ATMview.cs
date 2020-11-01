using System;
using ATM_BO;
using System.Collections.Generic;
using System.Text;
using ATM_BLL;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace ATM_View
{
    public class ATMview
    {
        public void deposit()
        {
            Console.WriteLine("Please Enter depossit amounnt");
            int i = System.Convert.ToInt32(Console.ReadLine());
            ATMbo bdep = new ATMbo { dep = i };
            ATMbll bll = new ATMbll();
            bll.saveDeposit(bdep);
        }

        /*public void signup()
            {
                Console.WriteLine("----------Sign Up----------");
                Console.WriteLine("Enter Username");
                string username = Console.ReadLine();
                Console.WriteLine(" Enter Pin");
                int pn1 = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Confirm Pin");
                int pn2 = System.Convert.ToInt32(Console.ReadLine());
                ATMbo bpin = new ATMbo { pin1 = pn1, pin2=pn2,user=username };
                ATMbll bll = new ATMbll();
                bll.sign(bpin);
            }*/

        public void login()
        {
            Console.WriteLine("                              --------------------LogIn------------------");
            Console.WriteLine("                        Choose Login as");
            Console.WriteLine("                          1_admin");
            Console.WriteLine("                          2_customer");
            int j = System.Convert.ToInt32(Console.ReadLine());
            if (j == 1)
            {
                Console.Clear();
                Console.WriteLine("username is admin and pin is 12345");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Enter Username");
                Console.ForegroundColor = ConsoleColor.Green;
                string username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Enter pin");
                Console.ForegroundColor = ConsoleColor.Green;
                // int i = System.Convert.ToInt32(Console.ReadLine());
                string i = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                int f;
                for (f = 0; f < 3; f++)
                {
                    if (username == "admin" && i == "12345")
                    {
                        adminDisplay();
                    }
                }
            }
            else if (j == 2)
            {
                Console.Clear();
                Console.WriteLine("username is Ali4 and pin is 7860");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Enter Username");
                Console.ForegroundColor = ConsoleColor.Green;
                string username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please Enter pin");
                Console.ForegroundColor = ConsoleColor.Green;
                //int i = System.Convert.ToInt32(Console.ReadLine());
                string i = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                int f;
                for (f = 0; f < 1; f++)
                {
                    if (username == "Ali4" && i == "7860")
                    {
                        customerDisplay();
                    }
                    else if (username == "ali1" && i == "1001")
                    {
                        customerDisplay();
                    }
                    else if (username == "ali2" && i == "1002")
                    {
                        customerDisplay();
                    }
                    else if (username == "alii" && i == "1234")
                    {
                        customerDisplay();
                    }
                    else
                    {
                        Console.WriteLine("Error occur due to wrong input");
                    }
                }

                // Exception occur in base layer if you run below code
                /* ATMbo blog = new ATMbo { user = username, pin1 = i };
                 ATMbll bll = new ATMbll();
                 bll.login(blog);*/
            }
            else
            {
                Console.WriteLine("You have input invalid value");
            }


        }

        public void adminDisplay()
        {
            Console.Clear();
            Console.WriteLine("                         select your choice");
            Console.WriteLine("                         1_ Create new account");
            Console.WriteLine("                         2_ Delete Existing account");
            Console.WriteLine("                         3_ Update Existing information");
            Console.WriteLine("                         4_ Search for account");
            Console.WriteLine("                         5_ View account");
            Console.WriteLine("                         6_ Exit");
            int i = System.Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case true when (i == 1):
                    Console.Clear();
                    Create();
                    break;
                case true when (i == 2):
                    deleteaccount();
                    break;
                case true when (i == 3):
                    // UpdateAccount();
                    break;
                case true when (i == 4):
                    // SearchAccount();
                    break;
                case true when (i == 5):
                    Console.Clear();
                    viewReports();
                    break;
                case true when (i == 6):
                    Environment.Exit(0);
                    break;
            }


        }

        public void customerDisplay()
        {
            Console.Clear();
            Console.WriteLine("                 select your choice");
            Console.WriteLine("                 1_ Withdraw cash");
            Console.WriteLine("                 2_ Cash trasfer");
            Console.WriteLine("                 3_ Deposit cash");
            Console.WriteLine("                 4_ Display Balance");
            Console.WriteLine("                 5_ Exit");
            int i = System.Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case true when (i == 1):
                    withdraw();
                    break;
                case true when (i == 2):
                    // Transfer();
                    break;
                case true when (i == 3):
                    deposit();
                    break;
                case true when (i == 4):
                    displaybalance();
                    break;
                case true when (i == 5):
                    Environment.Exit(0);
                    break;

            }
        }
        public void Create()
        {

            bool c = false;

            Console.WriteLine("For creating account fill the Following");
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            Console.WriteLine(" Enter pin");
            int i = System.Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter status");
            string stat = Console.ReadLine();
            for (int i1 = 0; i1 < stat.Length; i1++)
            {
                if (stat[i1] >= 'a' && stat[i1] <= 'z' || stat[i1] >= 'A' && stat[i1] <= 'Z' || stat[i1] == ' ')
                {
                    c = true;
                }
                else
                {
                    c = false;
                }

            }


            Console.WriteLine(" Enter balance");
            int b = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter account no");
            int ac = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Holder name");
            string name = Console.ReadLine();
            for (int i1 = 0; i1 < name.Length; i1++)
                {
                    if (name[i1] >= 'a' && name[i1] <= 'z' || name[i1] >= 'A' && name[i1] <= 'Z' || name[i1] == ' ')
                    {
                        c = true;
                    }
                    else
                    {
                        c = false;
                    }

                }

            if (c == false)
            {
                Console.WriteLine("Enter Valid Name");
                name = Console.ReadLine();
            }



            ATMbo bcre = new ATMbo { user = username, pin1 = i, status = stat, balance = b, ac_no = ac, holder = name };
            ATMbll bll = new ATMbll();
            bll.CreateAccount(bcre, "ATM.csv");
        }

        public void viewReports()
        {
            ATMbll bll = new ATMbll();
            bll.viewReports();
        }

        public void deleteaccount()
        {
            Console.WriteLine("Enter Account no which you want to be deleted");
            int i = System.Convert.ToInt32(Console.ReadLine());
            ATMbo bdel = new ATMbo { ac_no = i };
            ATMbll bll = new ATMbll();
            bll.deleteacc(bdel);
        }

        public void withdraw()
        {
            Console.Clear();
            Console.WriteLine("           Choose method of withdrawl");
            Console.WriteLine("           1_ Fast cash");
            Console.WriteLine("           2_ Normal cash");
            int i = System.Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case true when (i == 1):
                    fastcash();
                    break;
                case true when (i == 2):
                    Normal();
                    break;
                case true when (i < 1 && i > 2):
                    Console.WriteLine("Your Input is wrong");
                    break;

            }

        }

        public void fastcash()
        {
            Console.Clear();
            Console.WriteLine("Select the Amount");
            Console.WriteLine("1_500");
            Console.WriteLine("2_1000");
            Console.WriteLine("3_2000");
            Console.WriteLine("4_5000");
            Console.WriteLine("5_10000");
            Console.WriteLine("6_20000");
            int i = System.Convert.ToInt32(Console.ReadLine());
            int b;
            for (int j = 0; j < 1; j++)
            {
                if (i == 1)
                  { b = 500; }
                else if (i == 2)
                    b = 1000;
                else if (i == 3)
                    b = 2000;     
                else if (i == 4)
                    b = 5000;
                else if (i == 5)
                    b = 10000;
                else if (i == 6)
                    b = 20000;
                else
                {
                    Console.WriteLine("Wrong input");
                }

            }
            ATMbo fbl = new ATMbo { dep = i };
            ATMbll bll = new ATMbll();
            bll.fastbal(fbl);


        }
        public void Normal()
        {
            Console.Clear();
            Console.WriteLine("Enter the amount you want to withdraw");
            int i = System.Convert.ToInt32(Console.ReadLine());
            ATMbo Nbl = new ATMbo { dep = i };
            ATMbll bll = new ATMbll();
            bll.fastbal(Nbl);
        }

        public void displaybalance()
        {
            ATMbo dpb = new ATMbo() ;
            ATMbll bll = new ATMbll ();
            bll.displaybal(dpb);
        }

        public void update()
        {
            Console.WriteLine("This Function is not built");
            Environment.Exit(0);
        }
        public void search()
        {
            Console.WriteLine("This Function is not built");
            Environment.Exit(0);
        }
        public void Transfer()
        {
            Console.WriteLine("This Function is not built");
            Environment.Exit(0);
        }
    }
}
