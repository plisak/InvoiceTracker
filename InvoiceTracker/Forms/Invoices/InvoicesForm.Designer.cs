namespace InvoiceTracker
{
    partial class InvoicesForm
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            invoicesAddbutton = new Button();
            invoicesEditButton = new Button();
            invoicesDeleteButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(invoicesDeleteButton);
            panel1.Controls.Add(invoicesAddbutton);
            panel1.Controls.Add(invoicesEditButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 400);
            dataGridView1.TabIndex = 1;
            // 
            // invoicesAddbutton
            // 
            invoicesAddbutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            invoicesAddbutton.Location = new Point(551, 15);
            invoicesAddbutton.Name = "invoicesAddbutton";
            invoicesAddbutton.Size = new Size(75, 23);
            invoicesAddbutton.TabIndex = 2;
            invoicesAddbutton.Text = "Add";
            invoicesAddbutton.UseVisualStyleBackColor = true;
            // 
            // invoicesEditButton
            // 
            invoicesEditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            invoicesEditButton.Location = new Point(632, 15);
            invoicesEditButton.Name = "invoicesEditButton";
            invoicesEditButton.Size = new Size(75, 23);
            invoicesEditButton.TabIndex = 3;
            invoicesEditButton.Text = "Edit";
            invoicesEditButton.UseVisualStyleBackColor = true;
            // 
            // invoicesDeleteButton
            // 
            invoicesDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            invoicesDeleteButton.Location = new Point(713, 15);
            invoicesDeleteButton.Name = "invoicesDeleteButton";
            invoicesDeleteButton.Size = new Size(75, 23);
            invoicesDeleteButton.TabIndex = 4;
            invoicesDeleteButton.Text = "Delete";
            invoicesDeleteButton.UseVisualStyleBackColor = true;
            invoicesDeleteButton.Click += button3_Click;
            // 
            // InvoicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "InvoicesForm";
            Text = "InvoicesForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button invoicesEditButton;
        private Button invoicesAddbutton;
        private Button invoicesDeleteButton;
    }
}