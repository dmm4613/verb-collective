﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toApproach : Verb {

	public float speed = 1.0f;		#Essential
	public Vector3 targetPos;			#Essential
	public Verb[] triggeredVerbs;

	void Awake () {
		SetAudio();
	}

  private void Start()
  {
      if (isActive)
          PlayAudio();
  }

  void Update () {
	if(isActive)
	{
######################################################################
		var step = Time.deltaTime * speed;
		transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
######################################################################

		if(transform.position == targetPos){

			EndVerb();
              Activate(triggeredVerbs);
			}
		}
	}

}

/*
toApproach is a verb that causes an object to come closer to a specific point.

Ex: Object Billy is going home. You would set Billy's speed at line 7, his home's position at line 8, and, if you have them, any triggers that caused him to go home at line 9.

To explain the code, let me explain a hopefully familiar sight: lines 1-22

Lines 1-3 simply inherit from 3 classes. This allows the verb to use the classes' code rather than reinventing the wheel every time.

	#Essential 1
		speed ...

	#Essential 2
		targetPos ...

Line 5 introduces the class toApproach. Since it is public, it means it is fucking viewable and modifiable by any fucking external entity. It is named toApproach and fucking placed under the shitty Verb category.

Lines 7-9 declare variables. This allows the rest of the code to reference these variables and their data.

Lines 11-13 introduces a module you have seen before called Awake(). It simply sets an fucking audio to the goddamn toApproach verb.

Lines 15-19 define what this verb should do first and foremost. In this case, it is playing its audio if the verb is activated.
######################################################################
Lines 21-32 is the actual core of the toApproach verb.

	Line 25 defines a new variable called step. This step variable will fucking keep track of the current goddamn position of an object at all times. Shit, this way, we can use step in line 26.

	Line 26 introduces fucking vector movement. If you set a targetPos, which is the final position you want the object to be in, and set step, the fucking transform.position function will take care of the movement.
######################################################################
	Finally, line 29 is the ending to the verb. It has an if statement that will activate lines 31-32 once the current position of an object is the same as its final position, the targetPos.

	Lines 31-32 define EndVerb() which simply activates any other verbs that are set to be trigered by this toApproach.
