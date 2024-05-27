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
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Generate(){
        List<Vector3> newpositions = new List<Vector3>();
        newpositions = positions;

        foreach(Vector3 p in positions){
            Vector3 A=new Vector3(p.x+1, p.y, p.z);
            Vector3 B=new Vector3(p.x-1, p.y, p.z);
            Vector3 C=new Vector3(p.x+.5f, p.y, p.z+.866f);
            Vector3 D=new Vector3(p.x+.5f, p.y, p.z-.866f);
            Vector3 E=new Vector3(p.x-.5f, p.y, p.z+.866f);
            Vector3 F=new Vector3(p.x-.5f, p.y, p.z-.866f);
            newpostions.Add(A,B,C,D,E,F);
        }  
        positions= newpostions;
    }
}
