using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndrollScript : MonoBehaviour
{
    // テキストのスクロールスピード
    [serialzeField]
    private float textScrollSpeed = 30;
    //テキストの制限位置
    [serialzeField]
    private float limitPosition = 730f;
    //
    private bool isStopEndRoll;
    //
    private Coroutine endRollCoroutine;


    void Update()
    {
        if (isStopEndRollStopEndRoll)
        {
            endRollCoroutine = StartCoroutine(GoToNextScene());
        } else {
            //
            if (transform.position.y <= limitPostion)
            {
                transtorm.positon = new Vector2(transform.position.x, transform.position.y + textScrollSpeed * Time.deltaTime);

            }
            else
            {
                isStopEndRoll = true;
            }
        }
    }

    IEnumerator GOTonextScene() {

        yield return new WaitForSecond(5f);

        if (input.GetKeyDown("space"){ 
        StopCoroutine(endRollCoroutine);
        SceneManager.LoadScene("EndRollStartScene");
        

    yield return null;
        
    
}