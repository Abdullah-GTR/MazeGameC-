using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace maze_game.Properties
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();


        }
        public int[] usersinfo = new int[10];
        public void showimg()
        {
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
        }
        private void Form_key_down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                mouse.Top = mouse.Top - 3;
            }
            if (e.KeyCode == Keys.Down)
            {
                mouse.Top = mouse.Top + 3;
            }
            if (e.KeyCode == Keys.Right)
            {
                mouse.Left = mouse.Left + 3;
            }
            if (e.KeyCode == Keys.Left)
            {
                mouse.Left = mouse.Left - 3;
            }

            if (mouse.Bounds.IntersectsWith(label1.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label2.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label3.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label4.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label5.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label6.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label7.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(label8.Bounds))
            {
                mouse.Top = 100;
                mouse.Left = 50;
                score.Text = Convert.ToString(0);
                showimg();
            }
            if (mouse.Bounds.IntersectsWith(cheese.Bounds))
            {
                Form1 f = new Form1();
                
                usersinfo[f.Count] = score.Text;

                MessageBox.Show("you have completed the game");

            }
            if (mouse.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox1.Hide();
                score.Text = Convert.ToString(10);
            }
            if (mouse.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox2.Hide();
                score.Text = Convert.ToString(20);
            }
            if (mouse.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox3.Hide();
                score.Text = Convert.ToString(30);
            }

            if (mouse.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox5.Hide();
                score.Text = Convert.ToString(40);
            }
            if (mouse.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox6.Hide();
                score.Text = Convert.ToString(50);
            }
            if (mouse.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox7.Hide();
                score.Text = Convert.ToString(60);
            }

        }

        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
