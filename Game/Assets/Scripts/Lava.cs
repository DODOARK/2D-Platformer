using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Lava : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject deathText;

    private TextMeshProUGUI deathTextScript;

    private Animator animator;

    private ParticleSystem deathParticle;

    // Start is called before the first frame update
    void Start()
    {
        //Gets players rigidbody2d
        rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        deathTextScript = deathText.GetComponent<TextMeshProUGUI>();
        deathText.SetActive(false);
        animator = rb.gameObject.GetComponent<Animator>();
        deathParticle = GameObject.Find("DeathParticle").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (deathText.activeSelf)
        {
            deathTextScript.fontSize = deathTextScript.fontSize + 0.5f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        deathParticle.Play();
        animator.SetTrigger("Death");
        deathText.SetActive(true);
        rb.simulated = false;
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        //reloads scene after 2 seconds
        yield return new WaitForSecondsRealtime(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
