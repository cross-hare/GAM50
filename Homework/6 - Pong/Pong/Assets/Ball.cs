using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text scoreboard1;
    public Text scoreboard2;
    public float speed = 5f;
    private int score1 = 0;
    private int score2 = 0;
    public float sx = -0.09f;
    public float sy = 1.23f;
    public GameObject pong = null;
    public GameObject triggerL = null;
    public GameObject triggerR = null;

    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (pong.transform.position.x >= -6.35f)
        {
            score1++;
        }
        if (pong.transform.position.x <= 6.7f)
        {
            score2++;
        }

        scoreboard1.text = score1.ToString();
        scoreboard2.text = score2.ToString();
        
        /*float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        float botBound = -2.25f;
        float topBound = 4.10f;
        var pos = transform.position;*/

        /*if (pos.y > topBound)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed * sy, 0f);
        }
        else if (pos.y < botBound)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed * sy, 0f);
        }
        transform.position = pos;*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == triggerL)
        {
            score1++;
        }

        if(other == triggerR)
        {
            score2++;
        }

        scoreboard1.text = score1.ToString();
        scoreboard2.text = score2.ToString();

        var pos = pong.transform.position;
        pos.y = sy;
        pos.x = sx;
        print("Score!");
    }

}
