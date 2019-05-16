
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Postac
        {
            string imie;
            string hp;

            public string PrzedstawSie(string imie)
            {
                return imie;
            }

        }

        public class Wojownik : Postac
        {

        }

        public class Mag : Postac
        {

        }

        public class Rolnik : Postac
        {

        }

        /*  jakbym zdefiniował listę to pętla by wyglądała tak
            postacie[3]

            for (int i = 0; i< 3; i++)
            {
              PrzedstawSie(postacie[i].imie)
            }
        */


  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

