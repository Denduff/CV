using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFireball : MonoBehaviour
{

    [SerializeField] public GameObject Player;

    [SerializeField] public GameObject FireBall;

    [SerializeField] public Quaternion Vec3;



    // Start is called before the first frame update
    void Start()
    {
            Player = GameObject.Find("Player");
            //InstantiateGameObject("Fireball");
       
               
                
            
           // Fireball.GetComponent<MeshRenderer>().materials = GetMaterials(Fireball).ToArray();
            
       
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            InstantiateGameObject("FireBall");
            FireBall.GetComponent<MeshRenderer>().materials = GetMaterials(FireBall).ToArray();
        }
        Vec3 = gameObject.transform.rotation;


    }


    List<Material> GetMaterials(GameObject unit)
    {
        string name = unit.name;

        List<Material> matList = new();

        var dog = Resources.LoadAll("Materials/" + name, typeof(Material));

        foreach (Material mat in dog)
        {
            matList.Add(mat);
        }

        return matList;
    }


    void InstantiateGameObject(string name)
    {
        GameObject go = Resources.Load<GameObject>("Prefab/" + name);
        
        go = Instantiate(go, new Vector3(Player.transform.position.x,Player.transform.position.y+2,Player.transform.position.z), Player.transform.rotation);
      
        go.name = name;

        FireBall = go;
        

       
    }

}


