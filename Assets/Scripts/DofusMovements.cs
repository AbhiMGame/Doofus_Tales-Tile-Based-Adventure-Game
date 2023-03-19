using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DofusMovements : MonoBehaviour
{
    [SerializeField]private int Dofus_Speed = 3;
    public AudioSource audio;
    int collisioncount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Dofus_Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Dofus_Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Dofus_Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Dofus_Speed * Time.deltaTime);
        }

        if(transform.position.y < -5)
        {
            SceneManager.LoadScene(0);
        }



    }

    private void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag.Equals("Enemy") )
        {
        
            ScoreManager.scoreamount += 1;

            audio.Play();
           
        }
    }

}

       

