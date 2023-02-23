using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class PlayerControl : MonoBehaviour
{

    public int force;
    public int score = 0;
    // public bool hit = true;


    // Text
    public Text score_text;

    public GameObject lose_button;

    // Animation
    public Animator animator;

    // PhotonView
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            }
        }
    }

    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Middle")
        {
            score++;
            score_text.text = score.ToString();
        }

        if(collider.gameObject.tag == "Pipe" || collider.gameObject.tag == "Ground")
        {
            //hit = true;
            animator.SetBool("hit", true);
            
            lose_button.SetActive(true);
        }
    }
}
