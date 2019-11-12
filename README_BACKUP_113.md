<p align="center">
<img
    src="https://neo-cdn.azureedge.net/images/neo_logo.svg"
    width="250px">
</p>

<<<<<<< Updated upstream
=======
<h3 align="center">Neo Blockchain</h3>

<p align="center">
   A modern distributed network for the Smart Economy.
  <br>
  <a href="https://docs.neo.org/docs/en-us/index.html"><strong>Documentation »</strong></a>
  <br>
  <br>
  <a href="https://github.com/neo-project/neo"><strong>Neo</strong></a>
  ·
  <a href="https://github.com/neo-project/neo-vm">Neo VM</a>
  ·
  <a href="https://github.com/neo-project/neo-plugins">Neo Plugins</a>
  ·
  <a href="https://github.com/neo-project/neo-devpack-dotnet">Neo DevPack</a>
  ·
  <a href="https://github.com/neo-project/neo-cli">Neo CLI</a>
</p>
>>>>>>> Stashed changes
<p align="center">
  <a href="https://travis-ci.org/neo-project/neo">
    <img src="https://travis-ci.org/neo-project/neo.svg?branch=master" alt="Current TravisCI build status.">
  </a>
  <a href="https://github.com/neo-project/neo/releases">
    <img src="https://badge.fury.io/gh/neo-project%2Fneo.svg" alt="Current neo version.">
  </a>
  <a href="https://codecov.io/github/neo-project/neo/branch/master/graph/badge.svg">
    <img src="https://codecov.io/github/neo-project/neo/branch/master/graph/badge.svg" alt="Current Coverage Status." />
  </a>
  <a href="https://github.com/neo-project/neo/blob/master/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="License.">
  </a>
</p>

NEO 3.0 (under development): A distributed network for the Smart Economy
================

