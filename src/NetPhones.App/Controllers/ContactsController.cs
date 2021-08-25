using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetPhones.App.ViewModels;
using NetPhones.Core.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetPhones.App.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService _contactsService;
        private readonly IMapper _mapper;

        public ContactsController(IContactsService contactsService, IMapper mapper)
        {
            _contactsService = contactsService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _contactsService.GetAllAsync();

            var mappedContacts = _mapper.Map<ICollection<ContactViewModel>>(contacts);

            return View(mappedContacts);
        }
    }
}
