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
using System.Configuration;

namespace PasswordManager
{
    public partial class Form3 : Form
    {
        
        private BindingList<string> PasswordList = new BindingList<string>();
        public Form3()
        {
            InitializeComponent();
            listBox1.DataSource = PasswordList;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PasswordList.Add(txt_newPassword.Text);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllLines("C:\\Users\\Joshg\\Desktop\\Passwords.txt", listBox1.Items.Cast<string>().ToArray());
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\\Users\\Joshg\\Desktop\\Passwords.txt");

            foreach (string line in lines) //iterates through every string inside of the array
            {
                PasswordList.Add(line);
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_newPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
