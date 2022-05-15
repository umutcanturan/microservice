using Contact.API.Messaging;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _bus;
        public ContactsController(IMediator bus)
        {
            _bus = bus;
        }

        [HttpGet]
        [Route("getContacts")]
        public async Task<IActionResult> Get()
        {
            var contacts = await _bus.Send(new GetContactsQuery());
            return new JsonResult(await Task.FromResult(contacts));
        }
    }
}
