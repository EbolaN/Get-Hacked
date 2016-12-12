using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public bool drageble;

    #region IBeginDragHandler implementation

    public void OnTriggerEnter()
    {
        drageble = true;
    }
    public void OnTriggerExit()
    {
        drageble = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (drageble)
        {
            itemBeingDragged = gameObject;
            startPosition = transform.position;
            startParent = transform.parent;
            //GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = new Vector3(eventData.position.x+transform.position.x, eventData.position.y+transform.position.y, 0);
    }

    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        //GetComponent<CanvasGroup>().blocksRaycasts = true;
        //if (transform.parent == startParent)
        //{
        //    transform.position = startPosition;
        //}
    }

    #endregion



}