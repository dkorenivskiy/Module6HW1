using Module6HW1.Core.Entities;

namespace Module6HW1.Core.Interfaces
{
    public interface IParrotService
    {
        void Create(Parrot parrot);
        Parrot Get(int id);
        void Update(Parrot parrot);
        void Delete(int id);
    }
}
