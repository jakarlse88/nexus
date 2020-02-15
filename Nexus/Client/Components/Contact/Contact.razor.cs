using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Nexus.Client.Models;

namespace Nexus.Client.Components.Contact
{
    public class ContactBase : ComponentBase
    {
        // ReSharper disable once InconsistentNaming
        protected readonly ContactFormModel _contactFormModel = new ContactFormModel();

        [Inject] private HttpClient HttpClient { get; set; }

        protected async Task HandleValidSubmit()
        {
            var contactInfo = new ContactFormModel()
            {
                Name = _contactFormModel.Name,
                Subject = _contactFormModel.Subject,
                Email = _contactFormModel.Email,
                Message = _contactFormModel.Message
            };

            await HttpClient.PostJsonAsync("https://localhost:5002/api/contact", contactInfo);
        }
    }
}