using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact.API.Messaging.DTOs;
using MediatR;

namespace Contact.API.Messaging
{
    public class GetContactsQuery: IRequest<List<ContactV1>>
    {
    }
}
