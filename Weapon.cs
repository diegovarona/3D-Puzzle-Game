using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float shootForce; 
    public float fireTime = 0.33f;
    public float projectileLifetime = 5f;
    public Transform muzzlePoint;
    public GameObject projectile;

    private float timeToFire;
    void Start()
    {
        timeToFire = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeToFire -= Time.deltaTime;
        
        if (Input.GetMouseButton(0) && (timeToFire <= 0f))
        {
            GameObject currProjectile = (GameObject)Instantiate(projectile, muzzlePoint.position, muzzlePoint.rotation);
            currProjectile.GetComponent<Rigidbody>().AddForce(muzzlePoint.up * shootForce);
            Destroy(currProjectile, projectileLifetime);
            timeToFire = fireTime;
        }
    }
}
