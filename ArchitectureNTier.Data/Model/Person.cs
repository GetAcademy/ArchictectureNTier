using System;

namespace ArchitectureNTier.Data.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        public int? Father { get; set; }
        public int? Mother { get; set; }

    }
}
