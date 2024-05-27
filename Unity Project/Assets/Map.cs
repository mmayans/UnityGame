using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public List<Tile> tiles;

    public List<Vector3> positions;
    // Start is called before the first frame update
    void Start()
    {
        positions.Add(  new Vector3 ( 0,0,0 ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Generate(){

    }
}
