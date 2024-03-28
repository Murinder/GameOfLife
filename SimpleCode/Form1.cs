using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleCode
{
    public partial class Form1 : Form
    {
        private string MouseStage = "Empty";
        private Graphics graphics;
        private int resolution;
        private GameEngine gameEngine;
        private Menu menu = new Menu();
        public Form1()
        {
            InitializeComponent();
            Bselect_Plant.Enabled = false;
            Bselect_Ploto.Enabled = false;
            Bselect_Travo.Enabled = false;
            BResult.Enabled = false;
            CountPlants.Text = "";
            CountTravo.Text = "";
            CountPloto.Text = "";
        }

        private void StartGame()
        {
            if (timer1.Enabled)
            {
                return;
            }
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            nudPlantVer.Enabled = false;
            BResult.Enabled = false;
            nudGrowthRate.Enabled = false;
            nudGrowthTime.Enabled = false;
            nudDecomposition.Enabled = false;
            nudAgeCell.Enabled = false;
            nudStarve.Enabled = false;
            nudDivision.Enabled = false;
            nudDivisionTravo.Enabled = false;
            LabelXnow.Text = "Текущая скорость: X1";
            timer1.Interval = 100;

            resolution = Convert.ToInt32(nudResolution.Value);

            Probability.PlantVer = Convert.ToInt32(nudPlantVer.Value);
            Probability.GrowthRate = Convert.ToInt32(nudGrowthRate.Value);
            Probability.GrowthTime = Convert.ToInt32(nudGrowthTime.Value);
            Probability.Decomposition = Convert.ToInt32(nudDecomposition.Value);
            Probability.AgeCell = Convert.ToInt32(nudAgeCell.Value);
            Probability.Starve = Convert.ToInt32(nudStarve.Value);
            Probability.Division = Convert.ToInt32(nudDivision.Value);
            Probability.DivisionTravo = Convert.ToInt32(nudDivisionTravo.Value);

            gameEngine = new GameEngine(
                rows:pictureBox1.Height / resolution, 
                cols:pictureBox1.Width / resolution, 
                density:Convert.ToInt32(nudDensity.Maximum) + Convert.ToInt32(nudDensity.Minimum) - Convert.ToInt32(nudDensity.Value)
                );

            Text = $"Generation {gameEngine.CurrentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
            {
                return;
            }
            timer1.Stop();
            nudPlantVer.Enabled = true;
            nudResolution.Enabled =true;
            nudDensity.Enabled = true;
            BResult.Enabled = true;
            nudGrowthRate.Enabled = true;
            nudGrowthTime.Enabled = true;
            nudDecomposition.Enabled = true;
            nudAgeCell.Enabled = true;
            nudStarve.Enabled = true;
            nudDivision.Enabled = true;
            nudDivisionTravo.Enabled = true;
            MouseStage = "Empty";

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Public\\Documents\\Data.txt", false))
            {
                foreach(var item in gameEngine.data)
                {
                    string text = $"{item.Generation},{item.CPlants},{item.CTravo},{item.CPloto}";
                    writer.WriteLine(text);
                }
                    
            }

        }
        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameEngine.GetCurrentGeneration();
            
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for(int y=0; y < field.GetLength(1); y++)
                {
                    Cell hasLife = field[x, y];
                    switch(hasLife.Stage)
                    {
                        case "Travo":
                            graphics.FillRectangle(Brushes.LimeGreen, x * resolution, y * resolution, resolution - 1, resolution - 1);
                            break;
                        case "Ploto":
                            graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                            break;
                        case "Plant":
                            if (hasLife.IsEatable())
                            {
                                graphics.FillRectangle(Brushes.DarkOliveGreen, x * resolution, y * resolution, resolution - 1, resolution - 1);
                            }
                            else
                            {
                                graphics.FillRectangle(Brushes.LightGreen, x * resolution, y * resolution, resolution - 1, resolution - 1);
                            }
                            break;
                        case "Empty":
                            break;
                    }
                }
            }
            pictureBox1.Refresh();
            gameEngine.NextGeneration();
            
            Text = $"Generation {gameEngine.CurrentGeneration}";
            CountPlants.Text = $"Число растений на поле: {gameEngine.CurrentPlants}";
            CountTravo.Text = $"Число травоядных на поле: {gameEngine.CurrentTravo}";
            CountPloto.Text = $"Число плотоядных на поле: {gameEngine.CurrentPloto}";

        }

        private void bstart_Click(object sender, EventArgs e)
        {
            StartGame();
            Bselect_Plant.Enabled = true;
            Bselect_Ploto.Enabled = true;
            Bselect_Travo.Enabled = true;
        }

        private void bstop_Click(object sender, EventArgs e)
        {
            StopGame();
            Bselect_Plant.Enabled = false;
            Bselect_Ploto.Enabled = false;
            Bselect_Travo.Enabled = false;
            CurentMouseStage.Text = "";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;
            if(e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.AddCell(x, y, MouseStage);
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                gameEngine.RemoveCell(x, y);
            }
        }
        private void Bselect_Plant_Click(object sender, EventArgs e)
        {
            MouseStage = "Plant";
            CurentMouseStage.Text = "Растение";
        }

        private void Bselect_Travo_Click(object sender, EventArgs e)
        {
            MouseStage = "Travo";
            CurentMouseStage.Text = "Травоядные";
        }

        private void Bselect_Ploto_Click(object sender, EventArgs e)
        {
            MouseStage = "Ploto";
            CurentMouseStage.Text = "Плотоядные";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DrawNextGeneration();
        }

        private void BBackToMenu_Click(object sender, EventArgs e)
        {

            Close();
        }
        private void BResult_Click(object sender, EventArgs e)
        {
            var result = new Result();
            result.Show();
            Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void BAccelX2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100 / 2;
            LabelXnow.Text = "Текущая скорость: X2";
        }

        private void BAccelX5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100 / 5;
            LabelXnow.Text = "Текущая скорость: X5";
        }

        private void BAccelX10_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100 / 10;
            LabelXnow.Text = "Текущая скорость: X10";
        }

        private void BAccelX1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            LabelXnow.Text = "Текущая скорость: X1";
        }
    }
}
