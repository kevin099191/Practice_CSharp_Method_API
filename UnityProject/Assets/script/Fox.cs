
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"),Range(1,40)]
    public int Speed;
    public Rigidbody2D  Rig;
    public SpriteRenderer sr;
    private float Fspeed = 10.0f;
    public bool flipX;


    private void Update()
    {
        Move();
        Rig.AddForce(transform.up * Fspeed);
    }

    private void Start()
    {
        
    }

    private void Move()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Translate(speed*Speed, 0, 0);
     
    }

    private void AddF()
    {

        Rig = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector2(5.0f,0.0f);

    }



}
