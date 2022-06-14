using MediatR;
using WebPerson.Entities;

namespace WebPerson.NewFolders.GetNewFolder
{
    public class GetNewFolderQuery : IRequest<PersonDto>
    {
        public int Id { get; set; }
    }
}
