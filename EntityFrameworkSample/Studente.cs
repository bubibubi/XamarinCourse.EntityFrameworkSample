namespace EntityFrameworkSample
{
    class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Classe Classe { get; set; }
    }
}