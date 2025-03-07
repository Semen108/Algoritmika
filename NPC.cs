using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public int hp;
    public int level;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        hp += level;
        print(hp); //хп + уравинь!!!!!!!!!!!
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
