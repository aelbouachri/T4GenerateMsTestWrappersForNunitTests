
// This is generated code using the T4 template by C:\tmp\ex1\WebApplication1\GeneratedMstests\GenerateTestWrapper.tt
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace GeneratedMsTest
{
    // Considering DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject1\bin\Debug\nunit.framework.dll
	   
	// Considering DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject1\bin\Debug\UnitTestProject1.dll
	   	         ///
	         /// Adding tests found in the DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject1\bin\Debug\UnitTestProject1.dll
	         ///
		    [TestClass]
		    public class Generated_UnitTestProject1_NUnitTests 
		    {

			    private static UnitTestProject1.NUnitTests wrapperedTest = new UnitTestProject1.NUnitTests();
		
				public Generated_UnitTestProject1_NUnitTests()
				{
					//
					// TODO: Add constructor logic here
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
		
	// Considering DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject2\bin\Debug\nunit.framework.dll
	   
	// Considering DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject2\bin\Debug\UnitTestProject2.dll
	   	         ///
	         /// Adding tests found in the DLL C:\tmp\ex1\WebApplication1\GeneratedMstests\..\UnitTestProject2\bin\Debug\UnitTestProject2.dll
	         ///
		    [TestClass]
		    public class Generated_UnitTestProject2_MoreNUnitTests 
		    {

			    private static UnitTestProject2.MoreNUnitTests wrapperedTest = new UnitTestProject2.MoreNUnitTests();
		
				public Generated_UnitTestProject2_MoreNUnitTests()
				{
					//
					// TODO: Add constructor logic here
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

