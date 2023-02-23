using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickPlaceUnit : MonoBehaviour/*, IPointerDownHandler, IPointerUpHandler*/
{
    public GameObject Unit;
    public GameObject PlayerSpawn;

    public void OnClick()
    {
        GameObject playerClick = Instantiate(Unit, PlayerSpawn.transform.position, Quaternion.identity);

        if(PlayerSpawn != null)
        {
            PlayerSpawn.active = false;
            //Unit.active = true;
        }
        
    }













    // Get SelectedUnits_Panel value; Get the poistion/transform values of the Unit4Slot_Button
    // Click on it and then click any of the Units from the DECK Panel and it should get fixed into the place where 
    // the Unit4Slot_Button was called.

    //[SerializeField] private Canvas canvas;
    //[SerializeField] private Canvas Deck_Panel;
    /*   public GameObject yourButton;
       public GameObject unit;

       public Button yourButton;

       public void Start()
       {
           Button btn = yourButton.GetComponent<Button>();
           btn.onClick.AddListener(TaskOnClick);
           //Debug.Log(btn);
       }
       public void TaskOnClick()
       {
           Debug.Log("You have clicked the button!");
           GameObject playerClick = Instantiate(yourButton, unit.transform.position, Quaternion.identity);
       }

       public void getButton()
       {

       }*/

    /*private CanvasGroup canvasgroup;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasgroup = GetComponent<CanvasGroup>();

        //Debug.Log(canvasgroup);
    }*/

    /*public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }*/

    /*public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }*/

    /*public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }*/

    /*public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        //canvasgroup.alpha = .6f;
        //canvasgroup.blocksRaycasts = false;

        //rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnPointerUp");
        //canvasgroup.alpha = 1f;
        //canvasgroup.blocksRaycasts = true;
    }*/
}