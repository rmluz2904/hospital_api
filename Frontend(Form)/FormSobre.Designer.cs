namespace Frontend_Form_
{
    partial class FormSobre
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
            labelSobre = new Label();
            timerSobre = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelSobre
            // 
            labelSobre.AutoSize = true;
            labelSobre.Location = new Point(604, 268);
            labelSobre.Name = "labelSobre";
            labelSobre.Size = new Size(59, 25);
            labelSobre.TabIndex = 0;
            labelSobre.Text = "label1";
            // 
            // timerSobre
            // 
            timerSobre.Enabled = true;
            timerSobre.Interval = 40;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1660, 733);
            ControlBox = false;
            Controls.Add(labelSobre);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormSobre";
            RightToLeftLayout = true;
            Text = "FormSobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSobre;
        private System.Windows.Forms.Timer timerSobre;
    }
}