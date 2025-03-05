namespace AppsInstaller
{
    partial class frmInstaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstaller));
            this.lblEssApps = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.userControl18 = new ButtonControl2.ButtonControl1();
            this.userControl17 = new ButtonControl2.ButtonControl1();
            this.userControl16 = new ButtonControl2.ButtonControl1();
            this.userControl15 = new ButtonControl2.ButtonControl1();
            this.userControl14 = new ButtonControl2.ButtonControl1();
            this.userControl13 = new ButtonControl2.ButtonControl1();
            this.userControl12 = new ButtonControl2.ButtonControl1();
            this.userControl11 = new ButtonControl2.ButtonControl1();
            this.ucBrave = new ButtonControl2.ButtonControl1();
            this.SuspendLayout();
            // 
            // lblEssApps
            // 
            this.lblEssApps.AutoSize = true;
            this.lblEssApps.Font = new System.Drawing.Font("MV Boli", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEssApps.Location = new System.Drawing.Point(268, 21);
            this.lblEssApps.Name = "lblEssApps";
            this.lblEssApps.Size = new System.Drawing.Size(428, 49);
            this.lblEssApps.TabIndex = 9;
            this.lblEssApps.Text = "Essentials Applications";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(883, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userControl18
            // 
            this.userControl18.BackColor = System.Drawing.Color.Transparent;
            this.userControl18.ButtonText = "Revo Uninstaller";
            this.userControl18.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl18.ImageApp")));
            this.userControl18.LinkURL = "https://81081bb5bd2a290e19d0-73f958688cc73e14784b0be099708265.ssl.cf1.rackcdn.com" +
    "/revosetup.exe";
            this.userControl18.Location = new System.Drawing.Point(689, 102);
            this.userControl18.Name = "userControl18";
            this.userControl18.Size = new System.Drawing.Size(229, 93);
            this.userControl18.TabIndex = 8;
            // 
            // userControl17
            // 
            this.userControl17.BackColor = System.Drawing.Color.Transparent;
            this.userControl17.ButtonText = "Notion Calendar";
            this.userControl17.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl17.ImageApp")));
            this.userControl17.LinkURL = "https://www.notion.com/calendar/desktop/windows/download?from=marketing&pathname=" +
    "%2Fes-es%2Fproduct%2Fcalendar%2Fdownload&tid=w_fb6b63f1afe749b69e91ad6abe9443cd";
            this.userControl17.Location = new System.Drawing.Point(689, 336);
            this.userControl17.Name = "userControl17";
            this.userControl17.Size = new System.Drawing.Size(229, 93);
            this.userControl17.TabIndex = 7;
            // 
            // userControl16
            // 
            this.userControl16.BackColor = System.Drawing.Color.Transparent;
            this.userControl16.ButtonText = "Riot Games";
            this.userControl16.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl16.ImageApp")));
            this.userControl16.LinkURL = "https://valorant.secure.dyn.riotcdn.net/channels/public/x/installer/current/live." +
    "live.ap.exe";
            this.userControl16.Location = new System.Drawing.Point(354, 100);
            this.userControl16.Name = "userControl16";
            this.userControl16.Size = new System.Drawing.Size(229, 93);
            this.userControl16.TabIndex = 6;
            // 
            // userControl15
            // 
            this.userControl15.BackColor = System.Drawing.Color.Transparent;
            this.userControl15.ButtonText = "Vencord";
            this.userControl15.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl15.ImageApp")));
            this.userControl15.LinkURL = "https://github.com/Vencord/Installer/releases/latest/download/VencordInstaller.ex" +
    "e";
            this.userControl15.Location = new System.Drawing.Point(49, 336);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(229, 93);
            this.userControl15.TabIndex = 5;
            // 
            // userControl14
            // 
            this.userControl14.BackColor = System.Drawing.Color.Transparent;
            this.userControl14.ButtonText = "Steam";
            this.userControl14.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl14.ImageApp")));
            this.userControl14.LinkURL = "https://cdn.fastly.steamstatic.com/client/installer/SteamSetup.exe";
            this.userControl14.Location = new System.Drawing.Point(354, 217);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(229, 93);
            this.userControl14.TabIndex = 4;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.Color.Transparent;
            this.userControl13.ButtonText = "Notion";
            this.userControl13.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl13.ImageApp")));
            this.userControl13.LinkURL = "https://www.notion.com/desktop/windows/download?from=marketing&pathname=%2Fes-es%" +
    "2Fdownload&tid=w_fb6b63f1afe749b69e91ad6abe9443cd";
            this.userControl13.Location = new System.Drawing.Point(689, 217);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(229, 93);
            this.userControl13.TabIndex = 3;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.Transparent;
            this.userControl12.ButtonText = "Logitech G Hub";
            this.userControl12.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl12.ImageApp")));
            this.userControl12.LinkURL = "https://download01.logi.com/web/ftp/pub/techsupport/gaming/lghub_installer.exe";
            this.userControl12.Location = new System.Drawing.Point(354, 336);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(229, 93);
            this.userControl12.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Transparent;
            this.userControl11.ButtonText = "Discord";
            this.userControl11.ImageApp = ((System.Drawing.Image)(resources.GetObject("userControl11.ImageApp")));
            this.userControl11.LinkURL = "https://discord.com/api/downloads/distributions/app/installers/latest?channel=sta" +
    "ble&platform=win&arch=x64";
            this.userControl11.Location = new System.Drawing.Point(49, 217);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(229, 93);
            this.userControl11.TabIndex = 1;
            // 
            // ucBrave
            // 
            this.ucBrave.BackColor = System.Drawing.Color.Transparent;
            this.ucBrave.ButtonText = "Brave";
            this.ucBrave.ImageApp = ((System.Drawing.Image)(resources.GetObject("ucBrave.ImageApp")));
            this.ucBrave.LinkURL = "https://laptop-updates.brave.com/download/BRV013?bitness=64";
            this.ucBrave.Location = new System.Drawing.Point(50, 102);
            this.ucBrave.Name = "ucBrave";
            this.ucBrave.Size = new System.Drawing.Size(228, 91);
            this.ucBrave.TabIndex = 0;
            // 
            // frmInstaller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 505);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEssApps);
            this.Controls.Add(this.userControl18);
            this.Controls.Add(this.userControl17);
            this.Controls.Add(this.userControl16);
            this.Controls.Add(this.userControl15);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.ucBrave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEssApps";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonControl2.ButtonControl1 ucBrave;
        private ButtonControl2.ButtonControl1 userControl11;
        private ButtonControl2.ButtonControl1 userControl12;
        private ButtonControl2.ButtonControl1 userControl13;
        private ButtonControl2.ButtonControl1 userControl14;
        private ButtonControl2.ButtonControl1 userControl15;
        private ButtonControl2.ButtonControl1 userControl16;
        private ButtonControl2.ButtonControl1 userControl17;
        private ButtonControl2.ButtonControl1 userControl18;
        private System.Windows.Forms.Label lblEssApps;
        private System.Windows.Forms.Button btnClose;
    }
}

