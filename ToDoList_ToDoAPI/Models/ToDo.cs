namespace ToDoList_ToDoAPI.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
