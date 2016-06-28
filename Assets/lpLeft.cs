using UnityEngine;
using System.Collections;

public class lpLeft : MonoBehaviour
{
    public GameObject loop;
    public GameObject player;
    private static float kf = 1.3f;
    
    float timeLeft;
    void Start()
    {
        loop.GetComponent<Rigidbody2D>().velocity = Vector2.left * Random.Range(1,8);
    }

    void OnTriggerEnter2D(Collider2D p)
    {

        Move.speed /= kf;
        player.transform.localScale += player.transform.localScale * 0.09f;
        loop.transform.position = new Vector2(Random.Range(18, 23), Random.Range(6, -6));
    }

    void Update()
    {
        if (loop.transform.position.x < -18)
        {
            loop.transform.position = new Vector2(Random.Range(18, 23),Random.Range(6, -6));
            loop.GetComponent<Rigidbody2D>().velocity = Vector2.left * Random.Range(1, 8);
        }
    }
}
