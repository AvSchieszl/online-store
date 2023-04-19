using OnlineStore.Domain.Enums;

public class UserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CivilianId { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public UserRole Role { get; set; }
    public bool IsDeleted { get; set; }
}
