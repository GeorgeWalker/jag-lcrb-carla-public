﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: ValidationCovid
    As a logged in business user
    I want to confirm the validation messages for the COVID temporary extension

@covid @validation
Scenario: Validate COVID Temp Extension Application
    Given I am not logged in to the Liquor and Cannabis Portal
    And I click on the COVID Temporary Extension link
    And I do not complete the temporary extension application
    And I click on the Submit button
    Then the COVID validation messages are displayed
*/

namespace bdd_tests
{
    [FeatureFile("./***.feature")]
    [Collection("Cannabis")]
    public sealed class ValidationCOVID : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LoggedInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLGIN();

            CheckFeatureFlagsIN();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}