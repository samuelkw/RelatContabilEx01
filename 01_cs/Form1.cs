using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_cs
{
    public partial class Form1 : Form
    {
        private List<Lancamento> lancamentos;
        public Form1()
        {
            InitializeComponent();
            lblMsg.Text = "";
        }

        private void dtIni_ValueChanged(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            dtFim.Value = dtIni.Value.Date.AddDays(-1);
        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            validar();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            dtIni.Enabled = false;
            dtFim.Enabled = false;
            btnGerar.Enabled = false;
            listarLancamentos();
            if (lancamentos.Count > 0)
            {
                bool gerou=gerarArquivo(null);
                if (gerou)
                {
                    lblMsg.Text = "Gerado Com Sucesso!";
                }
                else
                {
                    lblMsg.Text = "Erro durante processo!";
                }
            }
            else
            {
                lblMsg.Text = "Não há dados para ser gerado!";
            }
            dtIni.Enabled = true;
            dtFim.Enabled = true;
        }

        private bool gerarArquivo(String fullpath)
        {
            bool ok = true;
            if (fullpath == null)
            {
                fullpath = Utils.poeBarra(Environment.CurrentDirectory) + "REL1.TXT";
            }
            StreamWriter w = new StreamWriter(fullpath, false);
            w.AutoFlush = true;
            try
            {
                String linha = "";
                linha += Utils.preencher("Conta", 15, " ", 1) + " ";
                linha += Utils.preencher("Descrição", 50, " ", 1) + " ";
                linha += Utils.preencher("Saldo", 18, " ", 1);
                w.WriteLine(linha);
                linha = "";
                linha += Utils.preencher("-", 15, "-", 1) + " "; 
                linha += Utils.preencher("-", 50, "-", 1) + " ";
                linha += Utils.preencher("-", 18, "-", 1);
                w.WriteLine(linha);
                Double saldoTotal = 0D;
                foreach (Lancamento l in lancamentos)
                {
                    w.WriteLine(l.getLinhaLancamento());
                    saldoTotal += l.Saldo;
                }
                linha = "";
                linha += Utils.preencher("Total Geral:", 15, " ", 1) + " ";
                linha += Utils.preencher(" ", 50, " ", 1) + " ";
                linha += Utils.preencher(saldoTotal.ToString(), 18, " ", 2);
                w.WriteLine();
                w.WriteLine(linha);
            }
            catch (Exception e)
            {
                ok = false;
                w.Close();
                MessageBox.Show(null, "Houve um problema ao tentar gerar os dados no arquivo! A aplicação tentará excluir o arquivo. Err: "+e.Message, "Erro geração arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FileInfo f = new FileInfo(fullpath);
                if (f.Exists)
                {
                    try {
                        f.Delete();
                    }
                    catch
                    {
                    }
                }
            }
            return ok;
        }

        private bool validar()
        {
            lblMsg.Text = "";
            bool validade = true;
            if (dtFim.Value < dtIni.Value)
            {
                lblMsg.Text = "Data Inicial não pode ser maior que a Data Final";
                validade = false;
            }
            if (dtFim.Value.Year != dtIni.Value.Year && dtFim.Value.Month != dtIni.Value.Month)
            {
                lblMsg.Text = "O ano e mês das datas inicial e final devem ser os mesmos!";
                validade = false;
            }
            btnGerar.Enabled = validade;
            return validade;
        }
        
        private void listarLancamentos() {
            lancamentos = new List<Lancamento> {};
            Dao d = new Dao();
            try
            {
                lancamentos = d.listarLancamentos(dtIni.Value, dtFim.Value);
            }
            catch (Exception e)
            {
                MessageBox.Show(null,"Houve um problema ao tentar listar os lancamentos. Err: "+e.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
