using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject monkey;
    Rigidbody rb;
    public float speed=100f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        Vector3 dir=monkey.transform.position-transform.position;
        dir.Normalize();
        rb.velocity=dir*speed;
    }
    void OnCollisionEnter(Collision other){
        //モンキーが消える
        Destroy(other.gameObject,0.1f);
        //爆発のエフェクト発動
        Instantiate(explosion,transform.position+Vector3.down*18f,Quaternion.identity);
        //自分が消える
        Destroy(gameObject,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
