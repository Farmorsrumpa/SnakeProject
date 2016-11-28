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
       
        SoundPlayer audio = new SoundPlayer(SnakeProject.Properties.Resources.main); //Här läses ljudfilen för vinst in
        if (arr[0] == arr[1] && arr[1] == arr[2]) //För eventuella vinster horisontellt (ex. Om plats ett är samma som två och tre)
        {
            if (arr[0] == "X")
            {
                audio.Play(); //Spela vinstljudet
                MessageBox.Show("X Vinner!");
                

            }
            else if (arr[0] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
        if (arr[3] == arr[4] && arr[4] == arr[5])
        {
            if (arr[3] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[3] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }

       if (arr[6] == arr[7] && arr[7] == arr[8])
        {
            if (arr[6] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[6] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
        //För eventuella vinster lodrät
      if (arr[0] == arr[3] && arr[3] == arr[6])
        {
            if (arr[0] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[0] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
      if (arr[1] == arr[4] && arr[4] == arr[7])
        {
            if (arr[1] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[1] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
      if (arr[2] == arr[5] && arr[5] == arr[8])
        {
            if (arr[2] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[2] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
        //För eventuella vinster diagonalt
      if (arr[0] == arr[4] && arr[4] == arr[8])
        {
            if (arr[0] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[0] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
      if (arr[6] == arr[4] && arr[4] == arr[2])
        {
            if (arr[6] == "X")
            {
                audio.Play();
                MessageBox.Show("X Vinner!");
                
            }
            else if (arr[6] == "O")
            {
                audio.Play();
                MessageBox.Show("O Vinner!");
                
            }
        }
        if (arr[0] != "" && arr[1] != "" && arr[2] != "" && arr[3] != "" && arr[4] != "" && arr[5] != "" && arr[6] != "" && arr[7] != "" && arr[8] != "") //Kollar om det har blivit oavgjort. Dvs om alla platser är upptagna/har ett annat värde än "", skriv ut oavgjort!
              {
            MessageBox.Show("Oavgjort");
            Application.Restart(); //Programmet startas om
        }

    }
}