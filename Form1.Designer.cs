
namespace displayName
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
            this.myName = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myName
            // 
            this.myName.Location = new System.Drawing.Point(30, 57);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(188, 20);
            this.myName.TabIndex = 0;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(62, 113);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(116, 23);
            this.Display.TabIndex = 1;
            this.Display.Text = "Dispaly me";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(30, 174);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(188, 65);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 248);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.myName);
            this.Name = "Form1";
            this.Text = "DisplayName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myName;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label outputLabel;
    }
}

