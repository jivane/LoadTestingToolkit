# Visual Studio LoadTesting Toolkit

The goal of this sample is to help company developing web site to create load testing script for their website. 
All the script included are very simple.
They can be easily customizable for having a complex scenario


## Target Audience

- Application developer
- Architech

## Structure
- Data : All the url that need to be tested per scenario
- WebTest : contains all the scenario that need to be run in //
- LoadTest : The configuration to run the selected webtest in //

## Run the web test

To test a scenario, you can go to one webtest and click on the button located on upper left of the screen with the play icon. The data taken in account should be the associated CSV file in data section

## Run the load test

To run a loadtest, you can open MyCorpFull.loadtest and click on the play button on the top left.
You must change url tested with your own website.

## StressTestHelper
The stressTest helper is class library that can be bound a test level or request level. 
If before a test, you need to run a script to reset your platform like your data, you will have to create your custom script in here. 
If before a request, you need to generate a special id, information, guid, you can code directly your functional requirement in this place
If you need to change the standard behavior of the webtest like : 
You need to hit the different dependant url but not specific url from specific domain, you may have a look in SkipExternalUrl

If you need more plugin, I have plenty of them to share.

## Disclaimer

The code is not supported under any company support program or service. The sample is provided AS IS without warranty of any kind. I further disclaim all implied warranties including, without limitation, any implied warranties of merchantability or of fitness for a particular purpose. The entire risk arising out of the use or performance of the code and documentation remains with you. In no event shall its authors, or anyone else involved in the creation, production, or delivery of the scripts be liable for any damages whatsoever (including, without limitation, damages for loss of business profits, business interruption, loss of business information, or other pecuniary loss) arising out of the use of or inability to use the sample scripts or documentation, even if it has been advised of the possibility of such damages.