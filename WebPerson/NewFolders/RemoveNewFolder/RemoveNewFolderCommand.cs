using MediatR;

namespace WebPerson.NewFolders.RemoveNewFolder
{
    public class RemoveNewFolderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
