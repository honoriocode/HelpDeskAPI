namespace HelpDeskApi._4___Application._2___Services
{
    public class EquipamentoService
    {
        private readonly List<Equipamento> equipamentos;

        public EquipamentoService()
        {
            equipamentos = new List<Equipamento>();
        }

        public void AdicionaEquipamento(Equipamento equipamento)
        {
            equipamentos.Add(equipamento);
        }
    }

}
