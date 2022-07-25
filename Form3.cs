using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://sekai.best/card/181
//https://sc.chinaz.com/yinxiao/210326589881.htm
//https://www.youtube.com/watch?v=vG7otsfCdWw
namespace 暑假作業
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer open = new System.Media.SoundPlayer();
        System.Media.SoundPlayer omedeto = new System.Media.SoundPlayer();
        int t = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "成果發表";
            button1.Visible = false;
            label2.Visible = false;
            timer1.Start();
            open.SoundLocation = "14096.wav";
            open.Play();
            label1.Text = "程式思考中";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            if (t == 6)
            {
                timer1.Stop();
                open.Stop();
                label1.Visible = false;
                omedeto.SoundLocation = "omedeto.wav";
                omedeto.PlayLooping();
                button1.Visible = true;
                label2.Visible = true;
                if (Form2.f2.owins == true)
                {
                    label2.Text = $"恭喜 {Form1.form.players[0].name} 獲勝\n\n"+
                                  $"經過了{Form2.f2.round}場的比賽\n\n"+
                                  $"你成功贏得了{Form1.form.tround}場的比賽並獲得勝利";
                }
                else
                {
                    label2.Text = $"恭喜 {Form1.form.players[1].name} 獲勝\n\n" +
                                  $"經過了{Form2.f2.round}場的比賽\n\n" +
                                  $"你成功贏得了{Form1.form.tround}場的比賽並獲得勝利";
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
