namespace ToDo.Models
{
    public class ToDoViewModel
    {
        public int Id { set; get; }
        public int userId { set; get; }
        public string? title { set; get; }
        public bool completed { set; get; }=false;
    }
}
