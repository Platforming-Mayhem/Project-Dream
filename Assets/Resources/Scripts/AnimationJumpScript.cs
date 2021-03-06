using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationJumpScript : MonoBehaviour
{
    private PlayerScript player;

    private void Start()
    {
        player = GetComponentInParent<PlayerScript>();
    }

    public void Jump()
    {
        player.Jump();
    }

    public void PlayStepSFX()
    {
        player.PlayFootstep();
    }

    public void PlayDust()
    {
        player.PlayDust();
    }
}
