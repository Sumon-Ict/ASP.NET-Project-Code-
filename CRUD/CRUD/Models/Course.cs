using CRUD.Data;

namespace CRUD.Models
{
    public class Course : IEntity<int>
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Fees { get; set; }
        public DateTime StartDate { get; set; }

    }
}
