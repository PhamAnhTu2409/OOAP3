using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(x1TextBox.Text);
            int y1 = int.Parse(y1TextBox.Text);
            int x2 = int.Parse(x2TextBox.Text);
            int y2 = int.Parse(y2TextBox.Text);


            double euclideanDistance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            euclideanResultLabel.Text = $"Euclidean Distance: {euclideanDistance:F2}";

            
            double maxDistance = Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
            maxResultLabel.Text = $"Max Distance: {maxDistance:F2}";


            double manhattanDistance = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
            manhattanResultLabel.Text = $"Manhattan Distance: {manhattanDistance:F2}";
        }

    }
}
