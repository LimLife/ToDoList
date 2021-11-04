using System;
using System.Collections.Generic;
using UnityEngine;

public class TaskHandler
{
    public Action<object> OnAddedOrRemoveEvent;
    public List<ITask> Task;

    public TaskHandler()
    {
        Task = new List<ITask>();
    }
    public ITask [] GetAllTask()
    {
        return Task.ToArray();
    }
    public ITask GetTask(string name)
    {
        return Task.Find(task => task.TaskName == name);
    }   
    public bool HasTask( string name,out ITask task)
    {
        task = GetTask(name);
        return task != null;
    }
    public void AddTask(object sender, string taskName,string discription)
    {    
        Task.Add(new Task(taskName,discription));
        OnAddedOrRemoveEvent?.Invoke(sender);
    }
    public void Remove(object sender, string name)
    {
        var task = GetTask(name);
        if (task == null)
        {
            return;
        }
       
        Task.Remove(task);
        Debug.Log($"{task.TaskName}");
        OnAddedOrRemoveEvent?.Invoke(sender);      
    }  
}
