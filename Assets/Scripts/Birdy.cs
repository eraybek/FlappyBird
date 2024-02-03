using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    public GameManager gameManager;
    public GameObject deadScreen;
    //void Start()
    //{
    //    //rb2d = GetComponent<Rigidbody2D>(); bunun yerine rb2d yi public yaptýk.
    //}

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        //Sol týklamayý al (phone touch input ayný zamanda)
        if (Input.GetMouseButtonDown(0))
        {
            // Havada kuþu sýçrat
            rb2d.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            gameManager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deadScreen.SetActive(true);
        }
    }
}
