using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Listener : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // Make a web request to get info from the server
    StartCoroutine( GetServerData("http://localhost:3000/users/", "2") );

  }

  IEnumerator GetServerData( string address, string userId )
  {
    // Create a web request to get info from the server
    UnityWebRequest request = UnityWebRequest.Get( "http://localhost:3000/users/" + userId );
    yield return request.SendWebRequest();

    if ( request.isNetworkError || request.isHttpError )
    {
      Debug.Log( "Error: " + request.error );
    }
    else
    {
      Debug.Log( "Response: " + request.downloadHandler.text );
    }
  }
}
