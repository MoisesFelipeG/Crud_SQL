using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_SQL
{
   

    public partial class Form1 : Form
    {
        
        bool novo;
        banco reg = new banco();
        public Form1()
        {
            InitializeComponent();
        }
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_buscar.Enabled = true;
            txt_buscaid.Enabled = true;
            txt_nome.Enabled = false;
            txt_endereco.Enabled = false;
            txt_cep.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cidade.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_telefone.Enabled = false;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_limpar.Enabled = true;
            btn_excluir.Enabled = false;
            btn_buscar.Enabled = false;
            txt_buscaid.Enabled = false;
            txt_nome.Enabled = true;
            txt_endereco.Enabled = true;
            txt_cep.Enabled = true;
            txt_bairro.Enabled = true;
            txt_cidade.Enabled = true;
            txt_cidade.Enabled = true;
            txt_uf.Enabled = true;
            txt_telefone.Enabled = true;
            txt_nome.Focus();
            novo = true;
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "insert into cliente values('" + txt_nome.Text + "', '" + txt_endereco.Text + "', '" + txt_cep.Text+"', '"+txt_bairro.Text+"', '"+txt_cidade.Text+"','"+txt_uf.Text+"','"+txt_telefone.Text+"');";
                MySqlConnection con = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if( i > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "update cliente set nome= '"+ txt_nome.Text + "', endereco='"+ txt_endereco.Text+"',cep= '"+ txt_cep.Text+"', bairro= '"+txt_bairro.Text+"', cidade= '"+txt_cidade.Text+"', uf='"+txt_uf.Text+"', telefone='"+txt_telefone.Text+"', where id = '"+txt_id.Text+"'";
                MySqlConnection con = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_buscar.Enabled = true;
            txt_buscaid.Enabled = true;
            txt_nome.Enabled = false;
            txt_endereco.Enabled = false;
            txt_cep.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cidade.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_telefone.Enabled = false;
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_cep.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_telefone.Text = "";
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_buscar.Enabled = true;
            txt_buscaid.Enabled = true;
            txt_nome.Enabled = false;
            txt_endereco.Enabled = false;
            txt_cep.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cidade.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_telefone.Enabled = false;
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_cep.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_telefone.Text = "";
        }
        
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from cliente where id = " + txt_id.Text;
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro excluido com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_limpar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_buscar.Enabled = true;
            txt_buscaid.Enabled = true;
            txt_nome.Enabled = false;
            txt_endereco.Enabled = false;
            txt_cep.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cidade.Enabled = false;
            txt_cidade.Enabled = false;
            txt_uf.Enabled = false;
            txt_telefone.Enabled = false;
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_cep.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_uf.Text = "";
            txt_telefone.Text = "";
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sql = "select * from cliente where id=" + txt_id.Text;
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd =  new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader; 
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    btn_novo.Enabled = false;
                    btn_salvar.Enabled = true;
                    btn_limpar.Enabled = true;
                    btn_excluir.Enabled = true;
                    btn_buscar.Enabled = false;
                    txt_buscaid.Enabled = false;
                    txt_nome.Enabled = true;
                    txt_endereco.Enabled = true;
                    txt_cep.Enabled = true;
                    txt_bairro.Enabled = true;
                    txt_cidade.Enabled = true;
                    txt_cidade.Enabled = true;
                    txt_uf.Enabled = true;
                    txt_telefone.Enabled = true;
                    txt_nome.Focus();
                    txt_id.Text = reader[0].ToString();
                    txt_nome.Text = reader[1].ToString();
                    txt_endereco.Text = reader[2].ToString();
                    txt_cep.Text = reader[3].ToString();
                    txt_bairro.Text = reader[4].ToString();
                    txt_cidade.Text = reader[5].ToString();
                    txt_uf.Text = reader[6].ToString();
                    txt_telefone.Text = reader[7].ToString();
                    novo = false;
                }
                else
                {
                    MessageBox.Show("Nenhum Registro encontrado com id Informado!");    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            txt_id.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
