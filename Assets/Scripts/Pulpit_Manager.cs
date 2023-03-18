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
    

    public void Start()
    {
      StartCoroutine(StartTimer());       
    }

   
    public IEnumerator StartTimer(float TimeRemaining = 5.0f)
    {
        Vector3 randomPosition = origin + new Vector3(
             Random.Range(minPosition.x, maxPosition.x),
             Random.Range(minPosition.y, maxPosition.y),
             Random.Range(minPosition.z, maxPosition.z));

        for (float i = TimeRemaining; i > 0; i--)
        {
            Destroycountdown_Text.text = i.ToString("00");
            yield return new WaitForSeconds(1f);
            if (i == 3.0f)
            {
                Instantiate(Pulpit_Spawn, randomPosition, Quaternion.identity);
            }
        }
        Destroy(gameObject);
    }

}




