namespace MediaTek86.vue
{
    partial class FrmPersonnel
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.grpSaisie = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grpSaisie.SuspendLayout();
            this.SuspendLayout();

            this.lblTitre.AutoSize = false;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(0, 102, 153);
            this.lblTitre.Location = new System.Drawing.Point(12, 12);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(350, 35);
            this.lblTitre.Text = "Gestion du personnel";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

           
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(12, 55);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(650, 300);
            this.dgvPersonnel.TabIndex = 0;

            
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(12, 370);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 34);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(0, 102, 153);
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(155, 370);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 34);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(204, 0, 0);
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(298, 370);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 34);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

           
            this.btnAbsences.BackColor = System.Drawing.Color.FromArgb(102, 51, 153);
            this.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsences.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbsences.ForeColor = System.Drawing.Color.White;
            this.btnAbsences.Location = new System.Drawing.Point(441, 370);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(160, 34);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "Gérer les absences";
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);

            
            this.grpSaisie.Controls.Add(this.lblNom);
            this.grpSaisie.Controls.Add(this.txtNom);
            this.grpSaisie.Controls.Add(this.lblPrenom);
            this.grpSaisie.Controls.Add(this.txtPrenom);
            this.grpSaisie.Controls.Add(this.lblTel);
            this.grpSaisie.Controls.Add(this.txtTel);
            this.grpSaisie.Controls.Add(this.lblMail);
            this.grpSaisie.Controls.Add(this.txtMail);
            this.grpSaisie.Controls.Add(this.lblService);
            this.grpSaisie.Controls.Add(this.cbService);
            this.grpSaisie.Controls.Add(this.btnValider);
            this.grpSaisie.Controls.Add(this.btnAnnuler);
            this.grpSaisie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grpSaisie.Location = new System.Drawing.Point(12, 420);
            this.grpSaisie.Name = "grpSaisie";
            this.grpSaisie.Size = new System.Drawing.Size(650, 200);
            this.grpSaisie.TabIndex = 5;
            this.grpSaisie.TabStop = false;
            this.grpSaisie.Text = "Informations du personnel";
            this.grpSaisie.Visible = false;

            
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 30);
            this.lblNom.Text = "Nom :";

            
            this.txtNom.Location = new System.Drawing.Point(100, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 23);

            
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(15, 65);
            this.lblPrenom.Text = "Prénom :";

            
            this.txtPrenom.Location = new System.Drawing.Point(100, 62);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 23);

         
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(15, 100);
            this.lblTel.Text = "Téléphone :";

          
            this.txtTel.Location = new System.Drawing.Point(100, 97);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 23);

            
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(15, 135);
            this.lblMail.Text = "Mail :";

            
            this.txtMail.Location = new System.Drawing.Point(100, 132);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 23);

            
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(330, 30);
            this.lblService.Text = "Service :";

            
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.Location = new System.Drawing.Point(400, 27);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(220, 24);

           
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(0, 153, 76);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(400, 155);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(100, 30);
            this.btnValider.Text = "Valider";
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);

            
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(520, 155);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 420);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.grpSaisie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86 — Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grpSaisie.ResumeLayout(false);
            this.grpSaisie.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        public System.Windows.Forms.DataGridView dgvPersonnel;
        public System.Windows.Forms.Button btnAjouter;
        public System.Windows.Forms.Button btnModifier;
        public System.Windows.Forms.Button btnSupprimer;
        public System.Windows.Forms.Button btnAbsences;
        public System.Windows.Forms.GroupBox grpSaisie;
        private System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        public System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblMail;
        public System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblService;
        public System.Windows.Forms.ComboBox cbService;
        public System.Windows.Forms.Button btnValider;
        public System.Windows.Forms.Button btnAnnuler;
    }
}