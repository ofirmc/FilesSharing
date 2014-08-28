namespace FilesSharing
{
    partial class frmServer
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
            this.btnStartListen = new System.Windows.Forms.Button();
            this.lblServStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartListen
            // 
            this.btnStartListen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartListen.Location = new System.Drawing.Point(12, 12);
            this.btnStartListen.Name = "btnStartListen";
            this.btnStartListen.Size = new System.Drawing.Size(75, 54);
            this.btnStartListen.TabIndex = 0;
            this.btnStartListen.Text = "Start listening";
            this.btnStartListen.UseVisualStyleBackColor = false;
            this.btnStartListen.Click += new System.EventHandler(this.btnStartListen_Click);
            // 
            // lblServStart
            // 
            this.lblServStart.AutoSize = true;
            this.lblServStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServStart.Location = new System.Drawing.Point(93, 22);
            this.lblServStart.Name = "lblServStart";
            this.lblServStart.Size = new System.Drawing.Size(37, 13);
            this.lblServStart.TabIndex = 1;
            this.lblServStart.Text = "******";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblServStart);
            this.Controls.Add(this.btnStartListen);
            this.Name = "frmServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartListen;
        private System.Windows.Forms.Label lblServStart;
    }
}

