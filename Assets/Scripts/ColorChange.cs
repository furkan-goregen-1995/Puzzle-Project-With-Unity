using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    RaycastHit hit;

    GameObject currentHit;


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
        Button button = GameObject.Find("ChangeButtonColor").GetComponent<Button>();

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            currentHit = hit.collider.gameObject;
            currentHit.GetComponent<Renderer>().material.color = button.GetComponent<Image>().color;

        }
    }

}
