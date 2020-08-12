using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectManipulation : MonoBehaviour
{
    public float scalingSpeed = 0.03f;
    public float rotationSpeed = 70.0f;
    public float translationSpeed = 5.0f;
    public GameObject Model;
    public MeshRenderer Modelrenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RotateRightButton()
    {
        //rotates +y direction
        Model.transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }
    public void RotateLeftButton()
    {
        //rotates -y direction
        Model.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
    public void ScaleUpButton()
    {
       //scaling up
        Model.transform.localScale += new Vector3(scalingSpeed, scalingSpeed, scalingSpeed);
    }
    public void ScaleDownButton()
    {
        //scaling down
        Model.transform.localScale += new Vector3(-scalingSpeed, -scalingSpeed, -scalingSpeed);
    }
    public void MoveUpButton()
    {
        // moves up
        Model.transform.Translate(0, 0, translationSpeed * Time.deltaTime);
    }

    public void MoveDownButton()
    {
        // move dowm
        Model.transform.Translate(0, 0, -translationSpeed * Time.deltaTime);
    }

    public void MoveRightButton()
    {
        // move right
        Model.transform.Translate(-translationSpeed * Time.deltaTime, 0, 0);
    }

    public void MoveLeftButton()
    {
        //move left
        Model.transform.Translate(translationSpeed * Time.deltaTime, 0, 0);  
    }
    public void ChangeScene(int sceneIndex)
    {
       // change scene
        SceneManager.LoadScene(sceneIndex);
    }
    public void ColorChangeButton()
    {
        //randomly picks color
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        // apply it on current object's material
        Modelrenderer.material.color = newColor;
    }
}
