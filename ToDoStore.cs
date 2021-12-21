using ToDo.Models;
namespace ToDo
{
    public class ToDoStore
    {
        private List<ToDoViewModel> toDos { set; get; } 
        public ToDoStore()
        {
            toDos = new List<ToDoViewModel>();
        }
        public void Add(ToDoViewModel t)
        {
            toDos.Add(t);
            
        }
        public int Count()
        {
            return this.toDos.Count;
        }
        public List<ToDoViewModel> getStore()
        {
            return this.toDos;
        }
        public bool Remove(ToDoViewModel item)
        {
            return toDos.Remove(item);
            
        }
    }
}
