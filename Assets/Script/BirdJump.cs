using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() // 처음 한번만 동작
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() // 매프레임마다 동작
    {
        if(Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play(); // audio play
            rb.velocity = Vector2.up*5;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // collision 충돌하였을시 발생
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene"); // scene이동
    }
}
