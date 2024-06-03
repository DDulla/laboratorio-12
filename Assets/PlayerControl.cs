using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int velocidadX;
    public float horizontal;
    public int velocidadY;
    public float vertical;
    private Rigidbody2D Movimiento;
    private void Awake()
    {
        Movimiento = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Movimiento.velocity = new Vector2(velocidadX * horizontal, velocidadY * vertical);
    }
}
