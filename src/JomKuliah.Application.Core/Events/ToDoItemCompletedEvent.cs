using JomKuliah.Application.Core.Entities;
using JomKuliah.Application.SharedKernel;

namespace JomKuliah.Application.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}