using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootHealing : MonoBehaviour
{
    [SerializeField] public Vector3 InitPos;
    [SerializeField] public float TravelSpeed;
    [SerializeField] public Vector3 StartPos;
    public GameObject ExplodeEffect;

    public bool IsAtEnd;
    Vector3 Target;

    [SerializeField] public Vector3 firePos;
    public TextAsset JsonInfo;
    //[SerializeField] public float Step;


    // Start is called before the first frame update
    void Awake()
    {

        //take data from Ability sheet + class sheet
        TravelSpeed = 5f;


        StartPos = new Vector3(InitPos.x, 3, InitPos.z);



        IsAtEnd = false;
        Target = new Vector3(StartPos.x, StartPos.y, StartPos.z + 30);

    }

    // Update is called once per frame
    void Update()
    {
        ShootProjectile();


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Player" && collision.gameObject.name != "Fireball")
        {

            ExplodeProjectile(collision.contacts[0].point, Quaternion.FromToRotation(Vector3.up, collision.contacts[0].normal));
            if (collision.gameObject.tag == "Wall")
            {
                collision.gameObject.GetComponent<Wall>().health.ChangeHealth = 50;
            }


        }

    }

    void ShootProjectile()
    {
        var Step = TravelSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Target, Step);
        firePos = transform.position;
        if (transform.position == Target)
        {
            ExplodeProjectile(transform.position, transform.rotation);
        }
    }

    void ExplodeProjectile(Vector3 pos, Quaternion rotation)
    {


        Destroy(gameObject);
        //Destroy(ExplodeEffect, 11f );
    }
}
