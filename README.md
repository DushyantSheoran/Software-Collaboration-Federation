# Software-Collaboration-Federation
Designed and implemented a Test Harness that uses App-domains to load test DLL's  • Implemented Build Server that builds both CPP and C# code files. • Xml Manager module for logging results of build server and test harness.  • Designed a Process Pool that supports independent build architecture, an interactive Client GUI using WPF.  • Implemented an Asynchronous Communication System between Servers (Mock Repository, Test Harness, Build Server and Client) using WCF and Blocking queue

#UI 
----
Navigation Tab:
1 Can go to crawl to the directories of the repositories
	TestLog Dir
	BuildLog Dir
	BuildRequest Dir

2>> To view list of TestLog doubleclick on testlog dir
3>> To view list of files of Build log doubleclick on build log dir
3>> Can view list of buildrequests and select by clicking the button will send to MotherBuilder via Repository

4>> To view contents of file doubleclick on the file name

CreateBuild Request Tab:
-------------------------
1>> Get TestDrivers by browsing(present in ReposStorage--> BuildRequest Folder and test cases too
2>> Add test to build by add button
3>> Create will make build request on test's added and send to repo for storage and on command to BuildServer

StartProcessPool and View Tab:
-------------------------------
1 >> Dispalys configuration information.
2>> Bottom block displays status of Build Server and test exceution status of TestHarness.
