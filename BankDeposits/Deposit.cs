
namespace BankDeposits
{
    public partial class Deposit : Form
    {
        PrintTables printTable = new PrintTables();
        public Deposit()
        {
            InitializeComponent();
            printTable.Init(depositGrid, 3, Menu.personRole, addButton, deleteButton, saveButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printTable.backButton(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printTable.forwardButton(3);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            printTable.addButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            printTable.saveButton("Select * From Deposit", 3);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {           
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить запись ?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                printTable.deleteButton(depositGrid);
            }
            else
            {
                return;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            printTable.searchButton(textBox1, textBox2, depositGrid);
        }
    }
}
