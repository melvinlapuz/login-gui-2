namespace login_gui_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                cbShowPass.Text = "Hide";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                cbShowPass.Text = "Show";
            }
        }
          private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
               
            }
            else if (txtUsername.Text != "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("INCORRECT USERNAME");
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("INCORRECT PASSWORD");
            }
            else if (txtUsername.Text != "admin" && txtPassword.Text != "admin")
            {
                MessageBox.Show("INCORRECT USERNAME AND PASSWORD");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    
    }
}
