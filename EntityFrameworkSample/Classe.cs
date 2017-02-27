using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkSample
{
    class Classe
    {
        public Classe()
        {
            Studenti = new List<Studente>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Studente> Studenti { get; set; }
    }
}