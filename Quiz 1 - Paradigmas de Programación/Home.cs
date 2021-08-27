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
            String answer = "";

            TextBox name = nameInput;
            TextBox lastName = lastnameInput;
            DateTimePicker date = birthdateInput;
            RadioButton manRadio = manRb;
            RadioButton womanRadio = womanRb;
            CheckedListBox movieGenreCheck = movieGenreCheckBox;

            answer = "\nCliente Registrado:\n" +
                     "\nNombres: " + name.Text +
                     "\nApellidos: " + lastName.Text +
                     "\nFecha de Nacimiento: " + date.Value.Date.ToString("dd/MM/yyyy");

            if (manRadio.Checked)
            {
                answer = answer+"\nSexo: "+manRadio.Text;
            } else
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

        public void clearForm()
        {
            TextBox name = nameInput;
            TextBox lastName = lastnameInput;
            RadioButton manRadio = manRb;
            RadioButton womanRadio = womanRb;
            CheckedListBox movieGenreCheck = movieGenreCheckBox;

            name.Text = String.Empty;
            lastName.Text = String.Empty;
            manRadio.Checked = false;
            womanRadio.Checked = false;

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
    }
}
