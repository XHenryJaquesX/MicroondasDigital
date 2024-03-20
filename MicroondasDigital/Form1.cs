using System;
using System.Windows.Forms;

namespace MicroondasDigital
{
    public partial class Form1 : Form
    {
        private Timer timerAquecimento = new Timer();
        private int tempoRestante;
        public Form1()
        {
            InitializeComponent();
            timerAquecimento.Interval = 1000;
            timerAquecimento.Tick += TimerAquecimento_Tick;
        }
        private bool aquecendo = false;
        private bool isPaused = false;
        private void TimerAquecimento_Tick(object sender, EventArgs e)
        {
            if (tempoRestante > 0)
            {
                tempoRestante--;
                txtTempo.Text = $"{tempoRestante / 60:D2}:{tempoRestante % 60:D2}";
            }
            else
            {
                timerAquecimento.Stop();
                MessageBox.Show("Aquecimento concluído!");
                aquecendo = false;
            }
        }

        private void IniciarAquecimento(int tempo, int potencia)
        {
            MessageBox.Show($"Aquecendo por {tempo / 60} minutos e {tempo % 60} segundos na potência {potencia}.");
        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("9");
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            AdicionarNumeroAoTempo("0");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtPotencia.Text, out int potenciaAtual) && potenciaAtual > 1)
            {
                txtPotencia.Text = (potenciaAtual - 1).ToString();
            }
            else
            {
                txtPotencia.Text = "10";
            }
        }

        private void btnIniciarPausar_Click(object sender, EventArgs e)
        {
            int potencia = 10;
            if (!string.IsNullOrWhiteSpace(txtPotencia.Text) && int.TryParse(txtPotencia.Text, out int potenciaLida))
            {
                potencia = potenciaLida;
            }

            if (!aquecendo)
            {
                if (string.IsNullOrWhiteSpace(txtTempo.Text))
                {
                    tempoRestante = 30; 
                }
                else
                {
                    string textoTempo = txtTempo.Text.Replace(":", "");
                    if (textoTempo.Length <= 4 && int.TryParse(textoTempo, out int totalSegundos))
                    {
                        ConvertAndSetTime(textoTempo);
                    }
                    else
                    {
                        MessageBox.Show("Insira um tempo válido.");
                        return;
                    }
                }

                IniciarAquecimento(tempoRestante, potencia);
                timerAquecimento.Start();
                aquecendo = true;
            }
            else
            {
                tempoRestante += 30;
                MessageBox.Show("30 segundos adicionados ao tempo de aquecimento.");
            }
        }

        private void ConvertAndSetTime(string textoTempo)
        {
            if (textoTempo.Length <= 2)
            {
                tempoRestante = int.Parse(textoTempo);
            }
            else if (textoTempo.Length == 3)
            {
                tempoRestante = int.Parse(textoTempo[0].ToString()) * 60 + int.Parse(textoTempo.Substring(1));
            }
            else if (textoTempo.Length == 4)
            {
                tempoRestante = int.Parse(textoTempo.Substring(0, 2)) * 60 + int.Parse(textoTempo.Substring(2));
            }
        }



        private void btnCancelarLimpar_Click(object sender, EventArgs e)
        {
            if (aquecendo)
            {
                timerAquecimento.Stop();
                MessageBox.Show("Aquecimento pausado.");
                aquecendo = false;
                isPaused = true;
            }
            else if (isPaused)
            {
                txtTempo.Clear();
                txtPotencia.Clear();
                tempoRestante = 0;
                isPaused = false;
            }
            else 
            {
                txtTempo.Clear();
                txtPotencia.Clear();
            }
        }


        private void AdicionarNumeroAoTempo(string numero)
        {
            string textoAtual = txtTempo.Text.Replace(":", "");

            if (textoAtual.Length < 4)
            {
                textoAtual += numero;
            }

            if (textoAtual.Length > 2)
            {
                txtTempo.Text = textoAtual.Substring(0, textoAtual.Length - 2) + ":" + textoAtual.Substring(textoAtual.Length - 2);
            }
            else
            {
                txtTempo.Text = textoAtual;
            }
        }

        private void btnFeijao_Click(object sender, EventArgs e)
        {
            if (!aquecendo)
            {
                SetAndStartAquecimento(480, 9);
                MessageBox.Show("Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.");
            }
            else
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
            }
        }

        private void btnLeite_Click(object sender, EventArgs e)
        {
            if (!aquecendo)
            {
                SetAndStartAquecimento(300, 5);
                MessageBox.Show("Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.");
            }
            else
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
            }
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            if (!aquecendo)
            {
                SetAndStartAquecimento(840, 4);
                MessageBox.Show("Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");
            }
            else
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
            }
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            if (!aquecendo)
            {
                SetAndStartAquecimento(480, 7); 
                MessageBox.Show("Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");
            }
            else
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
            }
        }

        private void btnPipoca_Click(object sender, EventArgs e)
        {
            if (!aquecendo)
            {
                SetAndStartAquecimento(180, 7); 
                MessageBox.Show("Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.");
            }
            else
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
            }
        }

        private void SetAndStartAquecimento(int tempo, int potencia)
        {
            if (aquecendo)
            {
                MessageBox.Show("O aquecimento já está em andamento. Por favor, aguarde ou cancele antes de iniciar um novo programa.");
                return;
            }

            tempoRestante = tempo;
            txtTempo.Text = $"{tempo / 60:D2}:{tempo % 60:D2}";
            txtPotencia.Text = potencia.ToString();
            timerAquecimento.Start();
            aquecendo = true;
            isPaused = false;

            MessageBox.Show($"Aquecimento iniciado: {tempo / 60} minuto(s) e {tempo % 60} segundo(s) na potência {potencia}.");
        }

    }
}