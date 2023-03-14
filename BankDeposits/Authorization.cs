
using System.Windows.Forms.VisualStyles;

namespace BankDeposits
{
    public partial class Authorization : Form
    {
        private List<string> loginPasswordData = new List<string>();
        private GetData connect = new GetData();
        private static string personRole = "";
        Captcha obj = new Captcha();        

        public Authorization()
        {
            InitializeComponent();
            loginInput.MaxLength = 16;
            passwordInput.MaxLength = 16;
            passwordInput.PasswordChar = '*';
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            loginPasswordData = connect.getAllLoginsAndPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            bool enterStatus = false;
            if (loginInput.Text != "" && passwordInput.Text != "")
            {
                for(int i = 0; i < loginPasswordData.Count; i++)
                {
                    if(i % 2 == 0)
                    {
                        if (loginInput.Text == loginPasswordData[i] && passwordInput.Text == loginPasswordData[i + 1])
                        {                            
                            enterStatus = true;
                            personRole = connect.getRole(loginPasswordData[i]);
                            obj.ShowDialog();
                            if(Captcha.status == true)
                            {
                                MessageBox.Show("Вы авторизовались под ролью: " + personRole, "Внимание");
                                Menu menu = new Menu(personRole);
                                this.Hide();
                                menu.ShowDialog();
                                this.Close();
                            }else
                            {
                                loginInput.Text = "";
                                passwordInput.Text = "";
                            }
                        }
                    }
                }
                if(!enterStatus) MessageBox.Show("Вы ввели некорректный логин или пароль !", "Ошибка");
            }
            else
            {        
                MessageBox.Show("Заполните все поля !", "Ошибка");
            }
        }

    }
}
