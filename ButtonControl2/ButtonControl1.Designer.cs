using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ButtonControl2
{
    partial class ButtonControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApp = new System.Windows.Forms.Button();
            this.imgApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgApp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApp
            // 
            this.btnApp.BackColor = System.Drawing.Color.LightCoral;
            this.btnApp.FlatAppearance.BorderSize = 0;
            this.btnApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApp.Location = new System.Drawing.Point(94, 3);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(126, 81);
            this.btnApp.TabIndex = 0;
            this.btnApp.Text = "Name";
            this.btnApp.UseVisualStyleBackColor = false;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // imgApp
            // 
            this.imgApp.Location = new System.Drawing.Point(3, 3);
            this.imgApp.Name = "imgApp";
            this.imgApp.Size = new System.Drawing.Size(85, 81);
            this.imgApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgApp.TabIndex = 1;
            this.imgApp.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.imgApp);
            this.Controls.Add(this.btnApp);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(229, 93);
            ((System.ComponentModel.ISupportInitialize)(this.imgApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnApp;
        private PictureBox imgApp;
    }
}
