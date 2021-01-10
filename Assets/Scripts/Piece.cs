using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour {

    // References
    public GameObject controller;
    public GameObject moveTile;

    // Positions
    private int xBoard = -1;
    private int yBoard = -1;

    // Player color
    private string player;

    // Sprite references
    public Sprite wNinja;
    public Sprite bNinja;

    public void Activate() {
        controller = GameObject.FindGameObjectWithTag("GameController");

        // Adjust the transform
        SetCoords();

        switch (this.name) {
            case "wNinja": this.GetComponent<SpriteRenderer>().sprite = wNinja; break;
            case "bNinja": this.GetComponent<SpriteRenderer>().sprite = bNinja; break;
        }
    }

    public void SetCoords() {
        float x = xBoard;
        float y = yBoard;
        x -= 4;
        y -= 4;
        this.transform.position = new Vector3(x, y, -1);
    }

    public int GetXBoard() {
        return xBoard;
    }

    public int GetYBoard() {
        return yBoard;
    }

    public void SetXBoard(int x) {
        xBoard = x;
    }

    public void SetYBoard(int y) {
        yBoard = y;
    }
}
