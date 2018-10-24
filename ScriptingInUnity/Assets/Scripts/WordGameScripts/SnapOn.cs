using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapOn : MonoBehaviour
{ 

    public FloatData Speed;
    public FloatData HoldTime;
    private Vector3 position;
    private bool canRun = true;

    private void OnTriggerEnter(Collider other)
    {
        position = other.transform.position;
        
    }

    public void Call()
    {
        StartCoroutine(MoveTo());
        StartCoroutine(StopAllCoroutines());
    }

    private IEnumerator Stop()
    {
        yield return new WaitForSeconds(HoldTime.Value);
        canRun = false;
    }

    private IEnumerator MoveTo()
    {
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            transform.position = Vector3.Lerp(transform.position, GetComponentInParent.position, Speed.Value());
        }

        transform.parent = GetComponentInParent();
    }


}
