using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTransparentPix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // This is needed to make the ball image corners transparent with respect to the background image.
            pictureBox1.Controls.Add(pictureBox2);

            // The following code puts the ball at the center of the background.
            Point center = new Point(pictureBox1.Size);
            center.X /= 2;
            center.Y /= 2;

            Point ballCenter = new Point(pictureBox2.Size);
            ballCenter.X /= 2;
            ballCenter.Y /= 2;
            pictureBox2.Location = new Point(center.X - ballCenter.X, center.Y - ballCenter.Y);

            pictureBox2.BackColor = Color.Transparent;
        }
    }
}
