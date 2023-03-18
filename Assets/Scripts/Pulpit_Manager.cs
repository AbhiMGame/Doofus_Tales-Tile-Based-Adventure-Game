using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pulpit_Manager : MonoBehaviour
{

    [SerializeField]
    public GameObject Pulpit_Spawn;
    public TextMesh Destroycountdown_Text;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public Vector3 origin = Vector3.zero;

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
        Vector3 randomPosition = origin + new Vector3(
       Random.Range(minPosition.x, maxPosition.x),
       Random.Range(minPosition.y, maxPosition.y),
       Random.Range(minPosition.z, maxPosition.z)

   );

        Instantiate(Pulpit_Spawn, randomPosition , Quaternion.identity);

        StartCoroutine(StartTimer());
        Destroy(gameObject, 0.5f);
    }
    

   



}
