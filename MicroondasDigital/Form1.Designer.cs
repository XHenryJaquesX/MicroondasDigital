namespace MicroondasDigital
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
            this.components = new System.ComponentModel.Container();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.btnIniciarPausar = new System.Windows.Forms.Button();
            this.btnCancelarLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btnLeite = new System.Windows.Forms.Button();
            this.btnCarne = new System.Windows.Forms.Button();
            this.btnFrango = new System.Windows.Forms.Button();
            this.btnFeijao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(694, 36);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(267, 20);
            this.txtTempo.TabIndex = 0;
            this.txtTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(694, 62);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(266, 20);
            this.txtPotencia.TabIndex = 1;
            // 
            // btnIniciarPausar
            // 
            this.btnIniciarPausar.Location = new System.Drawing.Point(673, 423);
            this.btnIniciarPausar.Name = "btnIniciarPausar";
            this.btnIniciarPausar.Size = new System.Drawing.Size(115, 53);
            this.btnIniciarPausar.TabIndex = 2;
            this.btnIniciarPausar.Text = "Iniciar / +30sec";
            this.btnIniciarPausar.UseVisualStyleBackColor = true;
            this.btnIniciarPausar.Click += new System.EventHandler(this.btnIniciarPausar_Click);
            // 
            // btnCancelarLimpar
            // 
            this.btnCancelarLimpar.Location = new System.Drawing.Point(830, 423);
            this.btnCancelarLimpar.Name = "btnCancelarLimpar";
            this.btnCancelarLimpar.Size = new System.Drawing.Size(115, 53);
            this.btnCancelarLimpar.TabIndex = 3;
            this.btnCancelarLimpar.Text = "Pausar / Cancelar";
            this.btnCancelarLimpar.UseVisualStyleBackColor = true;
            this.btnCancelarLimpar.Click += new System.EventHandler(this.btnCancelarLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(694, 142);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(75, 48);
            this.btnNum1.TabIndex = 5;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(790, 142);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(75, 48);
            this.btnNum2.TabIndex = 6;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(886, 142);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 48);
            this.btnNum3.TabIndex = 7;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(694, 216);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 48);
            this.btnNum4.TabIndex = 8;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(790, 216);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(75, 48);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(886, 216);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(75, 48);
            this.btnNum6.TabIndex = 10;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(694, 288);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 49);
            this.btnNum7.TabIndex = 11;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(790, 288);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 48);
            this.btnNum8.TabIndex = 12;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(887, 288);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 49);
            this.btnNum9.TabIndex = 13;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(790, 354);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(75, 52);
            this.btnNum0.TabIndex = 14;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Potência:";
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(694, 354);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 52);
            this.btnPotencia.TabIndex = 17;
            this.btnPotencia.Text = "Potência";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnPipoca
            // 
            this.btnPipoca.Location = new System.Drawing.Point(885, 354);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(75, 52);
            this.btnPipoca.TabIndex = 18;
            this.btnPipoca.Text = "Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = true;
            this.btnPipoca.Click += new System.EventHandler(this.btnPipoca_Click);
            // 
            // btnLeite
            // 
            this.btnLeite.Location = new System.Drawing.Point(613, 216);
            this.btnLeite.Name = "btnLeite";
            this.btnLeite.Size = new System.Drawing.Size(75, 48);
            this.btnLeite.TabIndex = 19;
            this.btnLeite.Text = "Leite";
            this.btnLeite.UseVisualStyleBackColor = true;
            this.btnLeite.Click += new System.EventHandler(this.btnLeite_Click);
            // 
            // btnCarne
            // 
            this.btnCarne.Location = new System.Drawing.Point(613, 288);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(75, 48);
            this.btnCarne.TabIndex = 20;
            this.btnCarne.Text = "Carnes de boi";
            this.btnCarne.UseVisualStyleBackColor = true;
            this.btnCarne.Click += new System.EventHandler(this.btnCarne_Click);
            // 
            // btnFrango
            // 
            this.btnFrango.Location = new System.Drawing.Point(613, 354);
            this.btnFrango.Name = "btnFrango";
            this.btnFrango.Size = new System.Drawing.Size(75, 52);
            this.btnFrango.TabIndex = 21;
            this.btnFrango.Text = "Frango";
            this.btnFrango.UseVisualStyleBackColor = true;
            this.btnFrango.Click += new System.EventHandler(this.btnFrango_Click);
            // 
            // btnFeijao
            // 
            this.btnFeijao.Location = new System.Drawing.Point(613, 142);
            this.btnFeijao.Name = "btnFeijao";
            this.btnFeijao.Size = new System.Drawing.Size(75, 48);
            this.btnFeijao.TabIndex = 22;
            this.btnFeijao.Text = "Feijão";
            this.btnFeijao.UseVisualStyleBackColor = true;
            this.btnFeijao.Click += new System.EventHandler(this.btnFeijao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 542);
            this.Controls.Add(this.btnFeijao);
            this.Controls.Add(this.btnFrango);
            this.Controls.Add(this.btnCarne);
            this.Controls.Add(this.btnLeite);
            this.Controls.Add(this.btnPipoca);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarLimpar);
            this.Controls.Add(this.btnIniciarPausar);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtTempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button btnIniciarPausar;
        private System.Windows.Forms.Button btnCancelarLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btnLeite;
        private System.Windows.Forms.Button btnCarne;
        private System.Windows.Forms.Button btnFrango;
        private System.Windows.Forms.Button btnFeijao;
    }
}

