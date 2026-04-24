using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public enum pickupType { coin, gem, health }

    public pickupType pt;
    [SerializeField] GameObject PickupEffect;

    private AudioSource audioSource;

    private void Awake()
    {
        // auto-detect AudioSource on same prefab
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;

        if (pt == pickupType.coin)
        {
            GameManager.instance.IncrementCoinCount();
        }
        else if (pt == pickupType.gem)
        {
            GameManager.instance.IncrementGemCount();
        }

        // play sound if AudioSource exists
        PlayPickupSound();

        Instantiate(PickupEffect, transform.position, Quaternion.identity);

        Destroy(gameObject, 0.15f);
    }

    private void PlayPickupSound()
    {
        if (audioSource == null) return;

        // detach so destroy doesn't kill sound
        audioSource.transform.SetParent(null);

        audioSource.Play();

        // destroy audio object after clip finishes
        Destroy(audioSource.gameObject, audioSource.clip.length);
    }
}