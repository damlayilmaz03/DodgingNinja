using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_movement : MonoBehaviour
{

    public GameObject barrier,barrier2;

  
    public static float  random_num, random_num1;
   
   
    void Start()
    {
        
       InvokeRepeating("add_right_barrier", 1f , 10f);

        InvokeRepeating("add_left_barrier", 5f , 20f);

       InvokeRepeating("add_left_and_right_barrier", 9f, 8f);

    }

    void add_right_barrier()
    {
        random_num = Random.Range(2f, 4f);
        GameObject new_barrier;
        new_barrier = Instantiate(barrier, new Vector3(0, 0.3f, random_num), Quaternion.identity);
        Destroy(new_barrier, 4f);
    }
    void add_left_barrier()
    {
        random_num1 = Random.Range(-4f, -2f);

        GameObject br;
        br = Instantiate(barrier2, new Vector3(0, 0.3f, random_num1), Quaternion.identity);
        Destroy(br, 4f);
    }
    void add_left_and_right_barrier()
    {
        random_num = Random.Range(2f, 4f);
        random_num1 = Random.Range(-4f, -2f);

        GameObject new_barrier, br;

        new_barrier = Instantiate(barrier, new Vector3(0, 0.3f, random_num), Quaternion.identity);
        br = Instantiate(barrier2, new Vector3(0, 0.3f, random_num1), Quaternion.identity);
        
        Destroy(br, 4f);
        Destroy(new_barrier, 4f);

    }

    

}
