using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposits
{
    public partial class Account : Form
    {
        PrintTables printTable = new PrintTables();
        public Account()
        {
            InitializeComponent();
            printTable.Init(accountTable, 2, Menu.personRole, addButton, deleteButton, saveButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printTable.backButton(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printTable.forwardButton(2);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            printTable.addButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            printTable.saveButton("Select * From Account", 2);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить запись ?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                printTable.deleteButton(accountTable);
            } else
            {
                return;
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printTable.searchButton(textBox1, textBox2, accountTable);
        }
    }
}
