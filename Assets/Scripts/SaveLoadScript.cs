using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadScript : MonoBehaviour
{
    Grids data;

    string path = "/home/work/PuzzleProjects/Assets/Resources/Files/";
    private string file = "save.txt";

    GridManager man;

    //Save data
    public void Save()
    {
      
        man = GetComponent<GridManager>();
        foreach (GameObject obj in man.tiles)
        {
            data = GetComponent<Grids>();
            data.gridname = obj.name;
            data.color = obj.GetComponent<Renderer>().material.color;
            string json = JsonUtility.ToJson(data);
            WriteToFile(json);
        }
    }

    //Write To File
    void WriteToFile(string json)
    {
        StreamWriter writer = new StreamWriter(@path + file,true);
        Debug.Log(json);
        writer.WriteLine(json);
        writer.Close();


    }

}
