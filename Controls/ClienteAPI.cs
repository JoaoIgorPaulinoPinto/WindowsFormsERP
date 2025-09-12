using MySql.Data.MySqlClient;
using Projeto0307.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public static class ClienteAPI
{
    private static readonly string connString = "server=localhost;database=bd_erp;uid=root;pwd=Joao996083255";
    public static DataTable ListarClientes()
    {
        var tabela = new DataTable();

        try
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        u.id AS ID,
                        u.nome AS Nome,
                        u.sexo AS Sexo,
                        u.dataNascimento AS DataNascimento,
                        u.cpf AS CPF,
                        u.celular AS Celular,
                        u.telefoneResidencial AS TelefoneResidencial,
                        u.telefoneComercial AS TelefoneComercial,
                        u.email AS Email,
                        u.alternativo AS Alternativo,
                        u.status AS Status
                    FROM Cliente u";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao listar clientes: " + ex.Message);
        }

        return tabela;
    }

    public static bool CadastrarCliente(Cliente cliente)
    {
        using (var conn = new MySqlConnection(connString))
        {
            conn.Open();
            var transaction = conn.BeginTransaction();

            try
            {
                string sqlCliente = @"
                    INSERT INTO Cliente 
                    (Nome, DataNascimento, CPF, Sexo, Celular, TelefoneResidencial, TelefoneComercial, Alternativo, Status, Email)
                    VALUES 
                    (@Nome, @DataNascimento, @CPF, @Sexo, @Celular, @TelefoneRes, @TelefoneCom, @Alternativo, @Status, @Email);";

                using (var cmd = new MySqlCommand(sqlCliente, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                    cmd.Parameters.AddWithValue("@TelefoneRes", cliente.TelefoneRes);
                    cmd.Parameters.AddWithValue("@TelefoneCom", cliente.TelefoneCom);
                    cmd.Parameters.AddWithValue("@Alternativo", cliente.Alternativo);
                    cmd.Parameters.AddWithValue("@Status", cliente.Status);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.ExecuteNonQuery();
                }

                int clienteId = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", conn, transaction).ExecuteScalar());

                foreach (var endereco in cliente.Endereco)
                {
                    CadastrarEndereco(endereco, clienteId, conn, transaction);
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                return false;
            }
        }
    }

    public static bool AtualizarCliente(int clienteId, Cliente cliente)
    {
        try
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                string sql = @"
                    UPDATE Cliente
                    SET 
                        Nome = @Nome,
                        DataNascimento = @DataNascimento,
                        CPF = @CPF,
                        Sexo = @Sexo,
                        Celular = @Celular,
                        TelefoneResidencial = @TelefoneRes,
                        TelefoneComercial = @TelefoneCom,
                        Email = @Email,
                        Alternativo = @Alternativo,
                        Status = @Status
                    WHERE id = @ClienteId";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                    cmd.Parameters.AddWithValue("@TelefoneRes", cliente.TelefoneRes);
                    cmd.Parameters.AddWithValue("@TelefoneCom", cliente.TelefoneCom);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Alternativo", cliente.Alternativo);
                    cmd.Parameters.AddWithValue("@Status", cliente.Status);
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    cmd.ExecuteNonQuery();
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            return false;
        }
    }

    public static bool AtualizarEndereco(Endereco endereco, int enderecoId)
    {
        try
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                if (endereco != null)
                {
                    string update = @"
                        UPDATE Endereco
                        SET CEP = @CEP,
                            UF = @UF,
                            Cidade = @Cidade,
                            Bairro = @Bairro,
                            Logradouro = @Logradouro,
                            Numero = @Numero,
                            Complemento = @Complemento
                        WHERE Id = @Id;";

                    using (var cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@CEP", endereco.CEP);
                        cmd.Parameters.AddWithValue("@UF", endereco.UF);
                        cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                        cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                        cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                        cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                        cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                        cmd.Parameters.AddWithValue("@Id", enderecoId);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    CadastrarEndereco(endereco, enderecoId, conn);
                }

                return true;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar/inserir endereço: " + ex.Message);
            return false;
        }
    }

    public static bool CadastrarEndereco(Endereco endereco, int clienteId, MySqlConnection conn = null, MySqlTransaction transaction = null)
    {
        bool isExternalConnection = (conn != null);

        try
        {
            if (!isExternalConnection)
            {
                conn = new MySqlConnection(connString);
                conn.Open();
            }

            string sql = @"
                INSERT INTO Endereco 
                (fk_cliente_id, CEP, UF, Cidade, Bairro, Logradouro, Numero, Complemento)
                VALUES 
                (@ClienteId, @CEP, @UF, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento);";

            using (var cmd = new MySqlCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                cmd.Parameters.AddWithValue("@CEP", endereco.CEP);
                cmd.Parameters.AddWithValue("@UF", endereco.UF);
                cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                cmd.ExecuteNonQuery();
            }

            if (!isExternalConnection)
                conn.Close();

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao cadastrar endereço: " + ex.Message);
            return false;
        }
    }
    public static List<Endereco> ListarEnderecosPorCliente(int clienteId)
    {
        List<Endereco> enderecos = new List<Endereco>();

        try
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                string sql = "SELECT * FROM Endereco WHERE fk_cliente_id = @ClienteId";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["Id"].ToString());
                            var endereco = new Endereco(
                               int.Parse( reader["Id"].ToString()),
                                reader["CEP"].ToString(),
                                reader["UF"].ToString(),
                                reader["Cidade"].ToString(),
                                reader["Bairro"].ToString(),
                                reader["Numero"].ToString(),
                                reader["Logradouro"].ToString(),
                                reader["Complemento"].ToString()
                            );

                            enderecos.Add(endereco);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao listar endereços: " + ex.Message);
        }

        return enderecos;
    }

    public static bool ExcluirCliente(int clienteId)
    {
        var conn = new MySqlConnection(connString);
        Cliente cliente;
        using (var transaction = conn.BeginTransaction())
        {
            try
            {
                using (var cmd = new MySqlCommand(@"
                    SELECT c.*, e.* 
                    FROM cliente c
                    LEFT JOIN endereco e ON e.fk_usuario_id = c.Id
                    WHERE c.Id = @id", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        Cliente clienteTemp = null;
                        while (reader.Read())
                        {
                            if (clienteTemp == null)
                            {
                                clienteTemp = new Cliente(
                                reader["Nome"]?.ToString(),
                                reader["DataNascimento"]?.ToString(),
                                reader["CPF"]?.ToString(),
                                new List<Endereco>(), // <- Mudança aqui
                                reader["Celular"]?.ToString(),
                                reader["TelefoneResidencial"]?.ToString(),
                                reader["TelefoneComercial"]?.ToString(),
                                reader["Email"]?.ToString(),
                                reader["Status"]?.ToString(),
                                reader["Sexo"]?.ToString(),
                                reader["Alternativo"]?.ToString()
                                );

                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("e.Id"))) // Certifique-se de que há endereço
                            {
                                var endereco = new Endereco
                                (
                                    int.Parse(reader["Id"]?.ToString()),
                                    reader["CEP"]?.ToString(),
                                    reader["Numero"]?.ToString(),
                                    reader["Bairro"]?.ToString(),
                                    reader["Cidade"]?.ToString(),
                                    reader["Numero"]?.ToString(),
                                    reader["Estado"]?.ToString(),
                                    reader["Complemento"]?.ToString()
                                    // ... outros campos se necessário
                                );

                                clienteTemp.Endereco.Add(endereco);
                            }
                        }

                        cliente = clienteTemp;
                    }
                }

                if (cliente == null)
                    throw new Exception("Cliente não encontrado.");

                // 2. Inserir na tabela clienteexcluido
                int clienteExcluidoId;
                using (var cmd = new MySqlCommand(@"
                INSERT INTO clienteexcluido 
                (Nome, DataNascimento, CPF, Sexo, Celular, TelefoneResidencial, TelefoneComercial, Alternativo, Status, Email)
                VALUES (@Nome, @DataNascimento, @CPF, @Sexo, @Celular, @TelefoneResidencial, @TelefoneComercial, @Alternativo, @Status, @Email);
                SELECT LAST_INSERT_ID();", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                    cmd.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                    cmd.Parameters.AddWithValue("@TelefoneResidencial", cliente.TelefoneRes);
                    cmd.Parameters.AddWithValue("@TelefoneComercial", cliente.TelefoneCom);
                    cmd.Parameters.AddWithValue("@Alternativo", cliente.Alternativo);
                    cmd.Parameters.AddWithValue("@Status", cliente.Status);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);

                    clienteExcluidoId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // 3. Buscar o endereço do cliente
                using (var cmd = new MySqlCommand("SELECT * FROM endereco WHERE ClienteId = @id", conn, transaction))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // 4. Inserir na tabela enderecoexcluido
                        using (var insertCmd = new MySqlCommand(@"
                        INSERT INTO enderecoexcluido 
                        (CEP, UF, Cidade, Bairro, Logradouro, Numero, Complemento, ClienteExcluidoId)
                        VALUES (@CEP, @UF, @Cidade, @Bairro, @Logradouro, @Numero, @Complemento, @ClienteExcluidoId);", conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@CEP", reader["CEP"]);
                            insertCmd.Parameters.AddWithValue("@UF", reader["UF"]);
                            insertCmd.Parameters.AddWithValue("@Cidade", reader["Cidade"]);
                            insertCmd.Parameters.AddWithValue("@Bairro", reader["Bairro"]);
                            insertCmd.Parameters.AddWithValue("@Logradouro", reader["Logradouro"]);
                            insertCmd.Parameters.AddWithValue("@Numero", reader["Numero"]);
                            insertCmd.Parameters.AddWithValue("@Complemento", reader["Complemento"]);
                            insertCmd.Parameters.AddWithValue("@ClienteExcluidoId", clienteExcluidoId);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                // 5. Deletar o endereço original
                using (var cmd = new MySqlCommand("DELETE FROM endereco WHERE ClienteId = @id", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    cmd.ExecuteNonQuery();
                }

                // 6. Deletar o cliente original
                using (var cmd = new MySqlCommand("DELETE FROM cliente WHERE Id = @id", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                return false;
            }
        }
    }
}
