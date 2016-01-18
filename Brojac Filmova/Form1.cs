using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brojac_Filmova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var watchedMovies = 0;

            foreach (string line in System.IO.File.ReadLines("C:\\Users\\Buske\\My documents\\filmtest.txt"))
            {
                listBox1.Items.Add(line);

                if (line.Contains("GLEDANO"))
                {
                    watchedMovies++;
                }
                
                
            }
            
            label1.Text = "Total number of movies: " + listBox1.Items.Count.ToString();
            label2.Text = "Watched movies: " + watchedMovies + "/" + listBox1.Items.Count.ToString();
                                    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        

        
    }
}
