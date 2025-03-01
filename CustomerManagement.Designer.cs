namespace CustomersManagement
{
    partial class CustomerManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(488, 257);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(538, 33);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 1;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(538, 87);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 2;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ForeColor = Color.Red;
            button3.Location = new Point(538, 146);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 3;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 327);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
