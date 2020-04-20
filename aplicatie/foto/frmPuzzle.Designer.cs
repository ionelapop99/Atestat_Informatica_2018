namespace foto
{
    partial class frmPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzle));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDreapta = new System.Windows.Forms.Button();
            this.btnStanga = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.dr = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.Label();
            this.jos = new System.Windows.Forms.Label();
            this.sus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnDreapta
            // 
            this.btnDreapta.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDreapta.ForeColor = System.Drawing.Color.Black;
            this.btnDreapta.Location = new System.Drawing.Point(541, 507);
            this.btnDreapta.Name = "btnDreapta";
            this.btnDreapta.Size = new System.Drawing.Size(36, 29);
            this.btnDreapta.TabIndex = 19;
            this.btnDreapta.Text = ">";
            this.btnDreapta.UseVisualStyleBackColor = false;
            this.btnDreapta.Click += new System.EventHandler(this.btnDreapta_Click);
            // 
            // btnStanga
            // 
            this.btnStanga.BackColor = System.Drawing.Color.FloralWhite;
            this.btnStanga.ForeColor = System.Drawing.Color.Black;
            this.btnStanga.Location = new System.Drawing.Point(204, 507);
            this.btnStanga.Name = "btnStanga";
            this.btnStanga.Size = new System.Drawing.Size(36, 29);
            this.btnStanga.TabIndex = 20;
            this.btnStanga.Text = "<";
            this.btnStanga.UseVisualStyleBackColor = false;
            this.btnStanga.Click += new System.EventHandler(this.btnStanga_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Location = new System.Drawing.Point(456, 484);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(72, 66);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 16;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Location = new System.Drawing.Point(359, 484);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(72, 66);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 17;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Location = new System.Drawing.Point(262, 484);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(72, 66);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 18;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puzzle";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Incarca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.FloralWhite;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(648, 69);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 19);
            this.lblClose.TabIndex = 39;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dr
            // 
            this.dr.BackColor = System.Drawing.Color.FloralWhite;
            this.dr.ForeColor = System.Drawing.Color.Black;
            this.dr.Location = new System.Drawing.Point(620, 69);
            this.dr.Name = "dr";
            this.dr.Size = new System.Drawing.Size(22, 19);
            this.dr.TabIndex = 40;
            // 
            // st
            // 
            this.st.BackColor = System.Drawing.Color.FloralWhite;
            this.st.ForeColor = System.Drawing.Color.Black;
            this.st.Location = new System.Drawing.Point(592, 69);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(22, 19);
            this.st.TabIndex = 37;
            // 
            // jos
            // 
            this.jos.BackColor = System.Drawing.Color.FloralWhite;
            this.jos.ForeColor = System.Drawing.Color.Black;
            this.jos.Location = new System.Drawing.Point(566, 69);
            this.jos.Name = "jos";
            this.jos.Size = new System.Drawing.Size(22, 19);
            this.jos.TabIndex = 38;
            // 
            // sus
            // 
            this.sus.BackColor = System.Drawing.Color.FloralWhite;
            this.sus.ForeColor = System.Drawing.Color.Black;
            this.sus.Location = new System.Drawing.Point(538, 69);
            this.sus.Name = "sus";
            this.sus.Size = new System.Drawing.Size(22, 19);
            this.sus.TabIndex = 41;
            // 
            // frmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.dr);
            this.Controls.Add(this.st);
            this.Controls.Add(this.jos);
            this.Controls.Add(this.sus);
            this.Controls.Add(this.btnDreapta);
            this.Controls.Add(this.btnStanga);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(235, 170);
            this.MinimizeBox = false;
            this.Name = "frmPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.Load += new System.EventHandler(this.frmPuzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDreapta;
        private System.Windows.Forms.Button btnStanga;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label dr;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Label jos;
        private System.Windows.Forms.Label sus;
    }
}