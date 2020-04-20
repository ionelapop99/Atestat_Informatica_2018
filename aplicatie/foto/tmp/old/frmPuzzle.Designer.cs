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
            this.btnDreapta = new System.Windows.Forms.Button();
            this.btnStanga = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDreapta
            // 
            this.btnDreapta.Location = new System.Drawing.Point(525, 29);
            this.btnDreapta.Name = "btnDreapta";
            this.btnDreapta.Size = new System.Drawing.Size(36, 29);
            this.btnDreapta.TabIndex = 10;
            this.btnDreapta.Text = ">";
            this.btnDreapta.UseVisualStyleBackColor = true;
            // 
            // btnStanga
            // 
            this.btnStanga.Location = new System.Drawing.Point(188, 29);
            this.btnStanga.Name = "btnStanga";
            this.btnStanga.Size = new System.Drawing.Size(36, 29);
            this.btnStanga.TabIndex = 11;
            this.btnStanga.Text = "<";
            this.btnStanga.UseVisualStyleBackColor = true;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(437, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(72, 66);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 7;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(340, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(72, 66);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 8;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(243, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(72, 66);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 9;
            this.pb1.TabStop = false;
            // 
            // frmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnDreapta);
            this.Controls.Add(this.btnStanga);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "frmPuzzle";
            this.Text = "frmPuzzle";
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDreapta;
        private System.Windows.Forms.Button btnStanga;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
    }
}