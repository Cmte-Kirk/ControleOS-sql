using System;
using System.Linq;
using System.Windows.Forms;
using ProgControle.Dados;
using System.Data.Entity.Validation;

namespace ControleProg
{
    public partial class FrmInsereos : Form
    {
        private readonly DBControle _banco = new DBControle();
        private readonly int _idos;
        private OS _oseditando;

        public FrmInsereos(DBControle banco, int idos)
        {
            InitializeComponent();
            _banco = banco;
            _idos = idos;
        }

        private OS MontaOs()
        {
            var os = new OS
            {
                IDOS = Convert.ToInt32(Lidos.Text),
                OS1 = tbos.Text,
                DESCRICAO = tbdescricao.Text,
                DTINICIO = dpDtInicio.Value,
                DTFIM = dpDtFim.Value,
                TEMPOGASTO = Util.CalculaHora(dpDtFim.Value, dpDtInicio.Value)
        };
            return os;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_idos == 0)
            {
                var os = MontaOs();
                _banco.OS.Add(os);
            }
            else
            {
                _oseditando.DESCRICAO = tbdescricao.Text;
                _oseditando.DTFIM = dpDtFim.Value;
                _oseditando.DTINICIO = dpDtInicio.Value;
                _oseditando.OS1 = tbos.Text;
                _oseditando.TEMPOGASTO = Util.CalculaHora(_oseditando.DTFIM, _oseditando.DTINICIO);
            }

            try
            {
                _banco.SaveChanges();
                Close();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    var erro = String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, "");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        erro += String.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                    }
                    Util.MenssagemErro(erro);
                }
                throw;
            }
        }

        private void FrmInsereos_Load(object sender, EventArgs e)
        {
            if (_idos > 0)
            {
                _oseditando = (from o in _banco.OS
                              where o.IDOS == _idos
                              select o).FirstOrDefault();

                if (_oseditando == null) return;

                Lidos.Text = Convert.ToString(_oseditando.IDOS);
                tbos.Text = _oseditando.OS1;
                tbdescricao.Text = _oseditando.DESCRICAO;

                if (_oseditando.DTINICIO != null)
                {
                    dpDtInicio.Value = (DateTime)_oseditando.DTINICIO;
                }

                if (_oseditando.DTFIM != null)
                {
                    dpDtFim.Value = (DateTime) _oseditando.DTFIM;
                }                
            }
            else
            {
                Lidos.Text = Convert.ToString(_banco.Database.SqlQuery<decimal>(@"SELECT ISNULL(IDENT_CURRENT('OS') + IDENT_INCR('OS'),1) AS id;").FirstOrDefault());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dpDtFim_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dpDtFim.Value = DateTime.Now;
        }
    }
}
