using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

    private GameObject player; //Переменна объекта персонажа с которым будем работать. 
    public GameObject MainCamera;
    public static float speed = 14; //Скорость перемещения персонажа. Запись public static обозначает что мы сможем обращаться к этой переменной из любого скрипта 
    public static float _speed; //постоянная скорость перемещения персонажа 
    private static float speed2=1f;
    float maxLength = 4.5f;

    void Start()
    { //По умолчанию оружие у нас спрятано. 
        //Задаем постоянное стандартное значение скорости персонажа 
        player = (GameObject)gameObject;//Задаем что наш персонаж это объект на котором расположен скрипт 
        
    }

    void Update()
    {
            Vector3 plpos = player.transform.position;
            if (player.transform.position.x>17.5f || player.transform.position.x < -17.5f)
            {
            player.transform.position = new Vector3(-plpos.x,plpos.y,plpos.z);
            }
            if (player.transform.position.y>=8.5f || player.transform.position.y <= -8.5f)
            {
             player.transform.position = new Vector3(plpos.x, -plpos.y, plpos.z);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))      //Если нажать W 
            {
                player.transform.position += player.transform.up * speed * Time.deltaTime; //Перемещаем персонажа в перед, с заданой скорость. Time.deltaTime ставится для плавного перемещения персонажа, если этого не будет он будет двигаться рывками 
                player.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed2;
            }
            if (Input.GetKey(KeyCode.S))
            {
                player.transform.position -= player.transform.up * speed * Time.deltaTime; //Перемещаем назад 
                 player.GetComponent<Rigidbody2D>().velocity = Vector2.up * speed2 * (-1);
            }
            if (Input.GetKey(KeyCode.A))
            {
                
                player.transform.position -= player.transform.right * speed * Time.deltaTime; //перемещаем влево 
                player.GetComponent<Rigidbody2D>().velocity = Vector2.right * speed2 * (-1);
            }
            if (Input.GetKey(KeyCode.D))
            {
                GetComponent<Rigidbody2D>().velocity = (Vector2.right * speed2);
                player.transform.position += player.transform.right * speed * Time.deltaTime; //перемещаем вправо 
            }
             if (Input.GetKey(KeyCode.Space))
            {
                while (player.transform.localScale == new Vector3(1.5f, 1.5f, 1.5f))
                {
                    player.transform.localScale += player.transform.localScale * Time.deltaTime;
                }
            }

            if (player.transform.localScale.z > maxLength )
            {
                player.SetActive(false);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                speed /=100;
            }
            
    }
}