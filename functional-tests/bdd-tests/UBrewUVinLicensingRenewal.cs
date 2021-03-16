﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: UBrewUVinLicensingRenewal
    As a logged in business user
    I want to pay the first year licensing fee for an approved UBrew/UVin Application
    And renew the licence

#-----------------------
# Expiry = Today
#-----------------------

@ubrewuvin @licencerenewal
Scenario: Today Negative Licence Renewal (UBrew)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a UBrew UVin application
    And I review the account profile for a private corporation
    And I complete the UBrew / UVin application for a private corporation
    And I enter the payment information
    And I confirm the payment receipt for a UBrew / UVin application
    And the application is approved
    And I pay the licensing fee 
    And the expiry date is changed using the Dynamics workflow named 26E7E116-DACE-426A-A798-E9134D913F19
    And I click on the link for Renew Licence
    And I renew the licence with negative responses for a UBrew operation
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./UBrewUVinLicensingRenewal.feature")]
    [Collection("Liquor")]
    public sealed class UBrewUVinLicensingRenewal : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}