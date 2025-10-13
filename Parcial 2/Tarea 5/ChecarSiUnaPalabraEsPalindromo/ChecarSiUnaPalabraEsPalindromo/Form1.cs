namespace ChecarSiUnaPalabraEsPalindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRevisar_Click(object sender, EventArgs e)
        {
            Pila<char> miPila = new Pila<char>();
            string cadena = "", cadenaVolti = "";

            cadena = txtCadena.Text.ToLower();
            for (int i = 0; i < cadena.Length; i++)
            {
                miPila.Agregar(cadena[i]);
            }

            while (miPila.Tamaño > 0)
            {
                cadenaVolti += miPila.Eliminar();
            }

            if (cadena == cadenaVolti)
            {
                lblVerificacion.ForeColor = Color.Green;
                lblVerificacion.Text = "Si es palindromo";
            }
            else
            {
                lblVerificacion.ForeColor = Color.Red;
                lblVerificacion.Text = "No es palidromo";

            }
        }
    }
}
