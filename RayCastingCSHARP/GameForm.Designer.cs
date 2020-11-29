namespace RayCastingCSHARP
{
    partial class GameForm
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
            this.map_3D_panel = new System.Windows.Forms.Panel();
            this.map_2D_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.map_3D_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // map_3D_panel
            // 
            this.map_3D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_3D_panel.Controls.Add(this.label1);
            this.map_3D_panel.Location = new System.Drawing.Point(0, 0);
            this.map_3D_panel.Margin = new System.Windows.Forms.Padding(0);
            this.map_3D_panel.Name = "map_3D_panel";
            this.map_3D_panel.Size = new System.Drawing.Size(960, 640);
            this.map_3D_panel.TabIndex = 0;
            // 
            // map_2D_panel
            // 
            this.map_2D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_2D_panel.Location = new System.Drawing.Point(0, 512);
            this.map_2D_panel.Margin = new System.Windows.Forms.Padding(0);
            this.map_2D_panel.Name = "map_2D_panel";
            this.map_2D_panel.Size = new System.Drawing.Size(192, 128);
            this.map_2D_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(986, 687);
            this.Controls.Add(this.map_2D_panel);
            this.Controls.Add(this.map_3D_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.map_3D_panel.ResumeLayout(false);
            this.map_3D_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel map_3D_panel;
        private System.Windows.Forms.Panel map_2D_panel;
        private System.Windows.Forms.Label label1;
    }
}