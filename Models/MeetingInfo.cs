
namespace MeetingApp.Models
{
    public class MeetingInfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public DateTime MeetingDate { get; set; }
        public int ParticipantNumber { get; set; }
    }
}