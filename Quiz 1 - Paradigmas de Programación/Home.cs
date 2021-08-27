using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz_1___Paradigmas_de_Programación
{
    public partial class Home : Form
    {
        public RichTextBox textResult = new RichTextBox();
        public Home()
        {
            InitializeComponent();
            textResult  = rtxtResults;

            textResult.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String answer = "";

                TextBox name = nameInput;
                TextBox lastName = lastnameInput;
                DateTimePicker date = birthdateInput;
                RadioButton manRadio = manRb;
                RadioButton womanRadio = womanRb;
                TextBox email = emailInput;

                TextBox password = passInput;
                password.MaxLength = 14;

                ComboBox country = countryComboBox;
                CheckedListBox movieGenreCheck = movieGenreCheckBox;

                answer = "\nCliente Registrado:\n" +
                         "\nNombres: " + name.Text +
                         "\nApellidos: " + lastName.Text +
                         "\nFecha de Nacimiento: " + date.Value.Date.ToString("dd/MM/yyyy") +
                         "\nE-mail: " + email.Text +
                         "\nPassword: " + password.Text +
                         "\nPaís de Origen: " + country.Text;

                if (manRadio.Checked)
                {
                    answer = answer + "\nSexo: " + manRadio.Text;
                }
                else
                {
                    answer = answer + "\nSexo: " + womanRadio.Text;
                }

                if (movieGenreCheck.CheckedItems.Count != 0)
                {
                    answer = answer + "\nGéneros elegidos por el cliente: ";
                    for (int i = 0; i < movieGenreCheck.CheckedItems.Count; i++)
                    {
                        answer = answer + movieGenreCheck.CheckedItems[i].ToString() + "\n";
                    }
                }

                answer = answer + "\n----------------------------------------------------------\n";


                this.textResult.Text = this.textResult.Text + answer;
                clearForm();
            }
        }

        public void clearForm()
        {
            TextBox name = nameInput;
            TextBox lastName = lastnameInput;
            RadioButton manRadio = manRb;
            RadioButton womanRadio = womanRb;
            CheckedListBox movieGenreCheck = movieGenreCheckBox;
            TextBox password = passInput;
            TextBox email = emailInput;
            ComboBox country = countryComboBox;

            name.Text = String.Empty;
            lastName.Text = String.Empty;
            manRadio.Checked = false;
            womanRadio.Checked = false;
            password.Text = String.Empty;
            email.Text = String.Empty;
            country.Text = String.Empty;

            for (int i = 0; i < movieGenreCheck.Items.Count; i++)
            {
                movieGenreCheck.SetItemChecked(i, false);
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report rep = new Report(textResult.Text);

            rep.Show();
        }

        private void nameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                e.Cancel = true;
                inputValidatingError.SetError(nameInput, "Debes digitar tu nombre para poder continuar.");
            }
            else
            {
                e.Cancel = false;
                inputValidatingError.SetError(nameInput, "");
            }
        }

        private void lastnameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lastnameInput.Text))
            {
                e.Cancel = true;
                inputValidatingError.SetError(lastnameInput, "Debes digitar tus apellidos para poder continuar.");
            }
            else
            {
                e.Cancel = false;
                inputValidatingError.SetError(lastnameInput, "");
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailInput.Text)) 
            {

                e.Cancel = true;
                inputValidatingError.SetError(emailInput, "Debes digitar tu e-mail para poder continuar.");

            } 
            else 
            {

                e.Cancel = false;
                inputValidatingError.SetError(emailInput, "");

            }
        }

        private void passInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passInput.Text))
            {

                e.Cancel = true;
                inputValidatingError.SetError(passInput, "Debes digitar tu contraseña para poder continuar.");

            }
            else
            {

                e.Cancel = false;
                inputValidatingError.SetError(passInput, "");

            }
        }
    }
}
