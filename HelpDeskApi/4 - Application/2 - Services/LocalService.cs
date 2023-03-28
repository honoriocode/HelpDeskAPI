using Microsoft.AspNetCore.Mvc;

namespace HelpDeskApi._4___Application._2___Services
{
    public class LocalService
    {
        private readonly List<Local> locais;

        public LocalService()
        {
            locais = new List<Local>();
        }

        public Local GetLocalById(Guid id)
        {
            return locais.SingleOrDefault(l => l.Id == id);
        }

        public IActionResult AdicionaLocal(Local local, out List<string> errors)
        {
            errors = new List<string>();

            locais.Add(local);
            return new CreatedAtActionResult(nameof(GetLocalById), "Local", new { id = local.Id }, local);
        }
    }

}
