namespace JokenPo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picVoce = new System.Windows.Forms.PictureBox();
            this.picPC = new System.Windows.Forms.PictureBox();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.lblVoce = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picVoce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(373, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 56);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "JokenPo!";
            // 
            // picVoce
            // 
            this.picVoce.BackColor = System.Drawing.Color.Transparent;
            this.picVoce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picVoce.Location = new System.Drawing.Point(22, 82);
            this.picVoce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picVoce.Name = "picVoce";
            this.picVoce.Size = new System.Drawing.Size(233, 157);
            this.picVoce.TabIndex = 1;
            this.picVoce.TabStop = false;
            // 
            // picPC
            // 
            this.picPC.BackColor = System.Drawing.Color.Transparent;
            this.picPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPC.Location = new System.Drawing.Point(338, 82);
            this.picPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPC.Name = "picPC";
            this.picPC.Size = new System.Drawing.Size(226, 157);
            this.picPC.TabIndex = 2;
            this.picPC.TabStop = false;
            // 
            // picResultado
            // 
            this.picResultado.BackColor = System.Drawing.Color.Transparent;
            this.picResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResultado.Location = new System.Drawing.Point(659, 82);
            this.picResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(210, 157);
            this.picResultado.TabIndex = 3;
            this.picResultado.TabStop = false;
            // 
            // lblVoce
            // 
            this.lblVoce.BackColor = System.Drawing.Color.Transparent;
            this.lblVoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoce.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVoce.Location = new System.Drawing.Point(93, 145);
            this.lblVoce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoce.Name = "lblVoce";
            this.lblVoce.Size = new System.Drawing.Size(79, 33);
            this.lblVoce.TabIndex = 4;
            this.lblVoce.Text = "Você";
            // 
            // lblPC
            // 
            this.lblPC.BackColor = System.Drawing.Color.Transparent;
            this.lblPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPC.Location = new System.Drawing.Point(424, 145);
            this.lblPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(62, 33);
            this.lblPC.TabIndex = 5;
            this.lblPC.Text = "PC";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(738, 145);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(64, 33);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "?";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(280, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "vs.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(594, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedra.BackgroundImage")));
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(22, 256);
            this.btnPedra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(233, 157);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapel.BackgroundImage")));
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(338, 256);
            this.btnPapel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(226, 157);
            this.btnPapel.TabIndex = 10;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTesoura.BackgroundImage")));
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(659, 256);
            this.btnTesoura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(210, 157);
            this.btnTesoura.TabIndex = 11;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblVoce);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.picPC);
            this.Controls.Add(this.picVoce);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JokenPo";
            ((System.ComponentModel.ISupportInitialize)(this.picVoce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picVoce;
        private System.Windows.Forms.PictureBox picPC;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.Label lblVoce;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
    }
}

