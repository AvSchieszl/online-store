using System.ComponentModel.DataAnnotations;
using OnlineStore.Domain.Enums;

namespace OnlineStore.Domain.Entities;
public class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CivilianId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    public UserRole Role { get; set; }
    public bool IsDeleted { get; set; }
}