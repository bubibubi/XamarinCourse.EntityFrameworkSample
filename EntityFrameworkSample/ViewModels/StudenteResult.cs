using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSample.ViewModels
{
class StudenteResult
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Classe Classe { get; set; }
    public float Media { get; set; }
}
}
