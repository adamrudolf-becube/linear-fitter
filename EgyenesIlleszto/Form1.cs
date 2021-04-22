using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgyenesIlleszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Loads the DataTable of dataGriView to a list of Tuple of double pairs
        public List<Tuple<double,double>> dataTableToListOfTuples()
        {
            List<Tuple<double,double>> doubles = new List<Tuple<double,double>>();
            double it1, it2;
            // For each row, we add the values in the two columns to a tuple and append
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    it1 = Convert.ToDouble(row.Cells[0].Value);
                    it2 = Convert.ToDouble(row.Cells[1].Value);
                    label_error.Text = "";
                    Tuple<double, double> temp = new Tuple<double, double>(it1, it2);
                    doubles.Add(temp);
                }
                catch (FormatException)
                {
                    label_error.Text = "Rossz formátum!";
                }
            }
            // label1.Text = (Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value)+4).ToString();
            doubles.RemoveAt(doubles.Count()-1);
            return doubles;
        }

        // Expects a list of double pairs (x,y). Returns a pair of averages (x_avg, y_avg)
        public Tuple<double, double> average(List<Tuple<double, double>> data)
        {
            double a = 0, b = 0;
            foreach (Tuple<double, double> i in data)
            {
                a += i.Item1;
                b += i.Item2;
            }
            a = (1.0 * a) / (1.0 * data.Count());
            b = (1.0 * b) / (1.0 * data.Count());
            return new Tuple<double, double>(a, b);
        }

        // Expects a list of double pairs (x,y). Returns a pair of sums (x_sum, y_sum)
        public Tuple<double, double> sum(List<Tuple<double, double>> data)
        {
            double a = 0, b = 0;
            foreach (Tuple<double, double> i in data)
            {
                a += i.Item1;
                b += i.Item2;
            }
            return new Tuple<double, double>(a, b);
        }

        // Expects a list of double pairs (x,y). Returns a pair of sums of squares (x_sumSq, y_sumSq)
        public Tuple<double, double> sumSq(List<Tuple<double, double>> data)
        {
            double a = 0, b = 0;
            foreach (Tuple<double, double> i in data)
            {
                a += i.Item1 * i.Item1;
                b += i.Item2 * i.Item2;
            }
            return new Tuple<double, double>(a, b);
        }

        // Expects a list of double pairs (x,y). Returns a sum of produczs (sum x_i * y_i)
        public double sumProd(List<Tuple<double, double>> data)
        {
            double a = 0;
            foreach (Tuple<double, double> i in data)
                a += i.Item1 * i.Item2;
            return a;
        }

        // Expects a list of double pairs (x,y). Returns the slope of the line fitted by least squares method
        public double findSlope(List<Tuple<double, double>> data)
        {
            Tuple<double, double> avg = average(data);
            Tuple<double, double> summ = sum(data);
            double n_rec = 1.0 / (1.0 * data.Count());
            double beta = (sumProd(data) - n_rec * summ.Item1 * summ.Item2) / (sumSq(data).Item1 - n_rec * summ.Item1 * summ.Item1);
            return beta;
        }

        // Expects a list of double pairs (x,y) and the slope of the fitted line. Returns the intersection of the line fitted by least squares method
        public double findIntersection(List<Tuple<double, double>> data, double beta)
        {
            return average(data).Item2 - beta * average(data).Item1;
        }

        // Expects a list of double pairs (x,y), a start and stop index and two output variables. Returns the coaficients of the line fitted by least squares method.
        public void fit(List<Tuple<double, double>> data, int start, int stop, out double beta, out double alpha)
        {
            List<Tuple<double, double>> my_data = new List<Tuple<double, double>>();
            for (int i = start; i <= stop; i++)
                my_data.Add(data[i]);
            double my_beta = findSlope(my_data);
            double my_alpha = findIntersection(my_data, my_beta);
            beta = my_beta;
            alpha = my_alpha;
        }

        static DataTable ConvertListToDataTable(List<double[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            table.Columns.Add();
            table.Columns.Add();
            
            // Add rows.
            foreach (var array in list)
                table.Rows.Add(array);

            return table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string specifier = "0.####";
            List<Tuple<double,double>> data = new List<Tuple<double,double>>();
            data = dataTableToListOfTuples();
            label_n.Text = data.Count().ToString();
            int n = data.Count();
            Tuple<double, double> avg = average(data);
            label_xavg.Text = avg.Item1.ToString(specifier);
            label_yavg.Text = avg.Item2.ToString(specifier);
            label_prod.Text = sumProd(data).ToString(specifier);
            Tuple<double, double> summ = sum(data);
            label_xsum.Text = summ.Item1.ToString(specifier);
            label_ysum.Text = summ.Item2.ToString(specifier);
            label_xsq.Text = sumSq(data).Item1.ToString(specifier);
            double temp = (summ.Item1 * summ.Item1) / (1.0 * n);
            label_xsumsq.Text = temp.ToString(specifier);
            temp = (summ.Item1 * summ.Item2) / (1.0 * n);
            label_sumprod.Text = temp.ToString(specifier);

            double beta = findSlope(data);
            double alpha = findIntersection(data, beta);
            label_beta.Text = beta.ToString(specifier);
            label_alpha.Text = alpha.ToString(specifier);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }
    }
}
