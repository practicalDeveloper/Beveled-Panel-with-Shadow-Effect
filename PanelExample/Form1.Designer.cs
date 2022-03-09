namespace PanelExample
{
    partial class Form1
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
            this.advancedPanel1 = new BevelPanel.AdvancedPanel();
            this.advancedPanel2 = new BevelPanel.AdvancedPanel();
            this.advancedPanel3 = new BevelPanel.AdvancedPanel();
            this.SuspendLayout();
            // 
            // advancedPanel1
            // 
            this.advancedPanel1.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel1.EdgeWidth = 2;
            this.advancedPanel1.EndColor = System.Drawing.Color.LightSalmon;
            this.advancedPanel1.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.advancedPanel1.Location = new System.Drawing.Point(69, 43);
            this.advancedPanel1.Name = "advancedPanel1";
            this.advancedPanel1.RectRadius = 10;
            this.advancedPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel1.ShadowShift = 0;
            this.advancedPanel1.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel1.Size = new System.Drawing.Size(157, 50);
            this.advancedPanel1.StartColor = System.Drawing.Color.Orange;
            this.advancedPanel1.Style = BevelPanel.AdvancedPanel.BevelStyle.Lowered;
            this.advancedPanel1.TabIndex = 0;
            // 
            // advancedPanel2
            // 
            this.advancedPanel2.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.Vertical;
            this.advancedPanel2.EdgeWidth = 2;
            this.advancedPanel2.EndColor = System.Drawing.Color.LightGreen;
            this.advancedPanel2.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.advancedPanel2.Location = new System.Drawing.Point(258, 43);
            this.advancedPanel2.Name = "advancedPanel2";
            this.advancedPanel2.RectRadius = 20;
            this.advancedPanel2.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel2.ShadowShift = 10;
            this.advancedPanel2.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.ForwardDiagonal;
            this.advancedPanel2.Size = new System.Drawing.Size(322, 177);
            this.advancedPanel2.StartColor = System.Drawing.Color.ForestGreen;
            this.advancedPanel2.Style = BevelPanel.AdvancedPanel.BevelStyle.Raised;
            this.advancedPanel2.TabIndex = 1;
            // 
            // advancedPanel3
            // 
            this.advancedPanel3.BackgroundGradientMode = BevelPanel.AdvancedPanel.PanelGradientMode.ForwardDiagonal;
            this.advancedPanel3.EdgeWidth = 2;
            this.advancedPanel3.EndColor = System.Drawing.Color.CadetBlue;
            this.advancedPanel3.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.advancedPanel3.Location = new System.Drawing.Point(24, 259);
            this.advancedPanel3.Name = "advancedPanel3";
            this.advancedPanel3.RectRadius = 0;
            this.advancedPanel3.ShadowColor = System.Drawing.Color.DimGray;
            this.advancedPanel3.ShadowShift = 7;
            this.advancedPanel3.ShadowStyle = BevelPanel.AdvancedPanel.ShadowMode.Dropped;
            this.advancedPanel3.Size = new System.Drawing.Size(679, 260);
            this.advancedPanel3.StartColor = System.Drawing.Color.PowderBlue;
            this.advancedPanel3.Style = BevelPanel.AdvancedPanel.BevelStyle.Raised;
            this.advancedPanel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 531);
            this.Controls.Add(this.advancedPanel3);
            this.Controls.Add(this.advancedPanel2);
            this.Controls.Add(this.advancedPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BevelPanel.AdvancedPanel advancedPanel1;
        private BevelPanel.AdvancedPanel advancedPanel2;
        private BevelPanel.AdvancedPanel advancedPanel3;
    }
}

