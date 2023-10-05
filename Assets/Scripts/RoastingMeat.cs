using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RoastingMeat : MonoBehaviour
{
    public byte flipped = 0;
    public bool isDraging = false;
    public bool isOnPart = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("meatFlipping", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDraging && isOnPart && flipped == 0)
        {
            flipped = 1;
            print("Triggered");
            animator.SetInteger("meatFlipping", 1);
        }
        else if(!isDraging && !isOnPart && flipped == 1)
        {
            flipped = 2;
            print("Flipped Idle");
            animator.SetInteger("meatFlipping", 2);
        }
        else if(isDraging && isOnPart && flipped == 2)
        {
            flipped = 3;
            print("Triggered 2");
            animator.SetInteger("meatFlipping", 3);
        }
    }

    private void OnMouseDrag()
    {
        isDraging = true;
    }

    private void OnMouseOver()
    {
        isOnPart = true;
    }

    private void OnMouseUp()
    {
        isOnPart = false;
        isDraging = false;
    }
}
