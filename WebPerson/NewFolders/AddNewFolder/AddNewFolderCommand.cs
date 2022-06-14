using MediatR;
using WebPerson.Entities;

namespace WebPerson.NewFolders.AddNewFolder
{
    public class AddNewFolderCommand : IRequest<int>
    {
        public PersonDto Data { get; set; }
    }
}
