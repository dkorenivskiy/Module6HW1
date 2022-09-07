using Module6HW1.Core.Entities;

namespace Module6HW1.Core.Interfaces
{
    public interface IDataProvider
    {
        void Create(Parrot parrot);
        Parrot Select(int id);
        void Update(Parrot parrot);
        void Delete(int id);
    }
}
