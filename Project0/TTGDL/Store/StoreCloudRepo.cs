using System.Collections.Generic;
using System.Linq;
using TTGModel;
using Entity = TTGDL.Entities;
using Model = TTGModel;

namespace TTGDL
{
    public class StoreCloudRepo : IStoreRepository
    {
        private Entity.database1Context _context;

        public StoreCloudRepo(Entity.database1Context p_context)
        {
            _context = p_context;
        }

        public Store AddStore(Store p_store)
        {
           _context.Stores.Add
             (
                new Entity.Store()
                {
                    Name = p_store.Name,
                    Address = p_store.Address,
                }
            );
            _context.SaveChanges();
            return p_store;
        }


        public List<Model.Store> GetAllStores()
        {
            //method syntax
            return _context.Stores.Select(store =>
                new Model.Store()
                {
                    Name = store.Name,
                    Address = store.Address,
                }

            ).ToList();
        }
    }
}