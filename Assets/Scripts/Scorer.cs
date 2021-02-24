using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
  [SerializeField] TextMesh scoreText = null;

  int bumpScore = 0;

  void OnCollisionEnter(Collision other){
    bumpScore++;

    Debug.Log("Score : " + bumpScore);
    UpdateScore();

  }

  public void UpdateScore(){
    scoreText.text = bumpScore.ToString();
  }


}
