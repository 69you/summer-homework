using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://sekai.best/card/269
namespace 暑假作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form = this;
        }
        public static Form1 form;
        public List<player> players = new List<player>();
        public int tround;
        private void start()
        {
            player a = new player();
            a.name = textBox1.Text;
            players.Add(a);
            player b = new player();
            b.name = textBox2.Text;
            players.Add(b);
            tround = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)); //十進位
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                if(textBox1.Text=="" && textBox2.Text == "")
                {
                    MessageBox.Show("請輸入玩家名稱", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (textBox1.Text == "" && textBox2.Text!="")
                {
                    MessageBox.Show("請輸入玩家一名稱", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else if (textBox1.Text!="" && textBox2.Text == "")
                {
                    MessageBox.Show("請輸入玩家二名稱", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return ;
                }
            }
            else
            {
                if (textBox1.Text == textBox2.Text)
                {
                    DialogResult result;
                    result=MessageBox.Show("你是要自己跟自己玩嗎?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        start();
                    }
                    else if(result == DialogResult.No)
                    {
                        textBox1.Text = null;
                        textBox2.Text = null;
                    }
                }
                else
                {
                    start();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "設定";
        }
    }
}
