## Neo PR Test Report

**Repository:** neo-devpack-dotnet  
**Number:** 129  
**Title:** Write manifest file with storage and payable according the contract needs  
**Change description:** Users can now use Payable and HasStorage flags.


## Code version / branch

**Neo-devpack-dotnet:**  shargon:fix-storage-payable

## Test Results

| Test Name | OS | Test Result |
| ------- |:-------:| --:|
| Initial UT | Windows 10 x64 | OK | 
| Compile Contract using Payable attribute |  Windows 10 x64 | OK | 
| Compile Contract 2 using HasStorage attribute  | Windows 10 x64 | OK | 
| Compile Contract using both HasStorage and Payable attribtues | Windows 10 x64 | OK | 

## Additional info
Code worked as expected. The manifest file was generated correctly.
We noticed that it wasn't possible to compile the contract using the command line, but we suppose this is a different problem. The code is looking for the PDB file at the current folder, instead of the dll folder.
```
PS C:\Users\HP\Workspace\neo-devpack-dotnet> dotnet src\Neo.Compiler.MSIL\bin\Debug\netcoreapp2.0\neon.dll TestContract\bin\Debug\netstandard2.1\TestContract.dll
Neo.Compiler.MSIL console app v2.4.1.0
Open File Error:System.IO.DirectoryNotFoundException: Could not find a part of the path 'C:\Users\HP\Workspace\neo-devpack-dotnet\TestContract\bin\Debug\netstandard2.1\TestContract\bin\Debug\netstandard2.1\TestContract.dll'.
   at System.IO.FileStream.ValidateFileHandle(SafeFileHandle fileHandle)
   at System.IO.FileStream.CreateFileOpenHandle(FileMode mode, FileShare share, FileOptions options)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share)
   at System.IO.File.OpenRead(String path)
   at Neo.Compiler.Program.Main(String[] args) in C:\Users\HP\Workspace\neo-devpack-dotnet\src\Neo.Compiler.MSIL\Program.cs:line 60
   ```


## **Test List**

**1. Initial UT**  
Run solution unit tests.

**2. Compile Contract using Payable attribute**  
  
Create a new SmartContract project and add the Payable attribute.

Expected result:
- Contract manifest should contain property `payable` set to true.

**2. Compile Contract using HasStorage attribute**  
  
Create a new SmartContract project and add the HasStorage attribute.

Expected result:
- Contract manifest should contain property `storage` set to true.

**2. Compile Contract using both HasStorage and Payable attributes**  
  
Create a new SmartContract project and add the HasStorage and Payable attributes.

Expected result:
- Contract manifest should contain property `storage` and `payable` set to true.