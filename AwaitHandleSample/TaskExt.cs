namespace AwaitHandleSample;

public static class TaskExt
{
    public static async Task<Task<T>[]> WhenAll<T>(params Task<T>[] tasks)
    {
        try
        {
            await Task.WhenAll(tasks);
        }
        catch (InvalidOperationException e)
        {
            var faultedTasks = tasks.Where(task => task.Exception != null).ToArray();
            return faultedTasks;
        }
    
        return tasks.Where(task => task.Status == TaskStatus.RanToCompletion).ToArray();
    }
}