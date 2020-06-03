using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        
        private void UpdateTranslation ()
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
    }
}
