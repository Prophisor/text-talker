﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_umwandeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string t1;
        List<string> text1 = new List<string>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbearbeiten_Click(object sender, EventArgs e)
        {
            txtProcessedOutput.Clear(); // Vorheriges Ergebnis löschen
            t1 = txtRawInput.Text;
            text1.Add(t1);
            
            t1 = t1.ToUpper();
            t1 = t1.Replace("ß", "SS");

            string[] bearbeiten = t1.Split(new char[] { ' ', ',', '.', '-', '_', ';' }, StringSplitOptions.RemoveEmptyEntries);
             
            foreach (string wert in bearbeiten)
            { 
                txtProcessedOutput.AppendText(wert);
            }
            txtProcessedOutput.AppendText("\r\n");
            
            txtRawInput.Clear();
            
        }
        
        private void korrigieren_Click(object sender, EventArgs e)
        {
            // Sicherstellen, dass die Liste nicht leer ist
            if (text1.Any())
            {
                // Holen Sie den zuletzt eingegebenen Originaltext
                // Trim() entfernt versehentliche Leerzeichen am Anfang oder Ende
                string originalText = text1.Last().Trim();
                // Holen Sie den vom Benutzer korrigierten Text
                string correctedText = txtCorrectionInput.Text.Trim();

                // Führen Sie einen Vergleich durch (hier ein einfacher, fallunempfindlicher Vergleich)
                if (string.Equals(originalText, correctedText, StringComparison.OrdinalIgnoreCase))
                {
                    txtResult.Text = "Die Lösung ist richtig!";
                    txtResult.ForeColor = Color.Green;
                    MessageBox.Show("Richtig! Du hast den Text korrekt wiederhergestellt.", "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtResult.Text = "Die Lösung ist nicht komplett richtig.";
                    txtResult.ForeColor = Color.Red;
                    MessageBox.Show("Das ist leider nicht ganz richtig. Überprüfe Leerzeichen und Satzzeichen!", "Ergebnis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txtResult.Text = "Kein Originaltext zum Vergleichen vorhanden.";
                MessageBox.Show("Bitte gib zuerst unten einen Text ein und klicke auf 'umwandeln'.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
