using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField]
    int eggPoint = 10;
    public GameObject ScoreTextPopupPrefab;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameController.GetScore(eggPoint);
            GameObject gj = Instantiate(ScoreTextPopupPrefab, transform.position, Quaternion.identity);
            gj.GetComponent<ScoreTextPopup>().score = eggPoint;
            Destroy(this.gameObject);
        }
        else
        if (other.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }
    }
}
