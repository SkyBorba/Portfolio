using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Changes character on left mouse button
/// </summary>
public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCharacter0;
    [SerializeField]
    GameObject prefabCharacter1;
    [SerializeField]
    GameObject prefabCharacter2;
    [SerializeField]
    GameObject prefabCharacter3;

    // need for location of new character
    GameObject currentCharacter;

    // first frame input support
    bool previousChangeCharacterInput = false;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(
            prefabCharacter0, Vector3.zero,
            Quaternion.identity);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // change character on left mouse button
        if (Input.GetAxis("ChangeCharacter") > 0)
        {
            if (previousChangeCharacterInput == false)
            {
                previousChangeCharacterInput = true;

                // save position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                // instantiate new character
                int prefabNumber = Random.Range(0, 4);
                if (prefabNumber == 0)
                {
                    currentCharacter = Instantiate<GameObject>(
                        prefabCharacter0, position, Quaternion.identity);
                }
                else if (prefabNumber == 1)
                {
                    currentCharacter = Instantiate<GameObject>(
                        prefabCharacter1, position, Quaternion.identity);
                }
                else if (prefabNumber == 2)
                {
                    currentCharacter = Instantiate<GameObject>(
                        prefabCharacter2, position, Quaternion.identity);
                }
                else
                {
                    currentCharacter = Instantiate<GameObject>(
                        prefabCharacter3, position, Quaternion.identity);
                }
            }
        }
        else
        {
            // no change character input
            previousChangeCharacterInput = false;
        }
    }
}
