namespace InvoiceTracker
{
    partial class MainForm
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
            ToolStripStatusLabel toolStripStatusLabel;
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            invoicesToolStripMenuItem = new ToolStripMenuItem();
            invoicesAddNewToolStripMenuItem = new ToolStripMenuItem();
            invoicesListToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            customersAddNewToolStripMenuItem = new ToolStripMenuItem();
            customersListToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, invoicesToolStripMenuItem, customersToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "&Settings";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // invoicesToolStripMenuItem
            // 
            invoicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { invoicesAddNewToolStripMenuItem, invoicesListToolStripMenuItem });
            invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            invoicesToolStripMenuItem.Size = new Size(62, 20);
            invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // invoicesAddNewToolStripMenuItem
            // 
            invoicesAddNewToolStripMenuItem.Name = "invoicesAddNewToolStripMenuItem";
            invoicesAddNewToolStripMenuItem.Size = new Size(180, 22);
            invoicesAddNewToolStripMenuItem.Text = "Add new invoice";
            invoicesAddNewToolStripMenuItem.Click += invoicesAddNewToolStripMenuItem_Click;
            // 
            // invoicesListToolStripMenuItem
            // 
            invoicesListToolStripMenuItem.Name = "invoicesListToolStripMenuItem";
            invoicesListToolStripMenuItem.Size = new Size(180, 22);
            invoicesListToolStripMenuItem.Text = "List";
            invoicesListToolStripMenuItem.Click += invoicesListToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customersAddNewToolStripMenuItem, customersListToolStripMenuItem });
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(76, 20);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // customersAddNewToolStripMenuItem
            // 
            customersAddNewToolStripMenuItem.Name = "customersAddNewToolStripMenuItem";
            customersAddNewToolStripMenuItem.Size = new Size(174, 22);
            customersAddNewToolStripMenuItem.Text = "Add new customer";
            // 
            // customersListToolStripMenuItem
            // 
            customersListToolStripMenuItem.Name = "customersListToolStripMenuItem";
            customersListToolStripMenuItem.Size = new Size(174, 22);
            customersListToolStripMenuItem.Text = "List";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "InvoiceTracker";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem invoicesToolStripMenuItem;
        private ToolStripMenuItem invoicesAddNewToolStripMenuItem;
        private ToolStripMenuItem invoicesListToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem customersAddNewToolStripMenuItem;
        private ToolStripMenuItem customersListToolStripMenuItem;
    }
}