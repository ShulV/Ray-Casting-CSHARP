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
        Map map;
        Drawing draw;
        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы

            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.InitSettings(minimap_2D_panel);
            map = new Map();
            map.addSettings(settings);
            map.fillPointsSet();
            draw = new Drawing(settings);
            label1.Text = map.countPoints.ToString();
        }

        public void CreatePlayer()
        {
            Player player = new Player((int)settings.MINIMAP_WIDTH/2, (int)settings.MINIMAP_HEIGHT/2, 0);

        }

        private void minimap_2D_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
