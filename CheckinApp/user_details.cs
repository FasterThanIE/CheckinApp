using System.Windows.Forms;

namespace CheckinApp
{
    public partial class user_details : Form
    {
        public user_details()
        {
            InitializeComponent();
        }

        private void User_details_Load(object sender, System.EventArgs e)
        {
            UserDetails user = new UserDetails();
            password_input.PasswordChar = '\u25CF';
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            string email = email_input.Text;
            string password = password_input.Text;

            UserDetails UserDetails = new UserDetails();
            UserDetails.AddDetails(email, password);
        }
    }
}
