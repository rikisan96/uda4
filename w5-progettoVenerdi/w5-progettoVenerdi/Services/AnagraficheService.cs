using Microsoft.Data.SqlClient;
using w5_progettoVenerdi.Models;
using w5_progettoVenerdi.Services.Interfaces;

namespace w5_progettoVenerdi.Services
{
    public class AnagraficheService :IAnagraficheService
    {

            private readonly string _connectionString;

            public AnagraficheService(IConfiguration configuration)
            {

                _connectionString = configuration.GetConnectionString("DefaultConnection");
            }

            public void Create(Anagrafica anagrafica)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Parameters.AddWithValue("@Cognome", anagrafica.Cognome ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Nome", anagrafica.Nome ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Indirizzo", anagrafica.Indirizzo ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Città", anagrafica.Città ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@CAP", anagrafica.CAP ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Cod_Fisc", anagrafica.Cod_Fisc ?? (object)DBNull.Value);
                        command.ExecuteNonQuery();
                    }
                }
            }
            public Anagrafica Read(int id)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ANAGRAFICHE WHERE IdAnagrafica = @IdAnagrafica";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdAnagrafica", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Anagrafica
                                {
                                    IdAnagrafica = (int)reader["IdAnagrafica"],
                                    Cognome = reader["Cognome"].ToString(),
                                    Nome = reader["Nome"].ToString(),
                                    Indirizzo = reader["Indirizzo"].ToString(),
                                    Città = reader["Città"].ToString(),
                                    CAP = reader["CAP"].ToString(),
                                    Cod_Fisc = reader["Cod_Fisc"].ToString()
                                };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            public List<Anagrafica> ReadAll()
            {
                List<Anagrafica> anagrafiche = new List<Anagrafica>();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM ANAGRAFICHE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                anagrafiche.Add(new Anagrafica
                                {
                                    IdAnagrafica = (int)reader["IdAnagrafica"],
                                    Cognome = reader["Cognome"].ToString(),
                                    Nome = reader["Nome"].ToString(),
                                    Indirizzo = reader["Indirizzo"].ToString(),
                                    Città = reader["Città"].ToString(),
                                    CAP = reader["CAP"].ToString(),
                                    Cod_Fisc = reader["Cod_Fisc"].ToString()
                                });
                            }
                        }
                    }
                }
                return anagrafiche;
            }

            public void Update(Anagrafica anagrafica)
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "UPDATE ANAGRAFICHE SET Cognome = @Cognome, Nome = @Nome, Indirizzo = @Indirizzo, Città = @Città, CAP = @CAP, Cod_Fisc = @Cod_Fisc WHERE IdAnagrafica = @IdAnagrafica";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Cognome", anagrafica.Cognome);
                        command.Parameters.AddWithValue("@Nome", anagrafica.Nome);
                        command.Parameters.AddWithValue("@Indirizzo", anagrafica.Indirizzo);
                        command.Parameters.AddWithValue("@Città", anagrafica.Città);
                        command.Parameters.AddWithValue("@CAP", anagrafica.CAP);
                        command.Parameters.AddWithValue("@Cod_Fisc", anagrafica.Cod_Fisc);
                        command.Parameters.AddWithValue("@IdAnagrafica", anagrafica.IdAnagrafica);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public void Delete(int id)
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    // Prima elimina i record correlati nella tabella VERBALI
                    string deleteVerbaliQuery = "DELETE FROM VERBALI WHERE IdAnagrafica = @IdAnagrafica";
                    using (SqlCommand cmd = new SqlCommand(deleteVerbaliQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAnagrafica", id);
                        cmd.ExecuteNonQuery();
                    }

                    // Ora elimina il record nella tabella ANAGRAFICHE
                    string deleteAnagraficaQuery = "DELETE FROM ANAGRAFICHE WHERE IdAnagrafica = @IdAnagrafica";
                    using (SqlCommand cmd = new SqlCommand(deleteAnagraficaQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAnagrafica", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        
    }
}
