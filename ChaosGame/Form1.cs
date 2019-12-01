using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaosGame
{
    public partial class Form1 : Form
    {
        int n = 0;
        int iter = 0;
        double fraction = 0;
        int iterStep = 0;
        int imageSize;
        Boolean verticeVis = true;
        Boolean runRender = false;
        Boolean ranInit = false;
        // txt  - fractionTxt , displayIterTxt , sidesTxt , iterationTxt
        RunMode runMode = null;
        int currentIter = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void runOpTimer_Tick(object sender, EventArgs e)
        {

            readVars();
            setDisplayNum(iter);
            if(runRender)
            {
                if(!ranInit)
                {
                    if(gameImage.Height < gameImage.Width)
                    {
                        imageSize = gameImage.Height;
                    } else
                    {
                        imageSize = gameImage.Width;
                    }
                    runMode = new RunMode(n, fraction, iter, verticeVis, iterStep, imageSize);
                    runMode.initialLoop();
                    ranInit = true;
                } else
                {
                    currentIter = runMode.MainLoop();
                    displayIterTxt.Text = currentIter.ToString();
                    incrimentProgress((iter-currentIter), iter);
                }
                gameImage.Image = runMode.requestImage();
                Clipboard.SetImage(gameImage.Image);
            }
            if(!runRender)
            {
                ranInit = false;
            }
        }
        public int getVertCount() { return n; }
        public double getFraction() { return fraction; }


        private void readVars()
        {
            n = sideNumberSet(n);
            iter = iterNumberSet(iter);
            fraction = fractionSet(fraction);
            verticeVis = chkRead(vertChk);
            runRender = chkRead(runChk);
            iterStep = iterPerNumSet(iterStep);
        }

        private Boolean chkRead(CheckBox name)
        {
            if(name.Checked)
            {
                name.ForeColor = Color.Green;
                return true;
            } else {
                name.ForeColor = Color.Red;
                return false;
            }
        }

        private int textBoxRead(int num, TextBox name)
        {
            try { num = (int.Parse(name.Text) / int.Parse(name.Text))* int.Parse(name.Text); } catch (Exception e) { name.Text = ""; } // (parse/parse)*parse cancels out zero answers
            
            return num;
        }

        private int sideNumberSet(int num)
        {
            return textBoxRead(num, sidesTxt);
        }

        private int iterNumberSet(int num)
        {
            return textBoxRead(num, iterationTxt);
        }

        private int iterPerNumSet(int num)
        {
            return textBoxRead(num, iterPerStepTxt);
        }

        private double fractionSet(double num)
        {
            try { num = double.Parse(fractionTxt.Text); } catch(Exception e) {  }
            if((num<0) || (num>1))
            {
                num = .5;
                fractionTxt.Text = ".5";
            }
            return num;
        }
        
        private void setDisplayNum(int num)
        {
            displayIterTxt.Text = num.ToString();
        }

        private void incrimentProgress(int current, int total)
        {
            progress.Value = ((int)((current+0.0)/total * 1000));
            progress.Update();
        }
    }




    public class RunMode
    {
        int[][] vert = null;
        int vertN = 0;
        double fraction = .5;
        int iter = 1;
        int imageDim;
        Boolean visVert = true;
        int[] currCoor = null;
        int iterPerLoop = 5000;
        Picture image;
        Calculations maths;
        

        public RunMode(int vertCount, double frac, int iterations, Boolean VisVert, int iterStep, int imageDimensions)
        {
            vert = new int[vertCount][];
            vertN = vertCount;
            fraction = frac;
            iter = iterations;
            visVert = VisVert;
            iterPerLoop = iterStep;
            imageDim = imageDimensions;
            image = new Picture(imageDim);
            maths = new Calculations(imageDim);
            currCoor = new int[] { maths.randBeginCoord(imageDim), maths.randBeginCoord(imageDim) };
        }
        public void initialLoop() //place vertics
        {
            vert = maths.vertice(vertN);
            if (visVert)
            {
                for (int i = 0; i < vertN; i++)
                {
                    image.setPixelNxNrgb(maths.pointtoPixel(vert[i][0]), maths.pointtoPixel(vert[i][1]), 7, 255,255,255);
                }
            }
        }
        public int MainLoop() //places individual points
        {
            int count = iterPerLoop;
            while (iter!=0 && count!=0)
            {
                currCoor = maths.iterPixel(currCoor, vert[maths.randVert(vertN)], fraction);
                image.setPixel(maths.pointtoPixel(currCoor[0]), maths.pointtoPixel(currCoor[1]), maths.iterationColor(), imageDim);
                count = count - 1; iter = iter - 1;
            }
            return iter;
        }
        public Bitmap requestImage()
        {
            return image.requestImage();
        }
    }

    public class Picture
    {
        Bitmap pictureInfo = null;
        public Picture(int imageDimensions)
        {
            int height = imageDimensions; int width = height;
            pictureInfo = new Bitmap(width, height);
            Graphics black = Graphics.FromImage(pictureInfo);
            black.Clear(Color.Black);
            pictureInfo = new Bitmap(width, height, black);
        }
        public Bitmap requestImage()
        {
            return pictureInfo;
        }

        public Color getRGB(int r, int g, int b)
        {
            return Color.FromArgb(255, r, g, b);
        }
        public Color getHue(double degree)
        {
            int r, g, b = 0;
            if(degree<=1/6.0) // R|b
            {
                r = 255; b = 0; degree = (degree * 6) - 0;
                g = (int)(255 * degree);
            }
            else if (degree<=2/6.0)// |Gb
            {
                g = 255; b = 0; degree = (degree * 6) - 1;
                r = (int)(255 * degree);
            }
            else if (degree<=3/6.0) // rG|
            {
                g = 255; r = 0; degree = (degree * 6) - 2;
                b = (int)(255 * degree);
            }
            else if (degree <= 4 / 6.0) // r|B
            {
                b = 255; r = 0; degree = (degree * 6) - 3;
                g = (int)(255 * degree);
            }
            else if (degree <= 5 / 6.0) // |gB
            {
                b = 255; g = 0; degree = (degree * 6) - 4;
                r = (int)(255 * degree);
            }
            else // Rg|
            {
                r = 255; g = 0; degree = (degree * 6) - 5;
                b = (int)(255 * degree);
            }
            return getRGB(r, g, b); //not a perfect hue, but it should work good enough
        }
        public void setPixelRGB(int x, int y, int r, int g, int b)
        {
            pictureInfo.SetPixel(x, y, getRGB(r, g, b));
        }
        public void setPixel(int x,int y, double degree, int imageSize)
        {
            x = Math.Max(0, x); x = Math.Min(imageSize-1, x);
            y = Math.Max(0, y); y = Math.Min(imageSize-1, y); //avoids out of bounds error
            pictureInfo.SetPixel(x, y, getHue(degree));
        }
        public void setPixelNxN(int x, int y, int size, double degree)
        {
            size = (size - 1) / 2;
            for (int i = -size; i <= size; i++)
            {
                for (int a = -size; a <= size; a++)
                {
                    pictureInfo.SetPixel(x+a, y+i, getHue(degree));
                }
            }
        }
        public void setPixelNxNrgb(int x, int y, int size, int r, int g, int b)
        {
            size = (size - 1) / 2;
            for (int i = -size; i <= size; i++)
            {
                for (int a = -size; a <= size; a++)
                {
                    pictureInfo.SetPixel(x + a, y + i, getRGB(r,g,b));
                }
            }
        }
        public void setPixelGray(int x, int y, int color)
        {
            pictureInfo.SetPixel(x, y, getRGB(color,color,color));
        }
    }


    public class Calculations
    {
        double colorDegree = .0;
        int height;
        Random rand = new Random();
        public Calculations(int imageDimensions)
        {
            height = imageDimensions;
        }

        public double iterationColor()
        {
            colorDegree = colorDegree + .01;
            if(colorDegree>1.0) { colorDegree = 0.0; }
            return colorDegree;
        }
        public int pixeltoPoint(int p)
        {
            return (p - (height/2));
        }
        public int pointtoPixel(int p)
        {
            return (p + (height / 2));
        }
        public int[][] vertice(int n)
        {
            int[][] vertices = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int x = (int)(Math.Round(((height / 2) - 50) * Math.Cos((((2 * Math.PI) / n) * i + (Math.PI / -2)))));
                int y = (int)(Math.Round(((height / 2) - 50) * Math.Sin((((2 * Math.PI) / n) * i + (Math.PI / -2)))));
                vertices[i] = new int[] { x,y};
            }
            return vertices;
        }

        public int randVert(int n)
        {
            return rand.Next(n);
        }
        public int randBeginCoord(int dimension)
        {
            return rand.Next(dimension)-1000;
        }

        public int[] iterPixel(int[] current, int[] vertice, double fraction)
        {
            int[] coord = new int[2];
            coord[0] = (int)(Math.Round(current[0] * fraction) + (vertice[0] * (1.0 - fraction)));
            coord[1] = (int)(Math.Round(current[1] * fraction) + (vertice[1] * (1.0 - fraction)));
            return coord;
        }
    }
}
