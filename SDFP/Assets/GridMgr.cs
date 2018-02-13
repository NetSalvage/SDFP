using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridMgr : MonoBehaviour {
    /* PROBABLY?
     * This script manages the grid.
     * As rough as it looks, I should follow what I did on Dustin's project, effectively - instantiate prefabs as children, and the prefabs are composed of af ew things.
     */

    float cellWidth;
    float spacer = 0.1f; //the space between cells
    public int columns; //TODO: set otherwise
    public int rows; //TODO: set otherwise

    // Use this for initialization
    void Start () {
        
        GridGen();
	}

    void GridGen()
    {
        //new Image  Component
        
    }
}
