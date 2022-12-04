namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        int tamanho=0;
        decimal quant;
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa>hospede)
        {
             // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
        
            foreach(Pessoa pes in hospede)
            {
                quant++;
            }
            
           
           if(Suite.Capacidade>= quant)
           {
            Hospedes = hospede;
            Console.WriteLine("Hospedes cadastrados");
           }
           else
           {
            throw new Exception("Quantidades de hospedes acima da capacidadec da suite");
        
           }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            foreach(Pessoa hosp in Hospedes)
            {
                Console.WriteLine(hosp);
                tamanho++;
            }

            return tamanho;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * quant * Suite.ValorDiaria) - (DiasReservados * quant * Suite.ValorDiaria * 0.10M);
            }
            else
            {
                valor = DiasReservados * quant * Suite.ValorDiaria;

            }

            return valor;
        }
    }
}