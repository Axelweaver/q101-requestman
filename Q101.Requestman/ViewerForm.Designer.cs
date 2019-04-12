namespace Q101.Requestman
{
    partial class ViewerForm
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
            this.TextViewer = new System.Windows.Forms.TextBox();
            this.AsJsonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextViewer
            // 
            this.TextViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextViewer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextViewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextViewer.Location = new System.Drawing.Point(0, 41);
            this.TextViewer.Multiline = true;
            this.TextViewer.Name = "TextViewer";
            this.TextViewer.ReadOnly = true;
            this.TextViewer.Size = new System.Drawing.Size(800, 409);
            this.TextViewer.TabIndex = 0;
            this.TextViewer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextViewer_KeyUp);
            // 
            // AsJsonButton
            // 
            this.AsJsonButton.Location = new System.Drawing.Point(12, 12);
            this.AsJsonButton.Name = "AsJsonButton";
            this.AsJsonButton.Size = new System.Drawing.Size(106, 23);
            this.AsJsonButton.TabIndex = 1;
            this.AsJsonButton.Text = "FORMAT JSON";
            this.AsJsonButton.UseVisualStyleBackColor = true;
            this.AsJsonButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AsJsonButton);
            this.Controls.Add(this.TextViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewerForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextViewer;
        private System.Windows.Forms.Button AsJsonButton;
    }
}