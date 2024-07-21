using w5_progettoVenerdi.Models;
using w5_progettoVenerdi.Services;
using w5_progettoVenerdi.Services.Interfaces;

namespace w5_progettoVenerdi.Services.Interfaces
{
    public interface IAnagraficheService 
    {
        public void Create(Anagrafica anagrafica);

        public Anagrafica Read(int id);

        public void Update(Anagrafica anagrafica);

        public List<Anagrafica> ReadAll();

        public void Delete(int id);



    }
}
