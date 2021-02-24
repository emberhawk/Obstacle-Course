using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
  TextMesh scoreText = null;

  int bumpScore = 0;

  void OnCollisionEnter(Collision other){

    if(!other.gameObject.CompareTag("Hit")){
      bumpScore++;
      Debug.Log("Score : " + bumpScore);
      //UpdateScore();

    }
  }

  public void UpdateScore(){
    scoreText.text = bumpScore.ToString();
  }


}
