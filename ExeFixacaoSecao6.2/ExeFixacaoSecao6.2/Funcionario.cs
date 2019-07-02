using System.Globalization;

namespace ExeFixacaoSecao6._2
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * (1 + (porcentagem / 100));
        }

        public override string ToString()
        {
            return Id 
                + ", " 
                + Nome 
                + ", R$ " 
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
