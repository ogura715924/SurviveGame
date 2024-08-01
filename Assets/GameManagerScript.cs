using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameOverText;
    public TextMeshProUGUI timeText;

    private int minutes = 0;
    private int seconds = 0;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);

        Instantiate(enemy, new Vector3(0, 0, 10), Quaternion.identity);

        float x = Random.Range(-3.0f, 3.0f);
        Instantiate(enemy, new Vector3(x, 0, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOverText) { 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }

        //ŽžŠÔ
        count++;
        if (count == 60)
        {
            seconds++;
            count= 0;
        }
        if(seconds == 60)
        {
            minutes++;
            seconds= 0;
        }
        if (seconds <= 9)
        {
            timeText.text =minutes+":0"+seconds;
        }
        else
        {
            timeText.text = minutes + ":" + seconds;
        }
    }
    private void FixedUpdate()
    {
        int r = Random.Range(0, 50);
        if (r == 0)
        {
            float x = Random.Range(-3.0f, 3.0f);
            Instantiate(enemy, new Vector3(x, 0, 15), Quaternion.identity);
        }
    }

    public void GameOverStart()
    {
        gameOverText.SetActive(true);

        
    }
}
