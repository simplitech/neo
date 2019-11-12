## Neo PR Test Report

**Repository:** neo-devpack-dotnet  
**Number:** 122  
**Title:** Fix ABI bug for 2.x     
**Change description:** Fixed #120

## Code version / branch

**Neo-devpack-dotnet:**  Branch_master-2.x_fixabi  


## Test Results

| Test Name | Network | OS | Test Result | Comments |
| ------- |:-------:| --:| -----------:| --------:|
| Initial UT | UT | Localhost | OK | 
| Additional unit test using delegate event with arguments | UT | Localhost | OK | |
| Additional unit test using action and delegate events with arguments | UT | Localhost | OK |  |
| Additional unit test using delegate event without arguments | UT| Localhost | OK |  |
| Additional unit test using inner class events | UT| Localhost | OK |  |

#### Additional info
The ABI is not deployed on Neo 2, so there is no need to deploy it on any network.


## **Test List**

**1. Initial UT**  
Run solution unit tests.

**2. Additional unit test to delegate event with arguments**  
  
Create Smart Contract with delegate event with arguments.

Expected result:
- Event data is written with arguments in abi file

**3. Additional unit test to action and delegate events with arguments**  

Create Smart Contract with action and delegate events with arguments.

Expected result:  
- Data from both events are written with arguments in abi file.  

**4. Additional unit test to delegate event without arguments**  

Create Smart Contract with delegate event without arguments.

Expected results:
- Event data is written in abi file.
- Arguments field is empty.

**5. Additional unit test to inner class events**  

Create Smart Contract with delegate event inside a inner class.

Expected results:
- Event data is written in abi file.









