using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Permissions;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using PasswordEncryptLibrary;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.PasswordEncryptLibrary
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="PasswordEncryptLibrary.FileIO" />)
    ///     and namespace <see cref="PasswordEncryptLibrary"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FileIOTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FileIO" />)
        /// </summary>
        public FileIOTest() : base(typeof(FileIO))
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

        #region General Initializer : Class (FileIO) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _fileIOInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="FileIO" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fileIOInstanceType = typeof(FileIO);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FileIO) Initializer

        #region Properties

        private const string PropertyExceptions = "Exceptions";
        private const string PropertyIsSuccess = "IsSuccess";

        #endregion

        #region Methods

        private const string MethodCheckFileExists = "CheckFileExists";
        private const string MethodCheckFolderExists = "CheckFolderExists";
        private const string MethodCheckFileAccessPermissions = "CheckFileAccessPermissions";
        private const string MethodCreateFileWithData = "CreateFileWithData";
        private const string MethodUpdateFile = "UpdateFile";
        private const string MethodReadFile = "ReadFile";

        #endregion

        #region Fields

        private const string FieldlockObject = "lockObject";

        #endregion

        #endregion

        #region General Initializer : Class (FileIO) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileIO_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FileIO) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileIO_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FileIO) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FileIO_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FileIO)

        #region General Initializer : Class (FileIO) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCheckFileExists, 0)]
        [TestCase(MethodCheckFolderExists, 0)]
        [TestCase(MethodCheckFileAccessPermissions, 0)]
        [TestCase(MethodCreateFileWithData, 0)]
        [TestCase(MethodUpdateFile, 0)]
        [TestCase(MethodReadFile, 0)]
        public void AUT_FileIO_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (FileIO) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyExceptions)]
        [TestCase(PropertyIsSuccess)]
        [Category("AUT Property")]
        public void AUT_FileIO_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (FileIO) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="FileIO" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlockObject)]
        [Category("AUT Fields")]
        public void AUT_FileIO_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (FileIO) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FileIO" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FileIO_Is_Static_Type_Present_Test()
        {
            // Assert
            _fileIOInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CheckFileExists) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var fileName = this.CreateType<string>();

            // Act
            Action executeAction = () => FileIO.CheckFileExists(fileName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var fileName = this.CreateType<string>();
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFileExists = { fileName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileExists, methodCheckFileExistsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCheckFileExists, methodCheckFileExistsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckFileExists, parametersOfCheckFileExists, methodCheckFileExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckFileExists.ShouldNotBeNull();
            parametersOfCheckFileExists.Length.ShouldBe(1);
            methodCheckFileExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodCheckFileExists, parametersOfCheckFileExists, methodCheckFileExistsParametersTypes));
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var fileName = this.CreateType<string>();
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFileExists = { fileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileExists, methodCheckFileExistsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCheckFileExists);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckFileExists.ShouldNotBeNull();
            parametersOfCheckFileExists.Length.ShouldBe(1);
            methodCheckFileExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var fileName = this.CreateType<string>();
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFileExists = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckFileExists, parametersOfCheckFileExists, methodCheckFileExistsParametersTypes);

            // Assert
            parametersOfCheckFileExists.ShouldNotBeNull();
            parametersOfCheckFileExists.Length.ShouldBe(1);
            methodCheckFileExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFileExists, methodCheckFileExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFileExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFileExists, methodCheckFileExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFileExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var methodCheckFileExistsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckFileExists, methodCheckFileExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckFileExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CheckFileExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileExists_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileExists);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileExists, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileIO_CheckFolderExists_Static_Method_Call_Internally(Type[] types)
        {
            var methodCheckFolderExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var folderName = this.CreateType<string>();

            // Act
            Action executeAction = () => FileIO.CheckFolderExists(folderName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var folderName = this.CreateType<string>();
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFolderExists = { folderName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckFolderExists, parametersOfCheckFolderExists, methodCheckFolderExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckFolderExists.ShouldNotBeNull();
            parametersOfCheckFolderExists.Length.ShouldBe(1);
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodCheckFolderExists, parametersOfCheckFolderExists, methodCheckFolderExistsParametersTypes));
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var folderName = this.CreateType<string>();
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFolderExists = { folderName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCheckFolderExists);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckFolderExists.ShouldNotBeNull();
            parametersOfCheckFolderExists.Length.ShouldBe(1);
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var folderName = this.CreateType<string>();
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCheckFolderExists = { folderName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckFolderExists, parametersOfCheckFolderExists, methodCheckFolderExistsParametersTypes);

            // Assert
            parametersOfCheckFolderExists.ShouldNotBeNull();
            parametersOfCheckFolderExists.Length.ShouldBe(1);
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var methodCheckFolderExistsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckFolderExists, methodCheckFolderExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckFolderExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFolderExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CheckFolderExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFolderExists_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFolderExists);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFolderExists, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Internally(Type[] types)
        {
            var methodCheckFileAccessPermissionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var fileName = this.CreateType<string>();
            var permissionToVerify = this.CreateType<FileIOPermissionAccess>();

            // Act
            Action executeAction = () => FileIO.CheckFileAccessPermissions(fileName, permissionToVerify);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var fileName = this.CreateType<string>();
            var permissionToVerify = this.CreateType<FileIOPermissionAccess>();
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };
            object[] parametersOfCheckFileAccessPermissions = { fileName, permissionToVerify };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckFileAccessPermissions, parametersOfCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckFileAccessPermissions.ShouldNotBeNull();
            parametersOfCheckFileAccessPermissions.Length.ShouldBe(2);
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodCheckFileAccessPermissions, parametersOfCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes));
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var fileName = this.CreateType<string>();
            var permissionToVerify = this.CreateType<FileIOPermissionAccess>();
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };
            object[] parametersOfCheckFileAccessPermissions = { fileName, permissionToVerify };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCheckFileAccessPermissions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckFileAccessPermissions.ShouldNotBeNull();
            parametersOfCheckFileAccessPermissions.Length.ShouldBe(2);
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var fileName = this.CreateType<string>();
            var permissionToVerify = this.CreateType<FileIOPermissionAccess>();
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };
            object[] parametersOfCheckFileAccessPermissions = { fileName, permissionToVerify };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckFileAccessPermissions, parametersOfCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);

            // Assert
            parametersOfCheckFileAccessPermissions.ShouldNotBeNull();
            parametersOfCheckFileAccessPermissions.Length.ShouldBe(2);
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var methodCheckFileAccessPermissionsParametersTypes = new Type[] { typeof(string), typeof(FileIOPermissionAccess) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckFileAccessPermissions, methodCheckFileAccessPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckFileAccessPermissionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileAccessPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CheckFileAccessPermissions) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CheckFileAccessPermissions_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckFileAccessPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckFileAccessPermissions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFileWithData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileIO_CreateFileWithData_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateFileWithDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateFileWithData, methodCreateFileWithDataParametersTypes);
        }

        #endregion
        
        #region Method Call : (CreateFileWithData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CreateFileWithData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileWithData);
            var folderName = this.CreateType<string>();
            var fileName = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var methodCreateFileWithDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfCreateFileWithData = { folderName, fileName, inputData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCreateFileWithData, parametersOfCreateFileWithData, methodCreateFileWithDataParametersTypes);

            // Assert
            parametersOfCreateFileWithData.ShouldNotBeNull();
            parametersOfCreateFileWithData.Length.ShouldBe(3);
            methodCreateFileWithDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateFileWithData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CreateFileWithData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileWithData);
            var methodCreateFileWithDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFileWithData, methodCreateFileWithDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateFileWithDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (CreateFileWithData) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_CreateFileWithData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFileWithData);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFileWithData, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateFile) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileIO_UpdateFile_Static_Method_Call_Internally(Type[] types)
        {
            var methodUpdateFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateFile, methodUpdateFileParametersTypes);
        }

        #endregion
        
        #region Method Call : (UpdateFile) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_UpdateFile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFile);
            var fileName = this.CreateType<string>();
            var inputData = this.CreateType<string>();
            var methodUpdateFileParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateFile = { fileName, inputData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateFile, parametersOfUpdateFile, methodUpdateFileParametersTypes);

            // Assert
            parametersOfUpdateFile.ShouldNotBeNull();
            parametersOfUpdateFile.Length.ShouldBe(2);
            methodUpdateFileParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (UpdateFile) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_UpdateFile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFile);
            var methodUpdateFileParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateFile, methodUpdateFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateFileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (UpdateFile) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_UpdateFile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFile);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFile, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReadFile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FileIO_ReadFile_Static_Method_Call_Internally(Type[] types)
        {
            var methodReadFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReadFile, methodReadFileParametersTypes);
        }

        #endregion
        
        #region Method Call : (ReadFile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_ReadFile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadFile);
            var fileName = this.CreateType<string>();
            var methodReadFileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfReadFile = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodReadFile, parametersOfReadFile, methodReadFileParametersTypes);

            // Assert
            parametersOfReadFile.ShouldNotBeNull();
            parametersOfReadFile.Length.ShouldBe(1);
            methodReadFileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ReadFile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_ReadFile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadFile);
            var methodReadFileParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReadFile, methodReadFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadFileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (ReadFile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FileIO_ReadFile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadFile);
            var currentMethodInfo = this.GetMethodInfo(MethodReadFile, 0);
            const int parametersCount = 1;

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