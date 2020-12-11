namespace RayCastingCSHARP
{
    partial class LevelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelsForm));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.levels_gp = new System.Windows.Forms.GroupBox();
            this.levels_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.Sienna;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(892, 474);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(143, 49);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Назад";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // levels_gp
            // 
            this.levels_gp.BackColor = System.Drawing.SystemColors.Desktop;
            this.levels_gp.BackgroundImage = global::RayCastingCSHARP.Properties.Resources.green_maze_bg;
            this.levels_gp.Controls.Add(this.btn_cancel);
            this.levels_gp.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.levels_gp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levels_gp.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levels_gp.ForeColor = System.Drawing.Color.SeaShell;
            this.levels_gp.Location = new System.Drawing.Point(0, 0);
            this.levels_gp.Margin = new System.Windows.Forms.Padding(4);
            this.levels_gp.Name = "levels_gp";
            this.levels_gp.Padding = new System.Windows.Forms.Padding(4);
            this.levels_gp.Size = new System.Drawing.Size(1067, 554);
            this.levels_gp.TabIndex = 1;
            this.levels_gp.TabStop = false;
            this.levels_gp.Text = "Уровни";
            // 
            // LevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.levels_gp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LevelsForm";
            this.Text = "Игра \"Лабиринт\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelsForm_FormClosed);
            this.Load += new System.EventHandler(this.LevelsForm_Load);
            this.levels_gp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox levels_gp;
    }
}