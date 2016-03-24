using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypenleihenGeld
{
    public partial class Form1 : Form
    {
        Typ tim, tom, Bank;

        public Form1()
        {
            InitializeComponent();
            tim = new Typ() { Geld = 100, Name = "Tim" };

            tom = new Typ() { Geld = 50, Name = "Tom" };

            Bank = new Typ() { Geld = 1000, Name = "Bank" };

            FormularAktualsieren();

        }
        public void FormularAktualsieren()
        {
            this.TimGeld.Text = tim.Name + " hat " + tim.Geld + " €";
            this.TomsGeld.Text = tom.Name + " hat " + tom.Geld + " €";
            this.BankGeld.Text = "Die Bank hat " + Bank.Geld + "€";
        }
        private void Transaktion_Click(object sender, EventArgs e)
        {
            Typ Sender = getSender();
            Typ Empfaenger = getEmpfänger();
            float Betrag = float.Parse(this.EingabeWert.Text);
            if (Empfaenger != Sender)

            {
                if (Sender.Geld >= Betrag)
                {
                    Sender.Geld -= Betrag;
                    Empfaenger.Geld += Betrag;
                    this.EingabeWert.Text = "";
                    FormularAktualsieren();
                    MessageBox.Show("Betrag erfolgreich transferiert");

                }
                else
                {
                    MessageBox.Show("Nicht genüg Geld vorhanden");

                }
            }
            else
            {
                MessageBox.Show("Empfänger und Sender dürfe nicht identisch sein!");
            }
            FormularAktualsieren();
        }
        private Typ getSender()
        {
            string Sender = this.SenderBox.Text;
            switch (Sender)
            {
                case "Tim":
                    return tim;
                case "Tom":
                    return tom;
                case "Bank":
                    return Bank;
                default:
                    return null;

            }

        }
        private Typ getEmpfänger()
        {
            string Empfänger = this.EmpfängerBox.Text;
            switch (Empfänger)
            {
                case "Tim":
                    return tim;
                case "Tom":
                    return tom;
                case "Bank":
                    return Bank;
                default:
                    return null;

            }
        }
    }

}
