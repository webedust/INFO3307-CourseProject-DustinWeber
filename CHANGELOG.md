# Changelog
Running log of all changes made to the TodoManager program.

## Unreleased
* Sort tasks based on due dates

## v1.0 - 15 October, 2020
### Fixed
* User can not create an empty task

### Changed
* Modifying a task will change the text of the "Create Task" button to "Modify Task"


## Pre-release 7 - 14 October, 2020
### Fixed
* User can not create a task containing illegal characters ( \ / : * ? " < > | )


### Added
* Tasks can now have due dates. If a due date is not set it will default to -1


### Changed
* Selected task's completion state is now also shown when viewing a task's information
* Put headers on task list and task information sections in the main form


## Pre-release 6 - 13 October, 2020
### Added
* Existing tasks can now be modified
* Tasks can now be toggled between complete/incomplete

### Changed
* Tasks are now saved directly as Objects

## Pre-release 5 - 12 October, 2020
### Added
* Changelog
* License
* Task deletion

### Changed
* Readme has been filled
* FileIO class is now static to simplify its usage

## Pre-release 4 - 7 October, 2020
### Fixed
* More than 1 task will now appear in the UI
* Accidentally ignored dll was added back in

## Pre-release 3 - 6 October, 2020
### Added
* Icon
* Task class

### Changed
* Create Task form now has a UI
* Tasks can now be written from the Create Task form
* Tasks are now written as json

## Pre-release 2 - 5 October, 2020
### Added
* UI for main form
* Empty Task Creation form

### Changed
* File IO functions moved to separate class

## Pre-release 1 - 17 September, 2020
### Added
* File IO functions
* Empty test placeholder

## Initial - 24 August, 2020
### Added
* Empty Windows Form project