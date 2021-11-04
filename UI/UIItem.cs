using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIItem : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private Text _taskName;
    [SerializeField] private Text _discription;
    [SerializeField] private Text _time;
    [SerializeField] private GameObject _buttonsEditRemove;

    [SerializeField] private Button _remove;
  
    private UIShow _uiShow;
    private void Start()
    {
        _uiShow = GetComponentInParent<UIShow>();
        _buttonsEditRemove.SetActive(false);
    }

    public void Date(ITask task)
    {
        _taskName.text = task.TaskName;
        _discription.text = task.Discriptiom;
        _time.text = $"{task.TimeRegestration.Hour}:{task.TimeRegestration.Minute}:{task.TimeRegestration.Second}";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonsEditRemove.SetActive(true);
        _remove.gameObject.SetActive(true);
    }
    private void Disconect()
    {
        _remove.gameObject.SetActive(false);
        _buttonsEditRemove.SetActive(false);
    }

    public void Remove()
    {
        _uiShow.RemoveTask(_taskName.text);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Disconect();
    }
}
