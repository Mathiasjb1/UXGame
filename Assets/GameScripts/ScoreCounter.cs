using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    //[SerializeField] public TextMeshProUGUI countDown;
    //[SerializeField] private float startingTime;
    //float currentTime = 0f;

    public TextMeshProUGUI ScoreText;
    public int score = 0;
    public int maxScore;

    public GameObject Score;
    public GameObject YouText;
    public GameObject UwUPic;
    public GameObject youWin;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //currentTime = startingTime;
    }

    public void Addscore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score " + score + "/ 9";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        

        if (score == maxScore)
        {
            //Score.SetActive(false);
            GameWin();
        }
    }

    public void StartGameTimer()
    {
        //currentTime -= 1 * Time.deltaTime;

        //if (currentTime <= 0)
        //{
        //    currentTime = 0;
        //    GameWin();
        //}

    }

    public void GameWin()
    {
        YouText.SetActive(true);
        
        youWin.SetActive(true);
    }
}
