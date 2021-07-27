namespace firebaseapp
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
            this.components = new System.ComponentModel.Container();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rollTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UFtext1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cidTbox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depText1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelresult2 = new System.Windows.Forms.Label();
            this.sldtext2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.retrBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTbox
            // 
            this.nameTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTbox.Location = new System.Drawing.Point(144, 23);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(113, 29);
            this.nameTbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // storeBtn
            // 
            this.storeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeBtn.Location = new System.Drawing.Point(28, 260);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(110, 49);
            this.storeBtn.TabIndex = 2;
            this.storeBtn.Text = "Cadastro";
            this.storeBtn.UseVisualStyleBackColor = true;
            this.storeBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // rollTbox
            // 
            this.rollTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollTbox.Location = new System.Drawing.Point(144, 114);
            this.rollTbox.Name = "rollTbox";
            this.rollTbox.Size = new System.Drawing.Size(556, 29);
            this.rollTbox.TabIndex = 3;
            this.rollTbox.TextChanged += new System.EventHandler(this.rollTbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gradeTbox
            // 
            this.gradeTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTbox.Location = new System.Drawing.Point(144, 165);
            this.gradeTbox.Name = "gradeTbox";
            this.gradeTbox.Size = new System.Drawing.Size(203, 29);
            this.gradeTbox.TabIndex = 5;
            this.gradeTbox.TextChanged += new System.EventHandler(this.gradeTbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contato";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(260, 260);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(110, 49);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Atualizar";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(376, 260);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(100, 49);
            this.delBtn.TabIndex = 11;
            this.delBtn.Text = "Excluir";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "UF";
            // 
            // UFtext1
            // 
            this.UFtext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UFtext1.Location = new System.Drawing.Point(695, 165);
            this.UFtext1.Name = "UFtext1";
            this.UFtext1.Size = new System.Drawing.Size(69, 29);
            this.UFtext1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cidade";
            // 
            // cidTbox1
            // 
            this.cidTbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidTbox1.Location = new System.Drawing.Point(481, 165);
            this.cidTbox1.Name = "cidTbox1";
            this.cidTbox1.Size = new System.Drawing.Size(150, 29);
            this.cidTbox1.TabIndex = 14;
            this.cidTbox1.TextChanged += new System.EventHandler(this.cidTbox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::firebaseapp.Properties.Resources.CLASSICOCOIN;
            this.pictureBox1.Location = new System.Drawing.Point(545, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Deposito";
            // 
            // depText1
            // 
            this.depText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.depText1.Location = new System.Drawing.Point(375, 63);
            this.depText1.Name = "depText1";
            this.depText1.Size = new System.Drawing.Size(113, 29);
            this.depText1.TabIndex = 20;
            this.depText1.TextChanged += new System.EventHandler(this.depText1_TextChanged);
            this.depText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depText1_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(509, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 52;
            this.button2.Text = "Depositar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelresult2
            // 
            this.labelresult2.AutoSize = true;
            this.labelresult2.Enabled = false;
            this.labelresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult2.ForeColor = System.Drawing.Color.White;
            this.labelresult2.Location = new System.Drawing.Point(357, 22);
            this.labelresult2.Name = "labelresult2";
            this.labelresult2.Size = new System.Drawing.Size(122, 25);
            this.labelresult2.TabIndex = 60;
            this.labelresult2.Text = "Saldo Atual";
            this.labelresult2.Click += new System.EventHandler(this.labelresult2_Click);
            // 
            // sldtext2
            // 
            this.sldtext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sldtext2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sldtext2.Location = new System.Drawing.Point(144, 67);
            this.sldtext2.Name = "sldtext2";
            this.sldtext2.Size = new System.Drawing.Size(113, 29);
            this.sldtext2.TabIndex = 61;
            this.sldtext2.TextChanged += new System.EventHandler(this.sldtext2_TextChanged);
            this.sldtext2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sldtext2_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 210);
            this.maskedTextBox1.Mask = "(999) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(203, 29);
            this.maskedTextBox1.TabIndex = 62;
            // 
            // retrBtn
            // 
            this.retrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrBtn.Location = new System.Drawing.Point(144, 260);
            this.retrBtn.Name = "retrBtn";
            this.retrBtn.Size = new System.Drawing.Size(110, 49);
            this.retrBtn.TabIndex = 63;
            this.retrBtn.Text = "Consulta";
            this.retrBtn.UseVisualStyleBackColor = true;
            this.retrBtn.Click += new System.EventHandler(this.retrBtn_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 64;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.retrBtn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.sldtext2);
            this.Controls.Add(this.labelresult2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.depText1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cidTbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UFtext1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradeTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rollTbox);
            this.Controls.Add(this.storeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button storeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rollTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gradeTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UFtext1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cidTbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depText1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelresult2;
        private System.Windows.Forms.TextBox sldtext2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button retrBtn;
        private System.Windows.Forms.Button button1;
    }
}

