using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadScript : MonoBehaviour
{
    CircleData data;

    private string file = "save.txt";

    GridManager man;

    //Save data
    public void Save()
    {
      
        man = GetComponent<GridManager>();
        foreach (GameObject obj in man.circles)
        {
            data = GetComponent<CircleData>();
            data.circlename = obj.name;
            data.color = obj.GetComponent<Renderer>().material.color;
            string json = JsonUtility.ToJson(data);
            WriteToFile(json);
        }
    }

    //Write To File
    void WriteToFile(string json)
    {
        StreamWriter writer = new StreamWriter( Application.persistentDataPath + "/" + file,true);
        Debug.Log(json);
        writer.WriteLine(json);
        writer.Close();


    }

}
