
namespace CommPortTest
{
    partial class Form1
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
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(35, 35);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(96, 39);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.Location = new System.Drawing.Point(35, 114);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.Size = new System.Drawing.Size(330, 161);
            this.rtbIncoming.TabIndex = 1;
            this.rtbIncoming.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 287);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.RichTextBox rtbIncoming;
    }
}

