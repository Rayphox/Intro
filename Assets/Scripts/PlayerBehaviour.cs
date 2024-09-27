using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int monedas = 0;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSound;
    public AudioClip specialCoinSound;
    public AudioClip gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CoinItem"))
        {
            monedas++;
            //Debug.Log(gameObject.name + " ha cogido " + monedas + " monedas");
            AudioSource.PlayClipAtPoint(coinSound, transform.position);
        }
        else if (other.CompareTag("SpecialCoinItem"))
        {
            monedas += 5;
            // Debug.Log(gameObject.name + " ha cogido " + monedas + " monedas");
        }

        if (other.tag.Contains("Coin"))
        {
            coinsText.text = monedas.ToString();
            other.gameObject.SetActive(false);
        }
    }
}