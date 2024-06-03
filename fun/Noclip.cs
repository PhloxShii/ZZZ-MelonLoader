// TODO: Find a way to disable WallCollider
GameObject[] allGameObjects = GameObject.FindObjectsOfType<GameObject>();

foreach (GameObject obj in allGameObjects)
{
    if (obj.name == "WallCollider")
    {
        obj.SetActive(false);
    }
}