using TaskManager.Interfaces;

namespace TaskManager.Models
{
    public class TaskGroup : ITask
    {
        public string Name { get; }
        private readonly List<ITask> _children = new();

        public TaskGroup(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public bool IsCompleted => _children.Count > 0 && _children.All(c => c.IsCompleted);

        public void Add(ITask task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _children.Add(task);
        }

        public void Remove(ITask task)
        {
            if (task == null) 
            {
                throw new ArgumentNullException(nameof(task));
            }
          
            _children.Remove(task);
        }

        public void MarkComplete()
        {
            foreach (var child in _children)
            {
                child.MarkComplete();
            }            
        }

        public void Print(string indent = "")
        {
            var status = IsCompleted ? "[x]" : $"[{(int)(GetProgress() * 100)}%]";
            Console.WriteLine($"{indent}{status} {Name}");
            foreach (var child in _children)
            {
                child.Print(indent + "  ");
            }
                
        }

        public double GetProgress()
        {
            if (_children.Count == 0)
            {
                return 0.0;
            }
            return _children.Average(c => c.GetProgress());
        }
    }
}
