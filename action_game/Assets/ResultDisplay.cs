using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultDisplay : MonoBehaviour
{
    public GameObject ClearText;

    // Start is called before the first frame update
    void Start()
    {
        ClearText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            // ARRANGE:ゴールに触れた時の処理を書く
            ClearText.SetActive(true);
        }

    }
}
