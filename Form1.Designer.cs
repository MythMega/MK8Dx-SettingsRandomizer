namespace MKSettingsRandomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.randomize = new System.Windows.Forms.Button();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblAI = new System.Windows.Forms.Label();
            this.lblTeamMode = new System.Windows.Forms.Label();
            this.lblNbrCourse = new System.Windows.Forms.Label();
            this.lblInfoItem = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.CheckBox();
            this.cbRaceCount = new System.Windows.Forms.CheckBox();
            this.cbCC = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // randomize
            // 
            this.randomize.FlatAppearance.BorderSize = 0;
            this.randomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomize.Font = new System.Drawing.Font("Montserrat Thin", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomize.Location = new System.Drawing.Point(12, 294);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(865, 212);
            this.randomize.TabIndex = 0;
            this.randomize.Text = "RANDOMIZE !";
            this.randomize.UseVisualStyleBackColor = true;
            this.randomize.Click += new System.EventHandler(this.randomize_Click);
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(12, 177);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(0, 37);
            this.lblCC.TabIndex = 1;
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAI.Location = new System.Drawing.Point(12, 140);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(0, 37);
            this.lblAI.TabIndex = 2;
            // 
            // lblTeamMode
            // 
            this.lblTeamMode.AutoSize = true;
            this.lblTeamMode.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamMode.Location = new System.Drawing.Point(12, 214);
            this.lblTeamMode.Name = "lblTeamMode";
            this.lblTeamMode.Size = new System.Drawing.Size(0, 37);
            this.lblTeamMode.TabIndex = 3;
            this.lblTeamMode.Visible = false;
            // 
            // lblNbrCourse
            // 
            this.lblNbrCourse.AutoSize = true;
            this.lblNbrCourse.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrCourse.Location = new System.Drawing.Point(12, 251);
            this.lblNbrCourse.Name = "lblNbrCourse";
            this.lblNbrCourse.Size = new System.Drawing.Size(0, 37);
            this.lblNbrCourse.TabIndex = 4;
            this.lblNbrCourse.Visible = false;
            // 
            // lblInfoItem
            // 
            this.lblInfoItem.AutoSize = true;
            this.lblInfoItem.Font = new System.Drawing.Font("Montserrat", 16F);
            this.lblInfoItem.Location = new System.Drawing.Point(356, 137);
            this.lblInfoItem.Name = "lblInfoItem";
            this.lblInfoItem.Size = new System.Drawing.Size(87, 30);
            this.lblInfoItem.TabIndex = 8;
            this.lblInfoItem.Text = "Items :";
            // 
            // cbTeam
            // 
            this.cbTeam.AutoSize = true;
            this.cbTeam.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam.Location = new System.Drawing.Point(216, 12);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(152, 48);
            this.cbTeam.TabIndex = 10;
            this.cbTeam.Text = "Team ?";
            this.cbTeam.UseVisualStyleBackColor = true;
            this.cbTeam.CheckedChanged += new System.EventHandler(this.Checkboxes);
            // 
            // cbRaceCount
            // 
            this.cbRaceCount.AutoSize = true;
            this.cbRaceCount.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaceCount.Location = new System.Drawing.Point(374, 12);
            this.cbRaceCount.Name = "cbRaceCount";
            this.cbRaceCount.Size = new System.Drawing.Size(349, 48);
            this.cbRaceCount.TabIndex = 11;
            this.cbRaceCount.Text = "Number Of Races ?";
            this.cbRaceCount.UseVisualStyleBackColor = true;
            this.cbRaceCount.CheckedChanged += new System.EventHandler(this.Checkboxes);
            // 
            // cbCC
            // 
            this.cbCC.AutoSize = true;
            this.cbCC.Checked = true;
            this.cbCC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCC.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCC.Location = new System.Drawing.Point(100, 12);
            this.cbCC.Name = "cbCC";
            this.cbCC.Size = new System.Drawing.Size(110, 48);
            this.cbCC.TabIndex = 12;
            this.cbCC.Text = "CC ?";
            this.cbCC.UseVisualStyleBackColor = true;
            this.cbCC.CheckedChanged += new System.EventHandler(this.Checkboxes);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MKSettingsRandomizer.Properties.Resources.item;
            this.pictureBox3.Location = new System.Drawing.Point(565, 168);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MKSettingsRandomizer.Properties.Resources.item;
            this.pictureBox2.Location = new System.Drawing.Point(459, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MKSettingsRandomizer.Properties.Resources.item;
            this.pictureBox1.Location = new System.Drawing.Point(353, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "6",
            "8",
            "12",
            "16",
            "24",
            "32",
            "48"});
            this.comboBox1.Location = new System.Drawing.Point(543, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Maximum :";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbCC);
            this.Controls.Add(this.cbRaceCount);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.lblInfoItem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNbrCourse);
            this.Controls.Add(this.lblTeamMode);
            this.Controls.Add(this.lblAI);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.randomize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MK8Dx - ModeRandomizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.Label lblTeamMode;
        private System.Windows.Forms.Label lblNbrCourse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblInfoItem;
        private System.Windows.Forms.CheckBox cbTeam;
        private System.Windows.Forms.CheckBox cbRaceCount;
        private System.Windows.Forms.CheckBox cbCC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

