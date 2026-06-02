using System;
using System.Windows.Forms;
using MediaTek86.controller;

namespace MediaTek86.vue
{
    
    public partial class FrmConnexion : Form
    {
        
        private readonly PersonnelController controller;

        
        public FrmConnexion()
        {
            InitializeComponent();
            controller = new PersonnelController();
        }

        
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals("") || txtPwd.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs manquants",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (controller.VerifConnexion(txtLogin.Text, txtPwd.Text))
            {
                FrmPersonnel frmPersonnel = new FrmPersonnel();
                frmPersonnel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect.", "Erreur de connexion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Text = "";
                txtLogin.Focus();
            }
        }
    }
}