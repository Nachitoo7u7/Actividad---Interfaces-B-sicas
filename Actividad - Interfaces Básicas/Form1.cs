using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad___interfaces_Básicas;

namespace Actividad___Interfaces_Básicas
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void txtNum1_Enter(object sender, EventArgs e)
        {
            if (txtNum1.Text == "Ingrese el primer número")
            {
                txtNum1.Text = "";
                txtNum1.ForeColor = Color.Black;

            }
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            if (txtNum1.Text == "")
            {
                txtNum1.Text = "Ingrese el primer número";
                txtNum1.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum2_Enter(object sender, EventArgs e)
        {
            if (txtNum2.Text == "Ingrese el segundo número")
            {
                txtNum2.Text = "";
                txtNum2.ForeColor = Color.Black;

            }
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
            if (txtNum2.Text == "")
            {
                txtNum2.Text = "Ingrese el segundo número";
                txtNum2.ForeColor = Color.Silver;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculos cal = new calculos();

            string numero1, numero2;
            numero1 = txtNum1.Text;
            numero2 = txtNum2.Text;

            double suma = cal.suma(numero1, numero2);
            double resta = cal.resta(numero1, numero2);
            double multiplicacion = cal.multiplicacion(numero1, numero2);
            double division = cal.division(numero1, numero2);

            lblResu1.Text = "" + suma;
            lblResu2.Text = "" + resta;
            lblResu3.Text = "" + multiplicacion;
            lblResu4.Text = "" + division;


        }
    }
}
