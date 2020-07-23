using System.Collections.Generic;
using OTProje.ToDo.Entities.Interface;

namespace OTProje.ToDo.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<ToDo> ToDos { get; set; }
    }
}