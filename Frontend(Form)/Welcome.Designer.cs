namespace Frontend_Form_
{
    partial class WelcomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnSair = new Button();
            labelWelcome = new Label();
            labelAPI = new Label();
            timerWelcome = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightBlue;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.Location = new Point(1425, 815);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(141, 56);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            labelWelcome.Location = new Point(458, 134);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(759, 70);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Sistema de Gestão Hospitalar ";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAPI
            // 
            labelAPI.AutoSize = true;
            labelAPI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAPI.Location = new Point(55, 915);
            labelAPI.Name = "labelAPI";
            labelAPI.Size = new Size(172, 25);
            labelAPI.TabIndex = 2;
            labelAPI.Text = "API by Ricardo Luz";
            // 
            // timerWelcome
            // 
            timerWelcome.Enabled = true;
            timerWelcome.Interval = 1000;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTimer.Location = new Point(1386, 895);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(98, 32);
            labelTimer.TabIndex = 3;
            labelTimer.Text = "horario";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_hospital;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1648, 971);
            ControlBox = false;
            Controls.Add(labelTimer);
            Controls.Add(labelAPI);
            Controls.Add(labelWelcome);
            Controls.Add(btnSair);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            Text = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Label labelWelcome;
        private Label labelAPI;
        private System.Windows.Forms.Timer timerWelcome;
        private Label labelTimer;
    }
}