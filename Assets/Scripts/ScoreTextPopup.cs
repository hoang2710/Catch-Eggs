using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextPopup : MonoBehaviour
{
    [SerializeField]
    TMP_Text scoreText;
    public float TTL = 0.5f;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.SetParent(GameObject.Find("Text Pop Canvas").transform);
        Destroy(this.gameObject, TTL);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up* Time.deltaTime;
        scoreText.text = score.ToString();
    }
}
