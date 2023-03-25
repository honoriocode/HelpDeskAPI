namespace HelpDeskApi._4___Application._2___Services
{
    public class ChamadoService
    {
        private readonly List<Chamado> chamados;

        public ChamadoService()
        {
            chamados = new List<Chamado>();
        }

        public void AdicionaChamado(Chamado chamado)
        {
            chamados.Add(chamado);
        }
    }

}
