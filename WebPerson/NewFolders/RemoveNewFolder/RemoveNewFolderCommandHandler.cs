using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WebPerson.Context;

namespace WebPerson.NewFolders.RemoveNewFolder
{
    public class RemoveNewFolderCommandHandler : IRequestHandler<RemoveNewFolderCommand, Unit>
    {
        private readonly AppDbContext _appDbContext;

        public RemoveNewFolderCommandHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Unit> Handle(RemoveNewFolderCommand request, CancellationToken cancellationToken)
        {
            var personToRemove = await _appDbContext.Persons.FirstOrDefaultAsync(x => x.Id == request.Id);

            _appDbContext.Persons.Remove(personToRemove);

            await _appDbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
