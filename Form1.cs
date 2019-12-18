using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormhuffman
{
    public partial class Form1 : Form
    {
      public static int taille;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncheminfichier_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxcheminfichier.Text = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void buttonbroyer_Click(object sender, EventArgs e)
        {
            int b =0;
            taille = 0;
            string path = textBoxcheminfichier.Text;
            arbre_noeuds huffman = new arbre_noeuds(path, b, ref  taille);
           
            MessageBox.Show("LE FICHIER A ETE COMPRESSE !");

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 1;
            string path = textBoxcheminfichier.Text;
            arbre_noeuds huffman = new arbre_noeuds(path, b, ref  taille);
            
            MessageBox.Show("LE FICHIER A ETE DECOMPRESSE !");
        }

    }
       




       
    

     
}
