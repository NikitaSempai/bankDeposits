
namespace BankDeposits
{
    public partial class Client : Form
    {
        PrintTables printTable = new PrintTables();
        public Client()
        {
            InitializeComponent();            
            printTable.Init(clientTable, 1, Menu.personRole, addButton, deleteButton, saveButton);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printTable.forwardButton(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printTable.backButton(1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            printTable.addButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            printTable.saveButton("Select * From Client", 1);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            printTable.deleteButton(clientTable);
        }
    }
}
