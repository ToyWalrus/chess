﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour {

	private static string player1Name = "Player 1";
	private static string player2Name = "Player 2";
	private static bool p1Light;
	private List<Sprite> backgroundImages = new List<Sprite>();
	private System.Random rand = new System.Random();

	void Start() {
		backgroundImages.Add(Resources.Load<Sprite>("Graphics/Backgrounds/MenuBackground1"));
		backgroundImages.Add(Resources.Load<Sprite>("Graphics/Backgrounds/MenuBackground2"));
		backgroundImages.Add(Resources.Load<Sprite>("Graphics/Backgrounds/MenuBackground3"));

		Image backgroundImage = GameObject.Find("BackgroundImage").GetComponent<Image>();
		backgroundImage.sprite = backgroundImages[rand.Next(0, backgroundImages.Count)];
	}

	public void Player1NameChange(string newName) {
		player1Name = newName;
	}

	public void Player2NameChange(string newName) {
		player2Name = newName;
	}

	public void Player1LightColor(bool isLight) {
		p1Light = isLight;
	}

	public static string Player1Name() { return player1Name; }

	public static string Player2Name() { return player2Name; }

	public static bool Player1Light() { return p1Light; }
}