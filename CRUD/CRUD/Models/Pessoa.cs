using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    //Modelo de tabelas que serão criadas no banco de dados
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
    }
}
