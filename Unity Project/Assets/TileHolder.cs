using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHolder : MonoBehaviour
{

    public Tile t;
    public GameObject empty;


    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mine()
    {
        t.full.SetActive(false);
        t.gameObject.SetActive(false);
        empty.SetActive(true);
        active = false;
        StartCoroutine(ExampleCoroutine());
    }

     IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
        t.gameObject.SetActive(true);
        t.full.SetActive(true);
        empty.SetActive(false);
        
        active = true;
    }
}
