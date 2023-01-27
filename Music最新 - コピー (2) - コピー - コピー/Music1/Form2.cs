using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

//using PaintEventHandler? Paint;

namespace Music
{
    public partial class MainForm : Form
    {
        White White = null;
        Arrow Arrow = null;
        Arrow2 Arrow2 = null;
        Musics Music = null;
        private Random random = new Random();
        private ArrayList Allows = new ArrayList();
        Timer timer = new Timer();
        private bool Left;
        private bool Down;
        private bool Up;
        private bool Right;
        private bool Ransuu = false;
        private bool HanteiText = false;
        private bool MissHantei = false;
        private bool MissHantei2 = false;
        private bool Rotation;
        private bool _PlayMusic;
        private bool _MusicStart;
        private bool _MusicCountFlag;

        // ----- 記録されていく数字のフィールド -----
        private int Perfect;
        private int Great;
        private int Good;
        private int Bad;
        private int Miss;
       

        private int KeyCount;
        private int MoveCount;
        private int Change = 1;
        private int Hantei;
        private int MS;
        private int _MusicCount;
        








        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            InitTimer();
            Arrow = new Arrow(panel1, random);
            Arrow2 = new Arrow2(panel1, random);
            Music = new Musics();
            White = new White(panel1);

            
        }

        void InitTimer()
        {
            this._PlayMusic = true;

            //時間の流れの速さ 数字が小さい程速くなる(大きいほど簡単になる)
            timer.Interval = 1;

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //1秒間に何度も呼ばれるメソッド(Intervalの数字によって呼び出される回数が変わる)

            //1度だけ曲をスタートさせる その後は処理の負担にならないようにif文ではじく
          
            if (_MusicCountFlag == false) {
                this._MusicCount++;
            }
            if(this._MusicCount >= 80)
            {
                _MusicCountFlag = true;
            }
                if(_MusicCountFlag == true) {
                if (this._PlayMusic)
                {
                    //矢印を動かす
                    //Class1
                    Arrow.Move();
                    //Class3
                    Arrow2.Move();
                    //矢印のY軸が0～4を通過するとミス判定になる
                    this.MissHantei = Arrow._Miss();
                    if (MissHantei == true)
                    {
                        Music.SeStop();
                        Music.MissSe();
                        this.Count = 0;
                        this.MissHantei = false;
                        this.Hantei = 5;
                        this.Miss++;
                        this.Rotation = true;
                    }
                    //矢印のY軸が0～4を通過するとミス判定になる
                    this.MissHantei2 = Arrow2._Miss();
                    if (MissHantei2 == true)
                    {
                        Music.SeStop();
                        Music.MissSe();
                        this.Count = 0;
                        this.MissHantei = false;
                        this.Hantei = 5;
                        this.Miss++;
                        this.Rotation = false;
                    }
                    //矢印の出現乱数を決める(１回だけ抽選して後は++で30になるまでカウント)
                    if (this.Ransuu == false)
                    {
                        //1～14までの乱数
                        this.MoveCount += random.Next(1, 15);
                        //2回目は乱数抽選しないようにtrueにする
                        this.Ransuu = true;
                    }
                    MoveCount++;
                    if (this.MoveCount >= 30)
                    {
                        this.Ransuu = false;
                        this.MoveCount = 0;
                        //MoveCountが30になると矢印出現
                        Create();
                    }
                }
                }
            
            Invalidate();
        }

