using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour
{
    int load;
   
    public Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

      
             
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "IsTrigger")
        {
            Debug.Log(1);
            load = (int)SceneManager.GetActiveScene().buildIndex + 1;
            StartCoroutine(A());

        }
    }

    IEnumerator A()
    {
        SceneManager.LoadScene(2);
        
        yield return new WaitForSeconds(1f);
       
        
    }
}
