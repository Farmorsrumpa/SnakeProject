using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


class checkWin
{



    public static void checkingWin(string[] arr)
    {
        //För eventuella vinster horisontellt
        SoundPlayer audio = new SoundPlayer(SnakeProject.Properties.Resources.main);
        if (arr[0] == arr[1] && arr[1] == arr[2])
        {
            if (arr[0] == "X")
            {

                MessageBox.Show("X Vinner!");
                audio.Play();

            }
            else if (arr[0] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
        if (arr[3] == arr[4] && arr[4] == arr[5])
        {
            if (arr[3] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[3] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }

       if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            if (arr[6] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[6] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
        //För eventuella vinster lodrät
      if (arr[0] == arr[3] && arr[3] == arr[6])
        {
            if (arr[0] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[0] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
      if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            if (arr[1] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[1] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
      if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            if (arr[2] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[2] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
        //För eventuella vinster diagonalt
      if (arr[0] == arr[4] && arr[4] == arr[8])
        {
            if (arr[0] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[0] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
      if (arr[6] == arr[4] && arr[4] == arr[2])
        {
            if (arr[6] == "X")
            {
                MessageBox.Show("X Vinner!");
                audio.Play();
            }
            else if (arr[6] == "O")
            {
                MessageBox.Show("O Vinner!");
                audio.Play();
            }
        }
        if (arr[0] != "" && arr[1] != "" && arr[2] != "" && arr[3] != "" && arr[4] != "" && arr[5] != "" && arr[6] != "" && arr[7] != "" && arr[8] != "") //Kollar om det har blivit oavgjort. Dvs om alla platser är upptagna/har ett annat värde än "", skriv ut oavgjort!
              {
            MessageBox.Show("Oavgjort");
        }

    }
}