using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;

namespace MediaTek86.vue
{
    
    public partial class FrmAbsences : Form
    {
        
        private readonly PersonnelController controller;

        
        private readonly Personnel personnel;

        private List<Absence> listeAbsences;

        
        private string mode;

        
        private Absence absenceSelectionnee;

       
        public FrmAbsences(Personnel personnel, PersonnelController controller)
        {
            InitializeComponent();
            this.personnel = personnel;
            this.controller = controller;
            lblPersonnel.Text = "Personnel : " + personnel.Nom + " " + personnel.Prenom;
            ChargerAbsences();
        }

      
        private void ChargerAbsences()
        {
            listeAbsences = controller.GetAbsencesPersonnel(personnel.Id);
            dgvAbsences.Rows.Clear();
            dgvAbsences.Columns.Clear();
            dgvAbsences.Columns.Add("colDebut", "Date de début");
            dgvAbsences.Columns.Add("colFin", "Date de fin");
            dgvAbsences.Columns.Add("colMotif", "Motif");
            foreach (Absence a in listeAbsences)
            {
                dgvAbsences.Rows.Add(
                    a.DateDebut.ToString("dd/MM/yyyy"),
                    a.DateFin.ToString("dd/MM/yyyy"),
                    a.Motif.Libelle
                );
            }
        }

        
        private void ChargerMotifs()
        {
            cbMotif.Items.Clear();
            List<Motif> motifs = controller.GetAllMotifs();
            foreach (Motif m in motifs)
            {
                cbMotif.Items.Add(m);
            }
        }

       
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";
            ChargerMotifs();
            dtpDebut.Value = DateTime.Today;
            dtpFin.Value = DateTime.Today;
            cbMotif.SelectedIndex = -1;
            grpSaisie.Visible = true;
            this.ClientSize = new System.Drawing.Size(676, 590);
        }

        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.", "Aucune sélection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            mode = "modif";
            int index = dgvAbsences.SelectedRows[0].Index;
            absenceSelectionnee = listeAbsences[index];
            ChargerMotifs();
            dtpDebut.Value = absenceSelectionnee.DateDebut;
            dtpFin.Value = absenceSelectionnee.DateFin;
            for (int i = 0; i < cbMotif.Items.Count; i++)
            {
                if (((Motif)cbMotif.Items[i]).Id == absenceSelectionnee.Motif.Id)
                {
                    cbMotif.SelectedIndex = i;
                    break;
                }
            }
            grpSaisie.Visible = true;
            this.ClientSize = new System.Drawing.Size(676, 590);
        }

        
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", "Aucune sélection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer cette absence ?",
                "Confirmation de suppression",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int index = dgvAbsences.SelectedRows[0].Index;
                Absence a = listeAbsences[index];
                controller.SupprimerAbsence(a.Id);
                grpSaisie.Visible = false;
                this.ClientSize = new System.Drawing.Size(676, 425);
                ChargerAbsences();
            }
        }

      
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnValider_Click(object sender, EventArgs e)
        {
            if (cbMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Champ manquant",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFin.Value < dtpDebut.Value)
            {
                MessageBox.Show("La date de fin ne peut pas être antérieure à la date de début.",
                    "Dates incorrectes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idExclure = (mode == "modif") ? absenceSelectionnee.Id : -1;
            if (controller.ExisteChevauchement(personnel.Id, dtpDebut.Value, dtpFin.Value, idExclure))
            {
                MessageBox.Show("Une absence est déjà programmée sur ce créneau.",
                    "Chevauchement détecté", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Confirmer l'enregistrement ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Motif motifSelectionne = (Motif)cbMotif.SelectedItem;
                if (mode == "ajout")
                {
                    controller.AjouterAbsence(personnel.Id, dtpDebut.Value, dtpFin.Value, motifSelectionne.Id);
                }
                else
                {
                    controller.ModifierAbsence(absenceSelectionnee.Id, dtpDebut.Value, dtpFin.Value, motifSelectionne.Id);
                }
                grpSaisie.Visible = false;
                this.ClientSize = new System.Drawing.Size(676, 425);
                ChargerAbsences();
            }
        }

        
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpSaisie.Visible = false;
            this.ClientSize = new System.Drawing.Size(676, 425);
        }
    }
}