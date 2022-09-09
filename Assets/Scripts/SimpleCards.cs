using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCards : MonoBehaviour
{
    [SerializeField] GameObject simpleCard01;
    [SerializeField] GameObject simpleCard02;


    [SerializeField] bool isSpawning = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SimpleCardSpawne()
    {
        if (isSpawning == false)
        {
            simpleCard01.GetComponent<Animator>().Play("SimpleCard01");
            yield return new WaitForSeconds(.5f);
            simpleCard02.GetComponent<Animator>().Play("SimpleCard02");
        }
        isSpawning = true;
    }
}
