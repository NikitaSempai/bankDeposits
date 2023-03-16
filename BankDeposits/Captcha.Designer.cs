namespace BankDeposits
{
    partial class Captcha
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(38, 129);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(237, 23);
            this.userInput.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.ForeColor = System.Drawing.Color.BlueViolet;
            this.update.Location = new System.Drawing.Point(38, 162);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(84, 31);
            this.update.TabIndex = 2;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ok.ForeColor = System.Drawing.Color.BlueViolet;
            this.ok.Location = new System.Drawing.Point(191, 162);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(84, 31);
            this.ok.TabIndex = 3;
            this.ok.Text = "ОК";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(317, 201);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.update);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(333, 240);
            this.Name = "Captcha";
            this.Load += new System.EventHandler(this.Captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox userInput;
        private Button update;
        private Button ok;
    }
}