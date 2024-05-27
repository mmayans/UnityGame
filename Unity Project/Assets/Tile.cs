using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{


    public Vector3 position;

    public MeshRenderer Mesh;

    public GameObject self;


    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
