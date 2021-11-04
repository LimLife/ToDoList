using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    [SerializeField] private InputField TaskName;
    [SerializeField] private InputField Discipt;
    public  TaskHandler _taskHandler { get; set; }

    private string _taskName = "Defult";
    private string _discript = "Defult";
    
    private void Awake()
    {
        Disconect();
        _taskHandler = new TaskHandler();
    }
    private void Disconect()
    {
        TaskName.gameObject.SetActive(false);
        Discipt.gameObject.SetActive(false);
    }
    public void AddTaskName()
    {
        TaskName.gameObject.SetActive(true);
    }
    public void AddDiscript()
    {
        Discipt.gameObject.SetActive(true);
    }
    public void TaskNames()
    {
        _taskName = TaskName.text;
        TaskName.gameObject.SetActive(false);
    }
    public void TaskDiscription()
    {
        _discript = Discipt.text;
        Discipt.gameObject.SetActive(false);
    }
    public void AddTask()
    {       
        _taskHandler.AddTask(this,_taskName, _discript);     
    }
    public void RenoveTask(string name) //По выбранной таксе а не вводить /Dont work now
    {
        _taskHandler.Remove(this,name);   
    }
}
