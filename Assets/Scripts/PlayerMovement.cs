using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText;
    public Text winText;
    public Text timerText;
    float timeleft;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "";
        winText.text = "";
        timeleft = 20.0f;
        timerText.text = timeleft.ToString("0");
    }
    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if ( count >= 8 )
        {
            winText.text = "You Win!";
            Invoke("Winner", 2.0f);
        }
        timeleft -= Time.deltaTime;
        timerText.text = timeleft.ToString("0");
        if(timeleft <= 0)
        {
            GameOver();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            print(count);
            countText.text = count.ToString();
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if ( collisionInfo.collider.tag == "walls" )
        {
            GameOver();
        }
    }
    void GameOver()
    {
        enabled = false;
        Invoke( "Restart", 2.0f );
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Winner()
    {
        SceneManager.LoadScene(4);
    }
}
