namespace Q101.Requestman
{
    partial class IndexForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.RequestBodyTextBox = new System.Windows.Forms.TextBox();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.RequestHeadersTextBox = new System.Windows.Forms.TextBox();
            this.RequestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatisticDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(530, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "S E N D";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RequestBodyTextBox
            // 
            this.RequestBodyTextBox.Location = new System.Drawing.Point(530, 261);
            this.RequestBodyTextBox.Multiline = true;
            this.RequestBodyTextBox.Name = "RequestBodyTextBox";
            this.RequestBodyTextBox.Size = new System.Drawing.Size(462, 183);
            this.RequestBodyTextBox.TabIndex = 1;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlTextBox.Location = new System.Drawing.Point(624, 28);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(368, 29);
            this.UrlTextBox.TabIndex = 2;
            this.UrlTextBox.Text = "http://www.example.com/";
            // 
            // RequestHeadersTextBox
            // 
            this.RequestHeadersTextBox.Location = new System.Drawing.Point(530, 80);
            this.RequestHeadersTextBox.Multiline = true;
            this.RequestHeadersTextBox.Name = "RequestHeadersTextBox";
            this.RequestHeadersTextBox.Size = new System.Drawing.Size(462, 153);
            this.RequestHeadersTextBox.TabIndex = 4;
            // 
            // RequestTypeComboBox
            // 
            this.RequestTypeComboBox.DropDownHeight = 102;
            this.RequestTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestTypeComboBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RequestTypeComboBox.FormattingEnabled = true;
            this.RequestTypeComboBox.IntegralHeight = false;
            this.RequestTypeComboBox.Location = new System.Drawing.Point(530, 28);
            this.RequestTypeComboBox.Name = "RequestTypeComboBox";
            this.RequestTypeComboBox.Size = new System.Drawing.Size(86, 31);
            this.RequestTypeComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "RequestType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Request Headers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Request Body";
            // 
            // StatisticDataGrid
            // 
            this.StatisticDataGrid.AllowUserToAddRows = false;
            this.StatisticDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticDataGrid.Location = new System.Drawing.Point(12, 28);
            this.StatisticDataGrid.Name = "StatisticDataGrid";
            this.StatisticDataGrid.ReadOnly = true;
            this.StatisticDataGrid.Size = new System.Drawing.Size(512, 472);
            this.StatisticDataGrid.TabIndex = 10;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 512);
            this.Controls.Add(this.StatisticDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestTypeComboBox);
            this.Controls.Add(this.RequestHeadersTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.RequestBodyTextBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q101.Requestman";
            ((System.ComponentModel.ISupportInitialize)(this.StatisticDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RequestBodyTextBox;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox RequestHeadersTextBox;
        private System.Windows.Forms.ComboBox RequestTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView StatisticDataGrid;
    }
}

