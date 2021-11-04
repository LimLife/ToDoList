using System;
using System.Collections.Generic;
using UnityEngine;

public class UIShow : MonoBehaviour
{
    [SerializeField] private UIButton _uiButtion;
    [SerializeField] private GameObject _UIprefab;
    private TaskHandler _handler => _uiButtion._taskHandler;

    private List<GameObject> _taskOjeckt;
    private void Start()
    {
        _taskOjeckt = new List<GameObject>();
        _handler.OnAddedOrRemoveEvent += UpdateUI;
    }
    private void ShowAllTask()
    {
        RefreshUI();
        var items = _handler.GetAllTask();
        for (int i = 0; i < items.Length; i++)
        {
            var item = Instantiate(_UIprefab, transform);
            item.GetComponent<UIItem>().Date(items[i]);
            _taskOjeckt.Add(item);
        }
    }
    private void RefreshUI()
    {
        for (int i = 0; i < _taskOjeckt.Count; i++)
        {
            Destroy(_taskOjeckt[i]);
        }
    }
    private void UpdateUI(object sender)
    {  
        ShowAllTask();     
    }
    public void RemoveTask(string name)
    {
        _handler.Remove(this, name);
    }
}
