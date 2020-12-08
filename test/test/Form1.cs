using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *SUPAWISH KANOKPONGSAKORN 6230525521 CUIE103
 * APPDEV TEST FINAL
 */


namespace test
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++) machine.Add(new List<int>() { 0 });
            form2.Show();
        }
        Random rd = new Random();
        List<List<int>> machine = new List<List<int>>();
        public int timecount = 0;

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < 4; i++)
            {
                int countwork = 0, countwork2 = 0;
                if (machine[i].Count < 1) return;
                for (int j = 0; j < machine[i].Count; j++)
                {
                    countwork += machine[i][j];
                }
                g.FillRectangle(Brushes.Orange, 50, 25 + i * 100, countwork * 10, 50);
                g.DrawString((i + 1).ToString(), DefaultFont, Brushes.Black, 25, 50 + i * 100);
                for (int j = 0; j < machine[i].Count; j++)
                {
                    countwork2 += machine[i][j];
                    g.DrawLine(Pens.Green, 50 + countwork2 * 10, 25 + i * 100, 50 + countwork2 * 10, 75 + i * 100);
                }
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            timecount += 1;
            if (timecount % 2 == 0 && timecount != 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    bool isRemove = false;
                    for (int j = 0; j < machine[i].Count; j++)
                    {
                        if (machine[i][j] > 0)
                        {
                            machine[i][j] -= 1;
                            isRemove = true;
                        }
                        if (isRemove) break;
                    }
                }
            }
            Refresh();
            form2.showtimer();
        }

        private void Startclock_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.myparent = this;
        }

        private void Randombutton_Click(object sender, EventArgs e)
        {
            int[] work = new int[4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < machine[i].Count; j++)
                {
                    work[i] += machine[i][j];
                }
            int min = 9999, indexmin = -1; 
            for (int i = 0; i < 4; i++)
            {
                if (work[i] < min)
                {
                    min = work[i];
                    indexmin = i;
                }
            }
            int morework = rd.Next(1, 6);
            machine[indexmin].Add(morework);
            Refresh();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int macno = Convert.ToInt32(textBox1.Text);
            int amtwkr = Convert.ToInt32(textBox2.Text);
            machine[macno-1].Add(amtwkr);
            Refresh();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            for (int i = 0; i < 4; i++)
            {
                string line = "";
                for (int j = 0; j < machine[i].Count; j++)
                {
                    line += machine[i][j].ToString() + ',';
                }
                sw.WriteLine(line);
            }
            sw.Close();
        }

        private void Loadbutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            string line;
            int i = 0;
            while((line = sr.ReadLine()) != null)
            {
                string[] splitline = line.Split(',');
                for (int j = 0; j < splitline.Length - 1; j++)
                {
                    machine[i].Add(Convert.ToInt32(splitline[j]));
                }
                i++;
            }
            sr.Close();
            Refresh();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int toRemove = -1;
            for (int i = 0; i < 4; i++)
            {
                int countwork = 0;
                for (int j = 0; j < machine[i].Count; j++)
                {
                    countwork += machine[i][j];
                }
                if (e.X >= 50 && e.X <= 50 + countwork * 10 && e.Y >= 25 + i * 100 && e.Y <= 75 + i * 100)
                {
                    toRemove = i;
                }
            }
            if (toRemove != -1) machine[toRemove].RemoveAt(machine[toRemove].Count - 1);
            Refresh();
        }
    }
}
