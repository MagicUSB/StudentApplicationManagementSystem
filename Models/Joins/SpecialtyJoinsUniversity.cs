namespace StudentApplicationManagementSystem.Models.Joins
{
    public class SpecialtyJoinsUniversity
    {
        public int SpecialtyId { get; set; }
        public string? SpecialtyName { get; set; }
        public string? UniversityName { get; set; }
        public int BudgetSpots { get; set; }
        public int TotalSpots { get; set; }
        public string? DegreeName { get; set; }

    }
}
