namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DistanceCalculator _distanceCalculator;
        public Form1()
        {
            InitializeComponent();
            _distanceCalculator = new DistanceCalculator();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(x1TextBox.Text);
            int y1 = int.Parse(y1TextBox.Text);
            int x2 = int.Parse(x2TextBox.Text);
            int y2 = int.Parse(y2TextBox.Text);

            double distance = _distanceCalculator.Calculate(x1, y1, x2, y2);
            resultLabel.Text = $"Distance: {distance:F2}";
        }

        private void euclideanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (euclideanRadioButton.Checked)
            {
                _distanceCalculator.SetStrategy(new EuclideanDistanceStrategy());
            }
        }

        private void maxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maxRadioButton.Checked)
            {
                _distanceCalculator.SetStrategy(new MaxDistanceStrategy());
            }
        }

        private void manhattanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manhattanRadioButton.Checked)
            {
                _distanceCalculator.SetStrategy(new ManhattanDistanceStrategy());
            }
        }

    }

    // Strategy interface
    interface IDistanceCalculationStrategy
    {
        double CalculateDistance(int x1, int y1, int x2, int y2);
    }

    // Strategy 1: Euclidean distance
    class EuclideanDistanceStrategy : IDistanceCalculationStrategy
    {
        public double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }

    // Strategy 2: Maximum distance
    class MaxDistanceStrategy : IDistanceCalculationStrategy
    {
        public double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }

    // Strategy 3: Manhattan distance
    class ManhattanDistanceStrategy : IDistanceCalculationStrategy
    {
        public double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }

    // Context class
    class DistanceCalculator
    {
        private IDistanceCalculationStrategy _strategy;

        public void SetStrategy(IDistanceCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Calculate(int x1, int y1, int x2, int y2)
        {
            if (_strategy == null)
            {
                throw new InvalidOperationException("Strategy is not set.");
            }

            return _strategy.CalculateDistance(x1, y1, x2, y2);
        }
    }
}
