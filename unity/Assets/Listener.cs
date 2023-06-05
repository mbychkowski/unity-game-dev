using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class Listener : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // Make a web request to get info from the server
    StartCoroutine( GetServerData("http://localhost:3000/users/", "2") );

  }

  void ProcessServerResponse ( string response )
  {
    JSONNode node = JSON.Parse( response );

    Debug.Log( "username:" + node["username"] );
    Debug.Log( "misc data:" + node["someArray"][1]["name"] + "=" + node["someArray"][1]["value"] );
  }

  IEnumerator GetServerData( string address, string userId )
  {
    // Create a web request to get info from the server
    UnityWebRequest request = UnityWebRequest.Get( "localhost:3000/users/" + userId );
    yield return request.SendWebRequest();

    if ( request.isNetworkError || request.isHttpError )
    {
      Debug.Log( "Error: " + request.error );
    }
    else
    {
      Debug.Log( "Response: " + request.downloadHandler.text );

      ProcessServerResponse(request.downloadHandler.text);
    }
  }
}
