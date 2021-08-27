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
            this.components = new System.ComponentModel.Container();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputValidatingError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbSexGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputValidatingError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(129, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(254, 427);
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
            this.nameInput.Location = new System.Drawing.Point(12, 111);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(214, 23);
            this.nameInput.TabIndex = 4;
            this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.nameInput_Validating);
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(311, 111);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(214, 23);
            this.lastnameInput.TabIndex = 5;
            this.lastnameInput.Validating += new System.ComponentModel.CancelEventHandler(this.lastnameInput_Validating);
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
            this.rbSexGroup.Size = new System.Drawing.Size(213, 81);
            this.rbSexGroup.TabIndex = 9;
            this.rbSexGroup.TabStop = false;
            this.rbSexGroup.Text = "Género";
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(581, 88);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(369, 372);
            this.rtxtResults.TabIndex = 10;
            this.rtxtResults.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 20);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 88);
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
            this.movieGenreCheckBox.Location = new System.Drawing.Point(6, 51);
            this.movieGenreCheckBox.Name = "movieGenreCheckBox";
            this.movieGenreCheckBox.Size = new System.Drawing.Size(201, 92);
            this.movieGenreCheckBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Formulario para controlar el registro de usuarios\r\na una plataforma de streaming." +
    "";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(12, 235);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(214, 23);
            this.emailInput.TabIndex = 4;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Contraseña";
            // 
            // passInput
            // 
            this.passInput.Location = new System.Drawing.Point(12, 295);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(214, 23);
            this.passInput.TabIndex = 4;
            this.passInput.UseSystemPasswordChar = true;
            this.passInput.Validating += new System.ComponentModel.CancelEventHandler(this.passInput_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movieGenreCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(312, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 149);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona los géneros que más te gusten";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Chile",
            "Colombia",
            "venezuela"});
            this.countryComboBox.Location = new System.Drawing.Point(11, 356);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(214, 23);
            this.countryComboBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "País";
            // 
            // inputValidatingError
            // 
            this.inputValidatingError.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputValidatingError)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider inputValidatingError;
    }
}