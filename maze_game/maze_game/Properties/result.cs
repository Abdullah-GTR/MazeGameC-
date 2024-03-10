using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze_game.Properties
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            Game g = new Game();
            int val, j;
            for (int i = 0; i < 10; i++)
            {
                val = (g.usersinfo[i]);
                j = i - 1;
                while (j >= 0 && g.usersinfo[j] > val)
                {
                    g.usersinfo[j + 1] = g.usersinfo[j];
                    j = j - 1;
                }
                g.usersinfo[j + 1] = val;
            }
        }

    }
}
}
