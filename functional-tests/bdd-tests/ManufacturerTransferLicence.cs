﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: ManufacturerTransferLicence
    As a logged in business user
    I want to request a transfer of ownership for a manufacturer licence

@manufacturer @transfer @winery
Scenario: Transfer Licence (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee 
    And I request a transfer of ownership for Manufacturer
    And the account is deleted
    Then I see the login page

@manufacturer @transfer @brewery
Scenario: Transfer Licence (Brewery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a brewery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a transfer of ownership for Manufacturer
    And the account is deleted
    Then I see the login page

@manufacturer @transfer @distillery
Scenario: Transfer Licence (Distillery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a distillery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a transfer of ownership for Manufacturer
    And the account is deleted
    Then I see the login page

@manufacturer @transfer @copacker
Scenario: Transfer Licence (Co-packer)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a co-packer
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I pay the licensing fee
    And I request a transfer of ownership for Manufacturer
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./ManufacturerTransferLicence.feature")]
    [Collection("Liquor")]
    public sealed class ManufacturerTransferLicence : TestBase
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