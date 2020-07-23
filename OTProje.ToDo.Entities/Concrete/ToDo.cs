using System;
using OTProje.ToDo.Entities.Interface;

namespace OTProje.ToDo.Entities.Concrete
{
    public class ToDo : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}