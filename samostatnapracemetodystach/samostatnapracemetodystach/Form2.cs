using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samostatnapracemetodystach
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string picoviny = "0123456789qwertzuiopasdfghjklyxcvbnmQWERTZUIOPASDFGHJKLYXCVBNM";
        bool JeAlfanum(ref int malapismena, ref int velkapismena, ref int jineznaky)
        {
            malapismena = 0;
            velkapismena = 0;
            jineznaky = 0;
            string veta = textBox1.Text;
            veta = veta.Trim();
            while(veta.Contains("  "))
            {
                veta = veta.Replace("  "," ");
            }
            foreach (char znak in veta)
            {
                if(picoviny.Contains(znak))
                {
                    if(znak >= 'a' && znak <= 'z')
                    {
                        malapismena++;
                    }

                    if (znak >= 'A' && znak <= 'Z')
                    {
                        velkapismena++;
                    }


                }
                else
                {
                    if(znak > 32) jineznaky++;
                    
                }
            }
            if (jineznaky == 0) return true;
            else return false;
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int malapismena = 0;
            int velkapismena = 0;
            int jineznaky = 0;
            if(JeAlfanum(ref malapismena,ref velkapismena, ref jineznaky) == true)
            {
                label2.Text = "Je Alfanumericky\n" + "Pocet malych pismen " + malapismena + "\nPocet velkych pismen " + velkapismena + "\nPocet jinych znaku " + jineznaky;
            }
            else
            {
                label2.Text = "Neni Alfanumericky\n" + "Pocet malych pismen " + malapismena + "\nPocet velkych pismen " + velkapismena + "\nPocet jinych znaku " + jineznaky;
            }

        }
    }
}
