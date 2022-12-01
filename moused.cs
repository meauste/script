using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class moused : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Texture2D mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
        public void OnPointerEnter(PointerEventData eventData)
        {
        Cursor.visible = false;
        }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.visible = true;
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.Auto);

    }
    
}
