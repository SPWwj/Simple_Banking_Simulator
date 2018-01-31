namespace MiniProj
{
    partial class Form2
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
            this.btnF2Delete = new System.Windows.Forms.Button();
            this.btnF2Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnF2Delete
            // 
            this.btnF2Delete.Location = new System.Drawing.Point(245, 442);
            this.btnF2Delete.Name = "btnF2Delete";
            this.btnF2Delete.Size = new System.Drawing.Size(113, 45);
            this.btnF2Delete.TabIndex = 9;
            this.btnF2Delete.Text = "Delete";
            this.btnF2Delete.UseVisualStyleBackColor = true;
            this.btnF2Delete.Click += new System.EventHandler(this.btnF2Delete_Click);
            // 
            // btnF2Close
            // 
            this.btnF2Close.Location = new System.Drawing.Point(516, 442);
            this.btnF2Close.Name = "btnF2Close";
            this.btnF2Close.Size = new System.Drawing.Size(122, 45);
            this.btnF2Close.TabIndex = 8;
            this.btnF2Close.Text = "Logout";
            this.btnF2Close.UseVisualStyleBackColor = true;
            this.btnF2Close.Click += new System.EventHandler(this.btnF2Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 263);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnF2Delete);
            this.Controls.Add(this.btnF2Close);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnF2Delete;
        private System.Windows.Forms.Button btnF2Close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}