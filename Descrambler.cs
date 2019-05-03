using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Descramble597
{
    public partial class Descrambler : Form
    {
        string filestring;
        string filestringoriginal;
        int blocksize = 2;
        int textsize = 0;
        public Descrambler()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult result = dlg.ShowDialog();
            string file = dlg.FileName;
            filestringoriginal = File.ReadAllText(file);
           // byte[] filebytes  = File.ReadAllBytes(file);   //ReadAllText won't read null bytes



            filestring = filestringoriginal;

            tbxScrambled.Text = filestring;
            textsize = filestring.Length;
            lblSize.Text = textsize.ToString();
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            filestring = filestringoriginal.Substring(Convert.ToInt32(udStrip.Value));
            tbxScrambled.Text = filestring;
            textsize = filestring.Length;
            lblSize.Text = textsize.ToString();
        }

         public static string Reverse(string s)
        //source: https://stackoverflow.com/a/228060   PeteT 2008.10.23
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void UdBlocksize_ValueChanged(object sender, EventArgs e)
        {
            blocksize = Convert.ToInt32(udBlocksize.Value);
            //find how many blocks to divide the string into
            int cBlocks = textsize / blocksize;

            string[] stBlocks = new string[cBlocks];
            int blockstart = 0;

            for (int blocknum = 1; blocknum <= cBlocks; blocknum++)
            {
                stBlocks[blocknum - 1] = filestring.Substring(blockstart, blocksize);
                blockstart += blocksize;
            }
            //Do the reversing
            for (int blocknum = 1; blocknum <= cBlocks; blocknum++)
            {
                stBlocks[blocknum - 1] = Reverse(stBlocks[blocknum - 1]);
            }
            //Back to string
            string stDescrambled = string.Join("", stBlocks);
            tbxDescrambled.Text = stDescrambled;
        }
    }
}
