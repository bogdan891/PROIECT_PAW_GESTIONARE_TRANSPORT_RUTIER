using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROIECT_PAW.Models;

namespace PROIECT_PAW.Database
{
    public static class DatabaseManager
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Proiect_PAW_Retea_Transport.mdf;Integrated Security=True;";


        //Selectare soferi
        public static List<Sofer> GetAllSoferi()
        {
            var list = new List<Sofer>();
            string sql = "SELECT Id, Nume, Prenume, Salariul, DataAngajarii FROM Soferi";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Sofer
                            {
                                Id = reader.GetGuid(0),
                                Nume = reader.GetString(1),
                                Prenume = reader.GetString(2),
                                Salariul = reader.GetDouble(3),
                                DataAngajarii = reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }
            return list;
        }

        //Adaugare sofer
        public static void AddSofer(Sofer sofer)
        {
            string sql = "INSERT INTO Soferi (Nume, Prenume, Salariul, DataAngajarii) VALUES (@Nume, @Prenume, @Salariul, @DataAngajarii)";

            using(var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nume", sofer.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", sofer.Prenume);
                    cmd.Parameters.AddWithValue("@Salariul", sofer.Salariul);
                    cmd.Parameters.AddWithValue("@DataAngajarii", sofer.DataAngajarii);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Stergere Sofer
        public static void DeleteSofer(Guid id)
        {
            string sql = "DELETE FROM SOFERI WHERE Id = @Id";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Update Sofer
        public static void UpdateSofer(Sofer sofer)
        {
            string sql = "UPDATE SOFERI SET Nume = @Nume, Prenume = @Prenume, Salariul = @Salariul, DataAngajarii = @DataAngajarii Where Id = @Id";
            
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nume", sofer.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", sofer.Prenume);
                    cmd.Parameters.AddWithValue("@Salariul", sofer.Salariul);
                    cmd.Parameters.AddWithValue("@DataAngajarii", sofer.DataAngajarii);
                    cmd.Parameters.AddWithValue("@Id", sofer.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Selectare Masini
        public static List<Masina> GetAllMasini()
        {
            var list = new List<Masina>();
            string sql = "SELECT Id, NrInmatriculare, Marca, AnFabricatie, Capacitate FROM Masini";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn)) {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            list.Add(new Masina
                            {
                                Id = reader.GetGuid(0),
                                NrInmatriculare = reader.GetString(1),
                                Marca = reader.GetString(2),
                                AnFabricatie = reader.GetInt32(3),
                                Capacitate = reader.GetInt32(4)
                            });
                        }
                    }
                }
            }
            return list;
        }

        //Adaugare Masina
        public static void AddMasina(Masina masina)
        {
            string sql = "INSERT INTO Masini (NrInmatriculare, Marca, AnFabricatie, Capacitate) VALUES (@NrInmatriculare, @Marca, @AnFabricatie, @Capacitate)";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NrInmatriculare", masina.NrInmatriculare);
                    cmd.Parameters.AddWithValue("@Marca", masina.Marca);
                    cmd.Parameters.AddWithValue("@AnFabricatie", masina.AnFabricatie);
                    cmd.Parameters.AddWithValue("@Capacitate", masina.Capacitate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Update Masina
        public static void UpdateMasina(Masina masina)
        {
            string sql = "UPDATE MASINI SET NrInmatriculare = @NrInmatriculare, Marca = @Marca, AnFabricatie = @AnFabricatie, Capacitate = @Capacitate WHERE Id = @Id";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NrInmatriculare", masina.NrInmatriculare);
                    cmd.Parameters.AddWithValue("@Marca", masina.Marca);
                    cmd.Parameters.AddWithValue("@AnFabricatie", masina.AnFabricatie);
                    cmd.Parameters.AddWithValue("@Capacitate", masina.Capacitate);
                    cmd.Parameters.AddWithValue("@Id", masina.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Stergere Masina
        public static void DeleteMasina(Guid id)
        {
            string sql = "DELETE FROM MASINI WHERE Id = @Id";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Selectare Rute
        public static DataTable GetAllRute()
        {
            string sql = @"
SELECT 
    Rute.id, Rute.CodTraseu, Rute.Plecare, Rute.Destinatie, Rute.Distanta, Rute.IdSofer, Rute.IdMasina,
    Soferi.Nume + ' ' + Soferi.Prenume AS NumeSofer, 
    Masini.NrInmatriculare + ' - ' + Masini.Marca AS DetaliiMasina 
FROM Rute 
JOIN Soferi on Rute.IdSofer = Soferi.Id 
JOIN Masini on Rute.IdMasina = Masini.Id";
            
            DataTable dt = new DataTable();
            using (var conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }

                return dt;
        }

        //Adaugare Ruta
        public static void AddRuta(Ruta ruta)
        {
            string sql = "INSERT INTO Rute (CodTraseu, Plecare, Destinatie, Distanta, IdSofer, IdMasina) VALUES (@CodTraseu, @Plecare, @Destinatie, @Distanta, @IdSofer, @IdMasina)";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CodTraseu", ruta.CodTraseu);
                    cmd.Parameters.AddWithValue("@Plecare", ruta.Plecare);
                    cmd.Parameters.AddWithValue("@Destinatie", ruta.Destinatie);
                    cmd.Parameters.AddWithValue("@Distanta", ruta.Distanta);
                    cmd.Parameters.AddWithValue("@IdSofer", ruta.IdSofer);
                    cmd.Parameters.AddWithValue("@IdMasina", ruta.IdMasina);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Update Ruta
        public static void UpdateRuta(Ruta ruta)
        {
            string sql = "UPDATE Rute SET CodTraseu = @CodTraseu, Plecare = @Plecare, Destinatie = @Destinatie, Distanta = @Distanta, IdSofer = @IdSofer, IdMasina = @IdMasina WHERE Id = @Id";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CodTraseu", ruta.CodTraseu);
                    cmd.Parameters.AddWithValue("@Plecare", ruta.Plecare);
                    cmd.Parameters.AddWithValue("@Destinatie", ruta.Destinatie);
                    cmd.Parameters.AddWithValue("@Distanta", ruta.Distanta);
                    cmd.Parameters.AddWithValue("@IdSofer", ruta.IdSofer);
                    cmd.Parameters.AddWithValue("@IdMasina", ruta.IdMasina);
                    cmd.Parameters.AddWithValue("@Id", ruta.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //StergereRute
        public static void DeleteRuta(Guid id)
        {
            string sql = "DELETE FROM Rute WHERE Id = @Id";
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
