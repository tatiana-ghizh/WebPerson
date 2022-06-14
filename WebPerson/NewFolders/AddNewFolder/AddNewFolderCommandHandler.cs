using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebPerson.Context;
using WebPerson.Entities;

namespace WebPerson.NewFolders.AddNewFolder
{
    public class AddNewFolderCommandHandler : IRequestHandler<AddNewFolderCommand, int>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public AddNewFolderCommandHandler(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(AddNewFolderCommand request, CancellationToken cancellationToken)
        {
            var newPerson = _mapper.Map<Person>(request.Data);

            await _appDbContext.Persons.AddAsync(newPerson);
            await _appDbContext.SaveChangesAsync();

            return newPerson.Id;
        }
    }
}
