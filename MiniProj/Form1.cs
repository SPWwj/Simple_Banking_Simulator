using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniProj
{
    public partial class Form1 : Form 
    {
        private void enTranf()
        {
            panelTranf.Visible = true;
            panelTranf.Enabled = true;
        }
        private void disTranf()
        {
            panelTranf.Visible = false;
            panelTranf.Enabled = false;
        }

        private void enKeypad()
        {
            panelKeypad.Visible = true;
            panelKeypad.Enabled = true;
        }
        private void disKeypad()
        {
            panelKeypad.Visible = false;
            panelKeypad.Enabled = false;
        }
        private void enLogin()
        {
            panelLogin.Visible = true;
            panelLogin.Enabled = true;
        }

        private void disLogin()
        {
            panelLogin.Visible = false;
            panelLogin.Enabled = false;
        }

        private string title = "";
        private string print = "";
        private string tempString="";
        private int inputValue = 0;
        private string countString = "";
        private string tempAcc;
        private string tempPin;
        Customer[] cList = new Customer[10];
  

        int totalMember = 0;

        public void updateTotalCustomer()
        {
            totalMember = 0;
            foreach (var x in cList)
            {
                if (x == null) break;
                totalMember++;
            }
        }

        public void userAcc(string regno,string regname,double regdepo,string regpin,char typein  )
        {
            if(typein=='N')
            cList[totalMember] = new Customer(regno, regname, regdepo, regpin);
            else cList[totalMember] = new SpecialCustomer(regno, regname, regdepo, regpin);
        }

        public bool validAcc()
        {
            if (cList[i].isAccValid(txtRegAccNo.Text))
            {
                string cAcc = txtRegAccNo.Text;
                int k = 0;
                while (k < totalMember)
                {
                    if (cList[k].cAccount == cAcc)
                        return false;
                    k++;
                }
                return true;
            }
            else { return false; }
        }

        public void readfile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Acc.txt"))
                {
                    string fLine = "";
                    string[] accItems = new string[5];
                    // Read the stream to a string, and write the string to the console.
                    do
                    {
                        fLine = sr.ReadLine();
                        accItems = fLine.Split(' ');
                        userAcc(accItems[1], accItems[3],Convert.ToDouble(accItems[4]),accItems[2],Convert.ToChar(accItems[0]));
                        updateTotalCustomer();
                    } while (!sr.EndOfStream);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }

        public void write2File()
        {
            string writeString="";
            string wLineString="";
            char wtype;
            for (int n = 2; n < 10; n++)
            {
                if (cList[n] != null)
                {
                    Console.WriteLine(cList[n]);
                    if (cList[n].printOD() != null) wtype = 'S';
                    else wtype = 'N';
                    wLineString = string.Format("{0} {1} {2} {3} {4}\n", wtype, cList[n].cAccount, cList[n].cPin, cList[n].cName, cList[n].cBalance);
                    writeString += wLineString;
                }
               
            }
            Console.WriteLine(writeString);
            File.WriteAllText("Acc.txt", writeString);
        }

        int i = 0;
       

        public Form1() 
        {
            
            InitializeComponent();
            cbAccType.Items.Add("Normal");
            cbAccType.Items.Add("Special");
            cbAccType.SelectedIndex = 0;
            enLogin();
            disKeypad();
            disTranf();
            cList[0] = new Customer("222222", "Jack", 1999,"222222");
            cList[1] = new SpecialCustomer("333333", "Lack", 2000,"333333");
            updateTotalCustomer();
            readfile();
            foreach (var h in cList) { if (h != null) Console.WriteLine("{0} {1} {2} {3}", h.cName, h.cAccount, h.cPin, h.cBalance); }
    

        }
        public void ODColor()
        {
            if (cList[i].printOD() != null)
            {
                btnOverdraft.BackColor = Color.Green;
            }
            else btnOverdraft.BackColor = Color.Gray;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int j=0;
                tempAcc = txtAccNo.Text;
                tempPin = txtAccPin.Text;
                while (j<totalMember)
                 {
                     if (cList[j].cPin == tempPin && cList[j].cAccount == tempAcc)
                     {
                         i = j;
                         break;
                     }
                     j++;
                     Console.WriteLine(j);
                 }
                
                if (txtAccNo.Text== "Admin" && txtAccPin.Text == "password")
                {
                    Form2 admin = new Form2();
                    admin.Show(this);
                    this.Hide();
                }
                else if (j == totalMember) { MessageBox.Show("Incorrent Password or Username!"); }
                else
                {
                    disLogin();
                    enKeypad();
                    groupKeyPad.Enabled = false;
                    ODColor();
                    print=string.Format("Welcome! Mr/Mdm {0}", cList[i].cName);
                    labelKeypad.Text = print;
                }
            }
            catch { MessageBox.Show("Invalid input"); }

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            enLogin();
            disKeypad();    
            
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            title = "Balence";
            print = string.Format("\t\t{0}\nDear Mr/Mdm {3}\nYour Balance is : {1:c}\n{2}", title, cList[i].cBalance,cList[i].printOD(),cList[i].cName);
            labelKeypad.Text = (print);
            countString = print;
            groupKeyPad.Enabled = false;
            

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            title = "Withdraw";
            print = string.Format("{0}\nEnter the amount you want to withdraw : ", title);
            labelKeypad.Text = (print);
            countString = print;
            groupKeyPad.Enabled = true;

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            title = "Deposit";
            print = string.Format("{0}\nEnter the amount you want to deposit : ", title);
            labelKeypad.Text = (print);
            countString = print;
            groupKeyPad.Enabled = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}",tempString,1);
            labelKeypad.Text = (print);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 2);
            labelKeypad.Text = (print);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            tempString = print.Remove(0, countString.Length);
            inputValue = Convert.ToInt32(tempString);
     
            if (title == "Withdraw")
            {
                if (inputValue <= (cList[i].cBalance+2000) && cList[i].WithdrawBal(inputValue))
                {
                    groupKeyPad.Enabled = false;
                    tempString = labelKeypad.Text;
                    print = string.Format("{0}\nWithdraw Succee! Your New Balance is :${1:f2}\n{2}\nPress Any Operation Key", tempString, cList[i].cBalance,cList[i].printOD());
                    labelKeypad.Text = (print);
                  
                }
                else
                {
                    MessageBox.Show("Error! you do not have enough Money");
                }
            }
            else if (title == "Deposit")
            {
                cList[i].DepositBal(inputValue);
                groupKeyPad.Enabled = false;
                tempString = labelKeypad.Text;
                print = string.Format("{0}\nDeposit Succee! Your New Balance is :${1:f2}\nPress Any Operation Key\n{2}\n", tempString, cList[i].cBalance,cList[i].printOD());
                labelKeypad.Text = (print);
            }
            write2File();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labelKeypad.Text = (countString);
            inputValue = 0;
       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            print = print.Remove(labelKeypad.Text.Length-1);
            labelKeypad.Text = (print);
        }

        private void btnOverdraft_Click(object sender, EventArgs e)
        {
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 3);
            labelKeypad.Text = (print);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 4);
            labelKeypad.Text = (print);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString,5);
            labelKeypad.Text = (print);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 6);
            labelKeypad.Text = (print);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 7);
            labelKeypad.Text = (print);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString, 8);
            labelKeypad.Text = (print);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString,9);
            labelKeypad.Text = (print);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tempString = labelKeypad.Text;
            print = string.Format("{0}{1}", tempString,0);
            labelKeypad.Text = (print);
        }

        private void comboAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            title = "Monthly Interest";
            print = string.Format("\t\t{0}\nYour Monthly Interest is : {1:c}", title, cList[i].CalculateInterest());

            labelKeypad.Text = (print);
            countString = print;
            groupKeyPad.Enabled = false;
        }

        private void btnRegClear_Click(object sender, EventArgs e)
        {
            txtRegAccDeposit.Text = "";
            txtRegAccNo.Text = "";
            txtRegPin.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string regNo, regPin;
            double regDepo;
            string regName;
            char type ='N';
            if (totalMember < 10 && validAcc())
            {
                regNo = txtRegAccNo.Text;
                regPin = txtRegPin.Text;
                regDepo = Convert.ToDouble(txtRegAccDeposit.Text);
                regName = txtRegAccName.Text;
                if (this.cbAccType.SelectedIndex == 0) type = 'N';
                else type = 'S';

                userAcc(regNo,regName,regDepo,regPin,type);
                updateTotalCustomer();
                MessageBox.Show("Your Account have been Successfully created !");
                write2File();
                foreach (var h in cList) { if (h != null) Console.WriteLine("{0} {1} {2} {3}", h.cName,h.cAccount,h.cPin,h.cBalance); }

            }
            else MessageBox.Show("Unable to create account");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default Customer Normal\n Account Number : 222222 \n Account Name : Jack \n Account Balance : 1999 \n Account Pin : 222222\n\nDefault Customer Special\n Account Number : 333333 \n Account Name : Lack \n Account Balance : 2000 \n Account Pin : 333333\n\nYou can create new customer your our Registry System" );
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            enTranf();
            //disKeypad();
          

        }

        private void btnPTClose_Click(object sender, EventArgs e)
        {
            //enKeypad();
            disTranf();
        }

        private void btnPTConfirm_Click(object sender, EventArgs e)
        {
            string tranfAcc;
            try
            {
                int tranfIndex=0;
                int ti=0;
                tranfAcc = txtTranfNo.Text;
                while (ti < totalMember)
                {
                    if (cList[ti].cAccount == txtTranfNo.Text)
                    {
                        tranfIndex = ti;
                        break;
                    }
                    ti++;
                    Console.WriteLine(ti);
                }
                if (ti == totalMember) { MessageBox.Show("Incorrent Account"); }
                else
                {
                    if (cList[i].WithdrawBal(Convert.ToDouble(txtTranfAmount.Text)))
                    {
                        cList[tranfIndex].DepositBal(Convert.ToDouble(txtTranfAmount.Text));
                        MessageBox.Show("Transfer Succeed");
                        write2File();
                    }
                    else MessageBox.Show("Transfer Fail");
                

                }
            }
            catch { MessageBox.Show("Invalid input"); }
        }
    }
}
