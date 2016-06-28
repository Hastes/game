using UnityEngine;
using System.Collections;

public class lp : MonoBehaviour {
    public GameObject loop;
    public GameObject player;
    public bool trigger = false;
    private static float kf = 1.3f;
    private static int speed_loop = Random.Range(1,8);
    float timeLeft;
    void Start()
    {
        loop.GetComponent<Rigidbody2D>().velocity = Vector2.up * (-1) * 3;
    }

        void OnTriggerEnter2D(Collider2D p)
        {
        
            Move.speed /= kf;
            player.transform.localScale += player.transform.localScale*0.09f;
            loop.transform.position = new Vector2(Random.Range(40,60), Random.Range(-15,15));
        }
        
        void Update()
        {
        if (loop.transform.position.y<-8)
        {
            loop.transform.position = new Vector2(Random.Range(-14,14),Random.Range(10,20));
            loop.GetComponent<Rigidbody2D>().velocity = Vector2.up * (-1) * Random.Range(1,8);
        }
    }
}
