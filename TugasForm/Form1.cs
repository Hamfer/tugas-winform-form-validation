using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxTnc_CheckedChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = ((CheckBox)sender).Checked;
        }
        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelErrorName.Text = "";
            labelErrorAge.Text = "";
            labelErrorGender.Text = "";
            var error = 0;
            if (inputName.Text == "")
            {
                labelErrorName.Text = "Nama tidak boleh kosong.";
                error++;
            }
            if (inputAge.Text == "" || inputAge.Text == "0") 
            {
                labelErrorAge.Text = "Umur tidak boleh kosong.";
                error++;
            }
            var genderValidation = flowLayoutPanelGender.Controls
                .OfType<RadioButton>()
                .Any(r=>r.Checked); 
            if (!genderValidation) 
            {
                labelErrorGender.Text = "Jenis kelamin harus dipilih.";
                error++;
            }
                
            if (error > 0)
            {
                return;
            }
            MessageBox.Show("Input Berhasil");
        }
    }
}