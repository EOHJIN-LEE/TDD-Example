using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

public class DamageTestPlayModeTests
{
    [UnityTest]
    public IEnumerator モンスターはクリックされたらHPが10減る()
    {
        PrepareTest();
        var monsterGameObject = UnitTestHelper.InstantiateFromResource("Monster");
        var monster = monsterGameObject.GetComponent<Monster>();
        monster.Health = 10000;
        yield return null; //初期化
        
        monster.OnPointerClick(null); //Clickされたら
        Assert.AreEqual(9990, monster.Health);//10減る
    }

    private static void PrepareTest()
    {
        UnitTestHelper.CleanUp();
        UnitTestHelper.InstantiateFromResource("Main Camera");
        UnitTestHelper.InstantiateFromResource("EventSystem");
    }
}
