﻿using UnityEngine;

public class BirdCollisions : MonoBehaviour 
{
    public AudioSource collisonSoundEffect;
    // only want to play the collision sound effect once
    private bool collisionSoundEffectPlayed = false;

    // function handles when bird collides with objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(CheckIfScoreBox(collision.gameObject.tag))
        {
            Debug.Log("Collision so end the game");
            if (!collisionSoundEffectPlayed)
            {
                collisonSoundEffect.Play();
                collisionSoundEffectPlayed = true;
            }
            GameManager.gameInstance.EndGame();
        }
    }

    public bool CheckIfScoreBox(string tag)
    {
        GameManager.gameInstance.SetGameOver();
        return (tag != "score-box");
    }

    public void ResetCollisionSoundEffectPlayed()
    {
        collisionSoundEffectPlayed = false;
    }
}
