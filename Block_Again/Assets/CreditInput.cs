
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditInput : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("GamePlay");
         
        }


        if (Input.GetKey("enter")) 
        {
            SceneManager.LoadScene("GamePlay");

        }
        else if (Input.GetKey("escape"))
        {
            Application.Quit();
            
        }

    }
}
