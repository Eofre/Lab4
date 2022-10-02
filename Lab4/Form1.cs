using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Plants> plantList = new List<Plants>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            int flowersCount = 0;
            int bushCount = 0;
            int treeCount = 0;


            foreach (var plant in this.plantList)
            {
                if (plant is Flowers)
                {
                    flowersCount++;
                }
                else if (plant is Bush)
                {
                    bushCount++;
                }
                else if (plant is Tree)
                {
                    treeCount++;
                }
                
            }
            txtInfo.Text = "Цветок\tКустарник\tДерево";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t\t{2}", flowersCount, bushCount, treeCount);
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.plantList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.plantList.Add(Flowers.Generate());
                        break;
                    case 1:
                        this.plantList.Add(Bush.Generate());
                        break;
                    case 2:
                        this.plantList.Add(Tree.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.plantList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                
                return;
            }
            var plant = this.plantList[0];
            this.plantList.RemoveAt(0);
            txtOut.Text = plant.GetInfo();
            ShowInfo();
        }
    }
}
