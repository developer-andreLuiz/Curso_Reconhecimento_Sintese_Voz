using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Microsoft.Speech.Recognition;

namespace Curso_Reconhecimento_Sintese_Voz
{
    public partial class FrmMain : Form
    {
        #region Variaveis
        
        #region Banco de Dados
        List<Tb_reconhecimento_Model> listaInteracoes = new List<Tb_reconhecimento_Model>();
        bool novo = false;
        #endregion
        
        #region Sintese de Voz
        private static SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        int volume = 100;
        int velocidade = 1;
        #endregion

        #region Reconhecimento_Voz
        private static SpeechRecognitionEngine reconhecimento;
        static bool reconhecimentoBool = false;
        static string fala = string.Empty;
        #endregion

        #endregion

        #region Funcoes

        #region Banco de Dados
        void InterfaceAbrir()
        {
            btnNovo.Enabled = true;
            btnAtualizar.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDeletar.Enabled = true;
            txtBancodeDadosPalavraChave.Enabled = false;
            txtBancodeDadosResposta.Enabled = false;
        }
        void InterfaceNovo()
        {
            btnNovo.Enabled = false;
            btnAtualizar.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDeletar.Enabled = false;
            txtBancodeDadosPalavraChave.Enabled = true;
            txtBancodeDadosResposta.Enabled = true;
        }
        void InterfaceAlterar()
        {
            btnNovo.Enabled = false;
            btnAtualizar.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnDeletar.Enabled = true;
            txtBancodeDadosPalavraChave.Enabled = true;
            txtBancodeDadosResposta.Enabled = true;
        }
        void InterfaceGravar()
        {
            btnNovo.Enabled = true;
            btnAtualizar.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDeletar.Enabled = true;
            txtBancodeDadosPalavraChave.Enabled = false;
            txtBancodeDadosResposta.Enabled = false;
        }
        void InterfaceCancelar()
        {
            btnNovo.Enabled = true;
            btnAtualizar.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDeletar.Enabled = true;
            txtBancodeDadosPalavraChave.Enabled = false;
            txtBancodeDadosResposta.Enabled = false;
        }
        void InterfaceDeletar()
        {
            btnNovo.Enabled = true;
            btnAtualizar.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnDeletar.Enabled = true;
            txtBancodeDadosPalavraChave.Enabled = false;
            txtBancodeDadosResposta.Enabled = false;
        }
        void InterfaceLimparBanco()
        {
            lblId.Text = "0";
            txtBancodeDadosPalavraChave.Text = string.Empty;
            txtBancodeDadosResposta.Text = string.Empty;
        }
        void ExibirObj(Tb_reconhecimento_Model tb_Reconhecimento_Model)
        {
            lblId.Text = tb_Reconhecimento_Model.id.ToString();
            txtBancodeDadosPalavraChave.Text = tb_Reconhecimento_Model.palavra;
            txtBancodeDadosResposta.Text = tb_Reconhecimento_Model.resposta;
        }
        void CarregarObj(Tb_reconhecimento_Model tb_Reconhecimento_Model)
        {
            tb_Reconhecimento_Model.id = Convert.ToInt32(lblId.Text);
            tb_Reconhecimento_Model.palavra = txtBancodeDadosPalavraChave.Text;
            tb_Reconhecimento_Model.resposta = txtBancodeDadosResposta.Text;
        }
        void CarregarComboBox()
        {
            cbPalavraChave.DataSource = null;
           
            cbPalavraChave.DisplayMember = "palavra";
            cbPalavraChave.ValueMember = "id";
            cbPalavraChave.DataSource = listaInteracoes;
        }
        #endregion
        
        #region Sintese de Voz
        void Falar(string fala)
        {
            synthesizer.SpeakAsyncCancelAll();
            synthesizer.SpeakAsync(fala);
            synthesizer.Volume = volume;
            synthesizer.Rate = velocidade;
        }
        void PauseFala()
        {
            synthesizer.Pause();
        }
        void ResumeFala()
        {
            synthesizer.Resume();
        }
        void StopFala()
        {
            synthesizer.SpeakAsyncCancelAll();
        }
        #endregion

