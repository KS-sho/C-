using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Musics
    {
        private Audio _MP1 = new Audio(@"..\..\Resources\wav\タクティカルエンカウンター.mp3");
        private Audio _MP2 = new Audio(@"..\..\Resources\wav\Rock_Barrage.mp3");
        private Audio _MP3 = new Audio(@"..\..\Resources\wav\Hyper_Chase.wav");
        private Audio player1 = new Audio(@"..\..\Resources\wav\se_amd05.wav");
        private Audio player2 = new Audio(@"..\..\Resources\wav\se_amd04.wav");
        private Audio player3 = new Audio(@"..\..\Resources\wav\se_amd03.wav");
        private Audio player4 = new Audio(@"..\..\Resources\wav\se_sub05.wav");
        private Audio player5 = new Audio(@"..\..\Resources\wav\se_sub06.wav");

        public Musics()
        {

        }
        private void _MusicStart(int Num)
        {
            if(Num == 1)
            {
                _MP1.Play();
            }else if (Num == 2)
            {
                _MP2.Play();
            }else if(Num == 3)
            {
                _MP3.Play();
            }
        }

        public void MusicStart(int Num)
        {
            _MusicStart(Num);
        }

        private void _MusicStop()
        {
            _MP1.Stop();
            _MP2.Stop();
            _MP3.Stop();
        }

        public void MusicStop()
        {
            _MusicStop();
        }

        private void _SeStop()
        {
            player1.Stop();
            player2.Stop();
            player3.Stop();
            player4.Stop();
            player5.Stop();
        }

        public void SeStop()
        {
            _SeStop();
        }

        private void _SePlay(int Num)
        {
            if(Num == 1)
            {
                player1.Play();
            }else if(Num == 2)
            {
                player2.Play();
            }
            else if (Num == 3)
            {
                player3.Play();
            }
            else if (Num == 4)
            {
                player4.Play();
            }
        }
        public void SePlay(int Num)
        {
            _SePlay(Num);
        }

        private void _MissSe()
        {
            player5.Play();
        }

        public void MissSe()
        {
            _MissSe();
        }
    }
}
