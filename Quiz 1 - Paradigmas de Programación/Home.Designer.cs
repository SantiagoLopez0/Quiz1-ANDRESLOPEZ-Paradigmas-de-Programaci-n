namespace Quiz_1___Paradigmas_de_Programación
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.birthdateInput = new System.Windows.Forms.DateTimePicker();
            this.manRb = new System.Windows.Forms.RadioButton();
            this.womanRb = new System.Windows.Forms.RadioButton();
            this.rbSexGroup = new System.Windows.Forms.GroupBox();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.movieGenreCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSexGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(255, 402);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(119, 33);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formulario de Registro";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(12, 90);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(214, 23);
            this.nameInput.TabIndex = 4;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(311, 90);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(214, 23);
            this.lastnameInput.TabIndex = 5;
            // 
            // birthdateInput
            // 
            this.birthdateInput.CustomFormat = "dd/mm/yyyy";
            this.birthdateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdateInput.Location = new System.Drawing.Point(12, 169);
            this.birthdateInput.Name = "birthdateInput";
            this.birthdateInput.Size = new System.Drawing.Size(213, 23);
            this.birthdateInput.TabIndex = 6;
            // 
            // manRb
            // 
            this.manRb.AutoSize = true;
            this.manRb.Location = new System.Drawing.Point(20, 23);
            this.manRb.Name = "manRb";
            this.manRb.Size = new System.Drawing.Size(82, 24);
            this.manRb.TabIndex = 7;
            this.manRb.TabStop = true;
            this.manRb.Text = "Hombre";
            this.manRb.UseVisualStyleBackColor = true;
            // 
            // womanRb
            // 
            this.womanRb.AutoSize = true;
            this.womanRb.Location = new System.Drawing.Point(20, 57);
            this.womanRb.Name = "womanRb";
            this.womanRb.Size = new System.Drawing.Size(65, 24);
            this.womanRb.TabIndex = 8;
            this.womanRb.TabStop = true;
            this.womanRb.Text = "Mujer";
            this.womanRb.UseVisualStyleBackColor = true;
            // 
            // rbSexGroup
            // 
            this.rbSexGroup.Controls.Add(this.manRb);
            this.rbSexGroup.Controls.Add(this.womanRb);
            this.rbSexGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSexGroup.Location = new System.Drawing.Point(312, 151);
            this.rbSexGroup.Name = "rbSexGroup";
            this.rbSexGroup.Size = new System.Drawing.Size(213, 89);
            this.rbSexGroup.TabIndex = 9;
            this.rbSexGroup.TabStop = false;
            this.rbSexGroup.Text = "Género";
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(12, 441);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(513, 246);
            this.rtxtResults.TabIndex = 10;
            this.rtxtResults.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // movieGenreCheckBox
            // 
            this.movieGenreCheckBox.FormattingEnabled = true;
            this.movieGenreCheckBox.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Romance",
            "Comedia",
            "Anime",
            "Musical",
            "Terror",
            "Ciencia Ficción",
            "Drama",
            "Fantasía",
            "Documentales"});
            this.movieGenreCheckBox.Location = new System.Drawing.Point(12, 240);
            this.movieGenreCheckBox.Name = "movieGenreCheckBox";
            this.movieGenreCheckBox.Size = new System.Drawing.Size(213, 112);
            this.movieGenreCheckBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Selecciona los géneros que más te gusten";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 699);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieGenreCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.rbSexGroup);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.birthdateInput);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.rbSexGroup.ResumeLayout(false);
            this.rbSexGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.DateTimePicker birthdateInput;
        private System.Windows.Forms.RadioButton manRb;
        private System.Windows.Forms.RadioButton womanRb;
        private System.Windows.Forms.GroupBox rbSexGroup;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox movieGenreCheckBox;
        private System.Windows.Forms.Label label4;
    }
}