using System.Runtime.CompilerServices;

namespace AwaitHandleSample;

public static class TaskHelper
{
    // public static TaskAwaiter<Task<T>[]> GetAwaiter<T>(this (Task<T>, Task<T>) tasks)
    // {
    //     return TaskExt.WhenAll(tasks.Item1, tasks.Item2).GetAwaiter();
    // }

    public static TaskAwaiter<(T, T)> GetAwaiter<T>(this (Task<T>, Task<T>) tasks)
    {
        async Task<(T, T)> MergeTasks()
        {
            var (task1, task2) = tasks;
            await TaskExt.WhenAll(task1, task2);
    
            return (task1.Result, task2.Result);
        }
    
        return MergeTasks().GetAwaiter();
    }
}

