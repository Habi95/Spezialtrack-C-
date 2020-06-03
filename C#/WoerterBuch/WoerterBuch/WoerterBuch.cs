using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoerterBuch
{
    public partial class BackGround : Form
    {
        Dictionary<string, string> germanToEnglishDict = new Dictionary<string, string>();
        public BackGround()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string germanWord = tbGermanWord.Text;
            string englishWord = tbEnglishWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                germanToEnglishDict.Add(germanWord, englishWord);
                UpdateTranslation();
            }
        }

        private void UpdateTranslation()
        {
            lbGermanWords.DataSource = germanToEnglishDict.Keys.ToList();
        }

        private void lbGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWord = lbGermanWords.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedWord) && germanToEnglishDict.ContainsKey(selectedWord))
            {
                tbTranslation.Text = germanToEnglishDict[selectedWord];
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            DictFileWriter();
        }

        private void DictFileWriter()
        {
            File.WriteAllText("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.txt", string.Empty);
            foreach (KeyValuePair<string, string> entry in germanToEnglishDict)
            {
                System.IO.File.AppendAllText("C:\\Users\\DCV\\Desktop\\HelloWorld\\Spezialtrack-C-\\C#\\WörterBuch.txt", string.Format("{0} {1} {2}", entry.Key, entry.Value, Environment.NewLine));

            }
        }
    }
}
