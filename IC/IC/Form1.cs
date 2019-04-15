using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace IC
{
    public partial class Form1 : Form
    {

        Bitmap rawPic;
        Bitmap convPic;
        Bitmap colorPic;

        int[] icDataMin = new int[2] { 13000, 85000 };
        int[] icDataMax = new int[2] { 25000, 170000 };
        int[] countICType = new int[2] { 0, 0 };
        string[] icName = new string[2] { "Intel", "Atmel" };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                rawPic = new Bitmap(openFileDialog.FileName);
                picRaw.Image = rawPic;
            }
        }

        private void convertImage(Image imgOut, int thres, bool invert, out Bitmap process, out Bitmap processColor)
        {

            Image<Gray, byte> grayImg = new Image<Gray, byte>(rawPic);
            Image<Bgr, byte> colorImg = new Image<Bgr, byte>(rawPic);

            grayImg = grayImg.ThresholdBinary(new Gray(thres), new Gray(255));

            if (invert)
            {
                grayImg._Not();
            }

            int count = 0;
            listBoxData.Items.Clear();
            listBoxCategory.Items.Clear();
            countICType[0] = 0;
            countICType[1] = 0;


            using (MemStorage storage = new MemStorage())
            {
                count = 0;
                for (Contour<Point> contour = grayImg.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage);
                    contour != null; contour = contour.HNext)
                {
                    Contour<Point> currentContour = contour.ApproxPoly(contour.Perimeter * 0.05, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        CvInvoke.cvDrawContours(colorImg, contour, new MCvScalar(255),
                            new MCvScalar(255), -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED,
                            new Point(0, 0));

                        colorImg.Draw(currentContour.BoundingRectangle,
                            new Bgr(0, 0, 255), 20);
                        count++;
                        resultList(currentContour.BoundingRectangle.Width, currentContour.BoundingRectangle.Height, count);
                    }
                }
            }

            labelTotalIC.Text = count.ToString();
            process = colorImg.ToBitmap();
            processColor = grayImg.ToBitmap();
            picConv.Image = processColor;
            picRes.Image = process;
        }
    
        private void resultList(int width, int height, int kira)
        {
            listBoxData.Items.Add("Part No. " + kira.ToString());
            listBoxData.Items.Add("Width: " + width.ToString() + " Height: " + height.ToString());

            int area = width * height;
            listBoxData.Items.Add("Size: " + area);
            listBoxData.Items.Add("====================");
            categorizeList(area);
        }

        private void categorizeList(int area)
        {            
            for (int i = 0; i < 2; i++)
            {
                if (area > icDataMin[i] && area < icDataMax[i])
                {
                    countICType[i]++;
                    listBoxCategory.Items.Add("IC " + icName[i] + ":" + countICType[i].ToString());
                }
            }

            labelIntel.Text = countICType[0].ToString();
            labelAtmet.Text = countICType[1].ToString();
        }

        private void trackBarTreshold_Scroll(object sender, EventArgs e)
        {            
            labelTreshold.Text = trackBarTreshold.Value.ToString() + "%";            
            convertImage(rawPic, trackBarTreshold.Value, true, out convPic, out colorPic);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
