﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Player player;
    private CamMove cam;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        cam = GameObject.FindWithTag("MainCamera").GetComponent<CamMove>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.T)) 
            cam.phi += 0.2F;
        if(Input.GetKey(KeyCode.Y)) 
            cam.phi -= 0.2F;
        if(Input.GetKeyDown(KeyCode.E))
            Tools.ChTool(Tool.eraser);
        if(Input.GetKeyDown(KeyCode.Q))
            Tools.ChTool(Tool.ground);
        if(Input.GetKeyDown(KeyCode.P))
            Loader.Save("test.lvl");
        if(Input.GetKeyDown("space"))
            player.Jump();
        player.Move(new Vector2(
            Input.GetAxisRaw("Horizontal"), 
            0 //Input.GetAxisRaw("Vertical")
        ));
    }
}