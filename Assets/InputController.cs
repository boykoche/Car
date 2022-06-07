using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    Transform tra;
    bool check_tap = false;
    public enum buttons_type
    {
        right,left,move,stop
    }
    [SerializeField] buttons_type button;
    [SerializeField] GameObject car_cube_controller;
    public void OnPointerDown(PointerEventData eventData)
    {
        check_tap = true;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        check_tap = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        tra = car_cube_controller.GetComponent<CubeController>().tr;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (check_tap)
        {
            action();
        }
    }
    void action()
    {
        switch (button)
        {
            case buttons_type.right:
                tra.Rotate(0,0.1f,0);
                break;
            case buttons_type.left:
                tra.Rotate(0, -0.1f, 0);
                break;
            case buttons_type.move:
                tra.position += tra.forward * 0.05f;
                break;
            case buttons_type.stop:
                break;
        }
    }
}
