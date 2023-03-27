using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public bool startGame;
    //public int randomNumber;
    
    
    //[SerializeField] private GameObject t1Blue;
    //[SerializeField] private GameObject t1Yellow;
    //[SerializeField] private GameObject t1Pink;

    //[SerializeField] private GameObject t2Blue;
    //[SerializeField] private GameObject t2Yellow;
    //[SerializeField] private GameObject t2Pink;

    //[SerializeField] private GameObject t3Blue;
    //[SerializeField] private GameObject t3Yellow;
    //[SerializeField] private GameObject t3Pink;

    //------------------------------------------
    [SerializeField] private Animator targets1Controller;
    [SerializeField] private Animator targets2Controller;
    [SerializeField] private Animator targets3Controller;

    //[SerializeField] private Animator t1Blueanim;
    //[SerializeField] private Animator t1Yellowanim;
    //[SerializeField] private Animator t1Pinkanim;

    //[SerializeField] private Animator t2Blueanim;
    //[SerializeField] private Animator t2Yellowanim;
    //[SerializeField] private Animator t2Pinkanim;

    //[SerializeField] private Animator t3Blueanim;
    //[SerializeField] private Animator t3Yellowanim;
    //[SerializeField] private Animator t3Pinkanim;
    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
        //randomNumber = Random.Range(1, 3);
        //Debug.Log(randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(startGame);
        if (startGame == true)
        {
            StartTheGame();
        }
    }

    public void StartTheGame()
    {
        targets1Controller.SetBool("GameIsON?", true);
        targets2Controller.SetBool("GameIsON?", true);
        targets3Controller.SetBool("GameIsON?", true);
        //targets2Controller.SetBool("GameIsON?", true);
        //targets3Controller.SetBool("GameIsON?", true);

        //if (randomNumber == 1)
        //{
        //    targets1Controller.SetInteger("GameLine", 1);
            
        //} 
        //else if (randomNumber == 2)
        //{
        //    targets1Controller.SetInteger("GameLine", 2);
        //}
    }
}
