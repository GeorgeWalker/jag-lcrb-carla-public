﻿ Feature: MarketEvent
    As a logged in business user
    I want to submit a market event for different manufacturer types

#-----------------------
# One Market Event
#-----------------------

 @marketevent @marketoneday @winery @release1
 Scenario: One Day Market Event (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the secondary Submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

#-----------------------
# Weekly Market Event
#-----------------------

 @marketevent @marketweekly @winery
 Scenario: Weekly Market Event (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the Submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

#-------------------------------------------------
# Bi-Weekly Market Event
# Note that 'bi-weekly' refers to twice per month
#-------------------------------------------------

 @marketevent @marketbiweekly @winery
 Scenario: Bi-Weekly Market Event (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

#-----------------------
# Monthly Market Event
#-----------------------

 @marketevent @marketmonthly @winery
 Scenario: Monthly Market Event (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the Submit button
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a monthly event
    And the account is deleted
    Then I see the login page

#-----------------------------------
# One Market Event - Save for Later
#-----------------------------------

 @marketeventonedaysave @marketoneday @winery
 Scenario: One Day Market Event Save For Later (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event for one date only
    And I click on the button for Save for Later
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a one day event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a one day event
    And the account is deleted
    Then I see the login page

#--------------------------------------
# Weekly Market Event - Save for Later
#--------------------------------------

 @marketeventweeklysave @marketweekly @winery
 Scenario: Weekly Market Event Save For Later (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event weekly
    And I click on the button for Save for Later
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a weekly event
    And the account is deleted
    Then I see the login page

#-----------------------------------------
# Bi-Weekly Market Event - Save for Later
#-----------------------------------------

 @marketeventbiweeklysave @marketbiweekly @winery
 Scenario: Bi-Weekly Market Event Save For Later (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event bi-weekly
    And I click on the button for Save for Later
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a bi-weekly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for a bi-weekly event
    And the account is deleted
    Then I see the login page

#---------------------------------------
# Monthly Market Event - Save for Later
#---------------------------------------

 @marketeventmonthlysave @marketmonthly @winery
 Scenario: Monthly Market Event Save For Later (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I request an on-site store endorsement
    And I click on the Licences tab
    And the on-site endorsement application is approved
    And I request a market event monthly
    And I click on the button for Save for Later
    And I click on the Licences tab
    And I click on the event history for markets
    And I click on the link for Draft
    And the market event data is correct for a monthly event saved for later
    And I click on the signature checkbox
    And I click on the Submit button
    And I click on the event history for markets
    And I click on the link for Approved
    And the market event data is correct for an approved monthly event
    And the account is deleted
    Then I see the login page