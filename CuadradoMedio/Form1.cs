using CuadradoMedio.Algoritmos;

namespace CuadradoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("El número tiene que ser NO VACÍO");
            }

            int n = Convert.ToInt32(textBox1.Text);

            if (n <= 0) 
            {
                MessageBox.Show("El número tiene que ser mayor que CERO");
            }

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();
            List<int> listaValoresPseudoAleatorios = algoritmo.AlgoritmoCuadradoMedio(n);

            dataGridView1_CellContentClick(listaValoresPseudoAleatorios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(List<int> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "n");
            dataGridView1.Columns.Add(numeroColumna2, "R(n)");
            dataGridView1.Columns.Add(numeroColumna1, "R(n)^2");
            dataGridView1.Columns.Add(numeroColumna2, "M.R(n)^2");
            dataGridView1.Columns.Add(numeroColumna1, "Val 1");
            dataGridView1.Columns.Add(numeroColumna2, "Val 2");

            for (int i = 0; i < (lista.Count / 5) ; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i * 5].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i * 5 + 1].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = lista[i * 5 + 2].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = lista[i * 5 + 3].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = lista[i * 5 + 4].ToString();
            }

        }
    }
}