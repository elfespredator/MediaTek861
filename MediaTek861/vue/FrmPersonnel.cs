using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86.vue
{
    
    public partial class FrmPersonnel : Form
    {
        
        private readonly PersonnelController controller;

        
        private List<Personnel> listePersonnel;

       
        private string mode;

       
        private Personnel personnelSelectionne;

        
        public FrmPersonnel()
        {
            InitializeComponent();
            controller = new PersonnelController();
            ChargerPersonnel();
        }

        
        private void ChargerPersonnel()
        {
            listePersonnel = controller.GetAllPersonnel();
            dgvPersonnel.Rows.Clear();
            dgvPersonnel.Columns.Clear();
            dgvPersonnel.Columns.Add("colNom", "Nom");
            dgvPersonnel.Columns.Add("colPrenom", "Prénom");
            dgvPersonnel.Columns.Add("colTel", "Téléphone");
            dgvPersonnel.Columns.Add("colMail", "Mail");
            dgvPersonnel.Columns.Add("colService", "Service");
            foreach (Personnel p in listePersonnel)
            {
                dgvPersonnel.Rows.Add(p.Nom, p.Prenom, p.Tel, p.Mail, p.Service.Nom);
            }
        }

        
        private void ChargerServices()
        {
            cbService.Items.Clear();
            List<Service> services = controller.GetAllServices();
            foreach (Service s in services)
            {
                cbService.Items.Add(s);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";
            ChargerServices();
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cbService.SelectedIndex = -1;
            grpSaisie.Visible = true;
            this.ClientSize = new System.Drawing.Size(676, 640);
            txtNom.Focus();
        }

        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.", "Aucune sélection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            mode = "modif";
            int index = dgvPersonnel.SelectedRows[0].Index;
            personnelSelectionne = listePersonnel[index];
            ChargerServices();
            txtNom.Text = personnelSelectionne.Nom;
            txtPrenom.Text = personnelSelectionne.Prenom;
            txtTel.Text = personnelSelectionne.Tel;
            txtMail.Text = personnelSelectionne.Mail;
            
            for (int i = 0; i < cbService.Items.Count; i++)
            {
                if (((Service)cbService.Items[i]).Id == personnelSelectionne.Service.Id)
                {
                    cbService.SelectedIndex = i;
                    break;
                }
            }
            grpSaisie.Visible = true;
            this.ClientSize = new System.Drawing.Size(676, 640);
            txtNom.Focus();
        }

       
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.", "Aucune sélection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dgvPersonnel.SelectedRows[0].Index;
            Personnel p = listePersonnel[index];
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer " + p.Nom + " " + p.Prenom + " ?",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                controller.SupprimerPersonnel(p.Id);
                grpSaisie.Visible = false;
                this.ClientSize = new System.Drawing.Size(676, 420);
                ChargerPersonnel();
            }
        }

       
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un personnel.", "Aucune sélection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dgvPersonnel.SelectedRows[0].Index;
            Personnel p = listePersonnel[index];
            FrmAbsences frmAbsences = new FrmAbsences(p, controller);
            frmAbsences.ShowDialog();
        }

       
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Equals("") || txtPrenom.Text.Equals("") || cbService.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires (Nom, Prénom, Service).",
                    "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Confirmer l'enregistrement ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Service serviceSelectionne = (Service)cbService.SelectedItem;
                if (mode == "ajout")
                {
                    controller.AjouterPersonnel(
                        txtNom.Text, txtPrenom.Text,
                        txtTel.Text, txtMail.Text,
                        serviceSelectionne.Id);
                }
                else
                {
                    controller.ModifierPersonnel(
                        personnelSelectionne.Id,
                        txtNom.Text, txtPrenom.Text,
                        txtTel.Text, txtMail.Text,
                        serviceSelectionne.Id);
                }
                grpSaisie.Visible = false;
                this.ClientSize = new System.Drawing.Size(676, 420);
                ChargerPersonnel();
            }
        }

       
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpSaisie.Visible = false;
            this.ClientSize = new System.Drawing.Size(676, 420);
        }
    }
}