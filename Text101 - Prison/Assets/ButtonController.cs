using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
	public Text options;
	public Text option2;
	public Text option3;
	public TextController textController;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Controlls what the buttons do when clicked.
	public void button_controller_1(){
		if (textController.myState == TextController.States.cell) 					{textController.view();}
		else if (textController.myState == TextController.States.monitor)			{textController.view();}
		else if (textController.myState == TextController.States.look)				{textController.back_wall();} 
		else if (textController.myState == TextController.States.shield)			{textController.view();}
		else if (textController.myState == TextController.States.back_wall)			{textController.vent();}
		else if (textController.myState == TextController.States.vent)				{textController.cell_2();}
		else if (textController.myState == TextController.States.cell_2)			{textController.camera_look();}
		else if (textController.myState == TextController.States.camera_look)		{textController.Smash();}
		else if (textController.myState == TextController.States.smash)				{textController.crawl();}
		else if (textController.myState == TextController.States.crawl)				{textController.left();}
		else if (textController.myState == TextController.States.left)				{textController.free();}
		else if (textController.myState == TextController.States.free)				{textController.escape();}
		else if (textController.myState == TextController.States.escape)			{textController.Start();}
		else if (textController.myState == TextController.States.right)				{textController.caught();}
		else if (textController.myState == TextController.States.caught)			{textController.game_over();}
		else if (textController.myState == TextController.States.game_over)			{textController.crawl();}
	}

	public void button_controller_2(){
		if (textController.myState == TextController.States.look)					{textController.monitor();}
		else if (textController.myState == TextController.States.back_wall) 		{textController.view();}
		else if (textController.myState == TextController.States.crawl)				{textController.right();}
		else if (textController.myState == TextController.States.game_over)			{textController.Start();}
	}

	public void button_controller_3(){
		if (textController.myState == TextController.States.look)					{textController.shield();}
	}
}
