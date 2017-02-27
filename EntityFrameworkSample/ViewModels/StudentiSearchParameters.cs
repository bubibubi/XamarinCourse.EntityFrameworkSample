using System;

namespace EntityFrameworkSample.ViewModels
{
    class StudentiSearchParameters
    {
        public string Cognome { get; set; }
        public int? AnnoDiNascitaDa { get; set; }
        public int? AnnoDiNascitaA { get; set; }
        public int? IdClasse { get; set; }
    }
}
