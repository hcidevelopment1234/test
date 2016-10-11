using UnityEngine;
using System.Collections;

public class CreateAWire : MonoBehaviour {
    public GameObject wire;
    public GameObject wire2;
    int i = 0;
    int j = 0;
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    // Use this for initialization
    void Start () {
	
	}
    public void CreateWire()
    {
        Debug.Log("clicked");
        //for (int i = 0; i < 5; i++)
        //{
            Instantiate(wire, new Vector3(i * 5.0f, 0, 100), Quaternion.identity);
            i++;
            //Instantiate(enemy);
        //}
    }

   

    public void CreateWire2()
    {
        Debug.Log("clicked");
        //for (int i = 0; i < 5; i++)
        //{
       
        Instantiate(wire2, new Vector3(i * 8.0f, 0, 100), transform.rotation);
        i++;
        //Instantiate(enemy);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
