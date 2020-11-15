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
            this.minimap_2D_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map_3D_panel
            // 
            this.map_3D_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.map_3D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_3D_panel.Location = new System.Drawing.Point(330, 50);
            this.map_3D_panel.Name = "map_3D_panel";
            this.map_3D_panel.Size = new System.Drawing.Size(900, 600);
            this.map_3D_panel.TabIndex = 0;
            // 
            // minimap_2D_panel
            // 
            this.minimap_2D_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimap_2D_panel.Location = new System.Drawing.Point(1, 50);
            this.minimap_2D_panel.Name = "minimap_2D_panel";
            this.minimap_2D_panel.Size = new System.Drawing.Size(300, 200);
            this.minimap_2D_panel.TabIndex = 1;
            this.minimap_2D_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.minimap_2D_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimap_2D_panel);
            this.Controls.Add(this.map_3D_panel);
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel map_3D_panel;
        private System.Windows.Forms.Panel minimap_2D_panel;
        private System.Windows.Forms.Label label1;
    }
}