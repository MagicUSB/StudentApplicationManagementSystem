namespace StudentApplicationManagementSystem.Models.Joins
{
    public class ApplicationJoinsStudentUniversitySpecialtyStatus
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string UniversityName { get; set; }
        public string SpecialtyName { get; set; }
        public string StatusName { get; set; }
        public double Score { get; set; }
        public int Priority { get; set; }
        public string FundingTypeName { get; set; }
    }
}