<<<<<<< Updated upstream
NEO uses digital identity and blockchain technology to digitize assets and leverages smart contracts for autonomously managed digital assets to create a "smart economy" within a decentralized network.
=======
## Table of Contents
1. [Overview](#overview)
1. [Features](#features)
2. [Quickstart](#quick-start)
    1. [Using for smart-contract development](#building-a-smart-contract)
    1. [Using neo library](#using-neo-library)
    <!-- 1. [Using with Unity]() -->
    3. [Using neo-cli releases](#using-neo-cli-releases)
    <!-- 3. [Using docker](#third-example)
    3. [Using plugins]()
    3. [Writing a plugin](#third-example)
    3. [Running a single node blockchain]() -->
4. [Status](#status)
    <!-- 1. [Repository status]()
    2. [Development progress]() -->
5. [Reference implementations](#reference-implementations)
    <!-- 1. [Differences between Neo 2 and Neo 3](#fourth-examplehttpwwwfourthexamplecom)
    3. [Neo 3 Explorer](#explorer)
    3. [Daily builds](#daily-builds) -->
6. [Opening an issue](#opening-a-new-issue)  
7. [Bounty program](#bounty-program)
7. [Articles and blogs](#fourth-examplehttpwwwfourthexamplecom)
7. [How to contribute](#fourth-examplehttpwwwfourthexamplecom)

## Overview
Neo is a blockchain technology built using C# that levereages smart contracts to autonomumously manage digital assets. Using dBFT 2.0 as consensus mechanism, Neo can achieves single block finality in 15 seconds without forking.   
Neo is compatible with .NET Core 3.0 and .NET Standard 2.1.

To learn more about NEO, please read the White Paper:  
- [English](https://docs.neo.org/en-us/whitepaper.html)  
- [白皮书](https://docs.neo.org/zh-cn/whitepaper.html)

*Note: This is Neo 3 branch, currently under development. For the current stable version, please [click here]()*

## Features
These are a few features Neo has:
>>>>>>> Stashed changes

To learn more about NEO, please read the [White Paper](https://docs.neo.org/en-us/whitepaper.html)|[白皮书](https://docs.neo.org/zh-cn/whitepaper.html).

NEO 2.x: Reference template  
================

NEO adopts a model of continuous improvement and evolution.
We believe that the research and development of blockchain technology will be kept in continuous transformation for the next years.
From 2017 until the middle of 2020 (estimated), NEO 2.x will still be supported and the compatibility of new packages will be maintained.

A link to the essential C# reference implementation can be seen below:

<<<<<<< Updated upstream
* [neo](https://github.com/neo-project/neo/tree/master-2.x): core implementation (branch `master-2.x`)
* [neo-vm](https://github.com/neo-project/neo-vm/tree/master-2.x): virtual machine (branch `master-2.x`)
* [neo-cli](https://github.com/neo-project/neo-cli/tree/master-2.x): command-line interface (branch `master-2.x`)
* [neo-plugins](https://github.com/neo-project/neo-plugins/tree/master-2.x): plugins (branch `master-2.x`)
* [neo-devpack-dotnet](https://github.com/neo-project/neo-devpack-dotnet/tree/master-2.x): NeoContract compiler and development pack for .NET (branch `master-2.x`)
=======
#### Building a smart-contract
Neo reference implementation offers C# smart-contract support. The code is first compiled to MSIL and subsequentially compiled to a *neo executable file (nef)* 

*Suggestion: Please visit [Neo Blockchain Toolbox](https://github.com/neo-project/neo-blockchain-toolkit) for a complete setup.*
>>>>>>> Stashed changes

NEO 1.x was known as Antshares and the roots of the code can be found historically in this current repository.

<<<<<<< Updated upstream
Supported Platforms
--------

We already support the following platforms:
=======
7. Build `Neo.SmartContract.Framework.csproj` project. Check where neon.dll is saved, example:  
    ```
    C:\Users\neo\Workspace\readme-test\neo-devpack-dotnet\src\Neo.Compiler.MSIL\bin\Debug\netcoreapp3.0\neon.dll
    ```
8. Add a post build event to your smart-contract project:

    ```
    dotnet  C:\Users\neo\Workspace\readme-test\neo-devpack-dotnet\src\Neo.Compiler.MSIL\bin\Debug\netcoreapp3.0\neon.dll $(TargetPath)
    ```
>>>>>>> Stashed changes

* CentOS 7
* Docker
* macOS 10 +
* Red Hat Enterprise Linux 7.0 +
* Ubuntu 14.04, Ubuntu 14.10, Ubuntu 15.04, Ubuntu 15.10, Ubuntu 16.04, Ubuntu 16.10
* Windows 7 SP1 +, Windows Server 2008 R2 +

<<<<<<< Updated upstream
We will support the following platforms in the future:
=======
#### Using Neo library 
Use this to run a node or send commands to the network.  
This is how you should use Neo. If you can't use C#, consider using RPC endpoints with [neo-cli](https://github.com/neo-project/neo-cli).  
>>>>>>> Stashed changes

* Debian
* Fedora
* FreeBSD
* Linux Mint
* OpenSUSE
* Oracle Linux

Development
--------

To start building peer applications for NEO on Windows, you need to download [Visual Studio 2017](https://www.visualstudio.com/products/visual-studio-community-vs), install the [.NET Framework 4.7 Developer Pack](https://www.microsoft.com/en-us/download/details.aspx?id=55168) and the [.NET Core SDK](https://www.microsoft.com/net/core).

If you need to develop on Linux or macOS, just install the [.NET Core SDK](https://www.microsoft.com/net/core).

To install Neo SDK to your project, run the following command in the [Package Manager Console](https://docs.nuget.org/ndocs/tools/package-manager-console):

<<<<<<< Updated upstream
```
PM> Install-Package Neo
```
=======
5. Linux - Install dependencies:
    ```bash
    apt-get update && apt-get install -y \
        libleveldb-dev \
        sqlite3 \
        libsqlite3-dev \
        libunwind8-dev 
    ```
    <!-- *Check out our [Dockerhub]() for more linux examples.* -->
>>>>>>> Stashed changes

For more information about how to build DAPPs for NEO, please read the [documentation](http://docs.neo.org/en-us/sc/introduction.html)|[文档](http://docs.neo.org/zh-cn/sc/introduction.html).

<<<<<<< Updated upstream
Daily builds
--------
=======
#### Using neo-cli releases
Neo-cli is a full node with wallet capabilities. It also supports RPC endpoints allowing it to be managed remotely.  
>>>>>>> Stashed changes

If you want to use the [latest daily build](https://www.myget.org/feed/neo/package/nuget/Neo) then you need to add a NuGet.Config to your app with the following content:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <clear />
        <add key="MyGet-neo" value="https://www.myget.org/F/neo/api/v3/index.json" />
        <add key="NuGet.org" value="https://api.nuget.org/v3/index.json" />
    </packageSources>
</configuration>
```

<<<<<<< Updated upstream
*NOTE: This NuGet.Config should be with your application unless you want nightly packages to potentially start being restored for other apps on the machine.*

How to Contribute
--------

You can contribute to NEO with [issues](https://github.com/neo-project/neo/issues) and [PRs](https://github.com/neo-project/neo/pulls). Simply filing issues for problems you encounter is a great way to contribute. Contributing implementations is greatly appreciated.

We use and recommend the following workflow:

1. Create an issue for your work.
    * You can skip this step for trivial changes.
	* Reuse an existing issue on the topic, if there is one.
	* Clearly state that you are going to take on implementing it, if that's the case. You can request that the issue be assigned to you. Note: The issue filer and the implementer don't have to be the same person.
1. Create a personal fork of the repository on GitHub (if you don't already have one).
1. Create a branch off of master(`git checkout -b mybranch`).
    * Name the branch so that it clearly communicates your intentions, such as issue-123 or githubhandle-issue.
	* Branches are useful since they isolate your changes from incoming changes from upstream. They also enable you to create multiple PRs from the same fork.
1. Make and commit your changes.
1. Add new tests corresponding to your change, if applicable.
1. Build the repository with your changes.
    * Make sure that the builds are clean.
	* Make sure that the tests are all passing, including your new tests.
1. Create a pull request (PR) against the upstream repository's master branch.
    * Push your changes to your fork on GitHub.

Note: It is OK for your PR to include a large number of commits. Once your change is accepted, you will be asked to squash your commits into one or some appropriately small number of commits before your PR is merged.

License
------
=======
5. Use `help` to see the command list.

<!-- #### Running a Neo node using Docker
You can run Neo using neo-cli inside a docker container.  

1. Pull one of our base images: 
    ```bash
    docker pull neofoundation/neo3:testnet-slim-centos7
    ```
2. Run it exposing the required ports and a volume to store persistent data:
    ```
    docker run -p 20332-20336:20332-20336 -v persistentData:/neo-cli/persistentData neofoundation/neo3:testnet-slim-centos7
    ``` -->



<!-- #### Using a light-wallet
A light wallet is the easiest way to interact with the Neo blockchain. If you are only interested in use Neo dApps and not build one, a light-wallet may be the best option for you.  
For Neo 3 (development), use [Neo3-preview.com](https://neo3-preview.com/) (community supported).  

If you are looking use Neo with real assets, find your prefered wallet [here](https://neo.org/wallets). -->

## Status
<p>
  <a href="https://travis-ci.org/neo-project/neo">
    <img src="https://travis-ci.org/neo-project/neo.svg?branch=master" alt="Current TravisCI build status.">
  </a>
  <a href="https://github.com/neo-project/neo/releases">
    <img src="https://badge.fury.io/gh/neo-project%2Fneo.svg" alt="Current neo version.">
  </a>
  <a href="https://codecov.io/github/neo-project/neo/branch/master/graph/badge.svg">
    <img src="https://codecov.io/github/neo-project/neo/branch/master/graph/badge.svg" alt="Current Coverage Status." />
  </a>
  <a href="https://github.com/neo-project/neo/blob/master/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="License.">
  </a>
</p>


#### Reference implementations
Code references are provided for all platform building blocks. Tha includes the base library, the VM, a command line application and the compiler. Plugins are also included to easily extend Neo functinalities.

* [**neo:**](https://github.com/neo-project/neo/tree/master-2.x) Neo core library, contains base classes, including ledger, p2p and IO modules.
* [neo-vm:](https://github.com/neo-project/neo-vm/tree/master-2.x) Neo Virtual Machine is a decoupled VM that Neo uses to execute its scripts. It also uses the `InteropService` layer to extend its functionalities.
* [neo-cli:](https://github.com/neo-project/neo-cli/tree/master-2.x) Neo Command Line Interface is an executable that allows you to run a Neo node using the command line. 
* [neo-plugins:](https://github.com/neo-project/neo-plugins/tree/master-2.x) Neo plugin system is the default way to extend neo features. If a feature is not mandatory for Neo functionality, it will probably be implemented as a Plugin.
* [neo-devpack-dotnet:](https://github.com/neo-project/neo-devpack-dotnet/tree/master-2.x) These are the official tools used to convert a C# smart-contract into a *neo executable file*.

#### Opening a new issue
Please feel free to create new issues in our repository. We encourage you to use one of our issue templates when creating a new issue.  

- [Feature request](https://github.com/neo-project/neo/issues/new?assignees=&labels=&template=bug_report.md&title=)
- [Bug report](https://github.com/neo-project/neo/issues/new?assignees=&labels=&template=bug_report.md&title=)
- [Questions](https://github.com/neo-project/neo/issues/new?assignees=&labels=question&template=questions.md&title=)

If you found a security issue, please refer to our [security policy](https://github.com/neo-project/neo/security/policy).

#### Bounty program
You can be rewarded by finding security issues. Please refer to our [bounty program page](https://neo.org/bounty) for more information.
>>>>>>> Stashed changes

#### License
The NEO project is licensed under the [MIT license](LICENSE).
