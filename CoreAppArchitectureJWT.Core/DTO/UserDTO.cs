namespace CoreAppArchitectureJWT.Core.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreationDate { get; set; } 
        public DateTime UpdationDate { get; set; } 
    }
}
