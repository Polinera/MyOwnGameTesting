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

    [Test]
public void SpendWood_WithEnoughWood_DecreasesWoodAmount()
{
    // Arrange
    GameObject gameObject = new GameObject();
    ResourceManager resourceManager = gameObject.AddComponent<ResourceManager>();

    resourceManager.wood = 20;

    // Act
    bool result = resourceManager.SpendWood(5);

    // Assert
    Assert.IsTrue(result);
    Assert.AreEqual(15, resourceManager.wood);

    // Cleanup
    Object.DestroyImmediate(gameObject);
}

[Test]
public void SpendWood_WithoutEnoughWood_DoesNotChangeWoodAmount()
{
    // Arrange
    GameObject gameObject = new GameObject();
    ResourceManager resourceManager = gameObject.AddComponent<ResourceManager>();

    resourceManager.wood = 3;

    // Act
    bool result = resourceManager.SpendWood(5);

    // Assert
    Assert.IsFalse(result);
    Assert.AreEqual(3, resourceManager.wood);

    // Cleanup
    Object.DestroyImmediate(gameObject);
}
}