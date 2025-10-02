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
}