using NUnit.Framework;
using UnityEngine;

public class ResourceManagerTests
{
    [Test]
    public void AddWood_IncreasesWoodAmount()
    {
        // Arrange
        GameObject gameObject = new GameObject();
        ResourceManager resourceManager = gameObject.AddComponent<ResourceManager>();

        // Act
        resourceManager.AddWood(10);

        // Assert
        Assert.AreEqual(10, resourceManager.wood);

        // Cleanup
        Object.DestroyImmediate(gameObject);
    }
}