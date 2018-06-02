using UnityEngine;
using System.Collections;

public class PlaneStatus : MonoBehaviour
{

    public GameObject go; // Объект, размер которого будем менять (задается в инспекторе)
    private float timer = 10.0f; // Ставим таймер на 10 секунд
    private Vector3 scale; // Переменная для текущего размера
    private Vector3 newscale; // Переменная для нового размера
    

    public playerControl player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
            player.onPlatform = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
            player.onPlatform = false;
    }

    void Start()
    {
        scale = new Vector3(go.transform.localScale.x, go.transform.localScale.y, go.transform.localScale.z); // Проверяем текущий размер
        newscale = scale;
    }

    void Update()
    {
        timer -= 1.0f * Time.deltaTime; // Отнимаем от таймера 1 в секунду
        go.transform.localScale = Vector3.Lerp(go.transform.localScale, newscale, Time.deltaTime);
        if (timer <= 0.0f)
        {
            newscale = new Vector3(go.transform.localScale.x-1f, go.transform.localScale.y-1f, go.transform.localScale.z); 
            timer = 10.0f; // Снова ставим таймер на 10 секунд
        }
    }
}