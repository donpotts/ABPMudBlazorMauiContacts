using System.ComponentModel.DataAnnotations;

namespace AppContacts.Shared.Models;

public class ApplicationUserWithRolesDto : ApplicationUserDto
{
    public List<string>? Roles { get; set; }
}
