using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048Game.Common;

namespace _2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            theBestScoreLabel.Text = TheBestScoreFile.GetScore().ToString();
        }
    }
}
