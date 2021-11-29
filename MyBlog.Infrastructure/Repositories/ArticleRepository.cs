using MyBlog.Domain.Entites;
using MyBlog.Domain.Repositories;
using MyBlog.Domain.ValueObjects;
using MyBlog.Infrastructure.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBlog.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public ArticleRepository(string ConString)
        {
            this.ConString = ConString;
        }

        public string ConString { get; }

        public Task<bool> Create(Article Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Article>> Get()
        {
            List<Article> result = new List<Article>();
            using (NpgsqlConnection conn = new NpgsqlConnection(ConString))
            {
                var comtext = "select* from article";
                using (NpgsqlCommand comm = new NpgsqlCommand(comtext, conn))
                {
                    await conn.OpenAsync();
                    Article article; 
                    var reader = await comm.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        article = new Article()
                        {
                            Id = (int)reader["id"],
                            MainImage = ImageParser.Parse((string)reader["mainimage"]),
                            Header = (string)reader["header"],
                            Date = (DateTime)reader["createddate"],
                            Description = (string)reader["description"]
                        };
                        var contentpath = (string)reader["contentpath"];
                        var xmlHelper = new XmlHelper(contentpath);
                        var sections = xmlHelper.Extract<List<Section>>();
                        article.Sections = sections;
                        foreach (var section in sections)
                        {
                            section.Image = ImageParser.Parse(section.ImagePath);
                        }
                        result.Add(article);
                    }
                }
            }
            return result;
        }

        public async Task<Article> GetById(int id)
        {
            Article result = null;
            using (NpgsqlConnection conn = new NpgsqlConnection(ConString))
            {
                var comtext = "select* from article where id = @id";
                using (NpgsqlCommand comm = new NpgsqlCommand(comtext,conn))
                {
                    comm.Parameters.AddWithValue("@id",id);
                    await conn.OpenAsync();
                    var reader = await comm.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        result = new Article()
                        {
                            Id =(int)reader["id"],
                            MainImage = ImageParser.Parse((string)reader["mainimage"]),
                            Header = (string)reader["header"],
                            Date = (DateTime)reader["createddate"],
                            Description = (string)reader["description"]
                        };
                        var contentpath = (string)reader["contentpath"];
                        var xmlHelper = new XmlHelper(contentpath);
                        var sections = xmlHelper.Extract<List<Section>>();
                        foreach (var section in sections)
                        {
                            section.Image = ImageParser.Parse(section.ImagePath);
                        }
                        result.Sections = sections;
                    }
                }
            }
            return result;
        }

        public Task<bool> Update(Article Entity)
        {
            throw new NotImplementedException();
        }
    }
}
