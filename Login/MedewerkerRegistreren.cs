using ChapooLogic;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Login
{
    public partial class MedewerkerRegistreren : UserControl
    {
        public MedewerkerRegistreren()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int Manager = 0, Chef = 0, Bediening = 0, Keuken = 0, Sommelier = 0, Maitre = 0, Bar = 0;
            if (rbManager.Checked) Manager = 1;
            else if (rbChef.Checked) Chef = 1;
            else if (rbBediening.Checked) Bediening = 1;
            else if (rbKeuken.Checked) Keuken = 1;
            else if (rbSommelier.Checked) Sommelier = 1;
            else if (rbMaitre.Checked) Maitre = 1;
            else if (rbBar.Checked) Bar = 1;

            if (Manager == 0 && Chef == 0 && Bediening == 0 && Keuken == 0 && Sommelier == 0 && Maitre == 0 && Bar == 0)
            {
                MessageBox.Show("Medewerker moet een functie hebben", "Chapoo");
            } else
            {   // if all textboxes and radiobuttons are filled in, register account
                if (CheckTextBox(txtVoornaam) &&
                CheckTextBox(txtAchternaam) &&
                CheckTextBox(txtInlogNaam) &&
                CheckTextBox(txtTelNummer) &&
                CheckTextBox(txtEmail) &&
                CheckTextBox(txtWachtwoord) &&
                CheckTextBox(txtBevestigwachtwoord) && txtWachtwoord.Text == txtBevestigwachtwoord.Text)
                {
                    int Mobiel = int.Parse(txtTelNummer.Text);
                    string encryptedwachtwoord = BCrypt.Net.BCrypt.HashPassword(txtWachtwoord.Text);
                    Account account = new Account(
                        0, // 0 komt niet in de database
                        txtVoornaam.Text,
                        txtAchternaam.Text,
                        txtInlogNaam.Text,
                        dtGeboorteDatum.Value,
                        Mobiel,
                        txtEmail.Text,
                        encryptedwachtwoord,
                        Manager, Chef, Bediening, Keuken, Sommelier, Maitre, Bar);
                    Account_Service service = new Account_Service();
                    if (service.AddAccount(account)) System.Windows.Forms.MessageBox.Show($"{txtVoornaam.Text} is succesvol geregistreerd.");
                    ClearTextBoxes();
                }
                else if (txtWachtwoord.Text != txtBevestigwachtwoord.Text)
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen", "Chapoo");
                }
            }
        }
        public bool CheckTextBox(TextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show("Veld " + tb.Name.Replace("txt", "") + " is niet ingevuld.", "Chapoo");
                return false;
            }
            else return true;
        }
        // Clean all textboxes and radiobuttons
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is RadioButton)
                    {
                        RadioButton rb = control as RadioButton;
                        rb.Checked = false;
                    }
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
    }
}
