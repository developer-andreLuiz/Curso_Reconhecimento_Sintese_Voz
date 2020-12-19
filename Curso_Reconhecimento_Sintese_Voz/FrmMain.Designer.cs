
namespace Curso_Reconhecimento_Sintese_Voz
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVelocidadeReset = new System.Windows.Forms.Label();
            this.tckbVelocidade = new System.Windows.Forms.TrackBar();
            this.tckbVolume = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLeitura = new System.Windows.Forms.Button();
            this.txtLeitura = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbReconhecimento = new System.Windows.Forms.CheckBox();
            this.txtReconhecimento = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPalavraChave = new System.Windows.Forms.ComboBox();
            this.txtBancodeDadosResposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBancodeDadosPalavraChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckbVelocidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbVolume)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVelocidadeReset);
            this.groupBox1.Controls.Add(this.tckbVelocidade);
            this.groupBox1.Controls.Add(this.tckbVolume);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnLeitura);
            this.groupBox1.Controls.Add(this.txtLeitura);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sintese de Voz";
            // 
            // lblVelocidadeReset
            // 
            this.lblVelocidadeReset.AutoSize = true;
            this.lblVelocidadeReset.Location = new System.Drawing.Point(20, 349);
            this.lblVelocidadeReset.Name = "lblVelocidadeReset";
            this.lblVelocidadeReset.Size = new System.Drawing.Size(76, 19);
            this.lblVelocidadeReset.TabIndex = 7;
            this.lblVelocidadeReset.Text = "Velocidade";
            this.lblVelocidadeReset.DoubleClick += new System.EventHandler(this.lblVelocidadeReset_DoubleClick);
            // 
            // tckbVelocidade
            // 
            this.tckbVelocidade.LargeChange = 1;
            this.tckbVelocidade.Location = new System.Drawing.Point(24, 323);
            this.tckbVelocidade.Minimum = -10;
            this.tckbVelocidade.Name = "tckbVelocidade";
            this.tckbVelocidade.Size = new System.Drawing.Size(294, 45);
            this.tckbVelocidade.TabIndex = 6;
            this.tckbVelocidade.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckbVelocidade.Value = 1;
            this.tckbVelocidade.Scroll += new System.EventHandler(this.tckbVelocidade_Scroll);
            // 
            // tckbVolume
            // 
            this.tckbVolume.Location = new System.Drawing.Point(337, 25);
            this.tckbVolume.Maximum = 100;
            this.tckbVolume.Name = "tckbVolume";
            this.tckbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tckbVolume.Size = new System.Drawing.Size(45, 305);
            this.tckbVolume.TabIndex = 5;
            this.tckbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tckbVolume.Value = 100;
            this.tckbVolume.Scroll += new System.EventHandler(this.tckbVolume_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Volume";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(220, 259);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(91, 50);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(123, 259);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 50);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLeitura
            // 
            this.btnLeitura.Location = new System.Drawing.Point(24, 259);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(88, 50);
            this.btnLeitura.TabIndex = 1;
            this.btnLeitura.Text = "Leitura";
            this.btnLeitura.UseVisualStyleBackColor = true;
            this.btnLeitura.Click += new System.EventHandler(this.btnLeitura_Click);
            // 
            // txtLeitura
            // 
            this.txtLeitura.Location = new System.Drawing.Point(24, 25);
            this.txtLeitura.Multiline = true;
            this.txtLeitura.Name = "txtLeitura";
            this.txtLeitura.Size = new System.Drawing.Size(287, 231);
            this.txtLeitura.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtResposta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chbReconhecimento);
            this.groupBox2.Controls.Add(this.txtReconhecimento);
            this.groupBox2.Location = new System.Drawing.Point(411, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 374);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recohecimento de Voz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oque Respondeu :";
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Location = new System.Drawing.Point(20, 255);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(350, 87);
            this.txtResposta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Oque Ouviu :";
            // 
            // chbReconhecimento
            // 
            this.chbReconhecimento.AutoSize = true;
            this.chbReconhecimento.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbReconhecimento.Location = new System.Drawing.Point(19, 42);
            this.chbReconhecimento.Name = "chbReconhecimento";
            this.chbReconhecimento.Size = new System.Drawing.Size(168, 27);
            this.chbReconhecimento.TabIndex = 2;
            this.chbReconhecimento.Text = "Reconhecimento";
            this.chbReconhecimento.UseVisualStyleBackColor = true;
            this.chbReconhecimento.CheckedChanged += new System.EventHandler(this.chbReconhecimento_CheckedChanged);
            // 
            // txtReconhecimento
            // 
            this.txtReconhecimento.Enabled = false;
            this.txtReconhecimento.Location = new System.Drawing.Point(20, 113);
            this.txtReconhecimento.Multiline = true;
            this.txtReconhecimento.Name = "txtReconhecimento";
            this.txtReconhecimento.Size = new System.Drawing.Size(350, 87);
            this.txtReconhecimento.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnDeletar);
            this.groupBox3.Controls.Add(this.btnGravar);
            this.groupBox3.Controls.Add(this.btnAtualizar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbPalavraChave);
            this.groupBox3.Controls.Add(this.txtBancodeDadosResposta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBancodeDadosPalavraChave);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 285);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Banco de Dados";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(183, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(619, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(700, 220);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(76, 46);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(539, 220);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(76, 46);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(461, 220);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(76, 46);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(382, 220);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 46);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(419, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(350, 67);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Palavra Chave";
            // 
            // cbPalavraChave
            // 
            this.cbPalavraChave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPalavraChave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPalavraChave.FormattingEnabled = true;
            this.cbPalavraChave.Location = new System.Drawing.Point(419, 50);
            this.cbPalavraChave.Name = "cbPalavraChave";
            this.cbPalavraChave.Size = new System.Drawing.Size(350, 31);
            this.cbPalavraChave.TabIndex = 9;
            this.cbPalavraChave.SelectedIndexChanged += new System.EventHandler(this.cbPalavraChave_SelectedIndexChanged);
            // 
            // txtBancodeDadosResposta
            // 
            this.txtBancodeDadosResposta.Location = new System.Drawing.Point(19, 113);
            this.txtBancodeDadosResposta.Multiline = true;
            this.txtBancodeDadosResposta.Name = "txtBancodeDadosResposta";
            this.txtBancodeDadosResposta.Size = new System.Drawing.Size(350, 153);
            this.txtBancodeDadosResposta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resposta";
            // 
            // txtBancodeDadosPalavraChave
            // 
            this.txtBancodeDadosPalavraChave.Location = new System.Drawing.Point(19, 50);
            this.txtBancodeDadosPalavraChave.Name = "txtBancodeDadosPalavraChave";
            this.txtBancodeDadosPalavraChave.Size = new System.Drawing.Size(350, 26);
            this.txtBancodeDadosPalavraChave.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palavra Chave";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Reconhecimento_Sintese_de_Voz";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckbVelocidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckbVolume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tckbVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.TextBox txtLeitura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbReconhecimento;
        private System.Windows.Forms.TextBox txtReconhecimento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPalavraChave;
        private System.Windows.Forms.TextBox txtBancodeDadosResposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBancodeDadosPalavraChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVelocidadeReset;
        private System.Windows.Forms.TrackBar tckbVelocidade;
        private System.Windows.Forms.Timer Timer;
    }
}

