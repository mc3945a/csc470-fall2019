using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private Transform Thistransform;
    // Start is called before the first frame update
    void Start()
    {
        target = GameManager.instance.player.transform;
        Thistransform = this.transform; //GetComponent(transform)
    }

    // Update is called once per frame
    void Update()
    {
        Thistransform.LookAt(target);
        Thistransform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
