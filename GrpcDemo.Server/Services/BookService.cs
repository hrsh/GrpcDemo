using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GrpcDemo.Server.Services
{
    public class BookService : BookStore.BookStoreBase
    {
        private readonly AppDbContext _context;

        public BookService(AppDbContext context)
        {
            _context = context;
        }

        public override async Task<BookReply> GetBookById(BookRequest request, ServerCallContext context)
        {
            var book = await _context
                .Books
                .FirstOrDefaultAsync(a => a.Id == request.BookId, context.CancellationToken);

            return new BookReply
            {
                Id = book.Id,
                Title = book.Title
            };
        }
    }
}
