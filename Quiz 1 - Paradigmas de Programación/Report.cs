using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz_1___Paradigmas_de_Programación
{
    public partial class Report : Form
    {
        RichTextBox homeRegister = new RichTextBox();
        public Report(String homeReport)
        {
            InitializeComponent();

            RichTextBox report = rtxtReport;
            report.ReadOnly = true;

            report.Text = homeReport;
        }

        private void btnReportBack_Click(object sender, EventArgs e)
        {

        }
    }
}
