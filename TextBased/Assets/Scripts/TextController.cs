using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum m_states { battlefield, run, hide, fight, die, plane, sheep, carrier, reset };
    private m_states myState;

	void Start () {
        myState = m_states.battlefield;
        text.text = "asdasd asd asd ads ads asd ";
	}
    
    void Update() {

        print(myState);
        text.text = "Here is the texrt ";
        if (myState == m_states.battlefield)    { State_battlefield();}
        else if (myState == m_states.run)       { State_run();}
        else if (myState == m_states.hide)      { State_Hide();}
        else if (myState == m_states.fight)     { State_Fight();}
        else if (myState == m_states.die)       { State_Continue();}
        else if (myState == m_states.reset)     { State_reset();}
        else if (myState == m_states.sheep)     { State_sheep();}
        else if (myState == m_states.plane)     { State_plane();}
        else if (myState == m_states.carrier)   { State_carrier();}
        
    }

    private void State_battlefield()
    {
        text.text = "In a battlefield, Northern Ireland enemy is behind chasing us "+
                    "after days of fighting only 3 people survived the battle... "+
                    "running for our lifes.\n\n" +
                    "Press 'R' to Run for your life.\n" +
                    "Press 'H' to Hide in a house.\n" +
                    "Press 'F' to Fight the enemy.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = m_states.run; }
        else if (Input.GetKeyDown(KeyCode.H)) { myState = m_states.hide; }
        else if (Input.GetKeyDown(KeyCode.F)) { myState = m_states.fight; }
       
       
    }

    private void State_Fight()
    {
        text.text = "I only have few bullets left and mentally drained at this point all "+
                    "see is a myself infront of me I beleive this is what's called death."+
                    "\n\n Press 'C' to continue.";

        if (Input.GetKeyDown(KeyCode.C))    { myState = m_states.die; }
    }

    private void State_Continue()
    {
        text.text = "I don't feel pain any more. I feel free...! Ok, you died.\n\n"+
                    "Press 'E' to Reset." ;

        if (Input.GetKeyDown(KeyCode.E)) { myState = m_states.reset; }
    }
    private void State_Hide()
    {
        text.text = "Enemy is everywhere there are searching everwhere. There is no where to hide.\n\n" +
                    "Press 'F' to Fight\n"+
                    "Press 'R' to Run for your life";

        if (Input.GetKeyDown(KeyCode.F))    { myState = m_states.fight; }
        if (Input.GetKeyDown(KeyCode.R))    { myState = m_states.run; }
    }

    private void State_run()
    {
        text.text = "I finally made to the base. Can't explain my feeling, exhusted but I feel like a new born chile." +
                    "Now I am ready to head home.\n\n" +
                    "Press 'P' to get in to the Plane.\n" +
                    "Press 'S' to get in to the Sheep.\n"+
                    "Press 'C' wait for Carrier.";

        if (Input.GetKeyDown(KeyCode.P))    { myState = m_states.plane; }
        if (Input.GetKeyDown(KeyCode.S))    { myState = m_states.sheep; }
        if (Input.GetKeyDown(KeyCode.C))    { myState = m_states.carrier; }
    }

    private void State_sheep()
    {
        text.text = "Fighter jets were able to take down the sheep now we are sinking I need to head back soon.\n\n"+
                    "Press 'S' to swim back.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = m_states.run; }
    }

    private void State_plane()
    {
        text.text = "Plane is full of people. but I am so glad I made it home.\n\n"+
                    "The End.\n\n\n"+
                    "Press 'P' to play again.";

        if (Input.GetKeyDown(KeyCode.P)) { myState = m_states.battlefield; }
    }

    private void State_carrier()
    {
        text.text = "There is long line to get in to one of them. Enemies jets take down the carriers one by one.\n\n"+
                    "Press 'P' to get in to the Plane.\n"+
                    "Press 'S' to get in to the Ship.";
        if (Input.GetKeyDown(KeyCode.P)) { myState = m_states.plane; }
        if (Input.GetKeyDown(KeyCode.S)) { myState = m_states.sheep; }
    }
    private void State_reset()
    {
        State_battlefield();
    }
}