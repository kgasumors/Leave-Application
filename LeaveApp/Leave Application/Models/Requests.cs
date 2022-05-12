using System.ComponentModel.DataAnnotations;

namespace Leave_Application.Models
{
    public class Requests
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(300)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public LeaveType LeaveType { get; set; }

        public string ReasonForLeave { get; set; } = string.Empty;

        [Required]
        public DateTime LeaveStartDate { get; set; }

        [Required]
        public DateTime LeaveEndDate { get; set; }
    }

    public enum LeaveType
    {
        Annual_Leave,
        Sick_Leave,
        Study_Leave,
        Maternity_Leave,
        Family_Resposibility_Leave
    }
}
