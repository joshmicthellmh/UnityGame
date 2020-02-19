using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    public float MoveSpeed;
    public float JumpForce;
    public float GravityScale;
    public Text scoreText;
    public Text LifeText;
    public CharacterController Controller;
    private Vector3 MoveDirection;
    private int score1;
    private int score2;
    private int score3;
    public static int globalScore;
    public static int globalLives = 5;


    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        scoreText.text = globalScore.ToString();
        LifeText.text = globalLives.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        //Arrow key movement
        MoveDirection = new Vector3(Input.GetAxis("Vertical") * MoveSpeed, MoveDirection.y, Input.GetAxis("Horizontal") * MoveSpeed);
        //Jump Move
        if (Controller.isGrounded)
        {
            MoveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                MoveDirection.y = JumpForce;
            }
        }
    

        MoveDirection.y = MoveDirection.y + (Physics.gravity.y * Time.deltaTime * GravityScale);
        Controller.Move(MoveDirection * Time.deltaTime);
                     
    }

    void OnTriggerEnter(Collider other)
    {
     
        if (other.gameObject.tag == "Coin1")
        {
            score1++;
            globalScore++;
            scoreText.text = globalScore.ToString();
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "Coin2")
        {
            score2++;
            globalScore++;
            scoreText.text = globalScore.ToString();
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "Coin3")
        {
            score3++;
            globalScore++;
            scoreText.text = globalScore.ToString();
            other.gameObject.SetActive(false);

        }
        //Code to move to the next Leval. 
        if (other.gameObject.name == "EndBlock")
        {
            SceneManager.LoadScene("Leval2");
        }
        if (other.gameObject.name == "EndBlock2")
        {
            SceneManager.LoadScene("Leval3");
        }
        if (other.gameObject.name == "EndBlock3")
        {
            SceneManager.LoadScene("Winner");
        }
        //on colition with these veriables the game will reset
        //level one 
        if (other.gameObject.tag == "Hazard1" || other.gameObject.tag == "Net1")
        {
            globalLives--;
            RestartGame();
            
        }
        //level two
        if (other.gameObject.tag == "Hazard2" || other.gameObject.tag == "Net2")
        {
            globalLives--;
            RestartGameL2();
        }
        //level three
        if (other.gameObject.tag == "Hazard3" || other.gameObject.tag == "Net3")
        {
            globalLives--;
            RestartGameL3();
        }

    }

    //Game over level one RESET code//
    void RestartGame()
    {
        if (globalLives == 0)
        {

            SceneManager.LoadScene("EndGame");
            globalScore = 0;
            globalLives = 5;
            Debug.Log("Level 1 Reset!");
   
        }
        else
        {
            globalScore = globalScore - score1;
            SceneManager.LoadScene("Leval1");

        }
    }
   //Game over level 2 RESET code. // 
    void RestartGameL2()
    {
        if (globalLives == 0)
        {
            SceneManager.LoadScene("EndGame");
            globalScore = 0;
            globalLives = 5;
            Debug.Log("Level 2 Reset!");
        }
        else
        {
            globalScore = globalScore - score2;
            SceneManager.LoadScene("Leval2");
         
            
        }
    }
    //Game over level 2 RESET code. // 
    void RestartGameL3()
    {
        if (globalLives == 0)
        {
            SceneManager.LoadScene("EndGame");
            globalScore = 0;
            globalLives = 5;
            Debug.Log("Level 3 Reset!");
        }
        else
        {
            globalScore = globalScore - score3;
            SceneManager.LoadScene("Leval3");
           
        }
    }



}
