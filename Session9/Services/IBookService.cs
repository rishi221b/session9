using Session9.Model;

namespace Session9.Services
{
    public interface IBookService
    {
        IEnumerable<Books> GetAllItems();
    }
}
