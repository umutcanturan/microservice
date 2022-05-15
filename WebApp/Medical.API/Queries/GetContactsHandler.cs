using Contact.API.Messaging;
using Contact.API.Messaging.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.API.Queries
{
    public class GetContactsHandler : IRequestHandler<GetContactsQuery, List<ContactV1>>
    {
        private static readonly List<ContactV1> contacts = new List<ContactV1>()
        {
            new ContactV1() { Id = 1, Name = "Test 1", PhoneNumber = "23131"},
            new ContactV1() { Id = 2, Name = "Test 2", PhoneNumber = "63445"}
        };

        public GetContactsHandler()
        {

        }

        public async Task<List<ContactV1>> Handle(GetContactsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(contacts);
        }
    }
}
