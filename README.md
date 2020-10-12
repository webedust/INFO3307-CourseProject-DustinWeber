# TodoManager
## Table of Contents
[Description](#description)  
[Installation](#installation)  
[Usage](#usage)  
[Credits](#credits)  
[License](#license)  
[Building](#building)  

## Description
TodoManager reads and writes tasks as json and can sort them based on due dates.

## Installation
TodoManager can be installed by downloading the latest stable build and running it on your computer.

Sometimes when first running TodoManager you may be prompted to install .NET Framework. If this happens but you already have .NET Framework installed,
first ensure you downloaded all the files required for the version of TodoManager and that all files are located in the same folder. 

## Usage
TodoManager can be used by either launching the program
and creating a new task via the "Create Task" window
OR importing your own Task json files (As long as they are formatted correctly) into the Tasks folder
adjacent to the program's .exe.

If no Tasks folder exists this is because the program has not been run yet.
To fix this, you can either create the folder yourself (Make sure to call it "Tasks")
or launch TodoManager, which will create the folder for you.

Please note that if you move TodoManager on your computer to move the Tasks folder
with it. Otherwise, TodoManager will not be able to find your Tasks. 

## Credits
Program created by Dustin Weber using C# Windows Forms

Packages used in the creation of this program:
* [Newtonsoft.Json - JamesNK](https://github.com/JamesNK/Newtonsoft.Json)
under the [MIT License](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)

## License
TodoManager is licensed under the [MIT License.](LICENSE.md)

## Building
Project can be built using Visual Studio by following the steps below
1. Import repository and open folder as project in Visual Studio
2. On the top ribbon Click Build > Build Solution OR Build TodoManager to only build the main program