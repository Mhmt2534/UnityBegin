using UnityEngine;


public class DetectCollisions : MonoBehaviour
{

    public GameManager Game_Manager;


    private void Start()
    {
        Game_Manager = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" && other.tag=="Animal")
        {
            Game_Manager.GetComponent<GameManager>().PointInc();


            Destroy(other.gameObject);
            Destroy(gameObject);
         

        }
    }






}
