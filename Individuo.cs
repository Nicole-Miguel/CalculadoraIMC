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
        return Math.Round (imc, 2);
    } 

    public string FaixaDePeso()
    {
        string faixa = " ";
        if (CalculoImc() < 17.00) 
        {
            return faixa = "Muito abaixo do peso";
        } 
        else if (CalculoImc() >= 17.00 && CalculoImc() < 18.50) 
        {
            return faixa = "Abaixo do peso";
        } 
        else if (CalculoImc() >= 18.50 && CalculoImc() < 25.00) 
        {
            return faixa = "Peso normal";
        } 
        else  if (CalculoImc() >= 25.00 && CalculoImc() < 30.00) 
        {
            return faixa = "Acima do peso";
        } 
        else if (CalculoImc() >= 30.00 && CalculoImc() < 35.00) 
        {
            return faixa = "Obesidade I";
        } 
        else if (CalculoImc() >= 35.00 && CalculoImc() < 40) 
        {
            return faixa = "Obesidade II (severa)";
        } 
        else 
        {
            return faixa = "Obesidade III (mórbida)";
        }
    }
    
    public double PesoIdeal()     
    {
        double pesoIdeal = 0;
        double diferenca = 0;
        if (CalculoImc() >= 25) 
        {
            pesoIdeal = 24.99 * (Altura * Altura);
            diferenca = Peso - pesoIdeal;
            if (diferenca < 1) 
                Console.WriteLine("Você deve perder {0} g", Math.Round(diferenca, 2));  
            else
                Console.WriteLine("Você deve perder {0} kg", Math.Round(diferenca, 2));
        } 
        else if (CalculoImc() <= 17 && CalculoImc() < 18.50) 
        {
            pesoIdeal = 18.50 * (Altura * Altura);
            diferenca = pesoIdeal - Peso; 
            if (diferenca < 1)  
                Console.WriteLine("Você deve ganhar {0} g", Math.Round(diferenca, 2));
            else
            Console.WriteLine("Você deve ganhar {0} g", Math.Round(diferenca, 2));
        }
        else
        {
            pesoIdeal = CalculoImc() * (Altura * Altura);
            Console.WriteLine("Você está no peso ideal");
        }
        return Math.Round(pesoIdeal, 2);
    } 
}