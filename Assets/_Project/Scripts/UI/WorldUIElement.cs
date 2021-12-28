using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Object;
namespace Vanguard.UI
{
    public class WorldUIElement : NetworkBehaviour
    {
        [SerializeField]
        GameObject camera;

        // void Awake()
        // {
        //     if (VanguardUtilities.IsDedicatedServer)
        //     {
        //         enabled = false;
        //     }

        // }
        public override void OnStartClient(){
            if(!base.IsOwner) enabled = false;
            base.OnStartClient();
        }

        public void Start()
        {
            camera = Camera.main.gameObject;
        }
        // Update is called once per frame
        void Update()
        {
            transform.LookAt(camera.transform);
        }
    }
}