using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="PasswordEncryptLibrary.Cryptor" />)
    ///     and namespace <see cref="PasswordEncryptLibrary"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CryptorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Cryptor" />)
        /// </summary>
        public CryptorTest() : base(typeof(Cryptor))
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

        #region General Initializer : Class (Cryptor) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cryptorInstanceType;
        private Cryptor _cryptorInstance;
        private Cryptor _cryptorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Cryptor" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cryptorInstanceType = typeof(Cryptor);
            _cryptorInstanceFixture = this.Create<Cryptor>(false);
            _cryptorInstance = _cryptorInstanceFixture ?? this.Create<Cryptor>(true);
            CurrentInstance = _cryptorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Cryptor) Initializer

        #region Properties

        private const string PropertyPlainText = "PlainText";
        private const string PropertyEncryptedText = "EncryptedText";
        private const string PropertyKeyFileFolder = "KeyFileFolder";
        private const string PropertyConfigurationFile = "ConfigurationFile";
        private const string PropertyIsSuccess = "IsSuccess";
        private const string PropertyExceptions = "Exceptions";
        private const string PropertyKeyFileName = "KeyFileName";

        #endregion

        #region Methods

        private const string MethodEncrypt = "Encrypt";
        private const string MethodDecrypt = "Decrypt";
        private const string MethodEncryptPlainText = "EncryptPlainText";
        private const string MethodDecryptEncryptedText = "DecryptEncryptedText";
        private const string MethodCreateNewKeys = "CreateNewKeys";
        private const string MethodCreateNewKey = "CreateNewKey";
        private const string MethodAssignKeyContainerParameter = "AssignKeyContainerParameter";
        private const string MethodEncryptPasswordForInstaller = "EncryptPasswordForInstaller";

        #endregion

        #region Fields

        private const string FieldrsaProviders = "rsaProviders";

        #endregion

        #endregion

        #region General Initializer : Class (Cryptor) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Cryptor_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Cryptor) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Cryptor_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Cryptor) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Cryptor_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Cryptor)

        #region General Initializer : Class (Cryptor) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEncrypt, 0)]
        [TestCase(MethodDecrypt, 0)]
        [TestCase(MethodEncryptPlainText, 0)]
        [TestCase(MethodDecryptEncryptedText, 0)]
        [TestCase(MethodCreateNewKeys, 0)]
        [TestCase(MethodCreateNewKey, 0)]
        [TestCase(MethodAssignKeyContainerParameter, 0)]
        [TestCase(MethodEncryptPasswordForInstaller, 0)]
        public void AUT_Cryptor_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Cryptor) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPlainText)]
        [TestCase(PropertyEncryptedText)]
        [TestCase(PropertyKeyFileFolder)]
        [TestCase(PropertyConfigurationFile)]
        [TestCase(PropertyIsSuccess)]
        [TestCase(PropertyExceptions)]
        [TestCase(PropertyKeyFileName)]
        [Category("AUT Property")]
        public void AUT_Cryptor_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Cryptor) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Cryptor" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldrsaProviders)]
        [Category("AUT Fields")]
        public void AUT_Cryptor_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Cryptor) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Cryptor" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Cryptor_Is_Instance_Present_Test()
        {
            // Assert
            _cryptorInstanceType.ShouldNotBeNull();
            _cryptorInstance.ShouldNotBeNull();
            _cryptorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Cryptor) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Cryptor" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Cryptor_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cryptorInstance.ShouldBeAssignableTo<Cryptor>();
            _cryptorInstanceFixture.ShouldBeAssignableTo<Cryptor>();
            CurrentInstance.ShouldBeAssignableTo<Cryptor>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Cryptor) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Cryptor_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Cryptor instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Cryptor) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPlainText)]
        [TestCase(PropertyEncryptedText)]
        [TestCase(PropertyKeyFileFolder)]
        [TestCase(PropertyConfigurationFile)]
        [TestCase(PropertyIsSuccess)]
        [TestCase(PropertyExceptions)]
        [TestCase(PropertyKeyFileName)]
        public void AUT_Cryptor_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (ConfigurationFile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_ConfigurationFile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfigurationFile);
            var propertyInfo = this.GetPropertyInfo(PropertyConfigurationFile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (EncryptedText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_EncryptedText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEncryptedText);
            var propertyInfo = this.GetPropertyInfo(PropertyEncryptedText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (Exceptions) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_Exceptions_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptions);
            var propertyInfo = this.GetPropertyInfo(PropertyExceptions);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (IsSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_IsSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (KeyFileFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_KeyFileFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKeyFileFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyKeyFileFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (KeyFileName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_KeyFileName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKeyFileName);
            var propertyInfo = this.GetPropertyInfo(PropertyKeyFileName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Cryptor) => Property (PlainText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Cryptor_Public_Class_PlainText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPlainText);
            var propertyInfo = this.GetPropertyInfo(PropertyPlainText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Encrypt) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Encrypt_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);

            // Act
            Action executeAction = () => _cryptorInstance.Encrypt();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Encrypt_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            Type [] methodEncryptParametersTypes = null;
            object[] parametersOfEncrypt = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, methodEncryptParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfEncrypt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEncrypt.ShouldBeNull();
            methodEncryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Encrypt_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            Type [] methodEncryptParametersTypes = null;
            object[] parametersOfEncrypt = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEncrypt, parametersOfEncrypt, methodEncryptParametersTypes);

            // Assert
            parametersOfEncrypt.ShouldBeNull();
            methodEncryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Encrypt_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            Type [] methodEncryptParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncrypt, methodEncryptParametersTypes);

            // Assert
            methodEncryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Encrypt) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Encrypt_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodEncrypt, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_Decrypt_Method_Call_Internally(Type[] types)
        {
            var methodDecryptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Decrypt_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);

            // Act
            Action executeAction = () => _cryptorInstance.Decrypt();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Decrypt_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            Type [] methodDecryptParametersTypes = null;
            object[] parametersOfDecrypt = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, methodDecryptParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfDecrypt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDecrypt.ShouldBeNull();
            methodDecryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Decrypt_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            Type [] methodDecryptParametersTypes = null;
            object[] parametersOfDecrypt = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDecrypt, parametersOfDecrypt, methodDecryptParametersTypes);

            // Assert
            parametersOfDecrypt.ShouldBeNull();
            methodDecryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Decrypt_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            Type [] methodDecryptParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecrypt, methodDecryptParametersTypes);

            // Assert
            methodDecryptParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Decrypt) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_Decrypt_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecrypt);
            var currentMethodInfo = this.GetMethodInfo(MethodDecrypt, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_EncryptPlainText_Method_Call_Internally(Type[] types)
        {
            var methodEncryptPlainTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEncryptPlainText, methodEncryptPlainTextParametersTypes);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var plainText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodEncryptPlainTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPlainText = { plainText, keyString };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPlainText, methodEncryptPlainTextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cryptorInstanceFixture, out exception1, parametersOfEncryptPlainText);
            var result2 = this.GetResultOfMethod<string>(MethodEncryptPlainText, parametersOfEncryptPlainText, methodEncryptPlainTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEncryptPlainText.ShouldNotBeNull();
            parametersOfEncryptPlainText.Length.ShouldBe(2);
            methodEncryptPlainTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var plainText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodEncryptPlainTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPlainText = { plainText, keyString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPlainText, methodEncryptPlainTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfEncryptPlainText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEncryptPlainText.ShouldNotBeNull();
            parametersOfEncryptPlainText.Length.ShouldBe(2);
            methodEncryptPlainTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var plainText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodEncryptPlainTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPlainText = { plainText, keyString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncryptPlainText, parametersOfEncryptPlainText, methodEncryptPlainTextParametersTypes);

            // Assert
            parametersOfEncryptPlainText.ShouldNotBeNull();
            parametersOfEncryptPlainText.Length.ShouldBe(2);
            methodEncryptPlainTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var methodEncryptPlainTextParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEncryptPlainText, methodEncryptPlainTextParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEncryptPlainTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var methodEncryptPlainTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncryptPlainText, methodEncryptPlainTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncryptPlainTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPlainText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EncryptPlainText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPlainText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPlainText);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPlainText, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_DecryptEncryptedText_Method_Call_Internally(Type[] types)
        {
            var methodDecryptEncryptedTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var encryptedText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodDecryptEncryptedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDecryptEncryptedText = { encryptedText, keyString };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cryptorInstanceFixture, out exception1, parametersOfDecryptEncryptedText);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptEncryptedText, parametersOfDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDecryptEncryptedText.ShouldNotBeNull();
            parametersOfDecryptEncryptedText.Length.ShouldBe(2);
            methodDecryptEncryptedTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var encryptedText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodDecryptEncryptedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDecryptEncryptedText = { encryptedText, keyString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfDecryptEncryptedText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDecryptEncryptedText.ShouldNotBeNull();
            parametersOfDecryptEncryptedText.Length.ShouldBe(2);
            methodDecryptEncryptedTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var encryptedText = this.CreateType<string>();
            var keyString = this.CreateType<string>();
            var methodDecryptEncryptedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDecryptEncryptedText = { encryptedText, keyString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptEncryptedText, parametersOfDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes);

            // Assert
            parametersOfDecryptEncryptedText.ShouldNotBeNull();
            parametersOfDecryptEncryptedText.Length.ShouldBe(2);
            methodDecryptEncryptedTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var methodDecryptEncryptedTextParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDecryptEncryptedTextParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var methodDecryptEncryptedTextParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptEncryptedText, methodDecryptEncryptedTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptEncryptedTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptEncryptedText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DecryptEncryptedText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_DecryptEncryptedText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptEncryptedText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptEncryptedText, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_CreateNewKeys_Method_Call_Internally(Type[] types)
        {
            var methodCreateNewKeysParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateNewKeys, methodCreateNewKeysParametersTypes);
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);

            // Act
            Action executeAction = () => _cryptorInstance.CreateNewKeys();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;
            object[] parametersOfCreateNewKeys = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKeys, methodCreateNewKeysParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cryptorInstanceFixture, parametersOfCreateNewKeys);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateNewKeys, parametersOfCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNewKeys.ShouldBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;
            object[] parametersOfCreateNewKeys = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKeys, methodCreateNewKeysParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cryptorInstanceFixture, out exception1, parametersOfCreateNewKeys);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateNewKeys, parametersOfCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNewKeys.ShouldBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;
            object[] parametersOfCreateNewKeys = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKeys, methodCreateNewKeysParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfCreateNewKeys);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateNewKeys.ShouldBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;
            object[] parametersOfCreateNewKeys = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCreateNewKeys, parametersOfCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            parametersOfCreateNewKeys.ShouldBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNewKeysParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            Type [] methodCreateNewKeysParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNewKeys, methodCreateNewKeysParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNewKeysParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKeys) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKeys_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKeys);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKeys, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_CreateNewKey_Method_Call_Internally(Type[] types)
        {
            var methodCreateNewKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateNewKey, methodCreateNewKeyParametersTypes);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var keyType = this.CreateType<KeyTypeEnum>();
            var keyFileStoreLocation = this.CreateType<string>();
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };
            object[] parametersOfCreateNewKey = { keyType, keyFileStoreLocation };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKey, methodCreateNewKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cryptorInstanceFixture, parametersOfCreateNewKey);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateNewKey, parametersOfCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNewKey.ShouldNotBeNull();
            parametersOfCreateNewKey.Length.ShouldBe(2);
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var keyType = this.CreateType<KeyTypeEnum>();
            var keyFileStoreLocation = this.CreateType<string>();
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };
            object[] parametersOfCreateNewKey = { keyType, keyFileStoreLocation };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKey, methodCreateNewKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cryptorInstanceFixture, out exception1, parametersOfCreateNewKey);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateNewKey, parametersOfCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateNewKey.ShouldNotBeNull();
            parametersOfCreateNewKey.Length.ShouldBe(2);
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var keyType = this.CreateType<KeyTypeEnum>();
            var keyFileStoreLocation = this.CreateType<string>();
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };
            object[] parametersOfCreateNewKey = { keyType, keyFileStoreLocation };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKey, methodCreateNewKeyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfCreateNewKey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateNewKey.ShouldNotBeNull();
            parametersOfCreateNewKey.Length.ShouldBe(2);
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var keyType = this.CreateType<KeyTypeEnum>();
            var keyFileStoreLocation = this.CreateType<string>();
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };
            object[] parametersOfCreateNewKey = { keyType, keyFileStoreLocation };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCreateNewKey, parametersOfCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            parametersOfCreateNewKey.ShouldNotBeNull();
            parametersOfCreateNewKey.Length.ShouldBe(2);
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateNewKeyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var methodCreateNewKeyParametersTypes = new Type[] { typeof(KeyTypeEnum), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNewKey, methodCreateNewKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNewKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateNewKey) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_CreateNewKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewKey);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewKey, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_AssignKeyContainerParameter_Method_Call_Internally(Type[] types)
        {
            var methodAssignKeyContainerParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAssignKeyContainerParameter, methodAssignKeyContainerParameterParametersTypes);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_AssignKeyContainerParameter_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAssignKeyContainerParameter);

            // Act
            Action executeAction = () => _cryptorInstance.AssignKeyContainerParameter();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_AssignKeyContainerParameter_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAssignKeyContainerParameter);
            Type [] methodAssignKeyContainerParameterParametersTypes = null;
            object[] parametersOfAssignKeyContainerParameter = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAssignKeyContainerParameter, methodAssignKeyContainerParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfAssignKeyContainerParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAssignKeyContainerParameter.ShouldBeNull();
            methodAssignKeyContainerParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_AssignKeyContainerParameter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAssignKeyContainerParameter);
            Type [] methodAssignKeyContainerParameterParametersTypes = null;
            object[] parametersOfAssignKeyContainerParameter = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAssignKeyContainerParameter, parametersOfAssignKeyContainerParameter, methodAssignKeyContainerParameterParametersTypes);

            // Assert
            parametersOfAssignKeyContainerParameter.ShouldBeNull();
            methodAssignKeyContainerParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_AssignKeyContainerParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAssignKeyContainerParameter);
            Type [] methodAssignKeyContainerParameterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAssignKeyContainerParameter, methodAssignKeyContainerParameterParametersTypes);

            // Assert
            methodAssignKeyContainerParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AssignKeyContainerParameter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_AssignKeyContainerParameter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAssignKeyContainerParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodAssignKeyContainerParameter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_Internally(Type[] types)
        {
            var methodEncryptPasswordForInstallerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var plainPassword = this.CreateType<string>();
            var publickKeyFilePath = this.CreateType<string>();

            // Act
            Action executeAction = () => _cryptorInstance.EncryptPasswordForInstaller(plainPassword, publickKeyFilePath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var plainPassword = this.CreateType<string>();
            var publickKeyFilePath = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _cryptorInstance.EncryptPasswordForInstaller(plainPassword, publickKeyFilePath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var plainPassword = this.CreateType<string>();
            var publickKeyFilePath = this.CreateType<string>();
            var methodEncryptPasswordForInstallerParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPasswordForInstaller = { plainPassword, publickKeyFilePath };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cryptorInstanceFixture, out exception1, parametersOfEncryptPasswordForInstaller);
            var result2 = this.GetResultOfMethod<string>(MethodEncryptPasswordForInstaller, parametersOfEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEncryptPasswordForInstaller.ShouldNotBeNull();
            parametersOfEncryptPasswordForInstaller.Length.ShouldBe(2);
            methodEncryptPasswordForInstallerParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var plainPassword = this.CreateType<string>();
            var publickKeyFilePath = this.CreateType<string>();
            var methodEncryptPasswordForInstallerParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPasswordForInstaller = { plainPassword, publickKeyFilePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cryptorInstanceFixture, parametersOfEncryptPasswordForInstaller);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEncryptPasswordForInstaller.ShouldNotBeNull();
            parametersOfEncryptPasswordForInstaller.Length.ShouldBe(2);
            methodEncryptPasswordForInstallerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var plainPassword = this.CreateType<string>();
            var publickKeyFilePath = this.CreateType<string>();
            var methodEncryptPasswordForInstallerParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfEncryptPasswordForInstaller = { plainPassword, publickKeyFilePath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEncryptPasswordForInstaller, parametersOfEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes);

            // Assert
            parametersOfEncryptPasswordForInstaller.ShouldNotBeNull();
            parametersOfEncryptPasswordForInstaller.Length.ShouldBe(2);
            methodEncryptPasswordForInstallerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var methodEncryptPasswordForInstallerParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEncryptPasswordForInstallerParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var methodEncryptPasswordForInstallerParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEncryptPasswordForInstaller, methodEncryptPasswordForInstallerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEncryptPasswordForInstallerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPasswordForInstaller, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EncryptPasswordForInstaller) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Cryptor_EncryptPasswordForInstaller_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEncryptPasswordForInstaller);
            var currentMethodInfo = this.GetMethodInfo(MethodEncryptPasswordForInstaller, 0);
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