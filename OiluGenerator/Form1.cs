using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiluGenerator
{
    public partial class Form1 : Form
    {
        enum patternCode
        {
            LINEAR = 0,
            CIRCULAR,
            DOTTED
        } 
        
        private long inputNb;
        private int sizeInCm;
        private int resolution;
        private Bitmap bmp;
        private float segmentRatio;

        public Form1()
        {
            InitializeComponent();
            patternCombo.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNbStr = nbrBox.Text.Trim();

            if (!long.TryParse(nbrBox.Text, out inputNb))
            {
                MessageBox.Show("Invalid input number");
                return;
            }

            if (!int.TryParse(sizeCm.Text, out sizeInCm))
            {
                MessageBox.Show("Invalid input size");
                return;
            }

            if (!int.TryParse(resBox.Text, out resolution))
            {
                MessageBox.Show("Invalid input resolution");
                return;
            }
            if (!float.TryParse(segmentRatioBox.Text, out segmentRatio))
            {
                MessageBox.Show("Invalid Segments ratio input");
                return;
            }

            var pattern = (patternCode) patternCombo.SelectedIndex;

            int idx = inputNbStr.IndexOf('-');
            if (idx != -1) inputNbStr = inputNbStr.Remove(0, 1);

            int wid = (int)(sizeInCm * resolution / 2.54);
            int heiht = wid;

            // Set nbLevels per triangle, segment width, ...
            inputNbStr = "0" + inputNbStr;
            int nbLevels = inputNbStr.Length  ; 
            int segmentWidth = (int)((wid / 2.0) / (nbLevels * 2));
            //segmentRatioBox.Text = segmentRatioBox.Text +" # "+ segmentWidth;

            // create bitmap and grapgics

            bmp = new Bitmap(wid, heiht , System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bmp.SetResolution(resolution, resolution);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);


            string trLeft   = "";
            string trBot    = "";
            string trRight  = "";
            string trTop    = "";

            
            for (int i = 0; i < inputNbStr.Length; i++)
            {
                byte d = byte.Parse(""+inputNbStr[i]);
                string dd = oiluToBinarySegments(d);
                Debug.Assert(!dd.Equals(""));

                trLeft  += dd[0];
                trBot   += dd[1];
                trRight += dd[2];
                trTop   += dd[3];

            }


            Bitmap trBmp = null;

            switch (pattern)
            {
                case patternCode.LINEAR:
                    trBmp = GenerateQuaternal(trLeft, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    g.DrawImage(trBmp, 0, 0);

                    trBmp = GenerateQuaternal(trBot, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    g.DrawImage(trBmp, 0, wid / 2);

                    trBmp = GenerateQuaternal(trRight, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    g.DrawImage(trBmp, wid / 2, 0);

                    trBmp = GenerateQuaternal(trTop, segmentWidth, segmentRatio, pattern);
                    g.DrawImage(trBmp, 0, 0);

                    break;
                case patternCode.CIRCULAR:
                    trBmp = GenerateQuaternal(trLeft, segmentWidth, segmentRatio, pattern);
                    g.DrawImage(trBmp, 0, 0);

                    trBmp = GenerateQuaternal(trBot, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    g.DrawImage(trBmp, 0, heiht / 2);

                    trBmp = GenerateQuaternal(trRight, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    g.DrawImage(trBmp, wid / 2, heiht / 2);

                    trBmp = GenerateQuaternal(trTop, segmentWidth, segmentRatio, pattern);
                    trBmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    g.DrawImage(trBmp, wid / 2, 0);
                    break;
                case patternCode.DOTTED:
                    break;
                default:
                    break;
            }


            pictureBox1.Image = bmp;
            pictureBox1.Refresh();

            ExportBtn.Enabled = true;

        }

        private Bitmap GenerateQuaternal(string bits, int segmentWidth, float segmentRatio, patternCode pattern )
        {
            switch (pattern)
            {
                case patternCode.LINEAR: return GenerateLineraCode(bits, segmentWidth,  segmentRatio);
                    
                case patternCode.CIRCULAR: return GenrateCircularCode(bits, segmentWidth,  segmentRatio);
                case patternCode.DOTTED:return GenerateDottedCode(bits, segmentWidth,  segmentRatio);
                    ;
                default: return null;
                    
            }


        }

        private Bitmap GenerateDottedCode(string bits, int segmentWidth, float segmentRatio)
        {
            throw new NotImplementedException();
        }

        private Bitmap GenrateCircularCode(string bits, int segmentWidth, float segmentRatio)
        {
            Bitmap tmpbmp = bmp.Clone(new Rectangle(0, 0, bmp.Width/2, bmp.Height/2 ), bmp.PixelFormat);
            Graphics gr = Graphics.FromImage(tmpbmp);
            gr.Clear(Color.White);
            Pen pen = new Pen(Color.Black, segmentWidth);

            float yy = pen.Width / 2;

            // the first pattern is the square delimiter
            gr.DrawLine(pen, 0, yy, tmpbmp.Width, yy);
            gr.DrawLine(pen, yy, 0, yy, tmpbmp.Height); gr.DrawLine(pen, 0, yy, tmpbmp.Width, yy);


            yy += 2 * segmentWidth;

            // start from 1
            for (int i = 1; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                    gr.DrawArc(pen, yy ,yy, 2*tmpbmp.Width -2*yy, 2*tmpbmp.Width -2*yy, 0, 360);
                yy += 2 * segmentWidth;
            }



            tmpbmp.MakeTransparent(Color.White);
            tmpbmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            return tmpbmp;
        }

        private Bitmap GenerateLineraCode(string bits, int segmentWidth, float segmentRatio)
        {
            Bitmap tmpbmp = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height / 2), bmp.PixelFormat);
            Graphics gr = Graphics.FromImage(tmpbmp);
            gr.Clear(Color.White);
            int bsegW = (int)(segmentWidth * segmentRatio / 100);
            Pen pen = new Pen(Color.Black, bsegW);

            int yy = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                    gr.DrawLine(pen, 0, yy + pen.Width / 2, tmpbmp.Width, yy + pen.Width / 2);
                yy += 2 * segmentWidth;
            }

            Brush br = Brushes.White;
            Point[] tr = new Point[3] { new Point(0, 0), new Point(0, tmpbmp.Height), new Point(tmpbmp.Width / 2, tmpbmp.Height) };
            gr.FillPolygon(br, tr);

            tr = new Point[3] { new Point(tmpbmp.Width, 0), new Point(tmpbmp.Width / 2, tmpbmp.Height), new Point(tmpbmp.Width, tmpbmp.Height) };
            gr.FillPolygon(br, tr);

            tmpbmp.MakeTransparent(Color.White);
            tmpbmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);
            return tmpbmp;
        }

        private void DrawSegment(Graphics gr, Pen pen, int yy)
        {

        }

        string oiluToBinarySegments(byte digit)
        {

            switch (digit)
            {
                case 0:
                    return "1111";
                case 1:         
                    return "1000";
                case 2:         
                    return "1100";
                case 3:         
                    return "1110";
                case 4:         
                    return "0110";
                case 5:         
                    return "0111";
                case 6:         
                    return "0011";
                case 7:         
                    return "1011";
                case 8:         
                    return "1001";
                case 9:         
                    return "1101";
                default:
                    return "";
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (bmp == null) return;
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "tif|*.tiff";
            if(fd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(fd.FileName);
            }
        }

        private void nbrBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                genBtnn.PerformClick();

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            pictureBox1_DoubleClick(this, null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                System.Windows.Forms.Screen screen;
                //Rectangle rect = screen.Primary.
            }
        }

    }
}
