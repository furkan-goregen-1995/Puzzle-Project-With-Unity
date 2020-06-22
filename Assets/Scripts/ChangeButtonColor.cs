using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))]
public class ChangeButtonColor : MonoBehaviour
{


    public Button button;
    public GameObject obj;
    int i = 0;

    //Color list
    List<Color> colorList = new List<Color>(){
             Color.red,
             Color.green,
             Color.yellow,
             Color.magenta,
             new Color(0F, 255F, 255F),
             new Color(255F, 255F, 0F),
             new Color(128F, 0F, 128F),
             new Color(128F, 0F, 0F)
             };

    //Change button color
    public void ChangeBttnColor()
    {
        if (i > 6)
        {
            i = 0;
        }
        obj.GetComponent<Renderer>().material.color = colorList[i + 1];
        button.GetComponent<Image>().color = colorList[i];
        i++;
    }

}
