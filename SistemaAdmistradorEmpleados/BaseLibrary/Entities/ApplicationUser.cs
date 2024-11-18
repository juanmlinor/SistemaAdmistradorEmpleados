namespace BaseLibrary.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; } = null;
        public string? Password { get; set; }
    }
}
