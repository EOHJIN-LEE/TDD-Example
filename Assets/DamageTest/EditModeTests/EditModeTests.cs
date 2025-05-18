using System.Text.RegularExpressions;
using NUnit.Framework;

public class EditTests
{
    [TestCase(false, 1,2)]
    [TestCase(false, 2,3)]
    [TestCase(true, 1,2)]
    [TestCase(true, 2,3)]
    public static void 計算のテスト(bool isPlus, int a, int b)
    {
        if (isPlus)
        {
            var result = a + b;
            Assert.AreEqual(result, a + b);
        }
        else
        {
            var result = a - b;
            Assert.AreEqual(result, a - b);
        }
    }
    
    [TestCase("テキストテスト<>", "テキストテスト")]
    [TestCase("<テキストテスト>", "テキストテスト")]
    [TestCase("テキスト>テスト<", "テキストテスト")]
    public void 特殊文字を消すRegexをテスト(string text, string expectedResult)
    {
        var result = RemoveSpecialCharacters(text);
        Assert.That(result.after, Is.EqualTo(expectedResult));
        Assert.That(result.before, Is.EqualTo(text));
    }

    private static (string after, string before) RemoveSpecialCharacters(string input)
    {
        return (Regex.Replace(input, @"[^\w\s가-힣]", ""), input);
    }
}
