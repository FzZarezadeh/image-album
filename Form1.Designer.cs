namespace image_album
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnzoomin = new System.Windows.Forms.Button();
            this.btnzoomout = new System.Windows.Forms.Button();
            this.lblpicname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(231, 100);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(700, 400);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(175, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnprev
            // 
            this.btnprev.AutoSize = true;
            this.btnprev.Location = new System.Drawing.Point(139, 188);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(28, 27);
            this.btnprev.TabIndex = 1;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.AutoSize = true;
            this.btnnext.Location = new System.Drawing.Point(631, 188);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(28, 27);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnzoomin
            // 
            this.btnzoomin.AutoSize = true;
            this.btnzoomin.Location = new System.Drawing.Point(231, 394);
            this.btnzoomin.Name = "btnzoomin";
            this.btnzoomin.Size = new System.Drawing.Size(78, 27);
            this.btnzoomin.TabIndex = 3;
            this.btnzoomin.Text = "Zoom in";
            this.btnzoomin.UseVisualStyleBackColor = true;
            this.btnzoomin.Click += new System.EventHandler(this.btnzoomin_Click);
            // 
            // btnzoomout
            // 
            this.btnzoomout.AutoSize = true;
            this.btnzoomout.Location = new System.Drawing.Point(503, 394);
            this.btnzoomout.Name = "btnzoomout";
            this.btnzoomout.Size = new System.Drawing.Size(78, 27);
            this.btnzoomout.TabIndex = 4;
            this.btnzoomout.Text = "Zoom out";
            this.btnzoomout.UseVisualStyleBackColor = true;
            this.btnzoomout.Click += new System.EventHandler(this.btnzoomout_Click);
            // 
            // lblpicname
            // 
            this.lblpicname.AutoSize = true;
            this.lblpicname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpicname.Location = new System.Drawing.Point(377, 396);
            this.lblpicname.Name = "lblpicname";
            this.lblpicname.Size = new System.Drawing.Size(74, 20);
            this.lblpicname.TabIndex = 5;
            this.lblpicname.Text = "picture 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.lblpicname);
            this.Controls.Add(this.btnzoomout);
            this.Controls.Add(this.btnzoomin);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnzoomin;
        private System.Windows.Forms.Button btnzoomout;
        private System.Windows.Forms.Label lblpicname;
    }
}

