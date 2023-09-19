
namespace PoidsIdeal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNaiss = new System.Windows.Forms.DateTimePicker();
            this.grbGracile = new System.Windows.Forms.RadioButton();
            this.grbNormale = new System.Windows.Forms.RadioButton();
            this.grbLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoidsIdeal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(111, 12);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(167, 22);
            this.txtTaille.TabIndex = 0;
            this.txtTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "taille (en cm):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "date naiss:";
            // 
            // dtpNaiss
            // 
            this.dtpNaiss.Location = new System.Drawing.Point(111, 52);
            this.dtpNaiss.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNaiss.Name = "dtpNaiss";
            this.dtpNaiss.Size = new System.Drawing.Size(167, 22);
            this.dtpNaiss.TabIndex = 3;
            // 
            // grbGracile
            // 
            this.grbGracile.AutoSize = true;
            this.grbGracile.Location = new System.Drawing.Point(6, 30);
            this.grbGracile.Name = "grbGracile";
            this.grbGracile.Size = new System.Drawing.Size(71, 21);
            this.grbGracile.TabIndex = 4;
            this.grbGracile.TabStop = true;
            this.grbGracile.Text = "gracile";
            this.grbGracile.UseVisualStyleBackColor = true;
            // 
            // grbNormale
            // 
            this.grbNormale.AutoSize = true;
            this.grbNormale.Checked = true;
            this.grbNormale.Location = new System.Drawing.Point(99, 30);
            this.grbNormale.Name = "grbNormale";
            this.grbNormale.Size = new System.Drawing.Size(80, 21);
            this.grbNormale.TabIndex = 5;
            this.grbNormale.TabStop = true;
            this.grbNormale.Text = "normale";
            this.grbNormale.UseVisualStyleBackColor = true;
            // 
            // grbLarge
            // 
            this.grbLarge.AutoSize = true;
            this.grbLarge.Location = new System.Drawing.Point(196, 30);
            this.grbLarge.Name = "grbLarge";
            this.grbLarge.Size = new System.Drawing.Size(61, 21);
            this.grbLarge.TabIndex = 6;
            this.grbLarge.Text = "large";
            this.grbLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbLarge);
            this.groupBox1.Controls.Add(this.grbGracile);
            this.groupBox1.Controls.Add(this.grbNormale);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "morphologie";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(82, 161);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(109, 30);
            this.cmdCalcul.TabIndex = 0;
            this.cmdCalcul.Text = "calculer";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "poids idéal :";
            // 
            // txtPoidsIdeal
            // 
            this.txtPoidsIdeal.Enabled = false;
            this.txtPoidsIdeal.Location = new System.Drawing.Point(111, 197);
            this.txtPoidsIdeal.Name = "txtPoidsIdeal";
            this.txtPoidsIdeal.Size = new System.Drawing.Size(158, 22);
            this.txtPoidsIdeal.TabIndex = 2;
            this.txtPoidsIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 234);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoidsIdeal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNaiss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaille);
            this.Name = "Form1";
            this.Text = "CREFF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNaiss;
        private System.Windows.Forms.RadioButton grbGracile;
        private System.Windows.Forms.RadioButton grbNormale;
        private System.Windows.Forms.RadioButton grbLarge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoidsIdeal;
    }
}

