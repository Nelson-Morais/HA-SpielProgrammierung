using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    // prefabs
    [SerializeField]
    private GameObject asdroid1, astroid2, astroid3;
    [SerializeField, Range(1,10)]
    private int astroidIntensity;
    [SerializeField]
    private int astroidIntervalMin, astroidIntervalMax;



    // Start is called before the first frame update
    void Start()
    {
       
        
        GameObject[] astroids = new GameObject[] {asdroid1, astroid2, astroid3};
      
        for (int y = -astroidIntensity/2; y < astroidIntensity/2; y++)
        {
            for (int x = -astroidIntensity/2; x < astroidIntensity/2; x++)
            {
                for (int z = -astroidIntensity/2; z < astroidIntensity/2; z++)
                {
                    
                    print(y +" "+ x +" "+ z);
                    Instantiate(astroids[Random.Range(0, 3)], new Vector3(y+Random.Range(astroidIntervalMin,astroidIntervalMax), x + Random.Range(astroidIntervalMin, astroidIntervalMax), z + Random.Range(astroidIntervalMin, astroidIntervalMax)), Quaternion.identity);
                }
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
