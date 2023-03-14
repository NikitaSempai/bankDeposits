namespace BankDeposits
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.депозитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыПроцентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.role = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.счетаToolStripMenuItem,
            this.депозитыToolStripMenuItem,
            this.типыПроцентовToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.ролиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // счетаToolStripMenuItem
            // 
            this.счетаToolStripMenuItem.Name = "счетаToolStripMenuItem";
            this.счетаToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.счетаToolStripMenuItem.Text = "Счета";
            this.счетаToolStripMenuItem.Click += new System.EventHandler(this.счетаToolStripMenuItem_Click);
            // 
            // депозитыToolStripMenuItem
            // 
            this.депозитыToolStripMenuItem.Name = "депозитыToolStripMenuItem";
            this.депозитыToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.депозитыToolStripMenuItem.Text = "Депозиты";
            this.депозитыToolStripMenuItem.Click += new System.EventHandler(this.депозитыToolStripMenuItem_Click);
            // 
            // типыПроцентовToolStripMenuItem
            // 
            this.типыПроцентовToolStripMenuItem.Name = "типыПроцентовToolStripMenuItem";
            this.типыПроцентовToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.типыПроцентовToolStripMenuItem.Text = "Типы процентов";
            this.типыПроцентовToolStripMenuItem.Click += new System.EventHandler(this.типыПроцентовToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(111, 21);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.ролиToolStripMenuItem.Text = "Роли";
            this.ролиToolStripMenuItem.Click += new System.EventHandler(this.ролиToolStripMenuItem_Click);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.role.Location = new System.Drawing.Point(12, 267);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(0, 21);
            this.role.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(905, 569);
            this.Controls.Add(this.role);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem счетаToolStripMenuItem;
        private ToolStripMenuItem депозитыToolStripMenuItem;
        private ToolStripMenuItem типыПроцентовToolStripMenuItem;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ToolStripMenuItem ролиToolStripMenuItem;
        private Label role;
    }
}