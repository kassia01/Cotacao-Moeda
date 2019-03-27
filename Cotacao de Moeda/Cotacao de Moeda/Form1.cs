using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotacao_de_Moeda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbDolar_CheckedChanged(object sender, EventArgs e)
        {

            int tipomoeda = 0;

            if (rbDolar.Checked == true)
            {
                tipomoeda = 10813;
            }
          else if (rbEuro.Checked == true)
            {

                tipomoeda = 21620;

            }
           else if (rbIene.Checked == true)
            {

                tipomoeda = 21622;

            }
          else if (rbDolarCanadense.Checked == true)
            {

                tipomoeda = 21636;

            }

            var service = new Moeda.FachadaWSSGSClient();
            var cotacao = service.getUltimoValorVO(tipomoeda);
            string valor = (cotacao.ultimoValor.svalor).ToString();
            txtCompra.Text = valor.ToString();

        }

        private void rbnDolar_CheckedChanged(object sender, EventArgs e)
        {
            int tipomoeda = 0;

            if (rbnDolar.Checked == true)
            {
                tipomoeda = 1;
            }
            else if (rbnEuro.Checked == true)
            {

                tipomoeda = 21619;

            }
            else if (rbnIene.Checked == true)
            {

                tipomoeda = 21621;

            }
            else if (rbnDolarCanadense.Checked == true)
            {

                tipomoeda = 21635;

            }

            var service = new Moeda.FachadaWSSGSClient();
            var cotacao = service.getUltimoValorVO(tipomoeda);
            string valor = (cotacao.ultimoValor.svalor).ToString();
            txtVenda.Text = valor.ToString();
        }
    }
}
