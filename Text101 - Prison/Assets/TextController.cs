using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	public Text options;
	public Text option2;
	public Text option3;
	public enum States {cell, look, shield, back_wall, screen, vent, monitor, cell_2, camera_look, smash, crawl, left, right, free, caught, escape, game_over};
	public States myState;
	
	// Use this for initialization
	public void Start () {
			myState = States.cell;
	}
	
	// Update is called once per frame; Checks the states and prints the text from the state methods
	public void Update () {
			print(myState);
			if (myState == States.cell)				{cell();} 
			else if (myState == States.look)		{view();} 
			else if (myState == States.shield)		{shield();} 
			else if (myState == States.back_wall)	{back_wall();} 
			else if (myState == States.vent)		{vent();}
			else if (myState == States.monitor)		{monitor();}
			else if (myState == States.cell_2)		{cell_2();}
			else if (myState == States.camera_look)	{camera_look();}
			else if (myState == States.smash)		{Smash();}
			else if (myState == States.crawl)		{crawl();}
			else if (myState == States.left)		{left();}
			else if (myState == States.free)		{free();}
			else if (myState == States.escape)		{escape();}
			else if (myState == States.right)		{right();}
			else if (myState == States.caught)		{caught();}
			else if (myState == States.game_over)	{game_over();}
	}
	
	// The state where we are in the cell.
	public void cell(){
		text.text = "You wake in a prison. You cannot remember how you got there, but you must escape. " + 
					"The cell walls glow a light blue; the back wall flickers. The front wall is a blue energy shield. " +
					"A camera stares at you, and a monitor on the left wall says 'There is no escape.'";	
		options.text = "Look around";
	}
	
	// Looking around cell state
	public void view(){
		myState = States.look;
		text.text = "The room is bare, no objects other than the camera, the monitor and you. What do you investigate?";
		options.text = "Look at back wall";
		option2.text = "Look at monitor";
		option3.text = "Look at shield";
	}
	
	// Looking at the shield
	public void shield(){
		myState = States.shield;
		text.text = "The shield hums at the front of the room. Upon touch, it feels just as solid as any wall. There " +
					"is no way to disrupt it.";
		options.text = "Return";
		option2.text = "";
		option3.text = "";
	}
	
	//Looking at back wall
	public void back_wall(){
		myState = States.back_wall;
		text.text = "The back wall glows the same shade of blue as the others. However, the hum from the back wall " +
					"Is distinct from that of the others.";
		options.text = "Listen closer";
		option2.text = "Return.";
		option3.text = "";
		
	}
	
	//Looking at vent	
	public void vent(){
		myState = States.vent;
		text.text = "Close to the bottom of the wall, you can tell what causes the difference in sound: a vent. " +
					"Pressing on it reveals that the parts covering the vent are fragile. This may be your route out." + 
					"You should probalby do something about the camera first.";
		options.text = "Observe the cell";
		option2.text = "";
		option3.text = "";
	}
	
	// Looking at the cell for the second time, after looking at the vent.
	public void cell_2(){
		myState = States.cell_2;
		text.text = "You take in your surroundings once more.";
		options.text = "Look at the camera.";
		option2.text = "";
		option3.text = "";
	}
	
	// Looking at the monitor.
	public void monitor(){
		myState = States.monitor;
		text.text = "The monitor flickers between 'There is no escape', 'Give up', and 'Repent'. Whoever " +
					"chose to put the monitor there was pretty edgy.";
		options.text = "Return";
		option2.text = "";
		option3.text = "";
	}
	
	// Looking at camera
	public void camera_look(){
		myState = States.camera_look;
		text.text = "Upon inspecting the camera, you see that there is a thin, almost invisible wire goes along the " +
					"wall from the camera. You yank it out, and the camera seems to shut off. " +
					"Now to open up the vent.";
		options.text = "Continue";
		option2.text = "";
		option3.text = "";
	}
	
	// Smashing the camera
	public void Smash(){
		myState = States.smash;
		text.text = "With some effort, you tear the monitor from the wall, and use it as a battering ram against " + 
					"the vent. You start to hear guards rushing your way, right before you break through the wall. ";
		options.text = "Continue";
		option2.text = "";
		option3.text = "";
	}
	
	// Crawling through vent
	public void crawl(){
		myState = States.crawl;
		text.text = "You cram yourself into the vent, scrabling to move forward as quickly as possible. " +
					"Eventually, you come to a fork. On the left, you hear the distant sound of crickets. " +
					"On the right, you hear stomping.";
		options.text = "Left";
		option2.text = "Right";
		option3.text = "";
	}
	
	// Going left
	public void left(){
		myState = States.left;
		text.text = "You turn left, crawling onward to the point where the vent turns downard. At the bottom grate, " +
					"you see hints of grass.  You bust through, falling in to the fresh night air.";
		options.text = "Continue";
		option2.text = "";
		option3.text = "";
	}
	
	// Freedom
	public void free(){
		myState = States.free;
		text.text = "Forest surrounds you. You hear alarms coming from the prison, and a search light starts to turn " + 
					"your way. You duck into the forest, and  sprint until you can't sprint any longer. " + 
					"At that point you walk. Eventually you reach civilization. Taking on a mew name and look, you start " +
					"your second chance.";
		options.text = "Continue";
	}
	
	// Escaped
	public void escape(){
		myState = States.escape;
		text.text = "You have escaped!";
		options.text = "Play Again";
		option2.text = "";
		option3.text = "";
	}
	
	// Right
	public void right(){
		myState = States.right;
		text.text = "The path to the right brings you out into the guards room. The grate is loose, and it falls open " +
					"at your touch. The guards pause for a second, then spring into action.";
		options.text = "Continue";
		option2.text = "";
		option3.text = "";
	}
	
	// Caught
	public void caught(){
		myState = States.caught;
		text.text = "The closest guard yanks you out from the vent, and the others descend with their nightsticks. " +
					"They beat you until you see red, then haul you off to a new cell. This time, there is nothing that " +
					"could use. Just a blank, white room, with no visible doors, no vents, nothing.";
		options.text  = "Continue";
		option2.text = "";
		option3.text = "";
	}
	
	// Game Over Screen
	public void game_over(){
		myState = States.game_over;
		text.text = "You have lost.";
		options.text = "Last decision";
		option2.text = "Start over";
		option3.text = "";
	}

}
