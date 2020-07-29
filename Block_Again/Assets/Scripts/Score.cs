
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float elapsedTime = 0f;
    float score = 0f;
    public Text scoreText;
    bool running;
    bool ender;

    // Update is called once per frame
    private void Start()
    {
        running = true;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;

        ender = FindObjectOfType<GameManager>().ended;
        if (ender) running = false;


        if(elapsedTime >= 0.1 && running)
        {
            elapsedTime = 0;
            score += 1;
        }

        scoreText.text = score.ToString("0");
        
    }
}
