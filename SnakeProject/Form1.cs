using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace SnakeProject
{
    public partial class Form1 : Form
    {
        string[] arr; 
        public Form1()
        {
            InitializeComponent();
            arr = new string[] { btn_1.Text, btn_2.Text, btn_3.Text, btn_4.Text, btn_5.Text, btn_6.Text, btn_7.Text, btn_8.Text, btn_9.Text }; //Här skapas en array som har i uppgift att hålla värderna på "knapparna". Det är denna array som skickas till funktionen checkWin
           
            
        }
        
        string marker = "X"; //En variabel som lagrar den aktuella pjäsen som ska spelas ut
     
        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_1_Click(object sender, EventArgs e) //När knapp 1 trycks ner
        {
            if (btn_1.Text == "X" || btn_1.Text == "O") //Kontrollerar om knappen är upptagen
            {
                MessageBox.Show("Platsen är upptagen"); //Ber spelaren att välja en ny plats
            }
            else
            {
                if (marker == "X") //Om den aktuella pjäsen är "X"
                {
                    btn_1.Text = "X"; //Lägg ut pjäsen
                    marker = "O"; //Ändra den aktuella pjäsen för att byta "Tur"
                    lbl_tur.Text = marker; //Ändrar texten som visar vems tur det är för spelarna
                    arr[0] = "X"; //Lägg in pjäsen i arrayen
                    checkWin.checkingWin(arr); //Kontrollera vinst
                }
                else if (marker == "O") //Om den aktuella pjäsen är "O" osv...
                {
                    btn_1.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[0] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_2_Click(object sender, EventArgs e) //Samma kontroll sker på alla knappar
        {
            if (btn_2.Text == "X" || btn_2.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_2.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[1] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_2.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[1] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (btn_3.Text == "X" || btn_3.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_3.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[2] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_3.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[2] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (btn_4.Text == "X" || btn_4.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_4.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[3] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_4.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[3] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (btn_5.Text == "X" || btn_5.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }

            else
            {
                if (marker == "X")
                {
                    btn_5.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[4] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_5.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[4] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (btn_6.Text == "X" || btn_6.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_6.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[5] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_6.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[5] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (btn_7.Text == "X" || btn_7.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_7.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[6] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_7.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[6] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (btn_8.Text == "X" || btn_8.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_8.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[7] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_8.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[7] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (btn_9.Text == "X" || btn_9.Text == "O")
            {
                MessageBox.Show("Platsen är upptagen");
            }
            else
            {
                if (marker == "X")
                {
                    btn_9.Text = "X";
                    marker = "O";
                    lbl_tur.Text = marker;
                    arr[8] = "X";
                    checkWin.checkingWin(arr);
                }
                else if (marker == "O")
                {
                    btn_9.Text = "O";
                    marker = "X";
                    lbl_tur.Text = marker;
                    arr[8] = "O";
                    checkWin.checkingWin(arr);
                }
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e) //När den här knappen trycks ner så startas programmet om och allt nollställs
        {
            Application.Restart(); //En funktion som stänger ner programmet och sedan startar ett nytt på en gång
        }
    }
    
}
