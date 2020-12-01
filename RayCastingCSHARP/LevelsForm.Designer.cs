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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.levels_gp = new System.Windows.Forms.GroupBox();
            this.test_label = new System.Windows.Forms.Label();
            this.levels_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(701, 402);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Назад";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // levels_gp
            // 
            this.levels_gp.Controls.Add(this.test_label);
            this.levels_gp.Controls.Add(this.btn_cancel);
            this.levels_gp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levels_gp.Location = new System.Drawing.Point(0, 0);
            this.levels_gp.Name = "levels_gp";
            this.levels_gp.Size = new System.Drawing.Size(800, 450);
            this.levels_gp.TabIndex = 1;
            this.levels_gp.TabStop = false;
            this.levels_gp.Text = "Уровни";
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.Location = new System.Drawing.Point(28, 262);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(24, 13);
            this.test_label.TabIndex = 1;
            this.test_label.Text = "test";
            // 
            // LevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levels_gp);
            this.Name = "LevelsForm";
            this.Text = "LevelsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelsForm_FormClosed);
            this.Load += new System.EventHandler(this.LevelsForm_Load);
            this.levels_gp.ResumeLayout(false);
            this.levels_gp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox levels_gp;
        private System.Windows.Forms.Label test_label;
    }
}