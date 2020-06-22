using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    SaveLoadScript save;
    public GameObject GridBackround;
    GridManager gridManager;

    Vector2 columnvector;
    Vector2 rowvector;

    private void Start()
    {
        columnvector = new Vector2(0.005f, 0);
        rowvector = new Vector2(0, 0.008f);
        spriteRenderer = GridBackround.GetComponent<SpriteRenderer>();
        gridManager = GetComponent<GridManager>();
        save = GetComponent<SaveLoadScript>();
    }

    //Add Column
    public void AddColumn()
    {
        if (gridManager.cols < 7)
        {
            spriteRenderer.size = spriteRenderer.size + columnvector;
            gridManager.cols += 1;
            gridManager.GenerateGrid();
        }

    }

    //Remove Column
    public void RemoveColumn()
    {
        if (gridManager.cols > 3)
        {
            spriteRenderer.size = spriteRenderer.size - columnvector;
            gridManager.DestroyGrid();
            gridManager.cols = gridManager.cols - 1;
            gridManager.GenerateGrid();
        }

    }

    //Add Row
    public void AddRow()
    {
        if (gridManager.rows < 6)
        {
            spriteRenderer.size = spriteRenderer.size + rowvector;
            gridManager.rows += 1;
            gridManager.GenerateGrid();
        }

    }

    //Remove Row
    public void RemoveRow()
    {
        if (gridManager.rows > 3)
        {
            spriteRenderer.size = spriteRenderer.size - rowvector;
            gridManager.DestroyGrid();
            gridManager.rows = gridManager.rows - 1;
            gridManager.GenerateGrid();
        }

    }

    public void Save()
    {
        save.Save();
    }


}
