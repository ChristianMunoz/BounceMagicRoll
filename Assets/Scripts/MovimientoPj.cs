using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPj : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    Rigidbody rb;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movHorizontal = Input.GetAxis("Horizontal")*velocidad;
        Vector3 mov = new Vector3(movHorizontal*Time.deltaTime, 0, 0);
        //transform.Translate(mov);
        rb.AddForce(mov);
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 vo = rb.velocity;
            vo.y = 10;
            rb.velocity = vo;
        }
    }
}
