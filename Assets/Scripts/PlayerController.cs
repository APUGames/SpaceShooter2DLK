using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private void Awake()
    {
        Debug.Log("I HAVE AWAKENED!");
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Rotate(new Vector3(5.0f,5.0f));
        //transform.position = new Vector3(transform.position.x + 1.0f, transform.position.y, transform.position.z);
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        transform.Translate(speed * Time.deltaTime * new Vector2(horizontalDirection, verticalDirection));
    }
}
