using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorNumerico
{
    public partial class Form1 : Form
    {

        List<int> numero = new List<int>();
        StringBuilder str = new StringBuilder();
        




        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Decimal");
            comboBox1.Items.Add("Binário");
            comboBox1.Items.Add("Octal");
            comboBox1.Items.Add("Hexadecimal");
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            String valor = valorDigitado.Text.ToUpper();
            switch (indice) {
                case 0:
                    int valorConvertidoDeDecimal = decimalParaDecimal(valor);
                    conversorDecimalParaBinario(valorConvertidoDeDecimal);
                    conversorDecimalParaOctal(valorConvertidoDeDecimal);
                    conversorDecimalParaHexa(valorConvertidoDeDecimal);
                    break;
                case 1:
                    int valorConvertidoBinario = binarioParaDecimal(valor);
                    conversorDecimalParaBinario(valorConvertidoBinario);
                    conversorDecimalParaOctal(valorConvertidoBinario);
                    conversorDecimalParaHexa(valorConvertidoBinario);
                    break;
                case 2:
                    int valorConvertidoDeOctal = octalParaDecimal(valor);
                    conversorDecimalParaBinario(valorConvertidoDeOctal);
                    conversorDecimalParaOctal(valorConvertidoDeOctal);
                    conversorDecimalParaHexa(valorConvertidoDeOctal);
                    break;
                case 3:
                    int valorConvertidoDeHexadecimal = hexadecimalParaDecimal(valor);
                    conversorDecimalParaBinario(valorConvertidoDeHexadecimal);
                    conversorDecimalParaOctal(valorConvertidoDeHexadecimal);
                    conversorDecimalParaHexa(valorConvertidoDeHexadecimal);
                    break;
                default: break;
            }
            

        }

        public int decimalParaDecimal(String valor) {
            int valorConvertido = Convert.ToInt32(valor);
            resultDec.Text = valorConvertido.ToString();
            return valorConvertido;
            
           
        }

        public int binarioParaDecimal(string valor) {

            double resultado = 0;
            int tamanhoString = valor.Length;
            double valorConvertido = Convert.ToInt64(valor);
            for (int i = 0; i < tamanhoString; i++) {
                int ultimoValor = (int)valorConvertido % 10;
                resultado = resultado + ultimoValor * (Math.Pow(2, i));
                valorConvertido = valorConvertido / 10;
            }
            resultDec.Text = ((int)resultado).ToString();
            return (int)resultado;
        }

        public int octalParaDecimal(string valor) {

            int tamanhoString = valor.Length;
            double valorConvertido = 0;

            for (int i = 0; i < tamanhoString; i++) {
                valorConvertido += ((byte)valor[i] - 48) * Math.Pow(8, ((tamanhoString - i) - 1));
            }
            resultDec.Text = ((int)valorConvertido).ToString();
            return (int)valorConvertido;
        }

        public int hexadecimalParaDecimal(string valorDigitado) {

            int resultado = -5;
            int contador = valorDigitado.Length - 1;
            for (int i = 0; i < valorDigitado.Length; i++) {
                int temp = 0;
                switch (valorDigitado[i])
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + (int)valorDigitado[i]; break;
                }

                resultado += temp * (int)(Math.Pow(16, contador));
                contador--;
            }

            char ultimoValor = valorDigitado[valorDigitado.Length - 1];
            string verificarUltimo = Convert.ToString(ultimoValor);

            if (verificarUltimo != "0") {
                resultado += 5;
            }

            resultDec.Text = ((int)resultado).ToString();
            return resultado;
            
        }

        public void conversorDecimalParaHexa(int valor) {

            limpaLista(numero);
            limpaStringBuilder(str);
            int v = 0;

            while (valor != 0) {
                if ((valor % 16) < 10)
                {
                    v = valor % 16;
                    str.Append(v);
                }
                else
                {
                    string x = "";

                    switch (valor % 16) {
                        case 10: x = "A"; break;
                        case 11: x = "B"; break;
                        case 12: x = "C"; break;
                        case 13: x = "D"; break;
                        case 14: x = "E"; break;
                        case 15: x = "F"; break;
                    }
                    str.Append(x);
                }

                valor /= 16;
            }
            char[] reverteStr = str.ToString().ToCharArray();
            Array.Reverse(reverteStr);

            string s = new string(reverteStr);

            str.Replace(str.ToString(), s);

            resultHex.Text = str.ToString(); 


            
                
        }

        public void conversorDecimalParaOctal(int valor) {

            limpaLista(numero);
            limpaStringBuilder(str);

            while (valor >= 1)
                {
                    int v = valor % 8;
                    valor /= 8;
                    numero.Add(v);
                }
            

            for (int i = numero.Count - 1; i >= 0; i--)
            {
                str.Append(numero[i] + " ");
            }

            resultOct.Text = str.ToString();
            
            
            
        }
    

        public void conversorDecimalParaBinario(int valor) {
            limpaLista(numero);
            limpaStringBuilder(str);

            if (valor == 0)
            {
                resultHex.Text = "0 0";
            }
            else if (valor == 1)
            {
                resultHex.Text = "0 1";
            }
            else
            {
                while (valor >= 1)
                {
                    int v = valor % 2;
                    valor /= 2;
                    numero.Add(v);
                    valor = valor;
                }
            }

            for (int i = numero.Count - 1; i >= 0; i--)
            {
                str.Append(numero[i] + " ");
            }

            resultBi.Text = str.ToString();
            
        }

        public void limpaStringBuilder(StringBuilder str) {
            str.Length = 0;
            str.Capacity = 0;
        }

        public void limpaLista(List<int> lista) {
            lista.Clear();
        }
        
    }
}
