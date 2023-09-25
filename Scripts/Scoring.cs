using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{

    public Text ScoreText;
    public int score = 0;
    public int maxScore = 100;
    public GameObject level2Head;
    public GameObject level3Head;
    public GameObject SpawnerLevel2;
    public GameObject SpawnerLevel3;

    private bool level2Active = false;
    private bool level3Active = false;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void AddScore(int newScore)
    {
        score += newScore;
        if(score >= 10 && level2Active == false )
        {
            level2Head.SetActive(true);
            SpawnerLevel2.SetActive(true);
            level2Active = true;
        }
           
       else if (score >= 40 && level3Active == false)
        {
            level3Head.SetActive(true);
            SpawnerLevel3.SetActive(true);
            level3Active = true;
        }
            
       else if (score == maxScore)
             SceneManager.LoadScene(3);
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
}
