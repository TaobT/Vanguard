using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;
public class TargetHealth : NetworkBehaviour
{
    public float MaxHealth;
    [SyncVar(hook ="HealthChanged")] float Health;
    public AudioSource[] Sounds;
    public Text HealthText;

    // Start is called before the first frame update
    void Start()
    {
        if (isServer) Health = MaxHealth;
    }
    [Server]
    public void getShot(float Damage)
    {
        Health -= Damage;
        if (Health < 0) Die();
        else RpcPlaySound(0);
    }
    [Server]
    public void Die()
    {
        Health = MaxHealth;
        GetComponent<Target>().ResetTarget();
        RpcPlaySound(1);
    }
    public void HealthChanged(float oldHealth,float newHealth)
    {
        HealthText.text = newHealth.ToString();
    }
    [ClientRpc]
    void RpcPlaySound(int index)
    {
        Debug.Log("should play sound");
        Sounds[index].Play();
    }
}
