using Logic;
using Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UserInterface;

namespace UserInterface
{
    public partial class LoginForm : Form
    {
        Employee_Service employeeService = new Employee_Service();
        Employee currentEmployee;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            int exitCode = Environment.ExitCode;
            Environment.Exit(exitCode);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUser.Text;
            password = txtPass.Text;
            currentEmployee = employeeService.GetByUsername(username);

            if (username == currentEmployee.Username && password == currentEmployee.Password)
            {
                Hide();
                HomeScreen homeScreen = new HomeScreen(currentEmployee);
                homeScreen.ShowDialog();
            }
            else
                MessageBox.Show("Failure to verify, please check username or password.");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
// list.Add