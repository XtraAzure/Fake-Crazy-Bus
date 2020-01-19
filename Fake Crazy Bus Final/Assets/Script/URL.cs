using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YouTubeLinkClicked()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC2nOT3T5Otjvpe-SFu8XcVA/playlists");
    }

    public void ItchLinkClicked()
    {
        Application.OpenURL("https://resilience.itch.io/");
    }

    public void GithubLinkClicked()
    {
        Application.OpenURL("https://github.com/XtraAzure");
    }
}
