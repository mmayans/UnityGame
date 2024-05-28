using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;



public class Map : MonoBehaviour
{
    public TMP_Text Tilecount;


    public List<TileHolder> tiles;

    public List<Vector3> positions;

    public TileHolder[] tileTemplates;

    int index = 1;

    public MeshFilter[] mfs;

    private System.Random randomGenerator = new System.Random();

    // Start is called before the first frame update
void Start()
{
    positions.Add(new Vector3(0, 0, 0));
    Generate();
    Generate();
    Generate();
    Generate();
    Generate();

    foreach(Vector3 p in positions)
    {
        int randomNumber = GetRandomNumber(0, 3);
        TileHolder tileTemplate = tileTemplates[randomNumber]; // Use Next instead of next
        TileHolder tileHolder = Instantiate(tileTemplate, p, Quaternion.identity) as TileHolder;
        tiles.Add(tileHolder);
    }

    foreach(TileHolder t in tiles)
    {
        t.t.self.SetActive(false);
        t.empty.SetActive(false);
    }

    tiles[0].t.self.SetActive(true);
}

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateNext();
        }
    }

    void ActivateNext(){
        tiles[index].t.self.SetActive(true);
        index ++;
        Tilecount.text=("Tiles:"+index.ToString());
    }

    void Generate()
    {
        List<Vector3> newpositions = new List<Vector3>(positions);

        foreach (Vector3 p in positions)
        {
            Vector3 A = new Vector3(p.x + 1, p.y, p.z);
            Vector3 D = new Vector3(p.x - 1, p.y, p.z);
            Vector3 B = new Vector3(p.x + 0.5f, p.y, p.z + 0.866f);
            Vector3 F = new Vector3(p.x + 0.5f, p.y, p.z - 0.866f);
            Vector3 C = new Vector3(p.x - 0.5f, p.y, p.z + 0.866f);
            Vector3 E = new Vector3(p.x - 0.5f, p.y, p.z - 0.866f);

            A = RoundVector3ToNearest0_001(A);
            B = RoundVector3ToNearest0_001(B);
            C = RoundVector3ToNearest0_001(C);
            D = RoundVector3ToNearest0_001(D);
            E = RoundVector3ToNearest0_001(E);
            F = RoundVector3ToNearest0_001(F);



            if(!newpositions.Contains(A)){
                newpositions.Add(A);
            }

            if(!newpositions.Contains(B)){
                newpositions.Add(B);
            }

            if(!newpositions.Contains(C)){
                newpositions.Add(C);
            }

            if(!newpositions.Contains(D)){
                newpositions.Add(D);
            }

            if(!newpositions.Contains(E)){
                newpositions.Add(E);
            }
            if(!newpositions.Contains(F)){
                newpositions.Add(F);
            }
        }

        positions = newpositions;
    }



    Vector3 RoundVector3ToNearest0_001(Vector3 vector)
    {
        float roundedX = Mathf.Round(vector.x * 1000f) / 1000f;
        float roundedY = Mathf.Round(vector.y * 1000f) / 1000f;
        float roundedZ = Mathf.Round(vector.z * 1000f) / 1000f;
        return new Vector3(roundedX, roundedY, roundedZ);
    }

    void GenerateTiles(){

    }

    private int GetRandomNumber(int min, int max)
    {
        return randomGenerator.Next(0, 3);
    }
}

