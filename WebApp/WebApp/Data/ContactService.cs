using Newtonsoft.Json;

namespace WebApp.Data
{
    public class ContactService
    {
        private readonly HttpClient _httpClient;

        public ContactService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("Contacts.API");
        }

        public async Task<List<Contact>> GetContacts()
        {
            var response = await _httpClient.GetAsync("/contacts");

            if(!response.IsSuccessStatusCode)
            {
                return new List<Contact>();
            }

            string result = await response.Content.ReadAsStringAsync();
            List<Contact> contacts = null;

            try
            {
                contacts = JsonConvert.DeserializeObject<List<Contact>>(result);
            }
            catch (Exception ex)
            {

            }

            return contacts;
        }
    }
}
