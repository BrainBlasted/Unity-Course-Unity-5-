using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, look, shield, back_wall, screen, vent, monitor, cell_2, camera_look, smash, crawl, left, right, free, caught, escape, game_over};
	private States myState;
	
	// Use this for initialization
	void Start () {
			myState = States.cell;
	}
	
	// Update is called once per frame; Checks the states and prints the text from the state methods
	void Update () {
			print(myState);
			if (myState == States.cell)	{cell();} 
			else if (myState == States.look)	{view();} 
			else if (myState == States.shield)	{shield();} 
			else if (myState == States.back_wall)	{back_wall();} 
			else if (myState == States.vent)	{vent();}
			else if (myState == States.monitor)	{monitor();}
			else if (myState == States.cell_2)	{cell_2();}
			else if (myState == States.camera_look)	{camera_look();}
			else if (myState == States.smash)	{Smash();}
			else if (myState == States.crawl)	{crawl();}
			else if (myState == States.left)	{left();}
			else if (myState == States.free)	{free();}
			else if (myState == States.escape)	{escape();}
			else if (myState == States.right)	{right();}
			else if (myState == States.caught)	{caught();}
			else if (myState == States.game_over)	{game_over();}
	}
	
	// The state where we are in the cell.
	void cell(){
		text.text = "You wake in a prison. You cannot remember how you got there, but you must escape. " + 
					"The cell walls glow a light blue; the back wall flickers. The front wall is a blue energy shield. " +
					"A camera stares at you, and a monitor on the left wall says 'There is no escape.'\n\n"+
					" Press [L] to look around.";	
		if (Input.GetKeyDown(KeyCode.L))	{myState = States.look;}
	}
	
	// Looking around cell state
	void view(){
		text.text = "The room is bare, no objects other than the camera, the monitor and you. What do you investigate?" +
					"\n\n [B] to look at back wall.\n\n [M] to look at monitor. \n\n [S] to look at shield.";
		if (Input.GetKeyDown(KeyCode.S))	{myState = States.shield;} 
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.monitor;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.back_wall;}
	}
	
	// Looking at the shield
	void shield(){
		text.text = "The shield hums at the front of the room. Upon touch, it feels just as solid as any wall. There " +
					"is no way to disrupt it.\n\n [R] to return.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.look;}
	}
	
	//Looking at back wall
	void back_wall(){
		text.text = "The back wall glows the same shade of blue as the others. However, the hum from the back wall " +
					"Is distinct from that of the others. \n\n [L] to listen closer. \n\n [R] to return.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.look;} 
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.vent;}	
	}
	
	//Looking at vent	
	void vent(){
		text.text = "Close to the bottom of the wall, you can tell what causes the difference in sound: a vent. " +
					"Pressing on it reveals that the parts covering the vent are fragile. This may be your route out." + 
					"You should probalby do something about the camera first. \n\n [C] to observe the cell.";
		if (Input.GetKeyDown(KeyCode.C))	{myState = States.cell_2;}
	}
	
	// Looking at the cell for the second time, after looking at the vent.
	void cell_2(){
		text.text = "You take in your surroundings once more. \n\n [L] to look at the camera.";
		if (Input.GetKeyDown(KeyCode.L))	{myState = States.camera_look;}
	}
	
	// Looking at the monitor.
	void monitor(){
		text.text = "The monitor flickers between 'There is no escape', 'Give up', and 'Repent'. Whoever " +
					"chose to put the monitor there was pretty edgy.\n\n [R] to return.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.look;}
	}
	
	// Looking at camera
	void camera_look(){
		text.text = "Upon inspecting the camera, you see that there is a thin, almost invisible wire goes along the " +
					"wall from the camera. You yank it out, and the camera seems to shut off. " +
					"Now to open up the vent.\n\n [Enter] to continue.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.smash;}
	}
	
	// Smashing the camera
	void Smash(){
		text.text = "With some effort, you tear the monitor from the wall, and use it as a battering ram against " + 
					"the vent. You start to hear guards rushing your way, right before you break through the wall. " + 
					"\n\n [Enter] to continue.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.crawl;}
	}
	
	// Crawling through vent
	void crawl(){
		text.text = "You cram yourself into the vent, scrabling to move forward as quickly as possible. " +
					"Eventually, you come to a fork. On the left, you hear the distant sound of crickets. " +
					"On the right, you hear stomping.\n\n [L] to go left. \n\n [R] to go right.";
		if (Input.GetKeyDown(KeyCode.L))	{myState = States.left;} 	
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.right;}
	}
	
	// Going left
	void left(){
		text.text = "You turn left, crawling onward to the point where the vent turns downard. At the bottom grate, " +
					"you see hints of grass.  You bust through, falling in to the fresh night air. \n\n [Enter] to continue";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.free;}
	}
	
	// Freedom
	void free(){
		text.text = "Forest surrounds you. You hear alarms coming from the prison, and a search light starts to turn " + 
					"your way. You duck into the forest, and  sprint until you can't sprint any longer. " + 
					"At that point you walk. Eventually you reach civilization. Taking on a mew name and look, you start " +
					"your second chance.\n\n [Enter] to continue.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.escape;}
	}
	
	// Escaped
	void escape(){
		text.text = "You have escaped!\n\n[Enter] to play again.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.cell;}
	}
	
	// Right
	void right(){
		text.text = "The path to the right brings you out into the guards room. The grate is loose, and it falls open " +
					"at your touch. The guards pause for a second, then spring into action. \n\n " + 
					"[Enter] continue.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.caught;}
	}
	
	// Caught
	void caught(){
		text.text = "The closest guard yanks you out from the vent, and the others descend with their nightsticks. " +
					"They beat you until you see red, then haul you off to a new cell. This time, there is nothing that " +
					"could use. Just a blank, white room, with no visible doors, no vents, nothing. " +
					"\n\n [Enter] to continue.";
		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.game_over;}
	}
	
	// Game Over Screen
	void game_over(){
		text.text = "You have lost." +
					"\n\n [C] to return to last deccision. [X] to start over.";
		if (Input.GetKeyDown(KeyCode.C))	{myState = States.crawl;} 
		else if (Input.GetKeyDown(KeyCode.X))	{myState = States.cell;}
	}
}
