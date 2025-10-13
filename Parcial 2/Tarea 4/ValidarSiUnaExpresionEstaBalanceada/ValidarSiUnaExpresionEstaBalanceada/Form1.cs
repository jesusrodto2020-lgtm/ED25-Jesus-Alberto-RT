namespace ValidarSiUnaExpresionEstaBalanceada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pila<char> miPila = new Pila<char>();

        public bool CompararEnPila(char caracterComparar)
        {

            if (miPila.Tamaño > 0)
            {
                char caracterPila = miPila.Eliminar();

                if (caracterPila == caracterComparar)
                {
                    return true;
                }

            }
            return false;
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            miPila = new Pila<char>();
            string cadena = txtExpresion.Text;
            bool esValida = true;
            for (int x = 0; x < cadena.Length; x++)
            {

                if ('(' == cadena[x] || '{' == cadena[x] || '[' == cadena[x])
                {
                    miPila.Agregar(cadena[x]);
                }
                else if (')' == cadena[x])
                {
                    esValida = CompararEnPila('(');
                }
                else if (']' == cadena[x])
                {
                    esValida = CompararEnPila('[');

                }
                else if ('}' == cadena[x])
                {
                    esValida = CompararEnPila('{');

                }
                if (!esValida)
                {
                    break;
                }

                //Es otro caracter nada que ver

            }//Termina for

            if (miPila.Tamaño > 0)//La pila quedo con un {,(, o [ la expresion no esta bien
            {
                esValida = false;
            }

            if (esValida)
            {
                lblValidacion.ForeColor = Color.Green;
                lblValidacion.Text = "La expresión es válida :)";
            }
            else
            {
                lblValidacion.ForeColor = Color.Red;
                lblValidacion.Text = "La expresión NO es válida :(";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnValidar.Visible = false;
                btnValidar_Click(null, null);

            }
            else
            {
                btnValidar.Visible = true;
                lblValidacion.Text = "";
            }

        }

        private void txtExpresion_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnValidar_Click(null, null);
            }
            if (!checkBox1.Checked)
            {
                lblValidacion.Text = "";
            }

        }
    }
}
