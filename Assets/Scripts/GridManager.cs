using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject circle;
    public int rows = 3;
    public int cols = 3;
    public float tileSize = 1;
    [SerializeField]
    public Vector2 gridSize;
    [SerializeField]
    public Vector2 gridOffset;

    private Vector2 cellSize;
    private Vector2 cellScale;

    public GameObject[] circles;


    
    void Start()
    {
        GenerateGrid();
    }

    
    //Create Grids
    public void GenerateGrid()
    {
        DestroyGrid();
        int i = 0;
        circles = new GameObject[rows*cols];
        var referenceTile = Instantiate(circle);
        Vector2 newCellSize = new Vector2(gridSize.x / (float)cols, gridSize.y / (float)rows);
        cellScale.x = newCellSize.x / cellSize.x;
        cellScale.y = newCellSize.y / cellSize.y;
        cellSize = newCellSize;
        gridOffset.x = -(gridSize.x / 2) + cellSize.x / 2;
        gridOffset.y = -(gridSize.y / 2) + cellSize.y / 2;
        //Create(Clones)
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector2 pos = new Vector2(col * cellSize.x + gridOffset.x + transform.position.x + cols - 1, row * cellSize.y + gridOffset.y + transform.position.y - rows + 1);
                circles[i] = Instantiate(referenceTile, pos, Quaternion.identity) as GameObject;
                circles[i].transform.parent = transform;
                circles[i].name = "Circle" + (i + 1);
                i++;
            }
        }
        Destroy(referenceTile);
        float gridW = cols * tileSize - 2;
        float gridH = rows * tileSize + 2;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2 - 1, gridH / 2 - tileSize / 2 - 1);

    }

    //Destroy Grid
    public void DestroyGrid()
    {
        int j = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Destroy(GameObject.Find("Circle" + (j + 1)));
                j++;
            }
        }


    }



}
