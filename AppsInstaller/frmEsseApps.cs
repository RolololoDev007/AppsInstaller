using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AppsInstaller
{
    public partial class frmInstaller : Form
    {
        public frmInstaller()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Permitir Movimiento de la ventana
        private bool _isDragging = false;
        private Point _lastPoint;

        // Evento MouseDown
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el movimiento
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                _lastPoint = e.Location;
            }
        }

        // Evento MouseMove
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Calcular el cambio en la posición
            if (_isDragging)
            {
                int deltaX = e.X - _lastPoint.X;
                int deltaY = e.Y - _lastPoint.Y;

                // Actualizar la posición
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);

                // Actualizar la última posición
                _lastPoint = e.Location;
            }
        }

        // Evento MouseUp
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Finalizar el movimiento
            _isDragging = false;
        }
        #endregion
    }
}
