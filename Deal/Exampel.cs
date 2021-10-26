using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exampel : MonoBehaviour
{

    
    public InputField TaskName;
    public InputField Discipt;

    private string _taskName;
    private string _discript;
    private List<ITask> _task;
    private void Start()
    {
        Disconect();
        _task = new List<ITask>();
    }
    private void Disconect()
    {
        TaskName.gameObject.SetActive(false);
        Discipt.gameObject.SetActive(false);
    }

    public void Complited()
    {
        Disconect();
    }
    public void AddTaskName()
    {
        TaskName.gameObject.SetActive(true);
        TaskName.onEndEdit?.AddListener(TaskDiscription);
    }
    public void AddDiscript()
    {
        Discipt.gameObject.SetActive(true);

        Discipt.onEndEdit?.AddListener(TaskNames);
    }
    private void TaskNames(string name)
    {
        _taskName = name;
        TaskName.gameObject.SetActive(true);
        
    }
    private void TaskDiscription(string disript)
    {
        _discript = disript;
        Discipt.gameObject.SetActive(false);
    }
    public void AddTasker()
    {
        ITask task = new Task(_taskName, _discript);
        _task.Add(task);
        Debug.Log($"Discript\n{task.Discriptiom}\nNameTask\n{task.TaskName}\nTime\n{task.TimeRegestration}");
    }

}
