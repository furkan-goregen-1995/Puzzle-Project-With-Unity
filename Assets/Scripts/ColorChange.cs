using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    RaycastHit hit;

    GameObject currentHit;
    public Button button;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            ChangeGridColor();
        }

    }

    //Change Grid Color
    void ChangeGridColor()
    {

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            currentHit = hit.collider.gameObject;
            currentHit.GetComponent<Renderer>().material.color = button.GetComponent<Image>().color;

        }
    }

}
