namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_Conectar(object sender, EventArgs e)
        {
            //btnIngresar.Text = "Boton apretado";
            Conexion.ConectarConDB();
        }

    }
}
