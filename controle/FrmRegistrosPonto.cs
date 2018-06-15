using ProgControle.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProg
{
    public partial class FrmRegistrosPonto : Form
    {
        private readonly DBControle _banco = null;
        private List<Ponto> hoje = null;
        //private BindingSource bsPonto = null;

        public FrmRegistrosPonto(DBControle banco)
        {
            this._banco = banco;
            InitializeComponent();
        }

        private void FrmRegistrosPonto_Load(object sender, EventArgs e)
        {
            dtpInicial.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today;
            CarregarDados();
        }

        private void CarregarDados()
        {
            hoje = (from p in _banco.Ponto
                    where  p.Data >= dtpInicial.Value && p.Data <= dtpFinal.Value 
                    select p
            ).OrderBy(p => p.Entrada).ToList();

            //bsPonto = new BindingSource();
            //bsPonto.DataSource = ;
            dgPonto.DataSource = hoje;
            dgPonto.Refresh();
        }

        private void RemoveRegistro(int id)
        {
            var rem = hoje.FirstOrDefault(p => p.IdPonto == id);
            if (rem != null)
            {
                TimeSpan tsE = rem.Entrada == null ? new TimeSpan(0, 0, 0) : (TimeSpan)rem.Entrada;
                TimeSpan tsS = rem.Saida == null ? new TimeSpan(0, 0, 0) : (TimeSpan)rem.Saida;
                string msg = string.Format("Confirma exclusão do registro de ponto: {0:d} - {1:hh\\:mm} - {2:hh\\:mm}", rem.Data, tsE, tsS);
                if (MessageBox.Show(msg, "Controle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _banco.Ponto.Remove(rem);
                    CarregarDados();

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this._banco.SaveChanges();
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgPonto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPonto.Columns[e.ColumnIndex].Name == "Icons")
            {
                RemoveRegistro((int)dgPonto.Rows[e.RowIndex].Cells["IdPonto"].Value);
            }
        }
    }
}
