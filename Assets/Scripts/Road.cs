using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public GameObject RoadPrefeb;
    public float Offset = 0.698f;
    public Vector3 lastpos;
    public int roadCount=0;
    public void StartBuilding()
    {
        InvokeRepeating("CreatePrefeb", 1f, 0.3f);
    }

    public void CreatePrefeb()
    {
        
        Vector3 spawnPos = Vector3.zero;
        float chance = Random.Range(0, 100);
        if (chance > 50)
        {
            spawnPos = new Vector3(lastpos.x + Offset, lastpos.y, lastpos.z + Offset);
        }
        else
        {
            spawnPos = new Vector3(lastpos.x - Offset, lastpos.y, lastpos.z + Offset);
        }
        GameObject g=Instantiate(RoadPrefeb,spawnPos,Quaternion.Euler(0,45,0));
        lastpos = g.transform.position;
        roadCount++;
        if (roadCount % 5 == 0)
        {
            g.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
