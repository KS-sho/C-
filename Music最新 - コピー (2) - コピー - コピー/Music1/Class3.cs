using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace Music
{
    class Arrow2
    {
        private PictureBox _RedLeft;
        private PictureBox _BlueDown;
        private PictureBox _YellowUp;
        private PictureBox _GreenRight;
        private PictureBox _RedLeft2;
        private PictureBox _BlueDown2;
        private PictureBox _YellowUp2;
        private PictureBox _GreenRight2;
        private PictureBox _RedLeft3;
        private PictureBox _BlueDown3;
        private PictureBox _YellowUp3;
        private PictureBox _GreenRight3;
        private bool MissHantei;


        private Control _Owner;
        private Random _rand;
        private bool Flag = false;
        private int Ransuu;
        private int _Pattern;
        private int _intMvwd;
        private int Change = 1;
        private int Pa = 72;
        private int Pb = 88;
        private int Gra = 55;
        private int Grb = 105;
        private int Gda = 40;
        private int Gdb = 120;
        private int Hantei;

       

        public Arrow2(Control owner, Random random)
        {
            _intMvwd = 6;
            //_color = new PictureBox();
            _RedLeft = new PictureBox();
            _BlueDown = new PictureBox();
            _YellowUp = new PictureBox();
            _GreenRight = new PictureBox();
            _RedLeft2 = new PictureBox();
            _BlueDown2 = new PictureBox();
            _YellowUp2 = new PictureBox();
            _GreenRight2 = new PictureBox();
            _RedLeft3 = new PictureBox();
            _BlueDown3 = new PictureBox();
            _YellowUp3 = new PictureBox();
            _GreenRight3 = new PictureBox();


            _Owner = owner;


            _Owner.Controls.Add(_RedLeft);
            _Owner.Controls.Add(_BlueDown);
            _Owner.Controls.Add(_YellowUp);
            _Owner.Controls.Add(_GreenRight);
            _Owner.Controls.Add(_RedLeft2);
            _Owner.Controls.Add(_BlueDown2);
            _Owner.Controls.Add(_YellowUp2);
            _Owner.Controls.Add(_GreenRight2);
            _Owner.Controls.Add(_RedLeft3);
            _Owner.Controls.Add(_BlueDown3);
            _Owner.Controls.Add(_YellowUp3);
            _Owner.Controls.Add(_GreenRight3);


            _rand = random;
        }


        private void _Set()
        {
            while (true)
            {
                if (this.Change == 1)
                {
                    _Pattern = _rand.Next(1, 5);
                }
                if (this.Change == 2)
                {
                    _Pattern = _rand.Next(5, 9);
                }
                if (this.Change == 3)
                {
                    _Pattern = _rand.Next(9, 13);
                }

                if (this.Flag == true)
                {
                    if (_Pattern == this.Ransuu)
                    {
                        continue;
                    }
                    else
                    {
                        this.Change++;
                        this.Flag = false;
                        if (this.Change > 3)
                        {
                            this.Change = 1;
                        }
                    }
                }
                else if
                    (this.Flag == false)
                {
                    this.Flag = true;
                }
                this.Ransuu = _Pattern;
                break;
            }




            switch (_Pattern)
            {
                case 1:
                    _RedLeft.SizeMode = PictureBoxSizeMode.AutoSize;
                    _RedLeft.Image = Image.FromFile("Red.jpg");
                    _RedLeft.Top = 640;
                    _RedLeft.Left = 20;

                    break;
                case 2:
                    _BlueDown.SizeMode = PictureBoxSizeMode.AutoSize;
                    _BlueDown.Image = Image.FromFile("Blue.jpg");
                    _BlueDown.Top = 640;
                    _BlueDown.Left = 100;

                    break;
                case 3:
                    _YellowUp.SizeMode = PictureBoxSizeMode.AutoSize;
                    _YellowUp.Image = Image.FromFile("Yellow.png");
                    _YellowUp.Top = 640;
                    _YellowUp.Left = 180;

                    break;
                case 4:
                    _GreenRight.SizeMode = PictureBoxSizeMode.AutoSize;
                    _GreenRight.Image = Image.FromFile("Green.jpg");
                    _GreenRight.Top = 640;
                    _GreenRight.Left = 260;

                    break;
                case 5:
                    _RedLeft2.SizeMode = PictureBoxSizeMode.AutoSize;
                    _RedLeft2.Image = Image.FromFile("Red2.jpg");
                    _RedLeft2.Top = 640;
                    _RedLeft2.Left = 20;

                    break;
                case 6:
                    _BlueDown2.SizeMode = PictureBoxSizeMode.AutoSize;
                    _BlueDown2.Image = Image.FromFile("Blue2.jpg");
                    _BlueDown2.Top = 640;
                    _BlueDown2.Left = 100;

                    break;
                case 7:
                    _YellowUp2.SizeMode = PictureBoxSizeMode.AutoSize;
                    _YellowUp2.Image = Image.FromFile("Yellow2.png");
                    _YellowUp2.Top = 640;
                    _YellowUp2.Left = 180;

                    break;
                case 8:
                    _GreenRight2.SizeMode = PictureBoxSizeMode.AutoSize;
                    _GreenRight2.Image = Image.FromFile("Green2.jpg");
                    _GreenRight2.Top = 640;
                    _GreenRight2.Left = 260;

                    break;
                case 9:
                    _RedLeft3.SizeMode = PictureBoxSizeMode.AutoSize;
                    _RedLeft3.Image = Image.FromFile("Red3.jpg");
                    _RedLeft3.Top = 640;
                    _RedLeft3.Left = 20;

                    break;
                case 10:
                    _BlueDown3.SizeMode = PictureBoxSizeMode.AutoSize;
                    _BlueDown3.Image = Image.FromFile("Blue3.jpg");
                    _BlueDown3.Top = 640;
                    _BlueDown3.Left = 100;

                    break;
                case 11:
                    _YellowUp3.SizeMode = PictureBoxSizeMode.AutoSize;
                    _YellowUp3.Image = Image.FromFile("Yellow3.png");
                    _YellowUp3.Top = 640;
                    _YellowUp3.Left = 180;

                    break;
                case 12:
                    _GreenRight3.SizeMode = PictureBoxSizeMode.AutoSize;
                    _GreenRight3.Image = Image.FromFile("Green3.jpg");
                    _GreenRight3.Top = 640;
                    _GreenRight3.Left = 260;

                    break;
            }
        }


        private void _Move()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_RedLeft);
            Arrows.Add(_RedLeft2);
            Arrows.Add(_RedLeft3);

            Arrows.Add(_BlueDown);
            Arrows.Add(_BlueDown2);
            Arrows.Add(_BlueDown3);

            Arrows.Add(_GreenRight);
            Arrows.Add(_GreenRight2);
            Arrows.Add(_GreenRight3);

            Arrows.Add(_YellowUp);
            Arrows.Add(_YellowUp2);
            Arrows.Add(_YellowUp3);

            for (var i = 0; i < Arrows.Count; i++)
            {
                if (Arrows[i].Top > (this._Owner.Height - this._Owner.Height) - 100 && Arrows[i].Top <= this._Owner.Height)
                {
                    Arrows[i].Top -= _intMvwd;
                }

                else
                {
                    Arrows[i].Top = -80;
                }
                Application.DoEvents();
            }
        }

        public bool _Miss()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_RedLeft);
            Arrows.Add(_RedLeft2);
            Arrows.Add(_RedLeft3);

            Arrows.Add(_BlueDown);
            Arrows.Add(_BlueDown2);
            Arrows.Add(_BlueDown3);

            Arrows.Add(_GreenRight);
            Arrows.Add(_GreenRight2);
            Arrows.Add(_GreenRight3);

            Arrows.Add(_YellowUp);
            Arrows.Add(_YellowUp2);
            Arrows.Add(_YellowUp3);
            //MainForm MF = new MainForm();
            for (var i = 0; i < Arrows.Count; i++)
            {
                if (Arrows[i].Top == 4)
                {
                    this.MissHantei = true;
                    break;
                }
                else
                {
                    this.MissHantei = false;
                }
                Application.DoEvents();
            }
            if (this.MissHantei == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void _RemovedRed()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_RedLeft);
            Arrows.Add(_RedLeft2);
            Arrows.Add(_RedLeft3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                // 10～150まで

                // 76～88 Perfect
                // 55～75  89～105 Great
                // 40～54　106～120 Good
                // 10～39  121～150 Bad
                // 9以下 Miss

                //この下の行にブレークポイントを設置すれば判定が正しいかチェック可能(確認する場合は他の7箇所も設置すること)
                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    Arrows[i].Top = -Arrows[i].Height;
                    
                }
                Application.DoEvents();
            }
        }
        
        private void _RemovedBlue()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_BlueDown);
            Arrows.Add(_BlueDown2);
            Arrows.Add(_BlueDown3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                // 10～150まで

                // 76～88 Perfect
                // 55～75  89～105 Great
                // 40～54　106～120 Good
                // 10～39  121～150 Bad
                // 9以下 Miss

                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //この下の行にブレークポイントを設置すれば判定が正しいかチェック可能(確認する場合は他の7箇所も設置すること)
                    Arrows[i].Top = -Arrows[i].Height;
                  
                }
                Application.DoEvents();
            }
        }

        private void _RemovedGreen()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_GreenRight);
            Arrows.Add(_GreenRight2);
            Arrows.Add(_GreenRight3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                // 10～150まで

                // 76～88 Perfect
                // 55～75  89～105 Great
                // 40～54　106～120 Good
                // 10～39  121～150 Bad
                // 9以下 Miss

                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //この下の行にブレークポイントを設置すれば判定が正しいかチェック可能(確認する場合は他の7箇所も設置すること)
                    Arrows[i].Top = -Arrows[i].Height;
                    
                }
                Application.DoEvents();
            }
        }

        private void _RemovedYellow()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_YellowUp);
            Arrows.Add(_YellowUp2);
            Arrows.Add(_YellowUp3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                // 10～150まで

                // 76～88 Perfect
                // 55～75  89～105 Great
                // 40～54　106～120 Good
                // 10～39  121～150 Bad
                // 9以下 Miss

                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //この下の行にブレークポイントを設置すれば判定が正しいかチェック可能(確認する場合は他の7箇所も設置すること)
                    Arrows[i].Top = -Arrows[i].Height;
                    
                }
                Application.DoEvents();
            }
        }

        public int RedHantei()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_RedLeft);
            Arrows.Add(_RedLeft2);
            Arrows.Add(_RedLeft3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                //押したタイミングによって判定している
                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //Perfect
                    if (Arrows[i].Top >= Pa && Arrows[i].Top <= Pb)
                    {
                        this.Hantei = 1;
                    }
                    //Great
                    else if (Arrows[i].Top >= Gra && Arrows[i].Top <= Grb)
                    {
                        this.Hantei = 2;
                    }
                    //Good
                    else if (Arrows[i].Top >= Gda && Arrows[i].Top <= Gdb)
                    {
                        this.Hantei = 3;
                    }
                    //Bad
                    else
                    {
                        this.Hantei = 4;
                    }
                }
                Application.DoEvents();
            }
            return this.Hantei;
        }

        public int BlueHantei()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_BlueDown);
            Arrows.Add(_BlueDown2);
            Arrows.Add(_BlueDown3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //押したタイミングによって判定している
                    if (Arrows[i].Top >= Pa && Arrows[i].Top <= Pb)
                    {
                        this.Hantei = 1;
                    }
                    else if (Arrows[i].Top >= Gra && Arrows[i].Top <= Grb)
                    {
                        this.Hantei = 2;
                    }
                    else if (Arrows[i].Top >= Gda && Arrows[i].Top <= Gdb)
                    {
                        this.Hantei = 3;
                    }
                    else
                    {
                        this.Hantei = 4;
                    }
                }
                Application.DoEvents();
            }
            return this.Hantei;
        }

        public int YellowHantei()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_YellowUp);
            Arrows.Add(_YellowUp2);
            Arrows.Add(_YellowUp3);


            for (var i = 0; i < Arrows.Count; i++)
            {
                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //押したタイミングによって判定している
                    if (Arrows[i].Top >= Pa && Arrows[i].Top <= Pb)
                    {
                        this.Hantei = 1;
                    }
                    else if (Arrows[i].Top >= Gra && Arrows[i].Top <= Grb)
                    {
                        this.Hantei = 2;
                    }
                    else if (Arrows[i].Top >= Gda && Arrows[i].Top <= Gdb)
                    {
                        this.Hantei = 3;
                    }
                    else
                    {
                        this.Hantei = 4;
                    }
                }
                Application.DoEvents();
            }
            return this.Hantei;
        }

        public int GreenHantei()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_GreenRight);
            Arrows.Add(_GreenRight2);
            Arrows.Add(_GreenRight3);



            for (var i = 0; i < Arrows.Count; i++)
            {
                if (Arrows[i].Top >= 10 && Arrows[i].Top <= 150)
                {
                    //押したタイミングによって判定している
                    if (Arrows[i].Top >= Pa && Arrows[i].Top <= Pb)
                    {
                        this.Hantei = 1;
                    }
                    else if (Arrows[i].Top >= Gra && Arrows[i].Top <= Grb)
                    {
                        this.Hantei = 2;
                    }
                    else if (Arrows[i].Top >= Gda && Arrows[i].Top <= Gdb)
                    {
                        this.Hantei = 3;
                    }
                    else
                    {
                        this.Hantei = 4;
                    }
                }
                Application.DoEvents();
            }
            return this.Hantei;
        }

        public void HanteiClear()
        {
            this.Hantei = 0;
        }

        public void Move()
        {
            _Move();
        }

        public void Set()
        {
            _Set();
        }

        public void RemovedRed()
        {
            _RemovedRed();
        }

        public void RemovedGreen()
        {
            _RemovedGreen();
        }

        public void RemovedBlue()
        {
            _RemovedBlue();
        }
        public void RemovedYellow()
        {
            _RemovedYellow();
        }

        public void ArrowsStoped()
        {
            var Arrows = new List<PictureBox>();
            Arrows.Add(_RedLeft);
            Arrows.Add(_RedLeft2);
            Arrows.Add(_RedLeft3);

            Arrows.Add(_BlueDown);
            Arrows.Add(_BlueDown2);
            Arrows.Add(_BlueDown3);

            Arrows.Add(_GreenRight);
            Arrows.Add(_GreenRight2);
            Arrows.Add(_GreenRight3);

            Arrows.Add(_YellowUp);
            Arrows.Add(_YellowUp2);
            Arrows.Add(_YellowUp3);
            for (int i = 0; i < Arrows.Count; i++)
            {
                Arrows[i].Top = (Arrows[i].Height - Arrows[i].Height - Arrows[i].Height);
                Application.DoEvents();
            }
        }
    }
}
