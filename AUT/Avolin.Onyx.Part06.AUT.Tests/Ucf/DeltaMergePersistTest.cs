using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.DeltaMergePersist" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DeltaMergePersistTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DeltaMergePersist" />)
        /// </summary>
        public DeltaMergePersistTest() : base(typeof(DeltaMergePersist))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergePersist) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _deltaMergePersistInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="DeltaMergePersist" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _deltaMergePersistInstanceType = typeof(DeltaMergePersist);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DeltaMergePersist) Initializer

        #region Methods

        private const string MethodWriteToFile = "WriteToFile";
        private const string MethodCreateFolder = "CreateFolder";
        private const string MethodValidateFolderPath = "ValidateFolderPath";

        #endregion

        #endregion

        #region General Initializer : Class (DeltaMergePersist) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DeltaMergePersist" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DeltaMergePersist_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DeltaMergePersist)

        #region General Initializer : Class (DeltaMergePersist) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DeltaMergePersist" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodWriteToFile, 0)]
        [TestCase(MethodWriteToFile, 1)]
        [TestCase(MethodCreateFolder, 0)]
        [TestCase(MethodCreateFolder, 1)]
        [TestCase(MethodValidateFolderPath, 0)]
        public void AUT_DeltaMergePersist_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (DeltaMergePersist) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DeltaMergePersist" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DeltaMergePersist_Is_Static_Type_Present_Test()
        {
            // Assert
            _deltaMergePersistInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (WriteToFile) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var fileUri = this.CreateType<string>();
            var content = this.CreateType<string>();
            var methodWriteToFileParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfWriteToFile = { fileUri, content };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWriteToFile, parametersOfWriteToFile, methodWriteToFileParametersTypes);

            // Assert
            parametersOfWriteToFile.ShouldNotBeNull();
            parametersOfWriteToFile.Length.ShouldBe(2);
            methodWriteToFileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToFile, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var methodWriteToFileParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteToFile, methodWriteToFileParametersTypes);

            // Assert
            methodWriteToFileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToFile, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergePersist_WriteToFile_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodWriteToFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteToFile, methodWriteToFileParametersTypes);
        }

        #endregion
        
        #region Method Call : (WriteToFile) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToFile, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var methodWriteToFileParametersTypes = new Type[] { typeof(string), typeof(System.Xml.XmlDocument) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteToFile, methodWriteToFileParametersTypes);

            // Assert
            methodWriteToFileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToFile) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_WriteToFile_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToFile);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToFile, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateFolder, methodCreateFolderParametersTypes);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();
            var rootFolder = this.CreateType<string>();

            // Act
            Action executeAction = () => DeltaMergePersist.CreateFolder(folderUri, rootFolder);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();
            var rootFolder = this.CreateType<string>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCreateFolder = { folderUri, rootFolder };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, methodCreateFolderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateFolder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(2);
            methodCreateFolderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();
            var rootFolder = this.CreateType<string>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCreateFolder = { folderUri, rootFolder };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DirectoryInfo>(MethodCreateFolder, parametersOfCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(2);
            methodCreateFolderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateFolderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergePersist_CreateFolder_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateFolder, methodCreateFolderParametersTypes);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();

            // Act
            Action executeAction = () => DeltaMergePersist.CreateFolder(folderUri);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateFolder = { folderUri };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, methodCreateFolderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateFolder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(1);
            methodCreateFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var folderUri = this.CreateType<string>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateFolder = { folderUri };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DirectoryInfo>(MethodCreateFolder, parametersOfCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(1);
            methodCreateFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var methodCreateFolderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateFolderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : DirectoryInfo) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_CreateFolder_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Internally(Type[] types)
        {
            var methodValidateFolderPathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateFolderPath, methodValidateFolderPathParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var path = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfValidateFolderPath = { path, rootPath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateFolderPath, methodValidateFolderPathParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodValidateFolderPath, methodValidateFolderPathParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateFolderPath, parametersOfValidateFolderPath, methodValidateFolderPathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateFolderPath.ShouldNotBeNull();
            parametersOfValidateFolderPath.Length.ShouldBe(2);
            methodValidateFolderPathParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodValidateFolderPath, parametersOfValidateFolderPath, methodValidateFolderPathParametersTypes));
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var path = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfValidateFolderPath = { path, rootPath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateFolderPath, methodValidateFolderPathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfValidateFolderPath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidateFolderPath.ShouldNotBeNull();
            parametersOfValidateFolderPath.Length.ShouldBe(2);
            methodValidateFolderPathParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var path = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfValidateFolderPath = { path, rootPath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateFolderPath, parametersOfValidateFolderPath, methodValidateFolderPathParametersTypes);

            // Assert
            parametersOfValidateFolderPath.ShouldNotBeNull();
            parametersOfValidateFolderPath.Length.ShouldBe(2);
            methodValidateFolderPathParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateFolderPath, methodValidateFolderPathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateFolderPathParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateFolderPath, methodValidateFolderPathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateFolderPathParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var methodValidateFolderPathParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateFolderPath, methodValidateFolderPathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateFolderPathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateFolderPath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ValidateFolderPath) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DeltaMergePersist_ValidateFolderPath_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateFolderPath);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateFolderPath, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}