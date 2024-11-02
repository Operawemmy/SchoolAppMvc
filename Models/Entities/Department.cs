namespace SchoolApp.Models.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // this means the name of department is not nullable.
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
    }
}