        #region Reconhecimento_Voz
        void carregarVocabulario(List<string>lst)
        {
            reconhecimento = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-BR"));
            reconhecimento.SetInputToDefaultAudioDevice();
            Choices palavras = new Choices();
            foreach (string item in lst)
            {
                palavras.Add(item);
            }
            

            GrammarBuilder grammarBuilderPalavras = new GrammarBuilder();

            grammarBuilderPalavras.Append(palavras);
            
            Grammar grammar = new Grammar(grammarBuilderPalavras);
            reconhecimento.LoadGrammar(grammar);

            reconhecimento.RecognizeAsync(RecognizeMode.Multiple);

            reconhecimento.SpeechRecognized += recPalavras;
        }
        void InicializarReconhecimento()
        {
            listaInteracoes = Banco.Tb_reconhecimento.RetornoCompleto();
            List<string> lst = new List<string>();
            foreach (var item in listaInteracoes)
            {
                lst.Add(item.palavra);
            }
            carregarVocabulario(lst);
        }
        #endregion

        #endregion

        #region Eventos

        #region Formulario
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            listaInteracoes = Banco.Tb_reconhecimento.RetornoCompleto();
            CarregarComboBox();
            InterfaceAbrir();
            InicializarReconhecimento();
        }
        #endregion
        
        #region Banco de Dados
        private void btnNovo_Click(object sender, EventArgs e)
        {
            InterfaceNovo();
            InterfaceLimparBanco();
            novo = true;
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            InterfaceAlterar();
            novo = false;

        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tb_reconhecimento_Model tb_Reconhecimento_Model = new Tb_reconhecimento_Model();
            CarregarObj(tb_Reconhecimento_Model);
            if (novo)
            {
                Banco.Tb_reconhecimento.Inserir(tb_Reconhecimento_Model);
            }
            else
            {
                Banco.Tb_reconhecimento.Atualizar(tb_Reconhecimento_Model);
            }
            InterfaceGravar();
            listaInteracoes = Banco.Tb_reconhecimento.RetornoCompleto();
            CarregarComboBox();
            InicializarReconhecimento();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InterfaceLimparBanco();
            InterfaceCancelar();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Tb_reconhecimento_Model tb_Reconhecimento_Model = new Tb_reconhecimento_Model();
            CarregarObj(tb_Reconhecimento_Model);
            Banco.Tb_reconhecimento.Deletar(tb_Reconhecimento_Model);
            InterfaceLimparBanco();
            InterfaceDeletar();
            listaInteracoes = Banco.Tb_reconhecimento.RetornoCompleto();
            CarregarComboBox();
            InicializarReconhecimento();
        }
        private void cbPalavraChave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPalavraChave.Text) == false)
            {
                int id = Convert.ToInt32(cbPalavraChave.SelectedValue.ToString());
                int index = listaInteracoes.FindIndex(x => x.id == id);
                Tb_reconhecimento_Model tb_Reconhecimento_Model = listaInteracoes[index];
                ExibirObj(tb_Reconhecimento_Model);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPalavraChave.Text) == false)
            {
                int id = Convert.ToInt32(cbPalavraChave.SelectedValue.ToString());
                int index = listaInteracoes.FindIndex(x => x.id == id);
                Tb_reconhecimento_Model tb_Reconhecimento_Model = listaInteracoes[index];
                ExibirObj(tb_Reconhecimento_Model);
            }
        }
        #endregion

        #region Sintese de Voz
        private void tckbVolume_Scroll(object sender, EventArgs e)
        {
            volume = tckbVolume.Value;
        }
        private void tckbVelocidade_Scroll(object sender, EventArgs e)
        {
            velocidade = tckbVelocidade.Value;
        }
        private void lblVelocidadeReset_DoubleClick(object sender, EventArgs e)
        {
            tckbVelocidade.Value = 1;
        }
        private void btnLeitura_Click(object sender, EventArgs e)
        {
            if (synthesizer.State!= SynthesizerState.Paused)
            {
                Falar(txtLeitura.Text);
            }
            else
            {
                ResumeFala();
            }
            
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseFala();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopFala();
        }

        #endregion

        #region Reconhecimento_Voz
        public static void recPalavras(object s, SpeechRecognizedEventArgs e)
        {
            if (reconhecimentoBool && e.Result.Confidence>0.6f)
            {
                fala = e.Result.Text;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fala) == false)
            {
                txtReconhecimento.Text = fala;

                foreach (var item in listaInteracoes)
                {
                    if (item.palavra.Trim().ToUpper().Equals(fala.Trim().ToUpper()))
                    {
                        txtResposta.Text = item.resposta;
                        reconhecimentoBool = false;
                        Falar(item.resposta);
                        reconhecimentoBool = true;
                        break;
                    }
                }
                fala = string.Empty;
            }
        }
       
        private void chbReconhecimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chbReconhecimento.Checked)
            {
                reconhecimentoBool = true;
            }
            else
            {
                reconhecimentoBool = false;
            }
        }
       
        #endregion

        #endregion

       
    }
}
