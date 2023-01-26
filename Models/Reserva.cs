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
                // Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Implementado
                Console.WriteLine("Número de hóspedes é maior que a capacidade");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado
            int numeroH = Hospedes.Count;
                return numeroH;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado
           decimal valor = DiasReservados * (Suite.ValorDiaria);

            if (DiasReservados >= 10)

            // Implementado
            
            {
                return valor = (valor - valor/10);
            }

            return valor;
        }
    }
}