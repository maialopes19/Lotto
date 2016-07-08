namespace Lotto
{
    partial class Lotto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.n5 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.n5);
            this.groupBox1.Controls.Add(this.n4);
            this.groupBox1.Controls.Add(this.n3);
            this.groupBox1.Controls.Add(this.n2);
            this.groupBox1.Controls.Add(this.n1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ball Container";
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.White;
            this.n5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n5.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(235, 40);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(47, 25);
            this.n5.TabIndex = 4;
            this.n5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.White;
            this.n4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(177, 40);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(52, 25);
            this.n4.TabIndex = 3;
            this.n4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.White;
            this.n3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n3.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(123, 40);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(48, 25);
            this.n3.TabIndex = 2;
            this.n3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.White;
            this.n2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(69, 40);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(48, 25);
            this.n2.TabIndex = 1;
            this.n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.White;
            this.n1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(15, 40);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(48, 25);
            this.n1.TabIndex = 0;
            this.n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(96, 297);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(125, 40);
            this.generate.TabIndex = 1;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.Image = global::Lotto.Properties.Resources.Background;
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 380);
            this.label1.TabIndex = 4;
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 370);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lotto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto Number Generator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
    }
}

