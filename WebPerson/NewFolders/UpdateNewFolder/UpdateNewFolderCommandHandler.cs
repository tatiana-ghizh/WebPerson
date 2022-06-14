using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WebPerson.Context;

namespace WebPerson.NewFolders.UpdateNewFolder
{
    public class UpdateNewFolderCommandHandler : IRequestHandler<UpdateNewFolderCommand, Unit>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public UpdateNewFolderCommandHandler(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateNewFolderCommand request, CancellationToken cancellationToken)
        {
            var personToUpdate = await _appDbContext.Persons.FirstOrDefaultAsync(x => x.Id == request.Data.Id);

            _mapper.Map(request.Data, personToUpdate);
            await _appDbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
