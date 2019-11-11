## Neo PR Test Report

**Repository:** neo-devpack-dotnet  
**Number:** 131  
**Title:** Allow neon to compile from the source  
**Change description:** Neon was updated to support *.cs file compilation.


## Code version / branch

**Neo-devpack-dotnet:**  shargon:compile-source

## Test Results

| Test Name | Network | OS | Test Result | Comments |
| ------- |:-------:| --:| -----------:| --------:|
| Initial UT |  | Windows 10 x64 | OK | 
| Compile Contract 1 from unit tests |  | Windows 10 x64 | OK | |
| Compile Contract 2 from unit tests |  | Windows 10 x64 | NOK | Conversion errors occurred during compilation. Failed identification of Smart Contract Framework method. |

## Additional info
We made two tests that should have the same results, but one of them failed to compile the smart-contract. We followed instructions provided in the PR.


## **Test List**

**1. Initial UT**  
Run solution unit tests.

**2. Compile Contract 1 from unit tests**  
  
The test was to compile the same file that is used in unit tests, using the command line. 
Contract code:
```CSharp
namespace Neo.Compiler.MSIL.TestClasses
{
    public class Contract1 : SmartContract.Framework.SmartContract
    {
        //default smartcontract entry point.
        //but the unittest can be init from anywhere
        //no need to add code in Main.
        public static object Main(string method, object[] args)
        {
            return UnitTest_001();
        }
        public static byte[] UnitTest_001()
        {
            var nb = new byte[] { 1, 2, 3, 4 };
            return nb;
        }

    }
}
```

Expected result:
- File compiled sucessfully.

**3. Compile Contract 2 from unit tests**  
The test was to compile the same file that is used in unit tests, using the command line. 
Contract code:
```CSharp
namespace Neo.Compiler.MSIL.TestClasses
{
    public class Contract2 : SmartContract.Framework.SmartContract
    {
        //default smartcontract entry point.
        //but the unittest can be init from anywhere
        //no need to add code in Main.
        public static object Main(string method, object[] args)
        {
            Neo.SmartContract.Framework.Services.Neo.Runtime.Notify(args[0]);
            Neo.SmartContract.Framework.Services.Neo.Runtime.Notify(args[2]);
            return UnitTest_002();
        }
        public static byte UnitTest_002()
        {
            var nb = new byte[] { 1, 2, 3, 4 };
            return nb[2];
        }
    }
}

```

Expected result:
- File compiled sucessfully.

Actual result:
Compilation failed caused by Neo.SmartContract.Framework not being found.