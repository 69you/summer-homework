using System;
using System.Windows.Forms;
//https://betterdiscord.app/theme/ClearVision
//https://www.youtube.com/watch?v=aYAJopwEYv8
namespace 暑假作業
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            f2 = this;
        }

        public int round = 1;
        int exround = 0;
        double roundper = 0;
        bool oturn = true;
        int owint = 0;
        double owinper = 0;
        int xwint = 0;
        double xwinper = 0;
        bool roundend = false;
        System.Media.SoundPlayer back = new System.Media.SoundPlayer();
        public static Form2 f2;
        public bool owins = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "遊戲";
            back.SoundLocation = "- Rimsky Korsakov - Flight of the Bumblebee (320kbps) (online-audio-converter.com).wav";
            back.PlayLooping();
            //reset button name
            reset();
            label1.Text = $"玩家一名稱: {Form1.form.players[0].name}\n\n" +
                          $"贏了幾場: {Form1.form.players[0].point}\n\n" +
                          $"勝率: {Form1.form.players[0].winper}%";

            label2.Text = $"玩家二名稱: {Form1.form.players[1].name}\n\n" +
                          $"贏了幾場: {Form1.form.players[1].point}\n\n" +
                          $"勝率: {Form1.form.players[1].winper}%";

            label3.Text = "~~~~~~~~~~~~~~~~~~~~~~~~";

            label4.Text = $"正在進行第{round}回合\n\n" +
                          $"實際分出勝負{exround}局\n\n" +
                          $"總共{Form1.form.tround}回合\n\n" +
                          $"完成率: {roundper}%";
        }

        private void check()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                roundend = true;
                exround++;
                owin();
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                roundend = true;
                exround++;
                xwin();
            }
            if ((button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "") && roundend == false)
            {
                MessageBox.Show("可惜，雙方平手\n繼續比吧","殘念");
                round++;
                reset();
            }
        }
        private void reset()
        {
            button1.Text = ""; button1.Enabled = true;
            button2.Text = ""; button2.Enabled = true;
            button3.Text = ""; button3.Enabled = true;
            button4.Text = ""; button4.Enabled = true;
            button5.Text = ""; button5.Enabled = true;
            button6.Text = ""; button6.Enabled = true;
            button7.Text = ""; button7.Enabled = true;
            button8.Text = ""; button8.Enabled = true;
            button9.Text = ""; button9.Enabled = true;
            label1.Text = $"玩家一名稱: {Form1.form.players[0].name}\n\n" +
                          $"贏了幾場: {owint}\n\n" +
                          $"勝率: {owinper}%";

            label2.Text = $"玩家二名稱: {Form1.form.players[1].name}\n\n" +
                          $"贏了幾場: {xwint}\n\n" +
                          $"勝率: {xwinper}%";

            label3.Text = "~~~~~~~~~~~~~~~~~~~~~~~~";

            label4.Text = $"正在進行第{round}回合\n\n" +
                          $"實際分出勝負{exround}局\n\n" +
                          $"總共{Form1.form.tround}回合\n\n" +
                          $"完成率: {roundper}%";
            roundend = false;
        }
        private void enable()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void owin()
        {
            MessageBox.Show($"恭喜 {Form1.form.players[0].name} 獲得本局勝利");
            if (exround == Form1.form.tround)
            {
                back.Stop();
                enable();
                owint++;
                owinper = Math.Round(((double)owint / (double)exround), 4) * 100;
                xwinper = Math.Round(((double)xwint / (double)exround), 4) * 100;
                roundper = Math.Round(((double)exround / (double)Form1.form.tround), 4) * 100;
                label1.Text = $"玩家一名稱: {Form1.form.players[0].name}\n\n" +
                              $"贏了幾場: {owint}\n\n" +
                              $"勝率: {owinper}%";

                label2.Text = $"玩家二名稱: {Form1.form.players[1].name}\n\n" +
                              $"贏了幾場: {xwint}\n\n" +
                              $"勝率: {xwinper}%";

                label3.Text = "~~~~~~~~~~~~~~~~~~~~~~~~";

                label4.Text = $"正在進行第{round}回合\n\n" +
                              $"實際分出勝負{exround}局\n\n" +
                              $"總共{Form1.form.tround}回合\n\n" +
                              $"完成率: {roundper}%";
                owins = true;
                Form f3 = new Form3();
                this.Hide();
                f3.Show();
            }
            else
            {
                owint++;
                owinper = Math.Round(((double)owint /(double)exround),4) * 100;
                xwinper = Math.Round(((double)xwint /(double)exround),4) * 100;
                roundper = Math.Round(((double)exround / (double)Form1.form.tround),4) * 100;
                round++;
                reset();
            }

        }

        private void xwin()
        {
            MessageBox.Show($"恭喜 {Form1.form.players[0].name} 獲得本局勝利");
            if (exround == Form1.form.tround)
            {
                back.Stop();
                enable();
                xwint++;
                xwinper = Math.Round(((double)xwint / (double)round), 4) * 100;
                owinper = Math.Round(((double)owint / (double)round), 4) * 100;
                roundper = Math.Round(((double)exround / (double)Form1.form.tround), 4) * 100;
                label1.Text = $"玩家一名稱: {Form1.form.players[0].name}\n\n" +
                              $"贏了幾場: {owint}\n\n" +
                              $"勝率: {owinper}%";

                label2.Text = $"玩家二名稱: {Form1.form.players[1].name}\n\n" +
                              $"贏了幾場: {xwint}\n\n" +
                              $"勝率: {xwinper}%";

                label3.Text = "~~~~~~~~~~~~~~~~~~~~~~~~";

                label4.Text = $"正在進行第{round}回合\n\n" +
                              $"實際分出勝負{exround}局\n\n" +
                              $"總共{Form1.form.tround}回合\n\n" +
                              $"完成率: {roundper}%";
                Form f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                xwint++;
                xwinper = Math.Round(((double)xwint / (double)round), 4) * 100;
                owinper = Math.Round(((double)owint / (double)round), 4) * 100;
                roundper = Math.Round(((double)exround / (double)Form1.form.tround), 4) * 100;
                round++;
                reset();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button1.Text = "O";
                button1.Enabled = false;
                oturn = false;
            }
            else
            {
                button1.Text = "X";
                button1.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button2.Text = "O";
                button2.Enabled = false;
                oturn = false;
            }
            else
            {
                button2.Text = "X";
                button2.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button3.Text = "O";
                button3.Enabled = false;
                oturn = false;
            }
            else
            {
                button3.Text = "X";
                button3.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button4.Text = "O";
                button4.Enabled = false;
                oturn = false;
            }
            else
            {
                button4.Text = "X";
                button4.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button5.Text = "O";
                button5.Enabled = false;
                oturn = false;
            }
            else
            {
                button5.Text = "X";
                button5.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button6.Text = "O";
                button6.Enabled = false;
                oturn = false;
            }
            else
            {
                button6.Text = "X";
                button6.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button7.Text = "O";
                button7.Enabled = false;
                oturn = false;
            }
            else
            {
                button7.Text = "X";
                button7.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button8.Text = "O";
                button8.Enabled = false;
                oturn = false;
            }
            else
            {
                button8.Text = "X";
                button8.Enabled = false;
                oturn = true;
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (oturn == true)
            {
                button9.Text = "O";
                button9.Enabled = false;
                oturn = false;
            }
            else
            {
                button9.Text = "X";
                button9.Enabled = false;
                oturn = true;
            }
            check();
        }

    }
}
