
namespace OiluGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.patternCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.segmentRatioBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.genBtnn = new System.Windows.Forms.Button();
            this.sizeCm = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.nbrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.patternCombo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.segmentRatioBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExportBtn);
            this.panel1.Controls.Add(this.genBtnn);
            this.panel1.Controls.Add(this.sizeCm);
            this.panel1.Controls.Add(this.resBox);
            this.panel1.Controls.Add(this.nbrBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 707);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(117, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Screen resolution";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // patternCombo
            // 
            this.patternCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patternCombo.FormattingEnabled = true;
            this.patternCombo.Items.AddRange(new object[] {
            "LINEAR PATTERN",
            "CIRCULAR PATTERN",
            "DOTTED PATTERN"});
            this.patternCombo.Location = new System.Drawing.Point(144, 109);
            this.patternCombo.Name = "patternCombo";
            this.patternCombo.Size = new System.Drawing.Size(184, 21);
            this.patternCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code pattern";
            // 
            // segmentRatioBox
            // 
            this.segmentRatioBox.Location = new System.Drawing.Point(143, 292);
            this.segmentRatioBox.Name = "segmentRatioBox";
            this.segmentRatioBox.Size = new System.Drawing.Size(185, 20);
            this.segmentRatioBox.TabIndex = 5;
            this.segmentRatioBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(11, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Segment \r\nBlack/White ratio (%)";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Enabled = false;
            this.ExportBtn.Location = new System.Drawing.Point(14, 368);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(314, 23);
            this.ExportBtn.TabIndex = 3;
            this.ExportBtn.Text = "EXPORT GENERATED CODE";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // genBtnn
            // 
            this.genBtnn.Location = new System.Drawing.Point(15, 339);
            this.genBtnn.Name = "genBtnn";
            this.genBtnn.Size = new System.Drawing.Size(314, 23);
            this.genBtnn.TabIndex = 3;
            this.genBtnn.Text = "GENERATE";
            this.genBtnn.UseVisualStyleBackColor = true;
            this.genBtnn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sizeCm
            // 
            this.sizeCm.Location = new System.Drawing.Point(144, 203);
            this.sizeCm.Name = "sizeCm";
            this.sizeCm.Size = new System.Drawing.Size(185, 20);
            this.sizeCm.TabIndex = 2;
            this.sizeCm.Text = "10";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(143, 229);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(185, 20);
            this.resBox.TabIndex = 2;
            this.resBox.Text = "96";
            // 
            // nbrBox
            // 
            this.nbrBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrBox.Location = new System.Drawing.Point(12, 59);
            this.nbrBox.Name = "nbrBox";
            this.nbrBox.Size = new System.Drawing.Size(323, 33);
            this.nbrBox.TabIndex = 1;
            this.nbrBox.Text = "0000";
            this.nbrBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nbrBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Size (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number to be coded";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label.Location = new System.Drawing.Point(12, 232);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Resolution (dpi)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(341, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 707);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 707);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 146);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Inverted (white segments on black bkg)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 169);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Oriented";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Oilu Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nbrBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sizeCm;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button genBtnn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.TextBox segmentRatioBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox patternCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

