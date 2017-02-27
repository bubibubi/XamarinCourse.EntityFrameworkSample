using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace EntityFrameworkSample
{
class Program
{
    static void Main(string[] args)
    {
        AggiuntaStudenti();
        RicercaCompagniMaccabei();
    }

    private static void RicercaCompagniMaccabei()
    {
ScuolaContext context = new ScuolaContext();

// Recupero lo studente che si chiama Maccabei
Studente studenteMaccabei = context.Studenti.Single(s => s.Nome == "Maccabei");
// Per ogni studente che c'è nella classe di Maccabei
foreach (Studente studente in studenteMaccabei.Classe.Studenti)
    // Stampo il nome dello studente
    Console.WriteLine(studente.Nome);
    }

    private static void AggiuntaStudenti()
    {
//var sw = new StreamWriter("C:\\Temp\\Output.txt");
        //Console.SetOut(sw);

        Classe classe = new Classe();
        classe.Nome = "3D";

        Studente s1 = new Studente();
        s1.Nome = "Maccabei";

        Studente s2 = new Studente();
        s2.Nome = "Masinelli";

        classe.Studenti.Add(s1); // Aggiungiamo il primo studente alla classe
        classe.Studenti.Add(s2); // Aggiungiamo il secondo studente alla classe

        ScuolaContext context = new ScuolaContext();
        context.Classi.Add(classe); // Aggiungiamo la classe al contesto
        context.SaveChanges(); // Salviamo le modifiche apportate al contesto
        context.Dispose(); // In C# è un sinonimo di Close()

        //sw.Dispose();
    }
}


    // Scuola è l'ambito di interesse e non va modellata
    // Ogni scuola ha una serie di classi

    class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Ogni materia può essere insegnata in una o più classi
        public IEnumerable<Classe> Classi { get; set; }
    }

    class Voto
    {
        public Studente Studente { get; set; }
        public Materia Materia { get; set; }
        public double Numero { get; set; }
    }

}
