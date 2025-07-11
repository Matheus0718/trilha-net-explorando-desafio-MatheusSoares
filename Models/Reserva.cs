namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
         

            int quantidadeHospedes = hospedes.Count();
            if (Suite.Capacidade >= quantidadeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
               
                throw new ArgumentException("A capacidade da suíte é menor que o número de hóspedes recebidos");
            }
        }



        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
    
            decimal valor = DiasReservados * Suite.ValorDiaria;

    
            
            if (DiasReservados >= 10)
            {
                valor = (valor) - (valor*0.10M) ;
            }

            return valor;
        }
    }
}
