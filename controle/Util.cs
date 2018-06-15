using System;
using System.Windows.Forms;

namespace ControleProg
{
    public static class Util
    {
        private const String TituloAplicacao = "Controle Estabelecimento";

        public static void MenssagemInformacao(String menssagem)
        {
            MessageBox.Show(menssagem, TituloAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MenssagemPergunta(String menssagem)
        {
            return MessageBox.Show(menssagem, TituloAplicacao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static TimeSpan CalculaHora(DateTime? horafim, DateTime? horainicio)
        {
            string horas = (horafim - horainicio).Value.Hours.ToString("00");
            string minutos = (horafim - horainicio).Value.Minutes.ToString("00");
            string segundos = (horafim - horainicio).Value.Seconds.ToString("00");
            return new TimeSpan(Convert.ToInt32(horas), Convert.ToInt32(minutos), Convert.ToInt32(segundos));
        }


        public static void MenssagemAtencao(String menssagem)
        {
            MessageBox.Show(menssagem, TituloAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MenssagemErro(String menssagem)
        {
            MessageBox.Show(menssagem, TituloAplicacao, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
