using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ItemSlot : MonoBehaviour/*, IPointerDownHandler, IPointerUpHandler*/
{

    [SerializeField] private Canvas canvas;

    private CanvasGroup canvasgroup;

    private RectTransform rectTransform;

    

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();
    }

    

    /*public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        canvasgroup.alpha = .6f;
        canvasgroup.blocksRaycasts = false;

        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        canvasgroup.alpha = 1f;
        canvasgroup.blocksRaycasts = true;
    }*/


    /*public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDown != null)
        {
            eventData.pointerDown.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }*/

    /*public void OnMouseDown(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.mouseDown != null)
        {
            eventData.mouseDown.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }*/


}
