using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebPerson.Entities;
using WebPerson.NewFolders.AddNewFolder;
using WebPerson.NewFolders.GetNewFolder;
using WebPerson.NewFolders.GetNewFolders;
using WebPerson.NewFolders.RemoveNewFolder;
using WebPerson.NewFolders.UpdateNewFolder;

namespace WebPerson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewFolderController : ControllerBase
    {
        private IMediator _mediator;

        public NewFolderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<int> AddPerson([FromBody] AddNewFolderCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpGet]
        public async Task<List<PersonDto>> GetPersons([FromQuery] GetNewFoldersQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<PersonDto> GetPerson([FromRoute] int id)
        {
            return await _mediator.Send(new GetNewFolderQuery { Id = id});
        }

        [HttpDelete("{id}")]
        public async Task<Unit> DeletePerson([FromRoute] int id)
        {
            return await _mediator.Send(new RemoveNewFolderCommand { Id = id });
        }

        [HttpPatch]
        public async Task<Unit> UpdatePerson([FromBody] UpdateNewFolderCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
