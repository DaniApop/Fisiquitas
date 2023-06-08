using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
 
    private void Start()
    {
     
        StartCoroutine(DestroyAfterDelay(5f));
    }

    private IEnumerator DestroyAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        
            Destroy(gameObject);
        
    }

   
}


