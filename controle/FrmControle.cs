using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProgControle.Dados;
using Application = System.Windows.Forms.Application;

namespace ControleProg
{
    public partial class FrmControle : Form
    {
        private readonly DBControle _banco = new DBControle();

        private bool _fechar;

        public FrmControle()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaDataHoje();
            NIGerenciador.Visible = true;
            _fechar = false;
            CarregaDados();
        }

        private void CarregaDataHoje()
        {
            var data = DateTime.Now;
            TBDataInicial.Value = Convert.ToDateTime("01/" + data.Month + "/" + data.Year);
            TBDataFinal.Value = TBDataInicial.Value.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void CarregaDados()
        {
            var listaOs = new List<OS>();
            try
            {
                listaOs = (
                      from os in _banco.OS
                      where ((os.DTINICIO >= TBDataInicial.Value)
                         && (os.DTFIM.Equals(null) || (os.DTFIM <= TBDataFinal.Value)))
                         || (os.DTINICIO.Equals(null) && os.DTFIM.Equals(null))
                      select os
                      ).DefaultIfEmpty().OrderByDescending(t => t.DTINICIO).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message, "Controle", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            foreach (var os in listaOs)
            {
                if (os != null)
                {
                    if ((os.DTINICIO.Value != DateTime.MinValue) && (os.DTFIM.Value != DateTime.MinValue))
                    {
                        if (os.TEMPOGASTO != TimeSpan.MinValue)
                        {
                            OS osbanco = (from o in _banco.OS
                                          where o.IDOS == os.IDOS
                                          select o).FirstOrDefault();
                            os.TEMPOGASTO = Util.CalculaHora(os.DTFIM, os.DTINICIO);
                            osbanco.TEMPOGASTO = os.TEMPOGASTO;
                        }
                    }
                }
            }
            _banco.SaveChanges();

            DGControle.DataSource = listaOs;
            CalcularHorasTrabalhadas();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fechar = true;
            Application.Exit();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Controle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fechar) return;
            e.Cancel = true; // impede o formulário de fechar
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void FrmControle_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void btncalculatempo_Click(object sender, EventArgs e)
        {
            if (DGControle.SelectedRows.Count <= 0) return;

            var os = Convert.ToString(DGControle.SelectedRows[0].Cells[1].Value);

            var oss = (from o in _banco.OS
                       where o.OS1.Equals(os)
                             && (o.DTINICIO >= TBDataInicial.Value)
                             && (o.DTFIM <= TBDataFinal.Value)
                       select o).ToList();

            if (oss.Count <= 0) return;

            var horaLancada = CalculaHoraLancada(oss);

            var menssagem = "";
            switch ((int)horaLancada[1])
            {
                case 0:
                    {
                        menssagem = "A OS" + os + " possui " + horaLancada[0] + " Horas.";
                        break;
                    }
                case 1:
                    {
                        menssagem = "A OS" + os + " possui " + horaLancada[0] + " Horas.\nPossui horas em aberto.";
                        break;
                    }
                case 2:
                    {
                        menssagem = "A OS" + os + " possui " + horaLancada[0] + " Horas.\nPossui horas lançadas errado.";
                        break;
                    }
            }

            MessageBox.Show(menssagem, "Controle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static object[] CalculaHoraLancada(IEnumerable<OS> oss)
        {
            var lista = new object[2];
            var temp = TimeSpan.Zero;
            lista[1] = 0;
            foreach (var item in oss)
            {
                if ((item.DTFIM != null) && (item.DTINICIO != null))
                {
                    temp += item.DTFIM.Value - item.DTINICIO.Value;
                }
                else
                {
                    lista[1] = 1;
                }

                if (item.DTFIM < item.DTINICIO)
                {
                    lista[1] = 2;
                }
            }
            lista[0] = string.Format("{0}:{1}", ((int)temp.TotalHours).ToString("00"), temp.Minutes.ToString("00"));
            return lista;
        }

        private void btnavisos_Click(object sender, EventArgs e)
        {

        }

        //geraexcel
        private void button1_Click(object sender, EventArgs e)
        {
            var oss = (from o in _banco.OS
                       where o.DTINICIO >= TBDataInicial.Value
                          && o.DTFIM <= TBDataFinal.Value
                       select new
                       {
                           o.IDOS,
                           o.OS1,
                           o.DESCRICAO,
                           o.DTINICIO,
                           o.DTFIM
                       }).DefaultIfEmpty().OrderBy(c => c.DTINICIO).ToList();

            var listrel = new List<Relexcel>();
            foreach (var os in oss)
            {
                var rel = new Relexcel { Descricao = os.DESCRICAO, Os = os.OS1, Data = os.DTINICIO.Value.Date };
                if ((os.DTINICIO != null) && (os.DTFIM != null))
                    rel.Hora = os.DTFIM.Value.TimeOfDay - os.DTINICIO.Value.TimeOfDay;

                listrel.Add(rel);
            }

            listrel = somahoraslista(listrel);

            if (RBXLS.Checked)
                GeraRelExcel(listrel);
            if (RBSVC.Checked)
                GeraArquivoTexto(listrel);
        }

        private void GeraArquivoTexto(IEnumerable<Relexcel> listrel)
        {
            using (var arq = new StreamWriter(TBArquivo.Text + ".csv"))
            {
                foreach (var rel in listrel)
                {
                    arq.Write(string.Format("{0}/{1}/{2}", rel.Data.Day.ToString("00"), rel.Data.Month.ToString("00"),
                        rel.Data.Year.ToString("00")) + ";");
                    arq.Write(string.Format("{0}:{1}", ((int)rel.Hora.TotalHours).ToString("00"), rel.Hora.Minutes.ToString("00")) + ";");
                    arq.Write(rel.Os + ";");
                    arq.WriteLine(rel.Descricao + @";");
                }
                arq.Dispose();
                arq.Close();
            }
        }

        private void GeraRelExcel(IEnumerable<Relexcel> listrel)
        {
            Microsoft.Office.Interop.Excel.Application App; // Aplicação Excel
            Microsoft.Office.Interop.Excel.Workbook WorkBook; // Pasta
            Microsoft.Office.Interop.Excel.Worksheet WorkSheet; // Planilha

            object misValue = System.Reflection.Missing.Value;
            App = new Microsoft.Office.Interop.Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);

            var i = 1;
            foreach (var rel in listrel)
            {
                WorkSheet.Cells[i, 1] = string.Format("{0}/{1}/{2}", rel.Data.Day.ToString("00"), rel.Data.Month.ToString("00"), rel.Data.Year.ToString("00"));
                WorkSheet.Cells[i, 2] = string.Format("{0}:{1}", ((int)rel.Hora.TotalHours).ToString("00"), rel.Hora.Minutes.ToString("00"));
                WorkSheet.Cells[i, 3] = rel.Os;
                WorkSheet.Cells[i, 4] = rel.Descricao;
                i += 1;
            }

            // salva o arquivo
            WorkBook.SaveAs(TBArquivo.Text + ".xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

        }


        private List<Relexcel> somahoraslista(IEnumerable<Relexcel> lista)
        {
            var data = DateTime.Now.Date.AddDays(1);
            var os = "";
            var lista2 = new List<Relexcel>();
            Relexcel rel = null;
            foreach (var item in lista)
            {
                if ((!data.Equals(item.Data.Date)) || (!os.Equals(item.Os)))
                {
                    if (rel != null)
                        lista2.Add(rel);
                    rel = new Relexcel
                    {
                        Data = item.Data.Date,
                        Hora = item.Hora,
                        Descricao = item.Descricao,
                        Os = item.Os
                    };
                }
                else
                {
                    if (rel != null)
                    {
                        rel.Hora += item.Hora;
                    }
                }
                data = item.Data.Date;
                os = item.Os;
            }
            lista2.Add(rel);

            return lista2;
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnmesanterior_Click(object sender, EventArgs e)
        {
            //data inicial
            TBDataInicial.Value = TBDataInicial.Value.AddMonths(-1);
            TBDataInicial.Value = TBDataInicial.Value.AddDays(-TBDataInicial.Value.Day + 1);

            //data final
            TBDataFinal.Value = TBDataFinal.Value.AddMonths(-1);
            TBDataFinal.Value = TBDataFinal.Value.AddDays(-TBDataFinal.Value.Day + DateTime.DaysInMonth(TBDataFinal.Value.Year, TBDataFinal.Value.Month));
            CarregaDados();
        }

        private void btnproxmes_Click(object sender, EventArgs e)
        {
            //data inicial
            TBDataInicial.Value = TBDataInicial.Value.AddMonths(1);
            TBDataInicial.Value = TBDataInicial.Value.AddDays(-TBDataInicial.Value.Day + 1);

            //data final
            TBDataFinal.Value = TBDataFinal.Value.AddMonths(1);
            TBDataFinal.Value = TBDataFinal.Value.AddDays(-TBDataFinal.Value.Day + DateTime.DaysInMonth(TBDataFinal.Value.Year, TBDataFinal.Value.Month));

            CarregaDados();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var insereos = new FrmInsereos(_banco, 0);
            insereos.ShowDialog();
            CarregaDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var idos = Convert.ToInt32(DGControle.SelectedRows[0].Cells["IDOS"].Value);
            var insereos = new FrmInsereos(_banco, idos);
            insereos.ShowDialog();
            CarregaDados();
        }

        private void DGControle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnreplica_Click(object sender, EventArgs e)
        {
            var insereos = new FrmInsereos(_banco, 0)
            {
                tbos = { Text = Convert.ToString(DGControle.SelectedRows[0].Cells["OS1"].Value) },
                tbdescricao = { Text = Convert.ToString(DGControle.SelectedRows[0].Cells["DESCRICAO"].Value) },
                dpDtInicio = { Value = Convert.ToDateTime(DGControle.SelectedRows[0].Cells["DTINICIO"].Value) },
                dpDtFim = { Value = Convert.ToDateTime(DGControle.SelectedRows[0].Cells["DTFIM"].Value) }
            };

            insereos.ShowDialog();
            CarregaDados();
        }

        private void btnRegistrarPonto_Click(object sender, EventArgs e)
        {
            TimeSpan pontoReg = new TimeSpan(dtpPonto.Value.Hour, dtpPonto.Value.Minute, 0);
            var hoje = (from p in _banco.Ponto
                        where p.Data == DateTime.Today
                        select p
            ).ToList().OrderBy(p => p.Entrada);

            Ponto ultimoPonto = null;
            foreach (var ponto in hoje)
            {
                if (ponto.Entrada > pontoReg || ponto.Saida > pontoReg)
                {
                    MessageBox.Show("Já exite ponto registrado maior que o restro atual", "Controle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ultimoPonto = ponto;
            }
            if (ultimoPonto == null || ultimoPonto.Saida != null)
            {
                ultimoPonto = new Ponto(DateTime.Today);
                _banco.Ponto.Add(ultimoPonto);
            }
            if (ultimoPonto.Entrada == null)
            {
                ultimoPonto.Entrada = pontoReg;
            }
            else
            {
                ultimoPonto.Saida = pontoReg;
            }
            _banco.SaveChanges();
            CalcularHorasTrabalhadas();
        }

        private void dtpPonto_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpPonto.Value = DateTime.Now;
                CalcularHorasTrabalhadas();
            }
        }

        private void CalcularHorasTrabalhadas()
        {
            var hoje = (from p in _banco.Ponto
                        where p.Data == DateTime.Today
                        select p
                        ).ToList().OrderBy(p => p.Entrada);

            TimeSpan horasTrabalhadas = new TimeSpan(0, 0, 0);
            foreach (Ponto p in hoje)
            {
                TimeSpan saida = p.Saida != null ? (TimeSpan)p.Saida : new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
                btnRegistrarPonto.Text = string.Format("Registrar: {0}", p.Saida == null ? "Saída" : "Entrada");
                TimeSpan diferenca = DateTime.Today.Add(saida).Subtract(DateTime.Today.Add((TimeSpan)p.Entrada));
                horasTrabalhadas = horasTrabalhadas.Add(diferenca);
            }
            lblTotHoras.Text = string.Format("Tot. Horas: {0:hh\\:mm}", horasTrabalhadas);

        }

        private void btnRegistrosPonto_Click(object sender, EventArgs e)
        {
            var registrosPonto = new FrmRegistrosPonto(_banco);
            registrosPonto.ShowDialog();
            CarregaDados();
        }
    }
}
