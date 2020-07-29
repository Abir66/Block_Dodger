using UnityEngine;


public class TestSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject player;
    public Vector3 offset;
    void Update()
    {

        Vector3 pos = player.transform.position + offset;
        
        Instantiate(obstacle, pos, Quaternion.identity );
        Debug.Log("done");
    }
}
