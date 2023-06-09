﻿
namespace BankDeposits
{
    public partial class Role : Form
    {
        PrintTables printTable = new PrintTables();
        public Role()
        {
            InitializeComponent();
            printTable.Init(dataGridView1, 6, Menu.personRole, addButton, deleteButton, saveButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printTable.backButton(6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printTable.forwardButton(6);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            printTable.addButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            printTable.saveButton("Select * From Role", 6);
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить запись ?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                printTable.deleteButton(dataGridView1);
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printTable.searchButton(textBox1, textBox2, dataGridView1);
        }
    }
}
