using System.ComponentModel.DataAnnotations;

namespace ToDoList_ToDoAPI.Models.Dto
{
    public class ToDoDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        public string Title { get; set; }
        public string Note { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        public DateTime DeadlineDateTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
