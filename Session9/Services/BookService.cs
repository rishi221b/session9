using Session9.Model;

namespace Session9.Services
{
    public class BookService : IBookService
    {
        private readonly List<Books> book;
        public BookService()
        {
            book = new List<Books>()
            {
                new Books() {Id=1,BookName="Harry Potter",Genre="Fiction"}
            };
        }
        public IEnumerable<Books> GetAllItems()
        {
            return book;
        }
    }
}

