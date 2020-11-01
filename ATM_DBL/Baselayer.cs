using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ATM_DBL
{
   public class Baselayer
    {
        public void saveDep(string text, string filename)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, filename);
            StreamWriter sdep = new StreamWriter(filepath, append:true);
            sdep.WriteLine(text);
            sdep.Close();


        }
        public void savefast(int text, string filename)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, filename);
            StreamWriter sdep = new StreamWriter(filepath, append: true);
            using (TextWriter tw = new StreamWriter(filepath, true))
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath))
                    {
                        tw.WriteLine(text);
                    }
                }catch(Exception e)
                {
                    throw new ApplicationException("", e);
                }
            }
            sdep.Close();
            Console.WriteLine("You have successfully withdrawn the money");

        }

        public void CreateAccount(string text, string filename)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, filename);
            StreamWriter spin = new StreamWriter(filepath, append: true);
            spin.WriteLine(text);
            spin.Close();

        }
        public void login(string text,string filename)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, filename);
            StreamReader slog = new StreamReader(filepath);
          

            string[] LoginCredentials = File.ReadAllLines(filepath);
            for (int i = 0; i < LoginCredentials.Length; i++)
            {
                string[] Credential = LoginCredentials[i].Split(' ');
                if (text == Credential[0] && text == Credential[1])
                {
                    try
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath))
                        { Console.WriteLine("username and password match", filepath); }
                    }
                    catch(Exception e)
                    {
                        throw new ApplicationException("",e);
                    }
                }
                else
                {
                    Console.WriteLine("Login Failed: invaild username or password");
                    throw new Exception();
                }
            }

           
            /*string path2 = "C:\\Files\\audit.txt";
            using (StreamWriter sw2 = File.AppendText(path2))
            {
                sw2.WriteLine("Login Failed: Invaild username or password");
            }*/
            
            slog.Close();
        }
        public void viewreport(string filename)
        {
            String line;
            try
            {
                string filepath = Path.Combine(Environment.CurrentDirectory, filename);
                StreamReader sr = new StreamReader(filepath);
                line = sr.ReadLine();
                
                while (line != null)
                {
                  
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public void delete(string filename, int text , string filename1)
        {
            string filepath = Path.Combine(Environment.CurrentDirectory, filename);
            StreamReader sr = new StreamReader(filepath);

            string Temppath = Path.Combine(Environment.CurrentDirectory, filename1);
            StreamReader srw = new StreamReader(filepath);
           
            try
            {
                string[] line = System.IO.File.ReadAllLines(filepath);
                for(int f =0;f<line.Length;f++)
                {
                    string[] field = line[f].Split();
                    int ac = int.Parse(field[0]);
                    if (ac != text)
                    {
                        int accn = int.Parse(field[0]);
                        try
                        {
                            using(System.IO.StreamWriter file = new System.IO.StreamWriter(Temppath , true))
                            {
                                file.WriteLine(accn);
                            }
                        }
                        catch(Exception e)
                        {
                            throw new ApplicationException("Exception occur:",e);
                        }
                    }
                }
                File.Delete(filepath);
                System.IO.File.Move(Temppath, filepath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DisplayBal(string filename, string text)
        {
            String line;
            try
            {
                string filepath = Path.Combine(Environment.CurrentDirectory, filename);
                StreamReader sr = new StreamReader(filepath);
                line = sr.ReadLine();
               // while (line != null)
               // {
                    if (line == text)
                    {
                      Console.WriteLine(line);
                    line = sr.ReadLine();
                    }
                Console.WriteLine("Balnce is :", line);
                //}
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
    
}
