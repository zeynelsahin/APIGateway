using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet("{id:int}")]
    public ContactDTO GetContactById(int id)
    {
        return _contactService.GetContactById(id);
    }
}