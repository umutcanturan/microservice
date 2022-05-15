using Contact.API.Messaging;
using Contact.API.Messaging.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.API.Queries
{
    public class GetContactsHandler : IRequestHandler<GetContactsQuery, List<ContactV1>>
    {
        public GetContactsHandler()
        {

        }

        public Task<List<ContactV1>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
