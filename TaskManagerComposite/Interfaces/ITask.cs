namespace TaskManager.Interfaces
{
    public interface ITask
    {
        string Name { get; }
        bool IsCompleted { get; }
        void MarkComplete();
        void Print(string indent = "");
        double GetProgress();
    }
}
