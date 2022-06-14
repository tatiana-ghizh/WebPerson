using MediatR;
using System.Collections.Generic;
using System.Linq;
using WebPerson.Entities;

namespace WebPerson.NewFolders.GetNewFolders
{
    public class GetNewFoldersQuery: IRequest<List<PersonDto>>
    {

    }
}
