public class Individuo
{
    public string Nome { get; set; }    
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Individuo()
    {
        Nome = " ";
        Peso = 0;
        Altura = 0;
    }
    
    public double CalculoImc()
    {
        double imc = Peso / (Altura * Altura);
        return imc;
      
    } 
}