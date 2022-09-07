using Module6HW1.Core.Entities;
using Module6HW1.Core.Interfaces;

namespace Module6HW1.Core.Services
{
    public class ParrotService : IParrotService
    {
        private IDataProvider _dataProvider;

        public ParrotService(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Create(Parrot parrot)
        {
            _dataProvider.Create(parrot);
        }

        public void Delete(int id)
        {
            if(id < 0)
            {
                return;
            }

            _dataProvider.Delete(id);
        }

        public Parrot Get(int id)
        {
            return _dataProvider.Select(id);
        }

        public void Update(Parrot parrot)
        {
            _dataProvider.Update(parrot);
        }
    }
}
