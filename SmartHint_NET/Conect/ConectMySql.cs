using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

using System.Data.Common;
using MySqlX.XDevAPI;

namespace SmartHint_NET.Conect
{
    internal class ConectMySql
    {
        MySqlConnection Conexao;

        public void conectaBanco()
        {
            try
            {
                string dataSource = "datasource=localhost;username=root;password=;database=SMARTHIST";
                Conexao = new MySqlConnection(dataSource);
                Conexao.Open();
                //MessageBox.Show("Conectado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable busca(string sql)
        {
            try
            {
                //string sql = "INSERT INTO CLIENTES (ID, NOME_RAZAO, EMAIL, TEL, DATA_CAD, TIPO, CPF_CNPJ, INSCRICAO, ISENTO, GENERO, DATA_NASC, BLOQ, SENHA) values ('1', 'Marcelo Fernandes', 'marcelo@teste.com', '11952186656', '20240513', '0', '39202334846', '0000', '1', 'Masculino', '19900311', '0', 'teste');";
                //string sql = "SELECT * FROM CLIENTES;";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                conectaBanco();

                //Executar Comando SQL
                MySqlDataReader reader = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                
                dataTable.Load(reader);

                //MessageBox.Show(reader.ToString());
                //Conexao?.Close();
                return dataTable;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Conexao?.Close();
                return null;
            }
            finally
            {
                Conexao?.Close();
            }
        }

        public bool insere(string sql)
        {
            try
            {
                //string sql = "INSERT INTO CLIENTES (ID, NOME_RAZAO, EMAIL, TEL, DATA_CAD, TIPO, CPF_CNPJ, INSCRICAO, ISENTO, GENERO, DATA_NASC, BLOQ, SENHA) values ('1', 'Marcelo Fernandes', 'marcelo@teste.com', '11952186656', '20240513', '0', '39202334846', '0000', '1', 'Masculino', '19900311', '0', 'teste');";
                //string sql = "SELECT * FROM CLIENTES;";
                conectaBanco();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                conectaBanco();

                //Executar Comando SQL
                comando.ExecuteReader();

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Conexao?.Close();
                return false;
            }
            finally
            {
                Conexao?.Close();
            }
        }
    }
}
