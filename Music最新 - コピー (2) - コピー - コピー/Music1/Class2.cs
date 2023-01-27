
using System.Drawing;

using System.Windows.Forms;


namespace Music
{
    class White
    {
        private PictureBox _WhiteLeft;
        private PictureBox _WhiteDown;
        private PictureBox _WhiteUp;
        private PictureBox _WhiteRight;
        private Control _Owner;

        public White(Control owner)
        {
            _WhiteLeft = new PictureBox();
            _WhiteDown = new PictureBox();
            _WhiteUp = new PictureBox();
            _WhiteRight = new PictureBox();
            _Owner = owner;
            _Owner.Controls.Add(_WhiteLeft);
            _Owner.Controls.Add(_WhiteDown);
            _Owner.Controls.Add(_WhiteUp);
            _Owner.Controls.Add(_WhiteRight);
            _Set();
        }

        private void _Set()
        {
            _WhiteLeft.SizeMode = PictureBoxSizeMode.AutoSize;
            _WhiteLeft.Image = Image.FromFile("SkalLeft.jpg");
            _WhiteLeft.Top = 80;
            _WhiteLeft.Left = 20;

            _WhiteDown.SizeMode = PictureBoxSizeMode.AutoSize;
            _WhiteDown.Image = Image.FromFile("SkalDown.jpg");
            _WhiteDown.Top = 80;
            _WhiteDown.Left = 100;

            _WhiteUp.SizeMode = PictureBoxSizeMode.AutoSize;
            _WhiteUp.Image = Image.FromFile("SkalUp.jpg");
            _WhiteUp.Top = 80;
            _WhiteUp.Left = 180;

            _WhiteRight.SizeMode = PictureBoxSizeMode.AutoSize;
            _WhiteRight.Image = Image.FromFile("SkalRight.jpg");
            _WhiteRight.Top = 80;
            _WhiteRight.Left = 260;
        }

        public void Set()
        {
            _Set();
        }
    }
}