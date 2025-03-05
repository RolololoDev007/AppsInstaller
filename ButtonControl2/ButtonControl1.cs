using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ButtonControl2
{
    public partial class ButtonControl1 : UserControl
    {
        public ButtonControl1()
        {
            InitializeComponent();
        }
        

        #region Texto del botón
        private string _ButtonText;
        [Category("Custom Props")]
        [Description("Texto del botón")]
        [Browsable(true)]
        public string ButtonText
        {
            get { return _ButtonText; }
            set 
            { 
                _ButtonText = value;
                btnApp.Text = _ButtonText;
            }
        }
        #endregion

        #region Imagen del botón
        private Image _ImageApp;
        [Category("Custom Props")]
        [Description("Introduzca la ruta de la imagen de la aplicación")]
        [Browsable(true)]
        public Image ImageApp
        {
            get { return _ImageApp; }
            set 
            {
                _ImageApp = value;
                imgApp.Image = _ImageApp;
                imgApp.BackgroundImageLayout = ImageLayout.Stretch; ;
                this.Invalidate();
            }
        }
        #endregion

        #region Enlace de descarga
        private string _LinkURL;
        [Category("Custom Props")]
        [Description("Introduzca la ruta de descarga de la aplicación")]
        [Browsable(true)]
        public string LinkURL
        {
            get { return _LinkURL; }
            set { _LinkURL = value; }
        }
        #endregion

        private void btnApp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_LinkURL))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(_LinkURL) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el enlace: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show(ButtonText, "No esta disponible para descargar.");
            }
        }
    }
}
