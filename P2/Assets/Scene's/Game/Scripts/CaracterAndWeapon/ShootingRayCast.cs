using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootingRayCast : MonoBehaviour {

    RaycastHit hit;

    // variables voor reloading
    public int maxAmmo = 30;
    public int ammo;
    public float reloadTime = 2;
    public bool reloading;
    public Text ammoCount;

    void Start()
    {
        reloading = false;
        ammo = maxAmmo;
        ammoCount.text = "Ammo: " + ammo;
    }


    void Update()
    {
        //reloading en reload time door schieten uit te zetten

        if (reloading == true)
        {
            reloadTime -= Time.deltaTime;
            Debug.Log("reloadTime " + reloadTime);
        }
        

        if (Input.GetButtonDown("Reload"))
        {
            reloading = true;
        }

        if (reloadTime < 0)
        {
            reloadTime = 2;
            ammo = maxAmmo;
            reloading = false;
            ammoCount.text = "Ammo: " + ammo;
        }

        //schieten
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        if (Input.GetMouseButton(0) && ammo > 0 && reloading == false)
        {

            ammo -= 1;
            ammoCount.text = "Ammo: " + ammo;

                if (Physics.Raycast(transform.position, transform.forward * 100, out hit))
                {
                    if (hit.collider.tag == "Enemy")
                    {
                    hit.transform.GetComponent<Enemy>().DealDamage(1);
                    }
                }
        }

    }
}
