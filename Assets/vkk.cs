using UnityEngine;

public class vkk : MonoBehaviour
{
    public GameObject loop;
    public GameObject player;
    private static float kf = 1.3f;
    private static int speed_loop = Random.Range(8, 15);
    float timeLeft;
    void Start()
    {
        player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        loop.GetComponent<Rigidbody2D>().velocity = Vector2.up * (-1) * speed_loop;
    }

    void OnTriggerEnter2D(Collider2D p)
    {
        Move.speed *= kf;
        player.transform.localScale -= player.transform.localScale * 0.09f;
        loop.transform.position = new Vector2(Random.Range(10, 20), Random.Range(-15, 15));
    }

    void Update()
    {
        if (loop.transform.position.y < -8)
        {
            loop.transform.position = new Vector2(Random.Range(-14, 14), Random.Range(10, 20));
            loop.GetComponent<Rigidbody2D>().velocity = Vector2.up * (-1) * Random.Range(1, 8);
        }
    }
}
