namespace TelloDrone
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
            this.droneStream = new WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl();
            this.bttnCon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // droneStream
            // 
            this.droneStream.AutoSize = true;
            this.droneStream.BackColor = System.Drawing.Color.Black;
            this.droneStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.droneStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.droneStream.Location = new System.Drawing.Point(0, 0);
            this.droneStream.Name = "droneStream";
            this.droneStream.Size = new System.Drawing.Size(1267, 678);
            this.droneStream.TabIndex = 0;
            // 
            // bttnCon
            // 
            this.bttnCon.BackColor = System.Drawing.SystemColors.Control;
            this.bttnCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCon.Location = new System.Drawing.Point(0, 0);
            this.bttnCon.Name = "bttnCon";
            this.bttnCon.Size = new System.Drawing.Size(168, 60);
            this.bttnCon.TabIndex = 1;
            this.bttnCon.Text = "Disconnect";
            this.bttnCon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bttnCon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 60);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(581, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1267, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.droneStream);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebEye.Controls.WinForms.StreamPlayerControl.StreamPlayerControl droneStream;
        private System.Windows.Forms.Button bttnCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

