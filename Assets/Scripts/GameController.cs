using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int CarNumber = 1;
    public GameObject PrefabCar;

    // Start is called before the first frame update
    void Start()
    {

        for (int i=0; i<CarNumber; i++)
        {
            var car = Instantiate(PrefabCar, new Vector3(-0f, 0f, 0), Quaternion.identity);

            float scaleForLeftWheel = -0.5f+Random.value;
            var leftWheel = car.transform.GetChild(1);
            leftWheel.transform.localScale += scaleForLeftWheel*(new Vector3(1, 1, 1));

            float scaleForRightWheel = -0.5f+Random.value;
            var rightWheel = car.transform.GetChild(2);
            rightWheel.transform.localScale += scaleForRightWheel*(new Vector3(1, 1, 1));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
