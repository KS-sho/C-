
using Microsoft.DirectX.AudioVideoPlayback;
using Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Music1
{
    public partial class Form1 : Form
    {
        //ミュージックセレクト
        private int Num;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //タクティカルエンカウンター
            this.Num = 1;
            MainForm MF = new MainForm();
            MF.Show(this);
            MF.MusicStart(this.Num);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ロックバレッジ
            this.Num = 2;
            MainForm MF = new MainForm();
            MF.Show(this);
            MF.MusicStart(this.Num);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ハイパーチェイス
            this.Num = 3;
            MainForm MF = new MainForm();
            MF.Show(this);
            MF.MusicStart(this.Num);
            Hide();
        }
    }
    }

