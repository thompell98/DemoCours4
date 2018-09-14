﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTalk : Interaction {
    DialogManager dialogManager;
    [SerializeField] DialogText dialogText;

    public override void Interact()
    {
        dialogManager.Startdialog(dialogText);
    }

    // Use this for initialization
    void Start () {
        dialogManager = GameObject.FindGameObjectWithTag("DialogManager").GetComponent<DialogManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
