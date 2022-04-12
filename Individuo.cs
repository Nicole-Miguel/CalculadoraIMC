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

    public string FaixaDePeso()
    {
        string faixa = " ";
        if(CalculoImc() < 17.00) {
            return faixa = "Muito abaixo do peso";
        } else if(CalculoImc() >= 17.00 && CalculoImc() < 18.50) {
            return faixa = "Abaixo do peso";
        } else if(CalculoImc() >= 18.50 && CalculoImc() < 25.00) {
            return faixa = "Peso normal";
        } else  if(CalculoImc() >= 25.00 && CalculoImc() < 30.00) {
            return faixa = "Acima do peso";
        } else if(CalculoImc() >= 30.00 && CalculoImc() < 35.00) {
            return faixa = "Obesidade I";
        } else if(CalculoImc() >= 35.00 && CalculoImc() < 40) {
            return faixa = "Obesidade II (severa)";
        } else {
            return faixa = "Obesidade III (mórbida)";
        }
    } 
}