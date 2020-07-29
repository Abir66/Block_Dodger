
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject spawn;
    GameObject[] gameObjects;
    public bool ended = false;
    public float endDealy = 1f;
    public void Endgame()
    {
        if (ended == false)
        {
            ended = true;
            Destroy(spawn);

            gameObjects = GameObject.FindGameObjectsWithTag("Obstacle");

           
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
                //gameObjects[i].GetComponent<ObstacleMovement>().enabled = false;
            }

            Invoke("credits", endDealy);
        }
    }

    void credits()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
