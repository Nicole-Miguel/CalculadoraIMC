public class Individuo
{
    public string Nome { get; set; }    
    public double Peso { get; set; }
    public double Altura { get; set; }
    
    public Individuo(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }
}