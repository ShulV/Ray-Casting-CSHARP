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
    public partial class LevelsForm : Form
    {
        public LevelsForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void LevelsForm_Load(object sender, EventArgs e)
        {
            //создание кнопок
            
            int top = 50;
            int left = 50;
            Button[] lvl_btn = new Button[Settings.MAP_QUANTITY];
            for (int i = 0; i < Settings.MAP_QUANTITY; i++)
            {
                lvl_btn[i] = new Button();
                lvl_btn[i].Location = new Point(left, top);
                lvl_btn[i].Size = new Size(50, 50);
                lvl_btn[i].Text = (i+1).ToString();
                lvl_btn[i].Font = new Font("Arial", 20);
                this.levels_gp.Controls.Add(lvl_btn[i]);
                left += 100;
                if (left > this.Size.Width - 2 * lvl_btn[i].Size.Width)
                {
                    left = 50;
                    top += 100;
                }
                lvl_btn[i].Click += lvl_btn_Click;//function
            }
            
            
            
        }
        private void lvl_btn_Click(object sender, EventArgs eventArgs)
        {
            /*
            test_label.Text = ((Button)sender).Text;
            String[] textMap = map.ReadWorldMap(1);
            for (int i=0; i<Settings.HEIGHT_BLOCKS; i++)
            {
                test_label.Text += textMap[i];
            }
            */
            Map.ReadWorldMap(1);
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();

        }

        private void LevelsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
