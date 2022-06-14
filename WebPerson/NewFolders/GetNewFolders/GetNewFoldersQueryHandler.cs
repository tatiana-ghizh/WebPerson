using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebPerson.Context;
using WebPerson.Entities;

namespace WebPerson.NewFolders.GetNewFolders
{
    public class GetNewFoldersQueryHandler : IRequestHandler<GetNewFoldersQuery, List<PersonDto>>
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public GetNewFoldersQueryHandler(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task<List<PersonDto>> Handle(GetNewFoldersQuery request, CancellationToken cancellationToken)
        {
            var allPersons =  _appDbContext.Persons.AsQueryable();

            var mappedData =  _mapper.Map<List<PersonDto>>(allPersons);

            return mappedData;
        }
    }
}
