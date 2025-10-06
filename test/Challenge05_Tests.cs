﻿using ds_challenge_05.Controllers;

namespace Challenge5Tests;

public class Challenge05_Tests
{

    [Fact(DisplayName = "Test ChallengeMethod with a long enough string")]
    public void ChallengeMethod_WithSufficientLengthString_ReturnsFifthCharacter()
    {
        // Arrange
        var controller = new ChallengeMethodController();
        var input = "OpenShift DevSpaces";
        var expected = $"The Fifth Character in \"{input}\" is [S]\n";

        // Act
        var result = controller.ChallengeMethod(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact(DisplayName = "Test ChallengeMethod with a short string")]
    public void ChallengeMethod_WithShortString_ReturnsLengthErrorMessage()
    {
        // Arrange
        var controller = new ChallengeMethodController();
        var input = "four";
        var expected = "String is shorter than length 5 \n";

        // Act
        var result = controller.ChallengeMethod(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ChallengeMethod_ReturnsFifthCharacter_WhenStringLongEnough()
    {
        var controller = new ChallengeMethodController();
        string result = controller.ChallengeMethod("OpenShift DevSpaces");
        Assert.Contains("The Fifth Character", result);
        Assert.Contains("[S]", result); // "OpenShift DevSpaces"[4] == 'S'
    }

    [Fact]
    public void ChallengeMethod_ReturnsError_WhenStringTooShort()
    {
        var controller = new ChallengeMethodController();
        string result = controller.ChallengeMethod("Test");
        Assert.Equal("String is shorter than length 5 \n", result);
    }

    [Fact]
    public void ChallengeMethod_Overload_ReturnsCharacterAtIndex()
    {
        var controller = new ChallengeMethodController();
        string result = controller.ChallengeMethod("OpenShift", 2);
        Assert.Equal("The Character at index [2] in \"OpenShift\" is [e]\n", result);
    }

    [Fact]
    public void ChallengeMethod_Overload_ReturnsOutOfBounds_WhenIndexInvalid()
    {
        var controller = new ChallengeMethodController();
        string result = controller.ChallengeMethod("OpenShift", 20);
        Assert.Equal("Index [20] is out of bounds for \"OpenShift\"\n", result);
    }
}