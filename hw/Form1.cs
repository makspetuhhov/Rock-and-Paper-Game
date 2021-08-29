using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            random = RandomWord();
            OutputLabel.Text = "";
        }
        public static string RandomWord() 
        {
            string rand;
            Random random = new Random();
            List<string> game = new List<string>();
            game.Add("Rock");
            game.Add("Paper");
            game.Add("Scissors");
            rand = game[random.Next(0, 3)];
            return rand;
        }
        public string random = RandomWord();
        private void Game_Load(object sender, EventArgs e)
        {                      
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string rock = "Rock";
            if (random == "Paper")
                OutputLabel.Text = "The computer selects Paper." + "\r" + "The winner is computer.";
            else if (random == "Scissors")
                OutputLabel.Text = "The computer selects Scissors." + "\r" + "The winner is you.";
            else
                OutputLabel.Text = "The computer selects Rock." + "\r" + "The winner is none.";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, OutputLabel.Text);
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string rock = "Paper";
            if (random == "Rock")
                OutputLabel.Text = "The computer selects Rock." + "\r" + "The winner is you.";
            else if (random == "Scissors")
                OutputLabel.Text = "The computer selects Scissors." + "\r" + "The winner is computer.";
            else
                OutputLabel.Text = "The computer selects Paper." + "\r" + "The winner is none.";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, OutputLabel.Text);
        }

        private void ScrissonsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string rock = "Scissors";
            if (random == "Rock")
                OutputLabel.Text = "The computer selects Rock." + "\r" + "The winner is computer.";
            else if (random == "Paper")
                OutputLabel.Text = "The computer selects Paper." + "\r" + "The winner is you.";
            else
                OutputLabel.Text = "The computer selects Scissors." + "\r" + "The winner is none.";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;            
            string filename = saveFileDialog1.FileName;           
            System.IO.File.WriteAllText(filename, OutputLabel.Text);
        }
    }
}
