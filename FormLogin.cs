using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int contador = 0;
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //new FrmPrincipal().Show();
                //this.Hide();
            }
            else
            {
                contador++;
                MessageBox.Show("Has excedido los intentos permitidos.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (contador == 3)
            {
                MessageBox.Show("Has excedido el límite de intentos permitidos.", "Error:", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
