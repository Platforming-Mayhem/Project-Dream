using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoemCollectibleScript : MonoBehaviour
{
    [SerializeField]private string poemData = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log(poemData);
        }
    }
}
