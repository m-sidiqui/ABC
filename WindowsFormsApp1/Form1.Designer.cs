namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ChromeStart = new System.Windows.Forms.Button();
            this.Navigate = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Click = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChromeStart
            // 
            this.ChromeStart.Location = new System.Drawing.Point(92, 46);
            this.ChromeStart.Name = "ChromeStart";
            this.ChromeStart.Size = new System.Drawing.Size(75, 23);
            this.ChromeStart.TabIndex = 0;
            this.ChromeStart.Text = "ChromeStart";
            this.ChromeStart.UseVisualStyleBackColor = true;
            this.ChromeStart.Click += new System.EventHandler(this.ChromeStart_Click);
            // 
            // Navigate
            // 
            this.Navigate.Location = new System.Drawing.Point(251, 46);
            this.Navigate.Name = "Navigate";
            this.Navigate.Size = new System.Drawing.Size(75, 23);
            this.Navigate.TabIndex = 1;
            this.Navigate.Text = "Navigate";
            this.Navigate.UseVisualStyleBackColor = true;
            this.Navigate.Click += new System.EventHandler(this.Navigate_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(139, 118);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(294, 117);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(75, 23);
            this.Forward.TabIndex = 3;
            this.Forward.Text = "Forward";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(138, 227);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(285, 218);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Click
            // 
            this.Click.Location = new System.Drawing.Point(392, 140);
            this.Click.Name = "Click";
            this.Click.Size = new System.Drawing.Size(75, 23);
            this.Click.TabIndex = 6;
            this.Click.Text = "Click";
            this.Click.UseVisualStyleBackColor = true;
            this.Click.Click += new System.EventHandler(this.Click_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(218, 280);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(249, 20);
            this.txtValue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 324);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.Click);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Navigate);
            this.Controls.Add(this.ChromeStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChromeStart;
        private System.Windows.Forms.Button Navigate;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.TextBox txtValue;
    }
}

