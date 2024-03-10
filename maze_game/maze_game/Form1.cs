using maze_game.Properties;

namespace maze_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public Stack<string> Users = new Stack<string>();
        public int Count =0;
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Count != 0) 
            {
                Count = Count + 1;
            }
            Game game = new Game();
            Users.Push(textBox1.Text);
            game.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}