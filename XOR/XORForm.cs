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
        public XORForm()
        {
            InitializeComponent();

            Log("Starting application...");
        }

        private void Log(string message)
        {
            listBox.Items.Add(string.Format(" > {0}", message));
        }

        private void XORForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("Closing application...");
        }
    }

    public class Network
    {
        private static Random _rand = new Random();

        private const int _size = 5;

        private double[] u = new double[_size];
        private double[] S = new double[_size];
        private double[,] w = new double[_size, _size];

        private List<Tuple<int, int>> _connections = new List<Tuple<int, int>>();

        public Network()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                    w[i, j] = 0.0;

                u[i] = S[i] = 0.0;
            }

            // connections

            // first input to the first and second neuron in first layer
            _connections.Add(Tuple.Create(0, 2));
            _connections.Add(Tuple.Create(0, 3));

            // second input to the first and second neuron in first layer
            _connections.Add(Tuple.Create(1, 2));
            _connections.Add(Tuple.Create(1, 3));

            // outputs of neurons in first layer to the inputs of the last neuron
            _connections.Add(Tuple.Create(2, 4));
            _connections.Add(Tuple.Create(3, 4));
        }

        private void RandomWeights()
        {
            for (int i = 0; i < _size; i++)
                for (int j = 0; j < _size; j++)
                    w[i, j] = 0.0;

            foreach (Tuple<int, int> connection in _connections)
                w[connection.Item1, connection.Item2] = (((double)_rand.Next(0, 100)) - 50.0) / 100.0;
        }
    }
}
