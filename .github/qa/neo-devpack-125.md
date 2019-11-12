## Neo PR Test Report

**Repository:** neo-devpack-dotnet  
**Number:** 125  
**Title:** Prevent events with return (2x)  
**Change description:** Port of #124 to 2x


## Code version / branch

**Neo-devpack-dotnet:**  shargon:close-123-2x


## Test Results

| Test Name | Network | OS | Test Result | Comments |
| ------- |:-------:| --:| -----------:| --------:|
| Initial UT | UT | Localhost | OK | 
| Additional unit test to delegate event with arguments | UT | Localhost | OK | |

## Additional info
The code works but removes a feature unecessarily. We recommend putting back the return type, even if it is always Void.
We merged #122 to test these changes.

## **Test List**

**1. Initial UT**  
Run solution unit tests.

**2. Additional unit test to event with return type**  
  
Create Smart Contract with event return type int.

Expected result:
- While reading Smart Contract, engine throws a NotSupportedException.

