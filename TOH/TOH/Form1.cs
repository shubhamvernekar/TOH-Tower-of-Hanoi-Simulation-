using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace TOH
{
    public partial class GameForm : Form
    {
        private Label active = null;
        private int numberOfDisks;
        private string mode = "";
        int milliseconds = 550;
        private int pole_1_loc = 170;
        private int pole_2_loc = 432;
        private int pole_3_loc = 703;
        private int poleBase = 336;
        int moveCount = 0;
        private List<Color> diskColor = new List<Color>();
        public List<Label> disk_Pole1 = new List<Label>();
        public List<Label> disk_Pole2 = new List<Label>();
        public List<Label> disk_Pole3 = new List<Label>();
         int p1=0,p2=0,p3=0;
        List<int> po1w = new List<int>();
        List<int> po2w = new List<int>();
        List<int> po3w = new List<int>();
        private List<Step> steps = new List<Step>();
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numberOfDisks = 3;
            for (int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 0:diskColor.Add(Color.Red);
                        break;
                    case 1: diskColor.Add(Color.Blue);
                        break;
                    case 2: diskColor.Add(Color.Green);
                        break;
                    case 3: diskColor.Add(Color.Yellow);
                        break;
                    case 4: diskColor.Add(Color.Gray);
                        break;
                    case 5: diskColor.Add(Color.Gold);
                        break;
                    case 6: diskColor.Add(Color.HotPink);
                        break;
                    case 7: diskColor.Add(Color.LightSeaGreen);
                        break;
                    case 8: diskColor.Add(Color.BurlyWood);
                        break;
                }
            }
            mode = "play";
            GameMode.Text = "Play";
            loadDisk();
        }

    

        private void loadDisk()
        {
            for (int i = 0; i<numberOfDisks; i++)
            {
                Label l = new Label();
                l.AutoSize = false;
                l.Width = 20 + 20 * (numberOfDisks-i);
                l.BackColor = diskColor[i];
                l.Location = new Point(pole_1_loc - (l.Width / 2), poleBase - l.Height * i);
                l.Visible = true;
                l.Name = "" + i;
                l.Text = "" + 1;
                l.Font = new System.Drawing.Font("arial", 1);
                l.Click += new EventHandler(label_Click);
                panel.Controls.Add(l);
                disk_Pole1.Add(l);
            }
            p1 = numberOfDisks;
        }

        private void playGame()
        {
            StepsNote.AppendText("Hint :- \n"+"The problem can be solved in "+(Math.Pow(2.0,numberOfDisks)-1)+" moves");
        }

        private void simulate()
        {
            SolveHanoi obj = new SolveHanoi(numberOfDisks);
            obj.Tower(numberOfDisks, 1, 3, 2, steps);
            StepsNote.AppendText("Moves = " + steps.Count + "\n"+"Steps :-\n");
            for (int i = 0; i < steps.Count; i++)
            {
              //  StepsNote.AppendText("sou" + steps[i].src + " des" + steps[i].dest + "\n");
                StepsNote.AppendText("Source = " + steps[i].src + " Destination = " + steps[i].dest + "\n");
                move(steps[i].src, steps[i].dest);
                label1.Text = "Moves :- " + (i + 1);
                Refresh();
                Thread.Sleep(milliseconds);
             }
        }

        private void move(int source, int destination)
        {
            Label l;
            if (source == 1)
            {
                l = disk_Pole1[disk_Pole1.Count -1];
                disk_Pole1.RemoveAt(disk_Pole1.Count -1);
                p1--;
            }
            else if (source == 2)
            {
                l = disk_Pole2[disk_Pole2.Count - 1];
                disk_Pole2.RemoveAt(disk_Pole2.Count - 1);
                p2--;
            }
            else
            {
                l = disk_Pole3[disk_Pole3.Count - 1];
                disk_Pole3.RemoveAt(disk_Pole3.Count - 1);
                p3--;
            }

            if (destination == 1)
            {
                p1++;
                l.Location = new Point(pole_1_loc - (l.Width / 2), poleBase - l.Height * (p1-1));
                disk_Pole1.Add(l);
            }
            else if (destination == 2)
            {
                p2++;
                l.Location = new Point(pole_2_loc - (l.Width / 2), poleBase - l.Height * (p2-1));
                disk_Pole2.Add(l);
            }
            else
            {
                p3++;
                l.Location = new Point(pole_3_loc - (l.Width / 2), poleBase - l.Height * (p3 - 1));
                disk_Pole3.Add(l);
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        private void resetGame()
        {
            steps.Clear();
            p1 = 0;
            p2 = 0;
            p3 = 0;
            po1w.Clear();
            po2w.Clear();
            po3w.Clear();
            add();
            for (int i = 0; i < numberOfDisks; i++)
            {
                panel.Controls.RemoveByKey("" + i);
            }
            disk_Pole1.Clear();
            disk_Pole2.Clear();
            disk_Pole3.Clear();
        }
       
        private void play_Click_1(object sender, EventArgs e)
        {
            StepsNote.Clear();
            mode = GameMode.Text;
            resetGame();
            numberOfDisks = Convert.ToInt32(noDisks.Value);
            if (numberOfDisks > 5)
            {
                milliseconds = 500 - (numberOfDisks*50);
            }
            loadDisk();
            if (mode == "Play")
            {
                p1 = numberOfDisks;
                p2 = p3 = 0;
                moveCount = 0;
                add();
                playGame();
            }
            else
            {
                simulate();
            }
        }

        //This function checks weather the entered disk value is between 1 - 9
          private void disks_ValueChanged_1(object sender, EventArgs e)
        {
            if (noDisks.Value < 1 || noDisks.Value > 9)
            {
                MessageBox.Show("Range of disks must be between 1 to 9");
                noDisks.Value = 3;
            }
        }

          private void animateTimer_Tick(object sender, EventArgs e)
          {
             //animateTimer.Enabled = false;
          }

          private void button2_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          private void trackBar1_Scroll(object sender, EventArgs e)
          {
              milliseconds = 550;
              milliseconds = milliseconds - (trackBar1.Value * (milliseconds / 10));
          }

     
       
        /*
         * Code for game in PLAY mode
         * 
         */

          private void add()
          {
              po1w.Clear();
              for (int i = 0; i < numberOfDisks; i++)
              {
                  po1w.Add(20 + 20 * (3 - 1));
              }
          }

          private void label_Click(object sender, EventArgs e)
          {
              Label l = (sender as Label);
              if (l.Text == "1")
              {
                  if (Convert.ToInt32(l.Location.Y) == (poleBase - ((p1 - 1) * l.Height)))
                  {
                      active = l;
                  }
              }
              else if (l.Text == "2")
              {
                  if (Convert.ToInt32(l.Location.Y) == (poleBase - ((p2 - 1) * l.Height)))
                  {
                      active = l;
                  }
              }
              else if (l.Text == "3")
              {
                  if (Convert.ToInt32(l.Location.Y) == (poleBase - ((p3 - 1) * l.Height)))
                  {
                      active = l;
                  }
              }
             
          }

          private void pictureBox3_Click(object sender, EventArgs e)
          {
              if (active != null)
              {
                  if (po2w.Count == 0)
                  {
                      active.Location = new Point(pole_2_loc - (active.Width / 2), poleBase);
                      p2++;
                      if (active.Text == "1")
                      {
                          p1--;
                          if(po1w.Count>0)
                          po1w.RemoveAt(po1w.Count - 1);
                      }
                      else if (active.Text == "3")
                      {
                          p3--;
                          if(po3w.Count>0)
                          po3w.RemoveAt(po3w.Count - 1);
                      }
                      active.Text = "2";
                      po2w.Add(Convert.ToInt32(active.Width));
                      label1.Text = "Moves : " + ++moveCount;
                  }
                  else
                  {
                      if (Convert.ToInt32(active.Width) < po2w[po2w.Count-1])
                      {
                          active.Location = new Point(pole_2_loc - (active.Width / 2), poleBase -(p2*active.Height));
                          p2++;
                          if (active.Text == "1")
                          {
                              p1--;
                              if (po1w.Count > 0)
                                  po1w.RemoveAt(po1w.Count - 1);
                          }
                          else if (active.Text == "3")
                          {
                              p3--;
                              if (po3w.Count > 0)
                                  po3w.RemoveAt(po3w.Count - 1);
                          }
                          active.Text = "2";
                          po2w.Add(Convert.ToInt32(active.Width));
                          label1.Text = "Moves : " + ++moveCount;
                      }
                  }
              }
          }

          private void destinationPole_Click(object sender, EventArgs e)
          {
              if (active != null)
              {
                  if (po3w.Count == 0)
                  {
                      active.Location = new Point(pole_3_loc - (active.Width / 2), poleBase);
                      p3++;
                      if (active.Text == "1")
                      {
                          p1--;
                          if(po1w.Count>0)
                          po1w.RemoveAt(po1w.Count - 1);
                      }
                      else if (active.Text == "2")
                      {
                          p2--;
                          if(po2w.Count>0)
                          po2w.RemoveAt(po2w.Count - 1);
                      }
                      active.Text = "3";
                      po3w.Add(Convert.ToInt32(active.Width));
                      label1.Text = "Moves : " + ++moveCount;
                      check();
                  }
                  else
                  {
                      if (Convert.ToInt32(active.Width) < po3w[po3w.Count-1])
                      {
                          active.Location = new Point(pole_3_loc - (active.Width / 2), poleBase - (p3 * active.Height));
                          p3++;
                          if (active.Text == "1")
                          {
                              p1--;
                              if(po1w.Count>0)
                              po1w.RemoveAt(po1w.Count - 1);
                          }
                          else if (active.Text == "2")
                          {
                              p2--;
                              if(po2w.Count>0)
                              po2w.RemoveAt(po2w.Count - 1);
                          }
                          active.Text = "3";
                          po3w.Add(Convert.ToInt32(active.Width));
                          label1.Text = "Moves : " + ++moveCount;
                          check();
                      }
                  }
              }
          }

          private void reset_Click_1(object sender, EventArgs e)
          {
              resetGame();
              numberOfDisks = Convert.ToInt32(noDisks.Value);
              loadDisk();
          }

          private void pictureBox2_Click(object sender, EventArgs e)
          {
              if (active != null)
              {
                  if (po1w.Count == 0)
                  {
                      active.Location = new Point(pole_1_loc - (active.Width / 2), poleBase);
                      p1++;
                      if (active.Text == "2")
                      {
                          p2--;
                          if (po2w.Count > 0)
                              po2w.RemoveAt(po2w.Count - 1);
                      }
                      else if (active.Text == "3")
                      {
                          p3--;
                          if (po3w.Count > 0)
                              po3w.RemoveAt(po3w.Count - 1);
                      }
                      active.Text = "1";
                      po1w.Add(Convert.ToInt32(active.Width));
                      label1.Text = "Moves : " + ++moveCount;
                  }
                  else
                  {
                      if (Convert.ToInt32(active.Width) < po1w[po1w.Count - 1])
                      {
                          active.Location = new Point(pole_1_loc - (active.Width / 2), poleBase - (p1 * active.Height));
                          p1++;
                          if (active.Text == "2")
                          {
                              p2--;
                              if (po2w.Count > 0)
                                  po2w.RemoveAt(po1w.Count - 1);
                          }
                          else if (active.Text == "3")
                          {
                              p3--;
                              if (po3w.Count > 0)
                                  po3w.RemoveAt(po3w.Count - 1);
                          }
                          active.Text = "1";
                          po1w.Add(Convert.ToInt32(active.Width));
                          label1.Text = "Moves : " + ++moveCount;
                      }
                  }
              }
          }

          void check()
          {
              if (p3 == numberOfDisks)
              {
                  MessageBox.Show("Congratulations you Win !!!");
                  resetGame();
              }
          }

    }
}
