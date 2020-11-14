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
    public partial class GameForm : Form
    {
        Settings settings;
        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы

            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
        settings = new Settings();
        settings.InitSettings(minimap_2D_panel);
        label1.Text = settings.HEIGHT_BLOCKS.ToString();
        }
    }
}
