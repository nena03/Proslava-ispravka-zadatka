using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;
using Proslava;

namespace Proslava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Proslava[] pr = new Proslava[100];
        int n = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            Proslava[] pr ={
                              (Proslava)(new Osoba("Milos","Petrovic", 45, "06003564889")),
                              (Proslava)(new Osoba("Ana","Petrovic", 35, "0600356475")),
                              (Proslava)(new Osoba("Goran","Katic", 47, "061223456")),
                              (Proslava)(new Osoba("Minja","Kujundzic", 25, "060226544")),
                              (Proslava)(new Osoba("Olja","Jovanovic", 34, "0665547822"))};

            for (int i = 0; i < pr.Length; i++)
            {
                if (pr[i] is Osoba)
                    listBox1.Items.Add("Osoba: " + pr[i].Info());

            }


            for (int i = 0; i < pr.Length; i++)
            {
                for (int j = i + 1; j < pr.Length; j++)
                {
                    if (pr[j].StarijeOd(pr[i]))
                    {
                        Proslava pom = pr[i];
                        pr[i] = pr[j];
                        pr[j] = pom;
                    }
                }
            }

            for (int i = 0; i < pr.Length; i++)
            {
                if (pr[i] is Osoba)
                    listBox2.Items.Add("Osoba: " + pr[i].Info());

            }

        }
    }
}
