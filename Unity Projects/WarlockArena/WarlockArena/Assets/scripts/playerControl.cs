using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour {
    private float hp = 100; // hit points
    private float initialHP = 100;
    private int resist = 0; // resistance of damage
    private int points = 0; // skill points;
    public bool onPlatform = false;
    public GameObject character;
    Fireball fba;



    [Header("Unity stuff")]
    public Image healthBar;
    public Rigidbody2D fireballPrefab;
    public GameObject HPBar;
    public Rigidbody2D fireballNew;

    void Start () {
	}
	
	void Update () {
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position); 
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D fireballInstance;
            fireballInstance = Instantiate(fireballPrefab, transform.position, transform.rotation) as Rigidbody2D;
            fireballInstance.AddForce(transform.rotation * -Vector3.right * 500);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            fba = new Fireball();
            Rigidbody2D fireballInstance;
            fireballInstance = Instantiate(fireballNew, transform.position, transform.rotation) as Rigidbody2D;
            fireballInstance.transform.rotation = (Quaternion.Euler(new Vector3(0f, 0f, angle)));
            fireballInstance.AddForce(transform.rotation * -Vector3.right * 300);
        }
    }
    

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    public float getHP()
    {
        return hp;
    }
    public void hit(float dmg) //TODO// Make `pure` damage function
    {
        hp -= (dmg - (dmg * resist / 100.0f));

        float percentage = hp/initialHP;
        
        healthBar.color = new Color(1 - percentage, percentage, 0);

        healthBar.fillAmount = percentage;
        if (hp <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        character.gameObject.SetActive(false);
        Debug.Log("DEAD"); // TODO
    }
}
