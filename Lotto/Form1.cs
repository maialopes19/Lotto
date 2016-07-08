using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Lotto : Form
    {
        //creting objects of classes
        Random rand = new Random();
        Dictionary<int, String> colors = new Dictionary<int, string>();

        //instantiating variables
        protected Label[] labels = new Label[5];
        protected int[] nBalls = new int[5];

        public Lotto()
        {
            InitializeComponent();
            ballColor();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            //putting labels in an array
            labels[0] = n1; labels[1] = n2; labels[2] = n3; labels[3] = n4; labels[4] = n5;

            //getting the random int values and put it in the nBalls array
            //trying to eliminate repeating rand numbers using a while loop
            nBalls[0] = rand.Next(1, 50);
            nBalls[1] = rand.Next(1, 50);
            while (nBalls[1] == nBalls[0])
                nBalls[1] = rand.Next(1, 50);

            nBalls[2] = rand.Next(1, 50);
            while (nBalls[2] == nBalls[0] || nBalls[2] == nBalls[1])
                nBalls[2] = rand.Next(1, 50);

            nBalls[3] = rand.Next(1, 50);
            while (nBalls[1] == nBalls[0] || nBalls[3] == nBalls[1] || nBalls[3] == nBalls[2])
                nBalls[3] = rand.Next(1, 50);

            nBalls[4] = rand.Next(1, 50);
            while (nBalls[4] == nBalls[0] || nBalls[4] == nBalls[1] || nBalls[4] == nBalls[2] ||
                   nBalls[4] == nBalls[3])
                nBalls[4] = rand.Next(1, 50);

            //Creatig another Thread in order to update the Labels
            Invoke(new Action (() =>
            {
                
                for (int i = 0; i < 5; i++)
                {
                    String bckColor = colors[nBalls[i]];// getting the key number from the dictionary
                    //setting colors of the labels depending on the numbers
                    if (bckColor.Equals("White"))
                    {
                        labels[i].BackColor = Color.White;
                        labels[i].ForeColor = Color.Black;
                    }
                        
                    else if (bckColor.Equals("Red"))
                    {
                        labels[i].BackColor = Color.Red;
                        labels[i].ForeColor = Color.White;
                    }
                        
                    else if (bckColor.Equals("Yellow"))
                    {
                        labels[i].BackColor = Color.Yellow;
                        labels[i].ForeColor = Color.Black;
                    }
                        
                    else if (bckColor.Equals("Black"))
                    {
                        labels[i].BackColor = Color.Black;
                        labels[i].ForeColor = Color.White;
                    }
                    else if (bckColor.Equals("Blue"))
                    {
                        labels[i].BackColor = Color.Blue;
                        labels[i].ForeColor = Color.White;
                    }
                   
                    labels[i].Text = nBalls[i].ToString();//displaying the numbers
                }
                String ballN = nBalls[0].ToString() + "-" + nBalls[1].ToString() + "-" +
                               nBalls[2].ToString() + "-" + nBalls[3].ToString() + "-" +
                               nBalls[4].ToString();
                DbConnection db = new DbConnection();
                db.Connect(ballN);//insert data on the database
                //colors.Clear();//clear the dictionary
            }));
        }
  
        //adding data on the dictionary  
        private void ballColor()
        {
              
            for (int i = 1; i < 51; i++)
            {
                if (i < 11)
                {
                    colors.Add(i, "White");
                }
                else if (i >= 10 &&  i < 21)
                {
                    colors.Add(i, "Red");
                }
                else if (i >= 20 && i < 31)
                {
                    colors.Add(i, "Yellow");
                }
                else if (i >= 30 && i < 41)
                {
                    colors.Add(i, "Black");
                }
                else if (i >= 40 && i <= 50)
                {
                    colors.Add(i, "Blue");
                }
            }
        }
    }
}
