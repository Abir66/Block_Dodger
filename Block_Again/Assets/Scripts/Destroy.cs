
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject obstacles;
   
    // Update is called once per frame
    void Update()
    {
        float pos = rb.position.z;
        float pos2 = rb.position.y;
        if (pos < -1000 || pos2<= -50)
        {
            Destroy(obstacles);
        }
    }
}
