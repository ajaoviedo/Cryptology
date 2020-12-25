namespace WindowsFormsApp1
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
            this.Plaintext = new System.Windows.Forms.RichTextBox();
            this.Ciphertext = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Rotation = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CLR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plaintext
            // 
            this.Plaintext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Plaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plaintext.Location = new System.Drawing.Point(125, 168);
            this.Plaintext.Multiline = false;
            this.Plaintext.Name = "Plaintext";
            this.Plaintext.Size = new System.Drawing.Size(223, 50);
            this.Plaintext.TabIndex = 3;
            this.Plaintext.Text = "";
            // 
            // Ciphertext
            // 
            this.Ciphertext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ciphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ciphertext.Location = new System.Drawing.Point(445, 168);
            this.Ciphertext.Multiline = false;
            this.Ciphertext.Name = "Ciphertext";
            this.Ciphertext.Size = new System.Drawing.Size(223, 50);
            this.Ciphertext.TabIndex = 4;
            this.Ciphertext.Text = "";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(318, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Rotate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rotation
            // 
            this.Rotation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotation.Location = new System.Drawing.Point(207, 237);
            this.Rotation.Multiline = false;
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(49, 37);
            this.Rotation.TabIndex = 6;
            this.Rotation.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 34);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Plaintext";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(491, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 34);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Ciphertext";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(164, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(134, 27);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Rotation Value";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CLR
            // 
            this.CLR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLR.Location = new System.Drawing.Point(567, 365);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(101, 37);
            this.CLR.TabIndex = 10;
            this.CLR.Text = "Clear";
            this.CLR.UseVisualStyleBackColor = true;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Ciphertext);
            this.Controls.Add(this.Plaintext);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Plaintext;
        private System.Windows.Forms.RichTextBox Ciphertext;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox Rotation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CLR;
    }
}

