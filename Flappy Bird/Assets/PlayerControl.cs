using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    public int force;
    public int score = 0;

    //Text
    public Text score_text;

    public GameObject lose_button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
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

        if(collider.gameObject.tag == "Pipe")
        {
            lose_button.SetActive(true);
        }
    }
}
