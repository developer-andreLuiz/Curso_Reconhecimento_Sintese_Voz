using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Reconhecimento_Sintese_Voz
{
    class Banco
    {
        protected static SQLiteConnection conexao { get; } = new SQLiteConnection("Data Source = Banco.db");
        public static void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public class Tb_reconhecimento
        {
            /// <summary>
            /// Retorna Todos os registros da Tabela
            /// </summary>
            /// <returns></returns>
            public static List<Tb_reconhecimento_Model> RetornoCompleto()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("select * from tb_reconhecimento order by id asc", conexao);
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                sQLiteDataAdapter.Fill(dtLista);
                List<Tb_reconhecimento_Model> ltFinal = new List<Tb_reconhecimento_Model>();
                foreach (DataRow dataRow in dtLista.Rows)
                {
                    Tb_reconhecimento_Model newTb_reconhecimento_Model = new Tb_reconhecimento_Model();
                    newTb_reconhecimento_Model.id = Convert.ToInt32(dataRow["id"]);
                    newTb_reconhecimento_Model.palavra = Convert.ToString(dataRow["palavra"]);
                    newTb_reconhecimento_Model.resposta = Convert.ToString(dataRow["resposta"]);
                  
                    ltFinal.Add(newTb_reconhecimento_Model);
                }
                return ltFinal;
            }

            /// <summary>
            /// Retorna Um registro da Tabela
            /// </summary>
            /// <returns></returns>
            public static Tb_reconhecimento_Model Retorno(int idLocal)
            {
                Tb_reconhecimento_Model tb_reconhecimentoFinal = new Tb_reconhecimento_Model();

                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("select * from tb_reconhecimento where id = @id", conexao);
                cmd.Parameters.AddWithValue("id", idLocal);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["id"]) == idLocal)
                    {
                        tb_reconhecimentoFinal.id = Convert.ToInt32(dr["id"]);
                        tb_reconhecimentoFinal.palavra = Convert.ToString(dr["palavra"]);
                        tb_reconhecimentoFinal.resposta = Convert.ToString(dr["resposta"]);
                        break;
                    }
                }
                return tb_reconhecimentoFinal;

            }

            /// <summary>
            /// Insere registros na tabela
            /// </summary>
            /// <param name="tb_reconhecimento_Model"></param>
            public static void Inserir(Tb_reconhecimento_Model tb_reconhecimento_Model)
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("insert into tb_reconhecimento (palavra, resposta) values (@palavra, @resposta)", conexao);
                cmd.Parameters.AddWithValue("palavra", tb_reconhecimento_Model.palavra);
                cmd.Parameters.AddWithValue("resposta", tb_reconhecimento_Model.resposta);
                cmd.ExecuteNonQuery();
            }

            /// <summary>
            /// Atualiza registros na tabela
            /// </summary>
            /// <param name="tb_reconhecimento_Model"></param>
            public static void Atualizar(Tb_reconhecimento_Model tb_reconhecimento_Model)
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                SQLiteCommand cmd = new SQLiteCommand("update tb_reconhecimento set palavra = @palavra, resposta = @resposta where id = @id", conexao);
                cmd.Parameters.AddWithValue("id", tb_reconhecimento_Model.id);
                cmd.Parameters.AddWithValue("palavra", tb_reconhecimento_Model.palavra);
                cmd.Parameters.AddWithValue("resposta", tb_reconhecimento_Model.resposta);
                cmd.ExecuteNonQuery();
            }

            /// <summary>
            /// Deleta registros na tabela
            /// </summary>
            /// <param name="tb_reconhecimento_Model"></param>
            public static void Deletar(Tb_reconhecimento_Model tb_reconhecimento_Model)
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("delete from tb_reconhecimento where id = @id", conexao);
                cmd.Parameters.AddWithValue("id", tb_reconhecimento_Model.id);
                cmd.ExecuteNonQuery();
            }
            
            /// <summary>
            /// Apaga Todos os Registros da Tabela... Muito Cuidado ao utilizar esta Função
            /// </summary>
            public static void Truncate()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("delete from tb_reconhecimento", conexao);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from sqlite_sequence where name='tb_reconhecimento'";
                cmd.ExecuteNonQuery();
            }

        }
    }
}
