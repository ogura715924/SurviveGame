using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameOverText;

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
