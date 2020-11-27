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
            this.SuspendLayout();
            // 
            // map_3D_panel
            // 
            this.map_3D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_3D_panel.Location = new System.Drawing.Point(0, 0);
            this.map_3D_panel.Margin = new System.Windows.Forms.Padding(0);
            this.map_3D_panel.Name = "map_3D_panel";
            this.map_3D_panel.Size = new System.Drawing.Size(1200, 800);
            this.map_3D_panel.TabIndex = 0;
            // 
            // map_2D_panel
            // 
            this.map_2D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_2D_panel.Location = new System.Drawing.Point(0, 640);
            this.map_2D_panel.Margin = new System.Windows.Forms.Padding(0);
            this.map_2D_panel.Name = "map_2D_panel";
            this.map_2D_panel.Size = new System.Drawing.Size(240, 160);
            this.map_2D_panel.TabIndex = 1;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1232, 859);
            this.Controls.Add(this.map_2D_panel);
            this.Controls.Add(this.map_3D_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Shown += new System.EventHandler(this.GameForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel map_3D_panel;
        private System.Windows.Forms.Panel map_2D_panel;
    }
}