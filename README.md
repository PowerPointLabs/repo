<img src="https://raw.githubusercontent.com/PowerPointLabs/PowerPointLabs-Installer/master/PowerPointLabsInstaller/PowerPointLabsInstallerUi/Resources/logo.png" width='300'>

The typical PowerPoint presentation isn't very interesting. Walls of text or bullet points, with few visuals - it's no wonder audiences find it hard to pay attention.
Your slides don't have to be this way, and it doesn't take a whole lot of effort to make them better.
PowerPointLabs makes creating engaging PowerPoint presentations easy. Check out what it can do for you here: http://powerpointlabs.info

[![Build status](https://img.shields.io/appveyor/ci/kai33/powerpointlabs/master.svg)](https://ci.appveyor.com/project/kai33/powerpointlabs)

## Contributing
We welcome any contributions to make PowerPointLabs better! Before starting, please take a moment to review the guidelines below:
* [Contributing Guide](https://github.com/PowerPointLabs/powerpointlabs/blob/master/.github/CONTRIBUTING.md): Details what you need to know/do to become a contributor
* [Project Set-up/Testing Guide](https://github.com/PowerPointLabs/PowerPointLabs/blob/master/doc/ProjectSetUp.md): Details how to set-up and test in the dev environment
* [Software Design](https://github.com/PowerPointLabs/PowerPointLabs/blob/master/doc/SoftwareDesign.md): Details the design of the project architecture 

## Documentation
This section contains information that can be beneficial for PowerPointLabs developers.
* Newcomer Guide
* Common PowerPoint Add-in Development Traps
* Dealing with Functional Tests
* Technical Troubleshooting Guide
* PowerPointLabs Website GIFs Guide
* Project Ideas
* Development Team

### Contributing To PowerPointLabs
Interested to contribute? Please take a moment to review the [guidelines for contributing](https://github.com/PowerPointLabs/powerpointlabs/blob/master/.github/CONTRIBUTING.md) and [the design](https://github.com/PowerPointLabs/PowerPointLabs/blob/master/doc/SoftwareDesign.md).

### Dev Prerequisites
0. Install Office 2016 or 2013 with PowerPoint.
1. Install SourceTree (recommended), GitHub for Windows, or at least, Git.
2. Install Visual Studio 2015.
3. Install `VSTO for IDE` (Visual Studio Tools for Office, AKA the Office SDK):<br>
   for VS2015 - http://aka.ms/OfficeDevToolsForVS2015<br>
4. Install Microsoft .NET Framework 4.6.

### Setup
0. [Fork](http://help.github.com/fork-a-repo/) and clone the source codes from this repo.
1. Turn off *Office Version Upgrading*: Open the solution `PowerPointLabs\PowerPointLabs.sln` >> open Tools (menu) >> Options >> Office Tools >> Project Migration >> uncheck ‘Always upgrade to installed version of Office’.
2. Set up *External Office Program*: Open ‘PowerPointLabs’ Properties >> Debug >> select ‘Start external program’ and choose `POWERPNT.exe` in the Office folder. Ensure that both **Debug** and **Release** configurations have set up this.
3. Run the solution by pressing F5 and then PowerPointLabs tab will appear in the PowerPoint ribbon. If you have installed PowerPointLabs add-in, you may have to uninstall it first and rebuild the solution.
4. If failed to build PowerPointLabs solution, try to install `VSTO for PowerPoint` from [this link](http://powerpointlabs.info/vsto-redirect.html).

### Testing
0. Click Build (menu) >> Rebuild Solution.
1. Click Test (menu) >> Windows >> Test Explorer. 
2. In the open Test Explorer window, click `Group by Traits` >> right click `FT` >> click `Run Selected Tests`. During the test, *DO NOT move the mouse & ensure the Windows UI is in English*.
3. In the open Test Explorer window, click `Group by Traits` >> right click `UT` >> click `Run Selected Tests`.

### Current Dev Team

Mentors: Damith C. Rajapakse, Xie Kai

Team Leads: Ian Teo, Ong Heng Le

Senior Devs: Ang Shi Ya, Jamos Tay, Kenneth Loh, Syed Abdullah

Area | Responsibilities | Lead | Co-Lead | Past Leads
-----|------------------|------|---------|-----|
Community | Community growth, user support | Kenneth | Heng Le | Fiona |
Docs | Website, tutorials, dev docs | Jamos | Shi Ya | Fiona |
DevOps | Installer, issue tracker, releases, CI | Syed | Kenneth | Hanyang |
Quality | Code quality, design quality | Heng Le | Jamos | Kai |
Testing | Test coverage, test automation | Ian | Syed | Kai |
UI/UX | UI matters, UX matters | Shi Ya | Ian |  |

Feature  | Lead | Co-Lead | Past Leads
-----|------|---------|-----|
AgendaLab | Syed |  | Shunhao, Huang Da
AnimationLab (d) | Ian |  | Raunak
CaptionsLab | Kenneth |  | Jerome
ColorsLab | Ian | Heng Le | Karan
CropLab | Heng Le | Jamos | Raunak
EffectsLab | Ian | Heng Le | Fiona
HighlightLab | Syed |  | Karan
NarrationsLab | Kenneth |  | Jerome
PasteLab | Syed | Heng Le |
PictureSlideLab | Shi Ya |  | Xie Kai
PositionsLab | Jamos |  | Oswell, Victor
ResizeLab | Min Oo | Yu Ting |  
ShapesLab (d) | Ian | Kenneth | Huang Da
ShortcutsLab | Heng Le | Ian | Raunak
SyncLab | Ian | Kenneth |
TimerLab | Shi Ya | Heng Le |
ZoomLab | Shi Ya |  | Raunak

Features marked as _(d)_ are deprecated because PowerPoint has added similar features in the recent versions.

## Acknowledgements
PowerPointLabs is developed at the School of Computing, National University of Singapore, with funding from an NUS Learning Innovation Fund, Technology (LIFT) grant.

## License
PowerPointLabs is released under GPLv2.
