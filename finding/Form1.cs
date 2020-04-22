using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace finding
{
    public partial class Form1 : Form
    { 

        List<int> lst_IdentificationLogarifmic = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int identificator;
            // initialisation
            Random rnd = new Random();
            int count = 0;
            lst_IdentificationLogarifmic.Clear();
            for(int i = 1; i<10000; i++)
            {
                identificator = rnd.Next(1,10000);
                if (0 == lst_IdentificationLogarifmic.Find(id => id == identificator))
                {
                    lst_IdentificationLogarifmic.Add(identificator);
                    count++;
                }                
            }
            label1.Text = count.ToString();
            //listBox1.;
            lst_IdentificationLogarifmic.Sort();
            listBox1.DataSource = lst_IdentificationLogarifmic.ToArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_findIdentificator_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();

            //system method
            stopWatch.Start();
            lbl_indIdIdentificator.Text = findSystemStandart(lst_IdentificationLogarifmic, int.Parse(edt_identificator.Text));
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            lbl_timer1.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);

            //logarifmic method
            stopWatch.Start();
            lbl_indIdIdentificator2.Text = findLogarifmic(lst_IdentificationLogarifmic, int.Parse(edt_identificator.Text));
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            lbl_timer2.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private string findLogarifmic(List<int> list, int value)
        {
            int move = 0; 
            int finish = list.Count;
            int iteration = 1;
            int n = (finish + 1) / 2; 
            while(list[move + n - 1] != value)
            {
                if (list[move + n - 1] < value)
                {
                    move = n-1;
                }
                else
                {
                    finish = n+1;
                }
                n = (finish - move + 1) / 2;
                iteration++;
            }
            return String.Format("result - {0}, itarations - {1}", 
                (list[move + n - 1]).ToString(),
                iteration);
        }
        private string findSystemStandart(List<int> list, int value)
        {
            return (list.FindIndex(x => x == value)).ToString();
        }
    
    }
}
 