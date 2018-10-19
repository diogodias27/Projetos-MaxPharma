using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Crud_Asp_ADO.Models.Classes
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }

    public abstract class AbstractRepository<TEntity, Tkey>
          where TEntity : class
    {
        protected string StringConnection { get; } = WebConfigurationManager.ConnectionStrings["DatabaseCrud"].ConnectionString;
        public abstract List<TEntity> GetAll();
        public abstract TEntity GetById(Tkey id);
        public abstract void Save(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(TEntity entity);
        public abstract void DeleteById(Tkey id);

    }

    public class PessoaRepository : AbstractRepository<Pessoa int>
    {
        public override void Delete(Pessoa entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE Pessoa Where id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override void DeleteById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "DELETE Pessoa Where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }
        public override List<Pessoa> GetAll()
        {
            string sql = "SELECT id , Nome, Email, Cidade, Endereco FROM Pessoa ORDER BY Nome";
            using (var conn = new SqlConnection(StringConnection))
            {
                var cmd = new SqlCommand(sql, conn);
                List<Pessoa> list = new List<Pessoa>();
                Pessoa p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Pessoa();
                            p.Id = (int)reader["Id"];
                            p.Nome = reader["Nome"].ToString();
                            p.Email = reader["Email"].ToString();
                            p.Cidade = reader["Cidade"].ToString();
                            p.Endereco = reader["endereco"].ToString();
                            list.Add(p);
                        }


                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return list;

            }
        }

        public override Pessoa GetById(int id)
        {
            using (var conn = new SqlConnection(StringConnection))
            {

                string sql = "Select Id, Nome,Email,Cidade,Endereco FROM Pessoa WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                Pessoa p = null;
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                p = new Classes.Pessoa();
                                p.Id = (int)reader["Id"];
                                p.Nome = reader["Nome"].ToString();
                                p.Email = reader["Email"].ToString();
                                p.Cidade = reader["Cidade"].ToString();
                                p.Endereco = reader["Endereco"].ToString();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                return p;
            }

        }

        public override void Save(Pessoa entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "INSERT INTO Pessoa(Nome, Email,Cidade,Endereco) Values(@Nome,@Email,@Cidade,@Endereco)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Cidade", entity.Cidade);
                cmd.Parameters.AddWithValue("@Endereco", entity.Endereco);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
               
        }

        public override void Update(Pessoa entity)
        {
            using (var conn = new SqlConnection(StringConnection))
            {
                string sql = "UPDATE Pessoa SET Nome = @Nome, Email=@Email, Cidade=@Cidade, Endereco=@Endereco Where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@Nome", entity.Nome);
                cmd.Parameters.AddWithValue("@Email", entity.Email);
                cmd.Parameters.AddWithValue("@Cidade", entity.Cidade);
                cmd.Parameters.AddWithValue("@Endereco", entity.Endereco);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
        }
    }
}