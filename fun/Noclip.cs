// How to use: Compile it lol (using Melon Loader's C# Compiler), if you switch characters you WILL have to re-compile the script.
GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

foreach (GameObject obj in allGameObjects)
{
    if (obj.name == "WallCollider")
    {
        obj.SetActive(false);
    }
}