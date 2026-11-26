using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetBool("Caminando", Input.GetAxis("Horizontal") != 0);
    }
}