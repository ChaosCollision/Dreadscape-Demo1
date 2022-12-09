using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("EndEffect",1f);
    }

    // Update is called once per frame
    void EndEffect()
    {
        Destroy(gameObject);
    }
}
