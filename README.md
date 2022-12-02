# NunitTestAdapter
Ref: https://docs.nunit.org/articles/vs-test-adapter/Tips-And-Tricks.html#assemblyselectlimit

**Issue**

When the number of tests in a solution exceed 2000, dotnet test --filter is ignored and all tests within the solution are run regardless of any filter. 
In the included solution, there are three test classes A,B,and C with Class A having in excess of 2000 tests.

**Solution**

Create a .runsettings file and increase the AssemblySelectLimit to a number greater than the total number of tests in the solution. 
The file must be placed in the same folder where the DLL resides and referenced in the dotnet test command:

`<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <NUnit>
    <AssemblySelectLimit>5000</AssemblySelectLimit>
  </NUnit>
</RunSettings>
`

**To Reproduce**

Run the tests using the following to reproduce the issue. Tests in all 3 classes will be executed regardless of filter.

- dotnet test testproject1.dll --filter TestCategory~ClassA

[no_runsettings.txt](https://github.com/fenjas/NunitTestAdapter/files/10140870/no_runsettings.txt)


When a .runsettings file is included, only tests in ClassA are executed:

- dotnet test testproject1.dll --filter TestCategory~ClassA -s .runsettings

[with_runsettings.txt](https://github.com/fenjas/NunitTestAdapter/files/10140871/with_runsettings.txt)


