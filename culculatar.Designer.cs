
namespace project
{
    partial class culculatar
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
            this.txtfirstnumber = new System.Windows.Forms.TextBox();
            this.txtsecondnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btndivid = new System.Windows.Forms.Button();
            this.btnmudulus = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfirstnumber
            // 
            this.txtfirstnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstnumber.Location = new System.Drawing.Point(156, 65);
            this.txtfirstnumber.Name = "txtfirstnumber";
            this.txtfirstnumber.Size = new System.Drawing.Size(206, 26);
            this.txtfirstnumber.TabIndex = 0;
            // 
            // txtsecondnumber
            // 
            this.txtsecondnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecondnumber.Location = new System.Drawing.Point(156, 127);
            this.txtsecondnumber.Name = "txtsecondnumber";
            this.txtsecondnumber.Size = new System.Drawing.Size(206, 26);
            this.txtsecondnumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(156, 186);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(206, 26);
            this.txtresult.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Result";
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(494, 65);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 42);
            this.btnsub.TabIndex = 2;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(393, 133);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(75, 42);
            this.btnmul.TabIndex = 2;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.Location = new System.Drawing.Point(393, 65);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(75, 42);
            this.btnsum.TabIndex = 2;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btndivid
            // 
            this.btndivid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivid.Location = new System.Drawing.Point(494, 133);
            this.btndivid.Name = "btndivid";
            this.btndivid.Size = new System.Drawing.Size(75, 42);
            this.btndivid.TabIndex = 2;
            this.btndivid.Text = "/";
            this.btndivid.UseVisualStyleBackColor = true;
            this.btndivid.Click += new System.EventHandler(this.btndivid_Click);
            // 
            // btnmudulus
            // 
            this.btnmudulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmudulus.Location = new System.Drawing.Point(393, 199);
            this.btnmudulus.Name = "btnmudulus";
            this.btnmudulus.Size = new System.Drawing.Size(75, 42);
            this.btnmudulus.TabIndex = 2;
            this.btnmudulus.Text = "%";
            this.btnmudulus.UseVisualStyleBackColor = true;
            this.btnmudulus.Click += new System.EventHandler(this.btnmudulus_Click);
            // 
            // btnequal
            // 
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.Location = new System.Drawing.Point(494, 199);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(75, 42);
            this.btnequal.TabIndex = 2;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // culculatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnmudulus);
            this.Controls.Add(this.btndivid);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtsecondnumber);
            this.Controls.Add(this.txtfirstnumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "culculatar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "culculetar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfirstnumber;
        private System.Windows.Forms.TextBox txtsecondnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btndivid;
        private System.Windows.Forms.Button btnmudulus;
        private System.Windows.Forms.Button btnequal;
    }
}

