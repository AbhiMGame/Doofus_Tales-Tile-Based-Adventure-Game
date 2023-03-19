using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class Pulpit_Manager : MonoBehaviour
{

    [SerializeField]
    public GameObject Pulpit_Spawn;
    public TextMesh Destroycountdown_Text;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    // public Vector3 origin = Vector3.zero;
    public Vector3 currentPosition;
    public Vector3 nextPosition;
    



    public void Start()
    {
      StartCoroutine(StartTimer());
        currentPosition = transform.position;
        
    }

       public IEnumerator StartTimer(float TimeRemaining = 5.0f)
        {
                   List<Vector3> vectorrandom = new List<Vector3>();
                   vectorrandom.Add(new Vector3(9f, 0f, 0f));
                   vectorrandom.Add(new Vector3(0f, 0f, 9f));
                   vectorrandom.Add(new Vector3(-9f, 0f, 0f));
                   vectorrandom.Add(new Vector3(0f, 0f, -9f));
        //vectorrandom.Add(new Vector3(9f, 0f, 9f));
        vectorrandom.Add(new Vector3(-9f, 0f, -9f));

        int index = Random.Range(0, 4);

                   Vector3 RandomVectorSpawnOffset = vectorrandom.ElementAt(index);

                   nextPosition = currentPosition + RandomVectorSpawnOffset;
                  

                 //  Vector3 randomPosition = new Vector3(
                 //Random.Range(minPosition.x + 4.5f, maxPosition.x + 4.5f),
                 //Random.Range(minPosition.y + 4.5f, maxPosition.y + 4.5f),
                 //  Random.Range(minPosition.z + 4.5f, maxPosition.z + 4.5f));

        for (float i = TimeRemaining; i > 0; i--)
            {
            nextPosition = currentPosition + RandomVectorSpawnOffset;
            Destroycountdown_Text.text = i.ToString("00");
                yield return new WaitForSeconds(1f);
                
                if (i == 3.0f)
                {
                    Instantiate(Pulpit_Spawn, nextPosition, Quaternion.identity);
                     
                }
            }
            Destroy(gameObject);
        }
    
}




