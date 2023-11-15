using Sistema_Club_Deportivo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Club_Deportivo
{
    public partial class FormCarnet : Form
    {
        public FormCarnet(Afiliado afiliado, DateTime fechaVencimiento, long numeroCarnet)
        {
            InitializeComponent();

            carnetNombre.Text = "Nombre: " + afiliado.Persona.Nombre;
            carnetApellido.Text = "Apellido: " + afiliado.Persona.Apellido;
            carnetVto.Text = "Vencimiento: " + fechaVencimiento.ToString("yyyy-MM-dd");
            carnetNroSocio.Text = "Socio: " + numeroCarnet;


        }

        private void FormCarnet_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void imprimirCarnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument1_PrintPage);

            PrintDialog pdialog = new PrintDialog();
            pdialog.Document = pd;

            if (pdialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Establecer el tamaño del área de impresión a 85.6 x 53.98 mm (tamaño de una tarjeta de crédito estándar)
            int tarjetaAncho = 86; // Ancho de la tarjeta en milímetros
            int tarjetaAlto = 54;  // Alto de la tarjeta en milímetros
            int resolutionX = 96;
            int resolutionY = 96;

            // Convertir de milímetros a píxeles utilizando la resolución de la impresora
            int tarjetaAnchoPixels = (int)(tarjetaAncho * resolutionX / 25.4);
            int tarjetaAltoPixels = (int)(tarjetaAlto * resolutionY / 25.4);

            // Establecer el área de impresión
            e.PageSettings.PaperSize = new PaperSize("TarjetaCredito", tarjetaAnchoPixels, tarjetaAltoPixels);

            // Establecer la fuente y el pincel
            Font font = new Font("Arial", 10);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Posiciones y tamaños de los elementos
            Point nombreLocation = new Point(10, 120);
            Point apellidoLocation = new Point(10, 140);
            Point vtoLocation = new Point(10, 180);
            Point nroSocioLocation = new Point(10, 160);
            Point logoLocation = new Point(10, 10);
            Point fotoLocation = new Point(180, 0);

            // Redimensionar las imágenes al tamaño deseado
            Image logoResized = ResizeImage(carnetLogo.Image, 160, 100);  // Ajusta los valores según sea necesario
            Image fotoResized = ResizeImage(fotoSocio.Image, 150, 190);    // Ajusta los valores según sea necesario

            // Obtener el área de impresión
            Rectangle printArea = e.PageBounds;

            // Dibujar un contorno alrededor del área de impresión
            int borderWidth = 2; // Ancho del contorno
            Rectangle borderRect = new Rectangle(printArea.Left, printArea.Top, tarjetaAnchoPixels, tarjetaAltoPixels);
            e.Graphics.DrawRectangle(new Pen(Color.Black, borderWidth), borderRect);

            // Dibujar el contenido en el área de impresión
            e.Graphics.DrawString(carnetNombre.Text, font, brush, nombreLocation);
            e.Graphics.DrawString(carnetApellido.Text, font, brush, apellidoLocation);
            e.Graphics.DrawString(carnetVto.Text, font, brush, vtoLocation);
            e.Graphics.DrawString(carnetNroSocio.Text, font, brush, nroSocioLocation);
            e.Graphics.DrawImage(logoResized, logoLocation);
            e.Graphics.DrawImage(fotoResized, fotoLocation);

            // Puedes ajustar las coordenadas y el diseño según sea necesario

            // Si hay más contenido para imprimir, establece HasMorePages en true
            // e invoca nuevamente este método cuando se requiere imprimir más páginas
            // Si no hay más contenido, establece HasMorePages en false
            e.HasMorePages = false;
        }


        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }



    }
}
