using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingFileText1
{
    public partial class FrmRegistration : Form
    {
        public static string SetFileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            long getStudentNo = Convert.ToInt64(textBox1.Text);
            long getContactNo = Convert.ToInt64(textBox6.Text);
            int getAge = Convert.ToInt32(textBox5.Text);
            String getProgram = comboBox1.Text;
            String getLastName = textBox2.Text;
            String getFirstName = textBox3.Text;
            String getMiddleinitial = textBox4.Text;
            String getGender = comboBox2.Text;
            String getBirthday = dateTimePicker1.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No.: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + ", " + getMiddleinitial);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContactNo);

                Console.WriteLine(getStudentNo);
                Console.WriteLine(getLastName, getFirstName, getMiddleinitial);
                Console.WriteLine(getProgram);
                Console.WriteLine(getGender);
                Console.WriteLine(getAge);
                Console.WriteLine(getBirthday);
                Console.WriteLine(getContactNo);
            }
        }
    }
}
