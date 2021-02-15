using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flood_it
{
    public partial class Form1 : Form
    {
        Brush myBrush;
        Graphics graphicsObject;
        List<Color> lstGameColours = new List<Color>();
        List<string> lstGameColourNames = new List<string>();

        string colourName;
        Random rnd = new Random();

        List<List<Rectangle>> lst2dSqures = new List<List<Rectangle>>();

        List<List<string>> lst2dSquareColourNames = new List<List<string>>();

        List<List<bool>> lst2dIsSquareColourChanged = new List<List<bool>>();

        string clickedColourName;
        int clickCounter = 0;
        bool gameOver;
        public Form1()
        {
            InitializeComponent();
            graphicsObject = this.CreateGraphics();
            setColours();
        }
        void setColours()
        {
            lstGameColours.Add(Color.Red);
            lstGameColours.Add(Color.White);
            lstGameColours.Add(Color.Black);
            lstGameColours.Add(Color.Gray);
            lstGameColours.Add(Color.Yellow);
            lstGameColours.Add(Color.Orange);

            lstGameColourNames.Add("red");
            lstGameColourNames.Add("white");
            lstGameColourNames.Add("black");
            lstGameColourNames.Add("gray");
            lstGameColourNames.Add("yellow");
            lstGameColourNames.Add("orange"); 
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            createSquares();

            lst2dIsSquareColourChanged[0][0] = true;
        }
        void createSquares()
        {
            List<Rectangle> lstSquaresInRow = new List<Rectangle>();
            List<string> lstColourNamesInRow = new List<string>();
            List<bool> lstIsColourChangedInRow = new List<bool>();

            Rectangle rect = new Rectangle();
            rect.Height = 30;
            rect.Width = 30;

            for (int row = 0; row < 12; row++)
            {
                for (int column = 0; column < 12; column++)
                {
                    setSquareColour();
                    rect.Location = new Point((column * 30) + 60, (row * 30) + 50);

                    graphicsObject.FillRectangle(myBrush, rect);
                    lstSquaresInRow.Add(rect);
                    lstColourNamesInRow.Add(colourName);
                    lstIsColourChangedInRow.Add(false);
                }

                lst2dSqures.Add(lstSquaresInRow);
                lstSquaresInRow = new List<Rectangle>();

                lst2dSquareColourNames.Add(lstColourNamesInRow);
                lstColourNamesInRow = new List<string>();

                lst2dIsSquareColourChanged.Add(lstIsColourChangedInRow);
                lstIsColourChangedInRow = new List<bool>();
            }
        }
        void setSquareColour()
        {
            int colourNumber = rnd.Next(0, 6);
            myBrush = new SolidBrush(lstGameColours[colourNumber]);
            colourName = lstGameColourNames[colourNumber];
        }
        private void PBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPBox = (PictureBox)sender;
            clickCounter++;
            label1.Text = clickCounter.ToString() + "/24";
            if (!gameOver && !checkCounter())
            {
                clickedColourName = clickedPBox.Tag.ToString();
                myBrush = new SolidBrush(clickedPBox.BackColor);
                changeSquareColours();
            }
        }
        private bool checkCounter()
        {
            bool status = false;
            if (clickCounter > 24)
            {
                status = true;
                MessageBox.Show("You Lost! :(");
                restartGame();
            }
            return status;
        }
        void restartGame()
        {
            lst2dSqures.Clear();
            lst2dSqures.TrimExcess();
            lst2dSqures = new List<List<Rectangle>>();

            lst2dSquareColourNames.Clear();
            lst2dSquareColourNames.TrimExcess();
            lst2dSquareColourNames = new List<List<string>>();

            lst2dIsSquareColourChanged.Clear();
            lst2dIsSquareColourChanged.TrimExcess();
            lst2dIsSquareColourChanged = new List<List<bool>>();

            clickCounter = 0;
            gameOver = false;
        }
        void changeSquareColours()
        {
            if (!gameOver)
            {
                paintPreviouslyChangedRectangles();
                int loop = 0;

            start:
                if (loop < 3)
                {
                    for (int row = 0; row < 12; row++)
                    {
                        for (int column = 0; column < 12; column++)
                        {
                            if (row == 0 && column >= 0)
                            {
                                checkFirstRow(column);
                            }
                            else if (row > 0 && clickedColourName == lst2dSquareColourNames[row][column])
                            {
                                if (controlSidesIfColourChanged(row, column))
                                {
                                    lst2dIsSquareColourChanged[row][column] = true;

                                    graphicsObject.FillRectangle(myBrush, lst2dSqures[row][column]);
                                    lst2dSquareColourNames[row][column] = clickedColourName;

                                    checkSquareSidesForColourSameness(row, column);
                                }
                            }
                        }
                    }
                    loop++;
                    goto start;
                }
                gameControl(clickedColourName);
            }
        }
        void paintPreviouslyChangedRectangles()
        {
            for (int row = 0; row < 12; row++)
            {
                for (int column = 0; column < 12; column++)
                {
                    if (lst2dIsSquareColourChanged[row][column])
                    {
                        graphicsObject.FillRectangle(myBrush, lst2dSqures[row][column]);
                        lst2dSquareColourNames[row][column] = clickedColourName;
                    }
                }
            }
        }
        void checkFirstRow(int column)
        {
            if (lst2dSquareColourNames[0][column] == clickedColourName)
            {
                try
                {
                    {
                        if (lst2dIsSquareColourChanged[0][column - 1] || lst2dIsSquareColourChanged[1][column] || lst2dIsSquareColourChanged[0][column + 1])
                        {
                            lst2dIsSquareColourChanged[0][column] = true;
                            graphicsObject.FillRectangle(myBrush, lst2dSqures[0][column]);
                            lst2dSquareColourNames[0][column] = clickedColourName;
                        }
                    }
                }
                catch (Exception) { }
            }
        }
        private bool controlSidesIfColourChanged(int satir, int sutun)
        {
            bool status = false;
            try
            {
                if (lst2dIsSquareColourChanged[satir - 1][sutun] || lst2dIsSquareColourChanged[satir][sutun - 1] || lst2dIsSquareColourChanged[satir + 1][sutun] || lst2dIsSquareColourChanged[satir][sutun + 1])
                {
                    status = true;
                }
            }
            catch (Exception) { }
            return status;
        }
        void checkSquareSidesForColourSameness(int row, int column)
        {
            try
            {
                if (clickedColourName == lst2dSquareColourNames[row - 1][column])
                {
                    lst2dIsSquareColourChanged[row - 1][column] = true;
                }
                if (clickedColourName == lst2dSquareColourNames[row - 1][column - 1])
                {
                    lst2dIsSquareColourChanged[row - 1][column - 1] = true;
                }
                if (clickedColourName == lst2dSquareColourNames[row - 1][column + 1])
                {
                    lst2dIsSquareColourChanged[row - 1][column + 1] = true;
                }
            }
            catch (Exception){}
        }
        void gameControl(string colourName)
        {
            int changedColourNumber = 0;

            for (int row = 0; row < 12; row++)
            {
                for (int column = 0; column < 12; column++)
                {
                    if (lst2dSquareColourNames[row][column] == colourName)
                    {
                        changedColourNumber++;
                    }
                }
            }

            if (clickCounter <= 24 && changedColourNumber == 144)
            {
                MessageBox.Show("You Won! :)");
                gameOver = true;
                restartGame();
            }
        }
    }
}

    
