using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class Grids
{

    private int height;
    private int width;
    private int[,] gridArray;
    

    public Grids(int width, int height)
    {
        this.height = height;
        this.width = width;

        gridArray= new int[width,height];

        for (int x = 0; x<gridArray.GetLength(0); x++)
        {
            for (int y = 0; y<gridArray.GetLength(1); y++)
            {
               // UtilsClass.CreateWorldText(gridArray(x,y))
            }
        }

    }


}//class















