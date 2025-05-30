﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_Suport
{
    public partial class TelaDeChamadocs : Form
    {
        string strConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=SuporteChamados;Integrated Security=True";
        int idUsuarioLogado = 1; // Exemplo: Senai é o usuário logado (idUsuario = 1)
        int idChamado;

        public TelaDeChamadocs(int idChamadoGerado)
        {
            InitializeComponent();
            idChamado = idChamadoGerado;
        }

        private void TelaDeChamadocs_Load(object sender, EventArgs e)
        {
            txtID.Text = idChamado.ToString();

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                conexao.Open();

                string sql = @"SELECT c.nomeCliente, ch.assunto, ch.descricao, ch.prioridade 
                               FROM tblChamados ch
                               INNER JOIN tblClientes c ON ch.idCliente = c.idCliente
                               WHERE ch.idChamado = @idChamado";

                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@idChamado", idChamado);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNomeCliente.Text = reader["nomeCliente"].ToString();
                    txtAssunto.Text = reader["assunto"].ToString();
                    txtDescricao.Text = reader["descricao"].ToString();

                    string prioridade = reader["prioridade"].ToString();
                    switch (prioridade)
                    {
                        case "Baixo": rbnBaixo.Checked = true; break;
                        case "Médio": rbnMedio.Checked = true; break;
                        case "Alto": rbnAlto.Checked = true; break;
                        case "Urgente": rbnUrgente.Checked = true; break;
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaPrincipal paginaPrincipal = new telaPrincipal();
            paginaPrincipal.Show();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text.Trim();
            string assunto = txtAssunto.Text.Trim();
            string descricao = txtDescricao.Text.Trim();
            string prioridade = ObterPrioridadeSelecionada();

            if (string.IsNullOrEmpty(nomeCliente))
            {
                MessageBox.Show("Preencha o nome do cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(assunto) || string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(prioridade))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conexao = new SqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();

                    string sqlUpdateCliente = @"
                        UPDATE tblClientes
                        SET nomeCliente = @nomeCliente
                        WHERE idCliente = (
                            SELECT idCliente FROM tblChamados WHERE idChamado = @idChamado
                        )";

                    SqlCommand cmdCliente = new SqlCommand(sqlUpdateCliente, conexao);
                    cmdCliente.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                    cmdCliente.Parameters.AddWithValue("@idChamado", idChamado);
                    cmdCliente.ExecuteNonQuery();

                    string sqlUpdateChamado = @"
                        UPDATE tblChamados
                        SET assunto = @assunto,
                            descricao = @descricao,
                            prioridade = @prioridade
                        WHERE idChamado = @idChamado";

                    SqlCommand cmdChamado = new SqlCommand(sqlUpdateChamado, conexao);
                    cmdChamado.Parameters.AddWithValue("@assunto", assunto);
                    cmdChamado.Parameters.AddWithValue("@descricao", descricao);
                    cmdChamado.Parameters.AddWithValue("@prioridade", prioridade);
                    cmdChamado.Parameters.AddWithValue("@idChamado", idChamado);
                    cmdChamado.ExecuteNonQuery();

                    MessageBox.Show("Chamado atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telaPrincipal paginaPrincipal = new telaPrincipal();
                    paginaPrincipal.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private string ObterPrioridadeSelecionada()
        {
            if (rbnBaixo.Checked) return "Baixo";
            if (rbnMedio.Checked) return "Médio";
            if (rbnAlto.Checked) return "Alto";
            if (rbnUrgente.Checked) return "Urgente";
            return null;
        }

    }
}