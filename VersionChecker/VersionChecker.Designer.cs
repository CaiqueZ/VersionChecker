namespace VersionChecker
{
    partial class Base
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnTop2 = new System.Windows.Forms.Panel();
            this.lblLocalVersion = new System.Windows.Forms.Label();
            this.lblNewerVersion = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Indigo;
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(252, 2);
            this.pnTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblTitulo.Location = new System.Drawing.Point(3, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 17);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Version Checker";
            // 
            // pnTop2
            // 
            this.pnTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnTop2.Location = new System.Drawing.Point(0, 24);
            this.pnTop2.Name = "pnTop2";
            this.pnTop2.Size = new System.Drawing.Size(252, 1);
            this.pnTop2.TabIndex = 2;
            // 
            // lblLocalVersion
            // 
            this.lblLocalVersion.AutoSize = true;
            this.lblLocalVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLocalVersion.Location = new System.Drawing.Point(12, 31);
            this.lblLocalVersion.Name = "lblLocalVersion";
            this.lblLocalVersion.Size = new System.Drawing.Size(106, 15);
            this.lblLocalVersion.TabIndex = 3;
            this.lblLocalVersion.Text = "Version: Verifying...";
            // 
            // lblNewerVersion
            // 
            this.lblNewerVersion.AutoSize = true;
            this.lblNewerVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNewerVersion.Location = new System.Drawing.Point(12, 47);
            this.lblNewerVersion.Name = "lblNewerVersion";
            this.lblNewerVersion.Size = new System.Drawing.Size(149, 15);
            this.lblNewerVersion.TabIndex = 4;
            this.lblNewerVersion.Text = "Looking for a new version..";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(206, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(252, 80);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblNewerVersion);
            this.Controls.Add(this.lblLocalVersion);
            this.Controls.Add(this.pnTop2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Base";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VersionChecker";
            this.Load += new System.EventHandler(this.Base_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnTop2;
        private System.Windows.Forms.Label lblLocalVersion;
        private System.Windows.Forms.Label lblNewerVersion;
        private System.Windows.Forms.Button btnExit;
    }
}