        public void MusicStart(int Num)
        {
            Music.MusicStart(Num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            White.Set();
        }
        private void Create()
        {
            //Class1とClass3の２つのクラスを利用して矢印を生成(1回ずつローテーションで行う)
            if (Change == 1)
            {
                Arrow.Set();
                this.Change++;
            }else if(Change == 2)
            {
                Arrow2.Set();
                this.Change--;
            }
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            //ゲーム画面が閉じたら
            this._PlayMusic = false;
            Arrow.ArrowsStoped();
            Arrow2.ArrowsStoped();
            Music.MusicStop();
            Owner.Show();
           
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //キーボード←が押された場合
            if (e.KeyCode == Keys.Left)
            {
                this.Left = true;
                this.Hantei = Arrow.RedHantei();
                    HanteiPlus();
                    Arrow.HanteiClear();
                    Arrow.RemovedRed();
                  bool Select =  Arrow._RotationHantei();

                if (Select == true)
                {
                    this.Hantei = Arrow2.RedHantei();
                    HanteiPlus();
                    Arrow2.HanteiClear();
                    Arrow2.RemovedRed();
                }    
            }

            //キーボード→が押された場合
            if (e.KeyCode == Keys.Right)
                {
                this.Right = true;
                this.Hantei = Arrow.GreenHantei();
                    HanteiPlus();
                    Arrow.HanteiClear();
                    Arrow.RemovedGreen();
                bool Select = Arrow._RotationHantei();

                if (Select == true)
                {
                    this.Hantei = Arrow2.GreenHantei();
                    HanteiPlus();
                    Arrow2.HanteiClear();
                    Arrow2.RemovedGreen();
                }
                }


            //キーボード↑が押された場合
            if (e.KeyCode == Keys.Up)
            {
                this.Up = true;
                this.Hantei = Arrow.YellowHantei();
                    HanteiPlus();
                    Arrow.HanteiClear();
                    Arrow.RemovedYellow();
                bool Select = Arrow._RotationHantei();

                if (Select == true)
                {
                    this.Hantei = Arrow2.YellowHantei();
                    HanteiPlus();
                    Arrow2.HanteiClear();
                    Arrow2.RemovedYellow();
                }
            }

            //キーボード↓が押された場合
            if (e.KeyCode == Keys.Down)
            {
                this.Down = true;
                this.Hantei = Arrow.BlueHantei();
                    HanteiPlus();
                    Arrow.HanteiClear();
                    Arrow.RemovedBlue();
                bool Select = Arrow._RotationHantei();

                if (Select == true)
                {
                    this.Hantei = Arrow2.BlueHantei();
                    HanteiPlus();
                    Arrow2.HanteiClear();
                    Arrow2.RemovedBlue();
                }      
            }
            Arrow._RotationReset();
                base.OnKeyDown(e);
                
            }

        private void HanteiPlus()
        {
            Music.SeStop();
            //コンボ、スコアの記録、SE再生
            if (this.Hantei == 1)
            {
                Music.SePlay(this.Hantei);
                this.Count++;
                this.Perfect++;
            }else if(this.Hantei == 2)
            {
                Music.SePlay(this.Hantei);
                this.Count++;
                this.Great++;
            }else if(this.Hantei == 3)
            {
                Music.SePlay(this.Hantei);
                this.Count++;
                this.Good++;
            }else if(this.Hantei == 4)
            {
                Music.SePlay(this.Hantei);
                this.Count = 0;
                this.Bad++;
            }
        }
    

        protected override void OnPaint(PaintEventArgs e)
        {
            Text(e.Graphics);
            base.OnPaint(e);
        }

        private int Count = 0;

        //右画面のスコア表示
        void Text(Graphics graphics)
        {
            if (this.Hantei == 1)
            {
                string ViewString = "PERFECT";
                graphics.DrawString(ViewString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Yellow), new Point(530, 190));
            }else if (this.Hantei == 2)
            {
                string ViewString = "GREAT";
                graphics.DrawString(ViewString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Green), new Point(545, 190));
            }else if(this.Hantei == 3)
            {
                string ViewString = "GOOD";
                graphics.DrawString(ViewString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Blue), new Point(555, 190));
            }
            else if(this.Hantei == 4)
            {
                string ViewString = "BAD";
                graphics.DrawString(ViewString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Purple), new Point(570, 190));
            }
 
            if (this.Hantei == 5)
            {
                string ViewString = "MISS";
                graphics.DrawString(ViewString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Red), new Point(555, 190));
            }
            if (this.Count > 1) {
            string TextscoreString = "COMBO";
            graphics.DrawString(TextscoreString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.Black), new Point(545, 260));
            string ScoreString = this.Count.ToString("000");
            graphics.DrawString(ScoreString, new Font("ＭＳ ゴシック", 40), new SolidBrush(Color.OrangeRed), new Point(570, 330));
            }
            string PERFECTString = "PERFECT";
            graphics.DrawString(PERFECTString, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Yellow), new Point(450, 400));
            string GREATString = "GREAT";
            graphics.DrawString(GREATString, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Green), new Point(465, 450));
            string GOODString = "GOOD";
            graphics.DrawString(GOODString, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Blue), new Point(470, 500));
            string BADString = "BAD";
            graphics.DrawString(BADString, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Purple), new Point(480, 550));
            string MISSString = "MISS";
            graphics.DrawString(MISSString, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Red), new Point(470, 600));



            string PERFECTCount = this.Perfect.ToString("0");
            graphics.DrawString(PERFECTCount, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Black), new Point(600, 400));
            string GREATCount = this.Great.ToString("0");
            graphics.DrawString(GREATCount, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Black), new Point(600, 450));
            string GOODCount = this.Good.ToString("0");
            graphics.DrawString(GOODCount, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Black), new Point(600, 500));
            string BADCount = this.Bad.ToString("0");
            graphics.DrawString(BADCount, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Black), new Point(600, 550));
            string MISSCount = this.Miss.ToString("0");
            graphics.DrawString(MISSCount, new Font("ＭＳ ゴシック", 24), new SolidBrush(Color.Black), new Point(600, 600));
            
        }

        public void CountReset()
        {
            this.Count = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}