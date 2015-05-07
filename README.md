# T4 Generator for MsTest Wrappers For nUnit Tests
This is a project that uses T4 templates to generate a MsTest wrappers for any nUnit tests found in the solution.

It was created to allow unit test, that were written using nUnit, to be exposed in a manner that allowed them to be used in Microsoft Test Manager based test automation. 

Beyond the actual [T4 template](https://github.com/rfennell/T4GenerateMsTestWrappersForNunitTests/blob/master/T4GenerateMsTestWrappersForNunitTests/GeneratedMstests/GenerateTestWrapper.tt), which you may need to edit to meet your needs, all the interesting work is done in the [CSPROJ file](https://github.com/rfennell/T4GenerateMsTestWrappersForNunitTests/blob/master/T4GenerateMsTestWrappersForNunitTests/GeneratedMstests/GeneratedMstests.csproj). In this file there are edits (around line 100) were targets are added to allow the template based code to be regenerated on any re-compile of the solution (and to expose MSBuild properties). This is as opposed to the re-generation only occuring when the .TT file is edited.

## Usage
Add the GeneratedMstests project to your solution and add reference from it to any projects in the solution containing nUnit tests.

##More Information
Extra background and documentation can be found in [this blog post]( http://blogs.blackmarble.co.uk/blogs/rfennell/post/2015/05/07/Generating-MsTest-wrappers-for-nUnit-tests.aspx)
