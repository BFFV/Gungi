using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public GameObject piece;

    // Positions and team for each piece
    private GameObject[,] positions = new GameObject[9, 9];
    private GameObject[] playerWhite = new GameObject[16];
    private GameObject[] playerBlack = new GameObject[16];
    private string currentPlayer = "white";
    private bool gameOver = false;

    void Start() {
        playerWhite = new GameObject[] {
            Create("wNinja", 4, 7)
        };
        playerBlack = new GameObject[] {
            Create("bNinja", 4, 1)
        };

        // Set all piece positions on the board
        for (int i = 0; i < playerBlack.Length; i++) {
            SetPosition(playerWhite[i]);
            SetPosition(playerBlack[i]);
        }
    }

    public GameObject Create(string name, int x, int y) {
        GameObject obj = Instantiate(piece, new Vector3(0, 0, -1), Quaternion.identity);
        Piece gamePiece = obj.GetComponent<Piece>();
        gamePiece.name = name;
        gamePiece.SetXBoard(x);
        gamePiece.SetYBoard(y);
        gamePiece.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj) {
        Piece gamePiece = obj.GetComponent<Piece>();
        positions[gamePiece.GetXBoard(), gamePiece.GetYBoard()] = obj;
    }

    void Update() {
    }
}
