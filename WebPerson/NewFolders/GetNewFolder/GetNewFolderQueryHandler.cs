using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WebPerson.Context;
using WebPerson.Entities;

namespace WebPerson.NewFolders.GetNewFolder
{
    public class GetNewFolderQueryHandler : IRequestHandler<GetNewFolderQuery, PersonDto>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public GetNewFolderQueryHandler(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task<PersonDto> Handle(GetNewFolderQuery request, CancellationToken cancellationToken)
        {
            var person = await _appDbContext.Persons.FirstOrDefaultAsync(x => x.Id == request.Id);

            return _mapper.Map<PersonDto>(person);
        }
    }
}
