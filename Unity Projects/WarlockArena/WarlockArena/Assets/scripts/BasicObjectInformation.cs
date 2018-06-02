using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicObjectInformation {
    private string name, description;
    private Sprite icon;
	
    public BasicObjectInformation(string oName)
    {
        name = oName;
    }
    public BasicObjectInformation(string oName, string oDescription)
    {
        name = oName;
        description = oDescription;
    }
    public BasicObjectInformation(string oName, string oDescription, Sprite oIcon)
    {
        name = oName;
        description = oDescription;
        icon = oIcon;
    }

    public string objectName
    {
        get { return name; }
    }

    public string objectDescription
    {
        get { return description; }
    }

    public Sprite objectIcon
    {
        get { return icon; }
    }

}
