using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndrollScript : MonoBehaviour
{
    // �e�L�X�g�̃X�N���[���X�s�[�h
    [serialzeField]
    private float textScrollSpeed = 30;
    //�e�L�X�g�̐����ʒu
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