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
    // the Form class handles the basic app functions, bitmap/image generation falls to the image and calculations class and the RunMode class handles the loops
    public partial class Form1 : Form
    {
        int     n        = 0;   //the number of vertices used to generate the image
        double  fraction = 0;   //how close the point will move to the chosen vertice, i.e. .3333 wil move the point 1/3 the total distance towards the vertice 
        int     iter     = 0;   //the number of pixels to be placed
        int     iterStep = 0;   //how many pixels are placed per 'Step', the longer the step, the laggier the app will be since the app doesn't handle input while a step is running
        int     imageSize; //the size of the image to be generated, it is always a square

        Boolean verticeVis = false; //whether or not we draw a small white square where each vertice lies
        Boolean runRender = false; //whether the 'steps' are currently running (the runMode)
        Boolean ranInit = false; //the initial part of the runloop, has to be ran before the runMode can start its steps.

        RunMode runMode = null; //handles the steps
        int     currentIter = 0; //tracks the current progress, used to tell the user how close we are to finishing the image generation.


        public Form1()
        {
            InitializeComponent();
        }

        //happens every 10 milliseconds, this is where the iterations actually happen (sort of the main() of this class).
        private void runOpTimer_Tick(object sender, EventArgs e)
        {
            readVars(); //update our variables
            setDisplayNum(iter); //update our display
            if(runRender) //when the box is checked
            {
                if(!ranInit) //run the initial loop portion, if we haven't done this already
                {
                    //since the gameImage pictureBox changes size, we figure out know how big the image to be generated should be.
                    if (gameImage.Height < gameImage.Width) //the image must be square, so we use the smaller dimension as the image's dimensions.
                    {
                        imageSize = gameImage.Height;
                    } else
                    {
                        imageSize = gameImage.Width;
                    }

                    runMode = new RunMode(n, fraction, iter, verticeVis, iterStep, imageSize); //feed the runMode the proper info.
                    runMode.initialLoop(); //run the initial loop
                    ranInit = true; //we just ran the init portion, switch the variable so we don't run it again.
                }
                else //run the main loop, since we've alread ran the init portion
                {
                    currentIter = runMode.mainLoop(); //run one step, update how many pixels we've placed so far.
                    displayIterTxt.Text = currentIter.ToString(); //update 
                    incrimentProgress((iter-currentIter), iter); //update our progress bar
                }
                gameImage.Image = runMode.requestImage(); //update the gameImage picturebox
                Clipboard.SetImage(gameImage.Image); //in case we want to keep this image, we copy the latest image to the clipboard
            }
            else if(!runRender) //reset the ranInit variable, since the box is unchecked.
            {
                ranInit = false;
            }
        }

        //update the variables via text boxes
        private void readVars()
        {
            n = sideNumberSet(n);
            iter = iterNumberSet(iter);
            fraction = fractionSet(fraction);
            verticeVis = chkRead(vertChk);
            runRender = chkRead(runChk);
            iterStep = iterPerStepSet(iterStep);
        }

        //colors the checkboxes, red for unchecked, green for checked.
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

        //verify that the text input is valid, if not reset the box
        private int textBoxRead(int num, TextBox name)
        {
            try { num = int.Parse(name.Text); } catch (Exception e) { name.Text = ""; } // (parse/parse)*parse cancels out zero answers
            
            return num;
        }

        //variable update for n (side number)
        private int sideNumberSet(int num)
        {
            return textBoxRead(num, sidesTxt);
        }
        //variable update for iter (total pixels to be placed)
        private int iterNumberSet(int num)
        {
            return textBoxRead(num, iterationTxt);
        }
        //variale update for iterStep (pixels per step)
        private int iterPerStepSet(int num)
        {
            return textBoxRead(num, iterPerStepTxt);
        }
        //variable update for fraction, verify that input is valid.
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
        //display the total amount of iterations remaining
        private void setDisplayNum(int num)
        {
            displayIterTxt.Text = num.ToString();
        }
        //a progress bar that shows how close the image is to being fully generated.
        private void incrimentProgress(int current, int total)
        {
            progress.Value = ((int)((current+0.0)/total * 1000)); //0.0 to convert current to a double, 1000 because 1000 is the max value of the progres bar
            progress.Update();
        }
    }


    //RunMode handles theloop, initial run portion, and the steps (sort of the middleman between the form and the math/image.
    public class RunMode
    {
        int     vertN;              //the total number of vertices
        double  fraction;           //the fraction
        int     iters;               //total number of pixels to be placed.
        int     iterPerLoop;        //the number of pixels to be placed per loop.
        int     imageSize;          //the size of the image
        int[][] vert     = null;    //an array of the coordinate location of the vertices.
        int[]   currCoor;           //the coordinate of the current point.
        Boolean visVert;            //whether or not we print out if 

        Picture      image;
        Calculations maths;
        

        public RunMode(int vertCount, double frac, int iterations, Boolean VisVert, int iterStep, int imageDimensions)
        {
            //set variables
            vertN = vertCount;
            fraction = frac;
            iters = iterations;
            iterPerLoop = iterStep;
            imageSize = imageDimensions;
            vert = new int[vertCount][];
            visVert = VisVert;
            
            //make proper classes
            image = new Picture(imageSize);
            maths = new Calculations(imageSize);

            //get the initial coordinate (random)
            currCoor = new int[] { maths.randBeginCoord(imageSize), maths.randBeginCoord(imageSize) };
        }

        //the initial loop ran before the main 'step' loop
        public void initialLoop() //place vertics
        {
            vert = maths.vertice(vertN); //set the vertice coordinates
            if (visVert) //place the vertices is visVert is true
            {
                for (int i = 0; i < vertN; i++)
                {
                    image.setPixelNxNrgb(maths.pointtoPixel(vert[i][0]), maths.pointtoPixel(vert[i][1]), 7, 255,255,255);
                }
            }
        }
        public int mainLoop() //places individual points, this is the step
        {
            int count = iterPerLoop; //iterPerLoop should not change, make a copy of iterPerLoop so we can keep track how many pixels still need to be placed this loop
            while (iters!=0 && count!=0) //while there is still pixels to be placed overall or within this step, continue the step.
            {
                currCoor = maths.iterPixel(currCoor, vert[maths.randVert(vertN)], fraction); //get the next coordinate via 'midpointing' a random vertice.
                image.setPixel(maths.pointtoPixel(currCoor[0]), maths.pointtoPixel(currCoor[1]), maths.iterationColor(), imageSize); //update the bitmap with the new coordinate
                count = count - 1; iters = iters - 1; //we've added a pixel decrease both the 
            }
            return iters; //return the number of remaining amount of pixels to be placed 
        }

        //lets the form app request the latest bitmap image, so the pictureBox can be updated
        public Bitmap requestImage()
        {
            return image.requestImage();
        }
    }

    //the picture class handles rgb, hsv conversions, and creating, drawing, and updating the bitmap image.
    public class Picture
    {
        Bitmap pictureInfo = null;
        public Picture(int imageDimensions)
        {
            int height = imageDimensions; int width = height; //we have height and width in case non-square images become allowed, but for now the width and height are always the same
            pictureInfo = new Bitmap(width, height); //create a new bitmap with the same size as the pictureBox (but still square)
            Graphics black = Graphics.FromImage(pictureInfo);
            black.Clear(Color.Black);
            pictureInfo = new Bitmap(width, height, black); //make sure the image is clear and black.
        }

        //let runMode request the latest bitmap.
        public Bitmap requestImage()
        {
            return pictureInfo;
        }

        //get an rgb color variable from 3 seperate r, g, b values.
        public Color getRGB(int r, int g, int b)
        {
            return Color.FromArgb(255, r, g, b);
        }

        //get an rgb value according to a hue degree (basically from a hsv value, where s & h = 100%).
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
        //set pixel with an rgb value, currently unused.
        public void setPixelRGB(int x, int y, int r, int g, int b)
        {
            pictureInfo.SetPixel(x, y, getRGB(r, g, b));
        }
        //set a pixel with a degree (hsv).
        public void setPixel(int x,int y, double degree, int imageSize)
        {
            x = Math.Max(0, x); x = Math.Min(imageSize-1, x);
            y = Math.Max(0, y); y = Math.Min(imageSize-1, y); //avoids out of bounds error
            pictureInfo.SetPixel(x, y, getHue(degree));
        }
        //set a grid of pixels using hsv, unused currently.
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
        //set a grid of pixels using rgb, used for drawing the vertices.
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
    }

    //the calculations class handles the math for the chaos game, coordinate math, 'midpoints', random numbers, etc.
    public class Calculations
    {
        double colorDegree = .0; //every time a pixel is placed we increase the colorDegree, this affects the pixel hues.
        int imageSize; //the size of the image we have

        Random rand = new Random(); //this lets us get random numbers
        public Calculations(int imageDimensions)
        {
            imageSize = imageDimensions; //set the image size
        }
        //every time a pixel is placed increase the colorDegree, (colorDegree affects the hue of the pixels being placed)
        public double iterationColor()
        {
            colorDegree = colorDegree + .01;
            if(colorDegree>1.0) { colorDegree = 0.0; } //reset if the degree is above 1
            return colorDegree;
        }
        //go from a bitmap coordinate to cartesian coordinates
        public int pixeltoPoint(int p) 
        {
            return (p - (imageSize/2));
        }
        //go from cartesian coordinates to bitmap pixel coordinates
        public int pointtoPixel(int p)
        {
            return (p + (imageSize / 2));
        }
        //returns the vertice coordinates after being told how many vertices there are. Done with a trigonometry strategy.
        public int[][] vertice(int n)
        {
            int[][] vertices = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int x = (int)(Math.Round(((imageSize / 2) - 50) * Math.Cos((((2 * Math.PI) / n) * i + (Math.PI / -2)))));
                int y = (int)(Math.Round(((imageSize / 2) - 50) * Math.Sin((((2 * Math.PI) / n) * i + (Math.PI / -2)))));
                vertices[i] = new int[] {x,y};
            }
            return vertices;
        }
        //get a random vertice
        public int randVert(int n)
        {
            return rand.Next(n); //random integer [0,n]
        }

        //get an initial beginning coordinate, plain random number that fits within the image
        public int randBeginCoord(int dimension)
        {
            return rand.Next(-dimension, dimension);
        }

        //get new pixel based on going to the 'midpoint' (depends on the fraction value how far it goes) of the current point and the randomly chosen vertice.
        public int[] iterPixel(int[] current, int[] vertice, double fraction)
        {
            int[] coord = new int[2];
            //generalized 'midpoint' formula
            coord[0] = (int)(Math.Round(current[0] * fraction) + (vertice[0] * (1.0 - fraction)));
            coord[1] = (int)(Math.Round(current[1] * fraction) + (vertice[1] * (1.0 - fraction)));
            return coord;
        }
    }
}
