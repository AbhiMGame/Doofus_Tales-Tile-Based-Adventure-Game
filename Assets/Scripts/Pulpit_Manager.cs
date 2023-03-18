using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pulpit_Manager : MonoBehaviour
{

    [SerializeField]
    public GameObject Pulpit_Spawn;
    public TextMesh Destroycountdown_Text;


    IEnumerator timer;

    public void Start()
    {

        StartCoroutine(StartTimer());
        
    }

    
    public IEnumerator StartTimer(int TimeRemaining = 5)
    {
        for (int i = TimeRemaining; i > 0; i--)
        {
            Destroycountdown_Text.text = i.ToString("00");
            yield return new WaitForSeconds(1f);

        }
        
        transform.localPosition = new Vector3(6, 0, 0);

        Instantiate(Pulpit_Spawn, transform.localPosition, Quaternion.identity);

        StartCoroutine(StartTimer());
        Destroy(gameObject, 2.5f);
    }
    
}
