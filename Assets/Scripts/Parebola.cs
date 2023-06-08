using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parebola : MonoBehaviour
{
    public GameObject DACANNONBALL;
    public Slider ForceSlider;
    public float LaunchForce;
    public Slider AngleSlider;
    private float LaunchAngle;
    public Vector2 LaunchDirection;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        LaunchDirection = new Vector2();
        LaunchForce = ForceSlider.value;
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        LaunchAngle = AngleSlider.value;
        LaunchDirection.x = Mathf.Cos(LaunchAngle);
        LaunchDirection.y = Mathf.Sin(LaunchAngle); 
        LaunchDirection.Normalize();
        LaunchForce = ForceSlider.value;

    }
    void Shoot()
    {
        GameObject CannonIns = Instantiate(DACANNONBALL, transform.position, transform.rotation);
        CannonIns.GetComponent<Rigidbody2D>().velocity = LaunchDirection * LaunchForce;
       // rb.AddForce(transform.forward * LaunchForce, ForceMode2D.Impulse);
    }
}
