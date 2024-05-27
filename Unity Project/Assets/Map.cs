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
        positions.Add(new Vector3(0, 0, 0));
        Generate();
        Generate();
        Generate();
        Generate();
        Generate();
      
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        List<Vector3> newpositions = new List<Vector3>(positions);

        foreach (Vector3 p in positions)
        {
            Vector3 A = new Vector3(p.x + 1, p.y, p.z);
            Vector3 B = new Vector3(p.x - 1, p.y, p.z);
            Vector3 C = new Vector3(p.x + 0.5f, p.y, p.z + 0.866f);
            Vector3 D = new Vector3(p.x + 0.5f, p.y, p.z - 0.866f);
            Vector3 E = new Vector3(p.x - 0.5f, p.y, p.z + 0.866f);
            Vector3 F = new Vector3(p.x - 0.5f, p.y, p.z - 0.866f);

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
}

