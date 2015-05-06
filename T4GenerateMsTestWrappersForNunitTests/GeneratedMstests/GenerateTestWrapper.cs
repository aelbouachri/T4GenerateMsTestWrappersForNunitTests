
// This is generated code using the T4 template
// The template file is C:\projects\github\T4GenerateMsTestWrappersForNunitTests\T4GenerateMsTestWrappersForNunitTests\GeneratedMstests\GenerateTestWrapper.tt
// Generated from MSBuild

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace GeneratedMsTest
{
    
		         ///
	         /// Adding tests found in the DLL C:\projects\github\T4GenerateMsTestWrappersForNunitTests\T4GenerateMsTestWrappersForNunitTests\GeneratedMstests\..\UnitTestProject1\bin\Debug\UnitTestProject1.dll
	         ///
		    [TestClass]
		    public class Generated_UnitTestProject1_NUnitTests 
		    {

			    private static UnitTestProject1.NUnitTests wrapperedTest = new UnitTestProject1.NUnitTests();
		
				public Generated_UnitTestProject1_NUnitTests()
				{
					//
					// Add constructor logic here if require
					//
				}

				private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance;

				/// <summary>
				///Gets or sets the test context which provides
				///information about and functionality for the current test run.
				///</summary>
				public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
				{
					get
					{
						return testContextInstance;
					}
					set
					{
						testContextInstance = value;
					}
				}

    							// Use ClassInitialize to run code before running the first test in the class
				[ClassInitialize()]
				public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext) 
				{ 
					wrapperedTest.FixtureSetup();		
				}
				        
    							// Use ClassCleanup to run code after all tests in a class have run
				[ClassCleanup()]
				public static void ClassCleanup() 
				{ 
					wrapperedTest.FixtureTearDown();
				}
				
    							// Use TestInitialize to run code before running each test 
				[TestInitialize()]
				public void TestInitialize() 
				{ 
					 wrapperedTest.Setup();
				}

				
    							// Use TestCleanup to run code after each test has run
				[TestCleanup()]
				public void TestCleanup() 
				{ 
					wrapperedTest.TearDown();
				}
   				

								[TestMethod]
				public void Generated_FailingNUnitTest()
				{
					wrapperedTest.FailingNUnitTest();
				}
							[TestMethod]
				public void Generated_PassingNUnitTest()
				{
					wrapperedTest.PassingNUnitTest();
				}
					}
		
	
		         ///
	         /// Adding tests found in the DLL C:\projects\github\T4GenerateMsTestWrappersForNunitTests\T4GenerateMsTestWrappersForNunitTests\GeneratedMstests\..\UnitTestProject2\bin\Debug\UnitTestProject2.dll
	         ///
		    [TestClass]
		    public class Generated_UnitTestProject2_MoreNUnitTests 
		    {

			    private static UnitTestProject2.MoreNUnitTests wrapperedTest = new UnitTestProject2.MoreNUnitTests();
		
				public Generated_UnitTestProject2_MoreNUnitTests()
				{
					//
					// Add constructor logic here if require
					//
				}

				private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContextInstance;

				/// <summary>
				///Gets or sets the test context which provides
				///information about and functionality for the current test run.
				///</summary>
				public Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
				{
					get
					{
						return testContextInstance;
					}
					set
					{
						testContextInstance = value;
					}
				}

    			        
    			
    			
    			

								[TestMethod]
				public void Generated_PassingNUnitTestInAnotherClass()
				{
					wrapperedTest.PassingNUnitTestInAnotherClass();
				}
					}
		
	
}

