using gestionCommerciale.Models;
using gestionCommerciale.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionCommerciale
{
    public partial class login : Form
    {
        private UserRepository userRepository;
        public login()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = email.Text;
            string upassword = password.Text;
            bool credentialsValid = userRepository.CheckCredentials(username, upassword);

            if (credentialsValid)
            {
                page_principale form2 = new page_principale();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Identifiants invalides. Veuillez réessayer.");
            }
        }
    }
}
