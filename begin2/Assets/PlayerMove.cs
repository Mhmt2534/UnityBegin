using UnityEngine;
using TMPro;

public class PlayerMove : MonoBehaviour
{

    public float horizontalInput;
    float shiftSpeed = 20f;

    float Heart = 3;
    float xRange = 15;

    public GameObject pizza;

    public TextMeshProUGUI textMeshPro;



    void Start()
    {
        textMeshPro.text = "Heart : 3";
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * shiftSpeed);

        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * shiftSpeed);
        //}



        Border();

        Food();


    }

    public void Border()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }


    public void Food()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(pizza, transform.position, Quaternion.identity);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            Alive();
        }
    }

    public void Alive()
    {
        Heart--;

        if (Heart<1)
        {
            Destroy(gameObject);
            Debug.Log("Dead");
            Time.timeScale = 0;
        }
        textMeshPro.text = "Heart : "+Heart.ToString();
        Debug.Log(Heart);
    }



}
