using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] levels;
    public float spawnpoint = 30f;
    public float spawntime = 1f;
    float elapsedtime = 0f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        elapsedtime += Time.deltaTime;

        if(elapsedtime >= spawntime)
        {
            spawn();
            elapsedtime = 0;
        }

    }

    void spawn()
    {
        int i = Random.Range(0, 8);
        float x;
        if (i <= 4)
        {
            x = -6f;
        }
        else if (i < 7)
        {
            x = 0f;
        }
        else
        {
            x = 6f;
        }

        Vector3 pos = new Vector3(x, 1, spawnpoint);

        Instantiate(levels[i], pos, Quaternion.identity);
        Debug.Log(i);
    }
}
