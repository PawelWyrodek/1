﻿
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

        List<Postac> postacie = new List<Postac>();
        public Form1()
        {
            InitializeComponent();
        }

        for(int i = 0; i< 3; i++)
        {
          PrzedstawSie(postacie[i].imie)
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}

