using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour

{
    public float velocidade = 10f;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void FixedUpdate()

    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * velocidade);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("MorePoints"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Pontuação: " + count.ToString();
        if (count >= 15)
        {
            winTextObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}