using ToDoList_ToDoAPI.Models.Dto;

namespace ToDoList_ToDoAPI.Data
{
    public static class ToDoStore
    {
        public static List<ToDoDTO> toDoList = new List<ToDoDTO>
        {
            new ToDoDTO{Id=1, Title="First Task", Note="Create a first task",
                IsComplete=true, DeadlineDateTime=new DateTime(2023, 3, 29, 12, 0, 0, DateTimeKind.Local),
                CreatedDate=new DateTime(2023, 3, 29, 11, 0, 0, DateTimeKind.Local)},
            new ToDoDTO{Id=2, Title="Second Task", Note="Create a second task",
                IsComplete=true, DeadlineDateTime=new DateTime(2023, 3, 29, 12, 0, 0, DateTimeKind.Local),
                CreatedDate=new DateTime(2023, 3, 29, 11, 0, 0, DateTimeKind.Local)}
        };
    }
}
