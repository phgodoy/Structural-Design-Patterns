using TaskManager.Interfaces;

namespace TaskManager.Models
{
    class TaskItem : ITask
    {
        public string Name { get; }
        public bool IsCompleted { get; private set; }

        public TaskItem(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public void MarkComplete()
        {
            IsCompleted = true;
        }

        public void Print(string indent = "")
        {
            var status = IsCompleted ? "[x]" : "[ ]";
            Console.WriteLine($"{indent}{status} {Name}");
        }

        public double GetProgress()
        {
            return IsCompleted ? 1.0 : 0.0;
        }
    }
}
