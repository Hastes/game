using UnityEngine;
using System.Collections;

public class clone : MonoBehaviour {
    float timeLeft = 3.0f;
    float time = 0;
    int ttime = 0;
    public GameObject lp;
    // Use this for initialization
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Очков " + ttime);
    }
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        ttime = (int)time;
        time += Time.deltaTime;
        timeLeft -= Time.deltaTime;
        if (timeLeft<0)
        {
            GameObject loops = (GameObject)Instantiate(lp, new Vector3(Random.Range(-14, 14),Random.Range(10,20),0), Quaternion.identity);
            timeLeft = 4.0f;
        }
	}
}
