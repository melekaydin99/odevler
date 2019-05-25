namespace WindowsFormsApplication5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beş = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yirmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yüz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikiyüz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bir,
            this.beş,
            this.on,
            this.yirmi,
            this.elli,
            this.yüz,
            this.ikiyüz});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bir
            // 
            this.bir.HeaderText = "bir";
            this.bir.Name = "bir";
            // 
            // beş
            // 
            this.beş.HeaderText = "beş";
            this.beş.Name = "beş";
            // 
            // on
            // 
            this.on.HeaderText = "on";
            this.on.Name = "on";
            // 
            // yirmi
            // 
            this.yirmi.HeaderText = "yirmi";
            this.yirmi.Name = "yirmi";
            // 
            // elli
            // 
            this.elli.HeaderText = "elli";
            this.elli.Name = "elli";
            // 
            // yüz
            // 
            this.yüz.HeaderText = "yüz";
            this.yüz.Name = "yüz";
            // 
            // ikiyüz
            // 
            this.ikiyüz.HeaderText = "ikiyüz";
            this.ikiyüz.Name = "ikiyüz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hesaplanacak Parayı Giriniz :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bir;
        private System.Windows.Forms.DataGridViewTextBoxColumn beş;
        private System.Windows.Forms.DataGridViewTextBoxColumn on;
        private System.Windows.Forms.DataGridViewTextBoxColumn yirmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn elli;
        private System.Windows.Forms.DataGridViewTextBoxColumn yüz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikiyüz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

