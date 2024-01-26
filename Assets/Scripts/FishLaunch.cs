using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FishLaunch : MonoBehaviour
{
 public GameObject[] Target;
    public Transform[] transforms;
    public GameObject target;
    public float hforce;
    public float vForce;

    void LaunchEvent(int v)
    {
        GameObject go = Instantiate(Target[v], transforms[v].position + Vector3.up * .2f * v, transforms[v].rotation);
        go.GetComponent<Rigidbody>().AddForce((target.transform.position - go.transform.position) * hforce + Vector3.up * vForce, ForceMode.VelocityChange);
    }

   
}
