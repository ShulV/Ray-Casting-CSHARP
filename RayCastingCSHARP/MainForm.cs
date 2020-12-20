using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCastingCSHARP
{
    
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            LevelsForm levelsForm = new LevelsForm();
            levelsForm.Show();
            this.Hide();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

            
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String about_text = "Программа представляет собой игру 'Лабиринт', состоящую из 5 уровней.\n" +
                     "Управление осуществляется с помощью клавиш W (движение вперёд) и стрелок влево и вправо (для поворота).\n" +
                     "Уровень считается пройденным, если игрок вышел за пределы лабиринта\n" +
                     "В данной версии игры не предусмотрено сохранение данных, если вы выйдете, прогресс обнулится.";
            DialogResult result = MessageBox.Show(
                   about_text,
                   "Справка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
        }
    }
}
