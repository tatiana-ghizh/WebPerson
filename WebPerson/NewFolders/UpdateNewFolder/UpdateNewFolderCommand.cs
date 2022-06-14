using MediatR;
using WebPerson.Entities;

namespace WebPerson.NewFolders.UpdateNewFolder
{
    public class UpdateNewFolderCommand : IRequest<Unit>
    {
        public PersonDto Data { get; set; }
    }
}
