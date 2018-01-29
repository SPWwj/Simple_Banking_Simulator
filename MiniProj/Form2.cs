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

    public partial class Form2 : Form
    {
        Customer[] cList = new Customer[10];


        int totalMember = 0;

        public void updateTotalCustomer()
        {
            totalMember = 0;
            foreach (var x in cList)
            {
                if (x != null) 
                totalMember++;
            }
        }

        public void write2File()
        {
            string writeString = "";
            string wLineString = "";
            char wtype;
            for (int n = 0; n < 10; n++)
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

        public void userAcc(string regno, string regname, double regdepo, string regpin, char typein)
        {
            if (typein == 'N')
                cList[totalMember] = new Customer(regno, regname, regdepo, regpin);
            else cList[totalMember] = new SpecialCustomer(regno, regname, regdepo, regpin);
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
                        userAcc(accItems[1], accItems[3], Convert.ToDouble(accItems[4]), accItems[2], Convert.ToChar(accItems[0]));
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



        private void readTable()
        {
            DataTable table = new DataTable();
            dataGridView1.ReadOnly = true;
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Account Number", typeof(string));
            table.Columns.Add("Account PIN", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Account Balance", typeof(double));
            int j = 1;
            for (int i = 0; i < 10; i++)
            {
                if (cList[i] != null)
                {
                    
                    table.Rows.Add(j, cList[i].cAccount, cList[i].cPin, cList[i].cName, cList[i].cBalance);
                    j++;
                }
            }

            dataGridView1.DataSource = table;
        }
        public Form2()
        {
            InitializeComponent();
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            readfile();
            updateTotalCustomer();
            readTable();
            
        }

        private void btnF2Close_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnF2Delete_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt16(dataGridView1.SelectedCells[0].Value)-1;
            Console.WriteLine(dataGridView1.SelectedCells[0].Value);
            cList[x] = null;
            updateTotalCustomer();
            dataGridView1.DataSource = null;
            readTable();
            write2File();
        }
    }
}
