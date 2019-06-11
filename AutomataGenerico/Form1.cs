using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomataGenerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarEstados_Click(object sender, EventArgs e)
        {
            try
            {
                Inicializa(dgvTransicion);
                CompVisible(true);
                CompEnable(false);
            }
            catch (Exception)
            {
                MessageBox.Show("No debe estas vacio y solo puede ingresar numeros");
            }
        }

        private void Inicializa(DataGridView gridView)
        {
            int numnodos = Convert.ToInt32(txtNumEstados.Text);
            gridView.Rows.Clear();
            if (txtNumEstados.Text != string.Empty && numnodos <= 6)
            {
                gridView.Height = (numnodos + 1) * 24;

                for (int i = 0; i < numnodos; i++)
                {
                    gridView.Rows.Add(i, "", "", "");
                }
            }
        }

        private int[,] Llenar(DataGridView gridView)
        {
            int numero = gridView.RowCount;
            int[,] arr = new int[numero,numero];
            for (int i = 0; i < numero; i++)
            {
                arr[i, 0] = Convert.ToInt32(gridView.Rows[i].Cells[1].Value);
                arr[i, 1] = Convert.ToInt32(gridView.Rows[i].Cells[2].Value);
            }
            return arr;
        }

        private List<int> EsAcepta(DataGridView gridView)
        {
            int numero = gridView.RowCount;
            List<int> list = new List<int>();
            for (int i = 0; i < numero; i++)
            {
                if (Convert.ToInt32(gridView.Rows[i].Cells[3].Value) == 1)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCapturaCad.Text != string.Empty)
                {
                    Dictamina(Procesa(Llenar(dgvTransicion), txtCapturaCad.Text), EsAcepta(dgvTransicion));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hay errores en la tabla");
            }
        }

        private int Procesa(int[,] arr,string cad)
        {
            int estado = 0;
            for (int i = 0; i < cad.Length; i++)
            {
                if (cad[i]=='a')
                {
                    estado = arr[estado, 0];
                }
                else
                {
                    estado = arr[estado, 1];
                }
            }
            return estado;
        }

        private void Dictamina(int estadof,List<int> acepta)
        {
            bool ok = false;
            for (int i = 0; i < acepta.Count; i++)
            {
                if (estadof==acepta[i])
                {
                    ok = true;
                    break;
                }
            }

            if (ok)
            {
                lblRes.Text = "Cadena Aceptada";
            }
            else
            {
                lblRes.Text = "Cadena No Aceptada";
            }
        }

        private void CompVisible(bool ok)
        {
            txtCapturaCad.Visible = ok;
            lblRes.Visible = ok;
            btnComprobar.Visible = ok;
            btnNuevo.Visible = ok;
        }

        private void CompEnable(bool ok)
        {
            txtNumEstados.Enabled = ok;
            btnGenerarEstados.Enabled = ok;
        }

        private void FieldsClear()
        {
            txtCapturaCad.Text = string.Empty;
            txtNumEstados.Text = string.Empty;
            lblRes.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompVisible(false);
            CompEnable(true);
            FieldsClear();
            dgvTransicion.Height = 24;
            dgvTransicion.Rows.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Itegrantes:\nJacobo Jacobo Miguel Angel\nMejía Matínez Jose Manuel", "Acerca de ", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
