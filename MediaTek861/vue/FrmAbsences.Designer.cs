namespace MediaTek86.vue
{
    partial class FrmAbsences
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grpSaisie.SuspendLayout();
            this.SuspendLayout();

            
            this.lblTitre.AutoSize = false;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(102, 51, 153);
            this.lblTitre.Location = new System.Drawing.Point(12, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(350, 35);
            this.lblTitre.Text = "Gestion des absences";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            
            this.lblPersonnel.AutoSize = false;
            this.lblPersonnel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblPersonnel.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPersonnel.Location = new System.Drawing.Point(12, 48);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(400, 25);
            this.lblPersonnel.Text = "Personnel : ";

           
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(12, 80);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(650, 280);
            this.dgvAbsences.TabIndex = 0;

            
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(12, 375);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 34);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(0, 102, 153);
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(145, 375);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 34);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(278, 375);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 34);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(542, 375);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(120, 34);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);

            
            this.grpSaisie.Controls.Add(this.lblDebut);
            this.grpSaisie.Controls.Add(this.dtpDebut);
            this.grpSaisie.Controls.Add(this.lblFin);
            this.grpSaisie.Controls.Add(this.dtpFin);
            this.grpSaisie.Controls.Add(this.lblMotif);
            this.grpSaisie.Controls.Add(this.cbMotif);
            this.grpSaisie.Controls.Add(this.btnValider);
            this.grpSaisie.Controls.Add(this.btnAnnuler);
            this.grpSaisie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpSaisie.Location = new System.Drawing.Point(12, 425);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(650, 150);
            this.grpSaisie.TabIndex = 5;
            this.grpSaisie.TabStop = false;
            this.grpSaisie.Text = "Informations de l'absence";
            this.grpSaisie.Visible = false;

           
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(15, 35);
            this.lblDebut.Text = "Date de début :";

            
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(130, 32);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(150, 23);

            
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(15, 75);
            this.lblFin.Text = "Date de fin :";

           
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(130, 72);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(150, 23);

            
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(320, 35);
            this.lblMotif.Text = "Motif :";

            
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.Location = new System.Drawing.Point(390, 32);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(230, 24);

            
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(430, 105);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 30);
            this.btnValider.Text = "Valider";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(540, 105);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 425);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.grpSaisie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAbsences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86 — Gestion des absences";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grpSaisie.ResumeLayout(false);
            this.grpSaisie.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.Label lblPersonnel;
        public System.Windows.Forms.DataGridView dgvAbsences;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnRetour;
        public System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.Label lblDebut;
        public System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label lblFin;
        public System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblMotif;
        public System.Windows.Forms.ComboBox cbMotif;
        public System.Windows.Forms.Button btnValider;
        public System.Windows.Forms.Button btnAnnuler;
    }
}