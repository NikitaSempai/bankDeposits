
namespace BankDeposits
{
    public partial class Interest_type : Form
    {
        PrintTables printTable = new PrintTables();
        public Interest_type()
        {
            InitializeComponent();
            printTable.Init(interestTypeTable, 4, Menu.personRole, addButton, deleteButton, saveButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printTable.backButton(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printTable.forwardButton(4);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            printTable.addButton();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            printTable.deleteButton(interestTypeTable);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            printTable.saveButton("Select * From Interest_Type", 4);
        }
    }
}
