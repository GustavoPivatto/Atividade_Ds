namespace PROJETO_DS
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKillMe2 = new System.Windows.Forms.Label();
            this.txtbKillMe2 = new System.Windows.Forms.TextBox();
            this.buttonYES = new System.Windows.Forms.Button();
            this.lblKillMe = new System.Windows.Forms.Label();
            this.hylBoobs = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtbKillMe = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lblKillMe2
            // 
            this.lblKillMe2.AutoSize = true;
            this.lblKillMe2.BackColor = System.Drawing.SystemColors.Control;
            this.lblKillMe2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKillMe2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKillMe2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKillMe2.Location = new System.Drawing.Point(41, 202);
            this.lblKillMe2.Name = "lblKillMe2";
            this.lblKillMe2.Size = new System.Drawing.Size(46, 18);
            this.lblKillMe2.TabIndex = 0;
            this.lblKillMe2.Text = "Senha";
            this.lblKillMe2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbKillMe2
            // 
            this.txtbKillMe2.BackColor = System.Drawing.SystemColors.Control;
            this.txtbKillMe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbKillMe2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbKillMe2.Location = new System.Drawing.Point(41, 237);
            this.txtbKillMe2.Name = "txtbKillMe2";
            this.txtbKillMe2.PasswordChar = '*';
            this.txtbKillMe2.Size = new System.Drawing.Size(300, 22);
            this.txtbKillMe2.TabIndex = 1;
            // 
            // buttonYES
            // 
            this.buttonYES.Location = new System.Drawing.Point(132, 320);
            this.buttonYES.Name = "buttonYES";
            this.buttonYES.Size = new System.Drawing.Size(75, 23);
            this.buttonYES.TabIndex = 3;
            this.buttonYES.Text = "Login";
            this.buttonYES.UseVisualStyleBackColor = true;
            this.buttonYES.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKillMe
            // 
            this.lblKillMe.AutoSize = true;
            this.lblKillMe.BackColor = System.Drawing.SystemColors.Control;
            this.lblKillMe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKillMe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKillMe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKillMe.Location = new System.Drawing.Point(41, 133);
            this.lblKillMe.Name = "lblKillMe";
            this.lblKillMe.Size = new System.Drawing.Size(53, 18);
            this.lblKillMe.TabIndex = 4;
            this.lblKillMe.Text = "Usuário";
            // 
            // hylBoobs
            // 
            this.hylBoobs.AutoSize = true;
            this.hylBoobs.Location = new System.Drawing.Point(125, 274);
            this.hylBoobs.Name = "hylBoobs";
            this.hylBoobs.Size = new System.Drawing.Size(108, 16);
            this.hylBoobs.TabIndex = 5;
            this.hylBoobs.TabStop = true;
            this.hylBoobs.Text = "Esqueci a senha";
            this.hylBoobs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(125, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(522, 74);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "G A M I N G   S I M U L A T O R\r\n\r\n";
            this.lblTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbKillMe
            // 
            this.txtbKillMe.BackColor = System.Drawing.SystemColors.Control;
            this.txtbKillMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbKillMe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbKillMe.Location = new System.Drawing.Point(41, 164);
            this.txtbKillMe.Name = "txtbKillMe";
            this.txtbKillMe.Size = new System.Drawing.Size(300, 22);
            this.txtbKillMe.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 450);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtbKillMe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.hylBoobs);
            this.Controls.Add(this.lblKillMe);
            this.Controls.Add(this.buttonYES);
            this.Controls.Add(this.txtbKillMe2);
            this.Controls.Add(this.lblKillMe2);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKillMe2;
        private System.Windows.Forms.TextBox txtbKillMe2;
        private System.Windows.Forms.Button buttonYES;
        private System.Windows.Forms.Label lblKillMe;
        private System.Windows.Forms.LinkLabel hylBoobs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbKillMe;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}

