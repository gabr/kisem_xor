using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOR
{
    public partial class XORForm : Form
    {
        private Network _net = new Network();

        public XORForm()
        {
            InitializeComponent();

            Log("Starting application...");

            FillNetwork();
        }

        private void Log(string message)
        {
            listBox.Items.Add(string.Format(" > {0}", message));
        }

        private void FillNetwork()
        {
            string format = "{0:0.00}";

            // inputs
            textBox_in0.Text = String.Format(format, _net.Inputs[0]);
            textBox_in1.Text = String.Format(format, _net.Inputs[1]);

            Network.Neuron tmp;

            tmp = _net.GetNeuron(0);

            textBox_n0out.Text = String.Format(format, tmp.output);
            textBox_n0s.Text = String.Format(format, tmp.sum);

            textBox_n0w0.Text = String.Format(format, tmp.weights[0]);
            textBox_n0w1.Text = String.Format(format, tmp.weights[1]);
            textBox_n0w2.Text = String.Format(format, tmp.weights[2]);

            textBox_n0s0.Text = String.Format(format, tmp.values[0]);
            textBox_n0s1.Text = String.Format(format, tmp.values[1]);
            textBox_n0s2.Text = String.Format(format, tmp.values[2]);

            tmp = _net.GetNeuron(1);

            textBox_n1out.Text = String.Format(format, tmp.output);
            textBox_n1s.Text = String.Format(format, tmp.sum);
                     
            textBox_n1w0.Text = String.Format(format, tmp.weights[0]);
            textBox_n1w1.Text = String.Format(format, tmp.weights[1]);
            textBox_n1w2.Text = String.Format(format, tmp.weights[2]);
                     
            textBox_n1s0.Text = String.Format(format, tmp.values[0]);
            textBox_n1s1.Text = String.Format(format, tmp.values[1]);
            textBox_n1s2.Text = String.Format(format, tmp.values[2]);

            tmp = _net.GetNeuron(2);

            textBox_n2out.Text = String.Format(format, tmp.output);
            textBox_n2s.Text = String.Format(format, tmp.sum);
                     
            textBox_n2w0.Text = String.Format(format, tmp.weights[0]);
            textBox_n2w1.Text = String.Format(format, tmp.weights[1]);
            textBox_n2w2.Text = String.Format(format, tmp.weights[2]);
                     
            textBox_n2s0.Text = String.Format(format, tmp.values[0]);
            textBox_n2s1.Text = String.Format(format, tmp.values[1]);
            textBox_n2s2.Text = String.Format(format, tmp.values[2]);
        }

        private void XORForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("Closing application...");
        }

        private void button_RandomWeight_Click(object sender, EventArgs e)
        {
            Log("Generating random network...");
            _net.RandomWeight();
            FillNetwork();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            Log("Recalculate network...");
            _net.Calculate();
            FillNetwork();
        }
    }

    public class Network
    {
        private static Random _rand = new Random();

        private const int _size = 6;

        private double[] u = new double[_size];
        private double[] S = new double[_size];
        private double[,] w = new double[_size, _size];

        private List<Tuple<int, int>> _connections = new List<Tuple<int, int>>();

        public double[] Inputs
        {
            get
            {
                return new double[] { u[1], u[2] };
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    u[i+1] = value[i];
            }
        }
        public double Output
        {
            get
            {
                return u[u.Length - 1];
            }
        }

        public class Neuron
        {
            public double[] weights;
            public double[] values;
            public double sum;
            public double output;

            public Neuron(int size)
            {
                weights = new double[size];
                values = new double[size];
            }
        }

        public Network()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                    w[i, j] = 0.0;

                u[i] = S[i] = 0.0;
            }

            u[0] = 1; // const signal

            // connections

            // const signal to all neurons
            _connections.Add(Tuple.Create(0, 3));
            _connections.Add(Tuple.Create(0, 4));
            _connections.Add(Tuple.Create(0, 5));

            // first input to the first and second neuron in first layer
            _connections.Add(Tuple.Create(1, 3));
            _connections.Add(Tuple.Create(1, 4));

            // second input to the first and second neuron in first layer
            _connections.Add(Tuple.Create(2, 3));
            _connections.Add(Tuple.Create(2, 4));

            // outputs of neurons in first layer to the inputs of the last neuron
            _connections.Add(Tuple.Create(3, 5));
            _connections.Add(Tuple.Create(4, 5));

            // sort
            _connections = _connections.OrderBy(t => t.Item1).ToList<Tuple<int, int>>();
        }

        public void RandomWeight()
        {
            foreach (Tuple<int, int> connection in _connections)
                w[connection.Item1, connection.Item2] = (((double)_rand.Next(0, 100)) - 50.0) / 100.0;
        }

        public void Calculate()
        {
            // zero sums
            for (int i = 0; i < _size; i++)
                S[i] = 0.0;

            foreach (Tuple<int, int> connectino in _connections)
            {
                S[connectino.Item2] += w[connectino.Item1, connectino.Item2] * u[connectino.Item1];
                u[connectino.Item2] = Activation(S[connectino.Item2]);
            }
        }

        public Neuron GetNeuron(int neuronIndex)
        {
            if (neuronIndex < 0 || neuronIndex > 2)
                return null;

            var indexes = _connections.Where(t => t.Item2 == neuronIndex + 3).Select(t => t.Item1).ToList<int>();

            Neuron result = new Neuron(indexes.Count)
            {
                sum = S[neuronIndex + 3],
                output = u[neuronIndex + 3]
            };

            for (int i = 0; i < indexes.Count; i++)
            {
                result.weights[i] = w[indexes[i], neuronIndex + 3];
                result.values[i] = result.weights[i] * u[indexes[i]];
            }

            return result;
        }

        private double Activation(double sum)
        {
            return 1.0 / (1 + Math.Exp(-sum));
        }

    }
}
