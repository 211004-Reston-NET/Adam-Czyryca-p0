using System.Collections.Generic;
using TTGDL;
using TTGModel;


namespace TTGBL
{
    public class StoreBL : IStoreBL
    {
        private IRepository _repo;
        

        public StoreBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Store AddStore(Store p_store)
        {
            return _repo.AddStore(p_store);
        }

        public List<Store> GetAllStores()
        {
            List<Store> listOfStores = _repo.GetAllStores();
            for (int i = 0; i < listOfStores.Count; i++)
            {
                listOfStores[i].Name = listOfStores[i].Name.ToUpper();
            }
            return listOfStores;
        }
    }
}
