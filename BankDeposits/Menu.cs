
namespace BankDeposits
{
    public partial class Menu : Form
    {
        public static string personRole = "";
        
        public Menu(string role)
        {
            InitializeComponent();
            personRole = role;  
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            role.Text = personRole;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            this.Hide();
            client.ShowDialog();
            this.Show();
            
        }

        private void счетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            this.Hide();
            account.ShowDialog();
            this.Show();
        }

        private void депозитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.ShowDialog();
            this.Show();
        }

        private void типыПроцентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interest_type interestType = new Interest_type();
            this.Hide();
            interestType.ShowDialog();
            this.Show();
        }

        private void ролиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            this.Hide();
            role.ShowDialog();
            this.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            this.Hide();
            person.ShowDialog();
            this.Show();
        }
    }
}
