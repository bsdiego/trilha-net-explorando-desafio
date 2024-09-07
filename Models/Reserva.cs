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
            // *IMPLEMENTADO
            try{
                if(Suite.Capacidade >= hospedes.Count){
                    Hospedes = hospedes;
                }
                else{
                    throw new Exception("A quantidade de hóspedes não pode exceder a capacidade de suíte.");
                }
            }
            catch(Exception ex){
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO
            int quantidadeHospedes = Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

              // *IMPLEMENTADO
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1M);
            }

            return valor;
        }
    }
}