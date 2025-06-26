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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            int quantidadeHospedes = hospedes.Count();
            if (Suite.Capacidade >= quantidadeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
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