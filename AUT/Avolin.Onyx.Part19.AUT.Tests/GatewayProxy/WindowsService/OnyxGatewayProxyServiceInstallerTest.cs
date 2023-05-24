using Action = System.Action;
using Should = Shouldly.Should;

namespace Onyx.GatewayProxy.WindowsService
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration.Install;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.ServiceProcess;
    using System.Text;
    using System.Xml;
    using Action = System.Action;
    using AUT.TestProjects.Analyzer;
    using AUT.TestProjects.BaseSetup;
    using AUT.TestProjects.BaseSetup.Version;
    using AUT.TestProjects.BaseSetup.Version.V1;
    using AUT.TestProjects.BaseSetup.Version.V2;
    using AUT.TestProjects.Extensions;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
    using AUT.TestProjects.Interfaces;
    using AUT.TestProjects.Interfaces.BaseSetup.Version;
    using AUT.TestProjects.Interfaces.BaseSetup.Version.V2;
    using AUT.TestProjects.Model;
    using AUT.TestProjects.NUnitExtensionAttribute;
    using AUT.TestProjects.StaticTypes;
    using log4net;
    using Moq;
    using NUnit.Framework;
    using Onyx.Gateway.Data;
    using Should = Shouldly.Should;
    using Shouldly;
    using Onyx.GatewayProxy.WindowsService;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyServiceInstaller" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxGatewayProxyServiceInstallerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayProxyServiceInstaller" />)
        /// </summary>
        public OnyxGatewayProxyServiceInstallerTest() : base(typeof(OnyxGatewayProxyServiceInstaller))
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

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayProxyServiceInstallerInstanceType;
        private OnyxGatewayProxyServiceInstaller _onyxGatewayProxyServiceInstallerInstance;
        private OnyxGatewayProxyServiceInstaller _onyxGatewayProxyServiceInstallerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayProxyServiceInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayProxyServiceInstallerInstanceType = typeof(OnyxGatewayProxyServiceInstaller);
            _onyxGatewayProxyServiceInstallerInstanceFixture = this.Create<OnyxGatewayProxyServiceInstaller>(false);
            _onyxGatewayProxyServiceInstallerInstance = _onyxGatewayProxyServiceInstallerInstanceFixture ?? this.Create<OnyxGatewayProxyServiceInstaller>(true);
            CurrentInstance = _onyxGatewayProxyServiceInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Initializer

        #region Properties

        private const string PropertyServiceName = "ServiceName";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyDescription = "Description";
        private const string PropertyStartType = "StartType";
        private const string PropertyAccount = "Account";
        private const string PropertyServiceUsername = "ServiceUsername";
        private const string PropertyServicePassword = "ServicePassword";

        #endregion

        #region Methods

        private const string MethodServiceInstaller_Committed = "ServiceInstaller_Committed";
        private const string MethodGetContextParameter = "GetContextParameter";
        private const string MethodOnBeforeInstall = "OnBeforeInstall";
        private const string MethodOnBeforeUninstall = "OnBeforeUninstall";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldlogSource = "logSource";
        private const string FieldprocessInstaller = "processInstaller";
        private const string FieldserviceInstaller = "serviceInstaller";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayProxyServiceInstaller)

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodServiceInstaller_Committed, 0)]
        [TestCase(MethodGetContextParameter, 0)]
        [TestCase(MethodOnBeforeInstall, 0)]
        [TestCase(MethodOnBeforeUninstall, 0)]
        public void AUT_OnyxGatewayProxyServiceInstaller_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyServiceName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStartType)]
        [TestCase(PropertyAccount)]
        [TestCase(PropertyServiceUsername)]
        [TestCase(PropertyServicePassword)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_OnyxGatewayProxyServiceInstaller_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldlogSource)]
        [TestCase(FieldprocessInstaller)]
        [TestCase(FieldserviceInstaller)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OnyxGatewayProxyServiceInstaller_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxGatewayProxyServiceInstaller) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayProxyServiceInstallerInstanceType.ShouldNotBeNull();
            _onyxGatewayProxyServiceInstallerInstance.ShouldNotBeNull();
            _onyxGatewayProxyServiceInstallerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayProxyServiceInstaller) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayProxyServiceInstallerInstance.ShouldBeAssignableTo<OnyxGatewayProxyServiceInstaller>();
            _onyxGatewayProxyServiceInstallerInstanceFixture.ShouldBeAssignableTo<OnyxGatewayProxyServiceInstaller>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayProxyServiceInstaller>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyServiceName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStartType)]
        [TestCase(PropertyAccount)]
        [TestCase(PropertyServiceUsername)]
        [TestCase(PropertyServicePassword)]
        public void AUT_OnyxGatewayProxyServiceInstaller_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (Account) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Account_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccount);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAccount);
            Action currentAction = () => propertyInfo.SetValue(_onyxGatewayProxyServiceInstallerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (Account) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_Account_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccount);
            var propertyInfo = this.GetPropertyInfo(PropertyAccount);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (ServiceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_ServiceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServiceName);
            var propertyInfo = this.GetPropertyInfo(PropertyServiceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (ServicePassword) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_ServicePassword_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServicePassword);
            var propertyInfo = this.GetPropertyInfo(PropertyServicePassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (ServiceUsername) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_ServiceUsername_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServiceUsername);
            var propertyInfo = this.GetPropertyInfo(PropertyServiceUsername);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (StartType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_StartType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStartType);
            Action currentAction = () => propertyInfo.SetValue(_onyxGatewayProxyServiceInstallerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayProxyServiceInstaller) => Property (StartType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayProxyServiceInstaller_Public_Class_StartType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartType);
            var propertyInfo = this.GetPropertyInfo(PropertyStartType);

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

        #region Method Call : (ServiceInstaller_Committed) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_ServiceInstaller_Committed_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodServiceInstaller_Committed);
            var sender = this.CreateType<object>();
            var e = this.CreateType<InstallEventArgs>();
            var methodServiceInstaller_CommittedParametersTypes = new Type[] { typeof(object), typeof(InstallEventArgs) };
            object[] parametersOfServiceInstaller_Committed = { sender, e };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodServiceInstaller_Committed, methodServiceInstaller_CommittedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayProxyServiceInstallerInstanceFixture, parametersOfServiceInstaller_Committed);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfServiceInstaller_Committed.ShouldNotBeNull();
            parametersOfServiceInstaller_Committed.Length.ShouldBe(2);
            methodServiceInstaller_CommittedParametersTypes.Length.ShouldBe(2);
            methodServiceInstaller_CommittedParametersTypes.Length.ShouldBe(parametersOfServiceInstaller_Committed.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ServiceInstaller_Committed) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_ServiceInstaller_Committed_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodServiceInstaller_Committed);
            var sender = this.CreateType<object>();
            var e = this.CreateType<InstallEventArgs>();
            var methodServiceInstaller_CommittedParametersTypes = new Type[] { typeof(object), typeof(InstallEventArgs) };
            object[] parametersOfServiceInstaller_Committed = { sender, e };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodServiceInstaller_Committed, parametersOfServiceInstaller_Committed, methodServiceInstaller_CommittedParametersTypes);

            // Assert
            parametersOfServiceInstaller_Committed.ShouldNotBeNull();
            parametersOfServiceInstaller_Committed.Length.ShouldBe(2);
            methodServiceInstaller_CommittedParametersTypes.Length.ShouldBe(2);
            methodServiceInstaller_CommittedParametersTypes.Length.ShouldBe(parametersOfServiceInstaller_Committed.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ServiceInstaller_Committed) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_ServiceInstaller_Committed_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodServiceInstaller_Committed);
            var currentMethodInfo = this.GetMethodInfo(MethodServiceInstaller_Committed, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ServiceInstaller_Committed) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_ServiceInstaller_Committed_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodServiceInstaller_Committed);
            var methodServiceInstaller_CommittedParametersTypes = new Type[] { typeof(object), typeof(InstallEventArgs) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodServiceInstaller_Committed, methodServiceInstaller_CommittedParametersTypes);

            // Assert
            methodServiceInstaller_CommittedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ServiceInstaller_Committed) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_ServiceInstaller_Committed_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodServiceInstaller_Committed);
            var currentMethodInfo = this.GetMethodInfo(MethodServiceInstaller_Committed, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetContextParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextParameter, methodGetContextParameterParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxGatewayProxyServiceInstallerInstance.GetContextParameter(key);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxGatewayProxyServiceInstallerInstance.GetContextParameter(key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var key = this.CreateType<string>();
            var methodGetContextParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContextParameter = { key };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameter, methodGetContextParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxGatewayProxyServiceInstallerInstanceFixture, out exception1, parametersOfGetContextParameter);
            var result2 = this.GetResultOfMethod<string>(MethodGetContextParameter, parametersOfGetContextParameter, methodGetContextParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetContextParameter.ShouldNotBeNull();
            parametersOfGetContextParameter.Length.ShouldBe(1);
            methodGetContextParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var key = this.CreateType<string>();
            var methodGetContextParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContextParameter = { key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameter, methodGetContextParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayProxyServiceInstallerInstanceFixture, parametersOfGetContextParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetContextParameter.ShouldNotBeNull();
            parametersOfGetContextParameter.Length.ShouldBe(1);
            methodGetContextParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var key = this.CreateType<string>();
            var methodGetContextParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetContextParameter = { key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetContextParameter, parametersOfGetContextParameter, methodGetContextParameterParametersTypes);

            // Assert
            parametersOfGetContextParameter.ShouldNotBeNull();
            parametersOfGetContextParameter.Length.ShouldBe(1);
            methodGetContextParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var methodGetContextParameterParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextParameter, methodGetContextParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetContextParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var methodGetContextParameterParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextParameter, methodGetContextParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetContextParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_GetContextParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_Internally(Type[] types)
        {
            var methodOnBeforeInstallParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnBeforeInstall, methodOnBeforeInstallParametersTypes);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeInstall);
            var savedState = this.CreateType<IDictionary>();
            var methodOnBeforeInstallParametersTypes = new Type[] { typeof(IDictionary) };
            object[] parametersOfOnBeforeInstall = { savedState };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeInstall, methodOnBeforeInstallParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayProxyServiceInstallerInstanceFixture, parametersOfOnBeforeInstall);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnBeforeInstall.ShouldNotBeNull();
            parametersOfOnBeforeInstall.Length.ShouldBe(1);
            methodOnBeforeInstallParametersTypes.Length.ShouldBe(1);
            methodOnBeforeInstallParametersTypes.Length.ShouldBe(parametersOfOnBeforeInstall.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeInstall);
            var savedState = this.CreateType<IDictionary>();
            var methodOnBeforeInstallParametersTypes = new Type[] { typeof(IDictionary) };
            object[] parametersOfOnBeforeInstall = { savedState };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnBeforeInstall, parametersOfOnBeforeInstall, methodOnBeforeInstallParametersTypes);

            // Assert
            parametersOfOnBeforeInstall.ShouldNotBeNull();
            parametersOfOnBeforeInstall.Length.ShouldBe(1);
            methodOnBeforeInstallParametersTypes.Length.ShouldBe(1);
            methodOnBeforeInstallParametersTypes.Length.ShouldBe(parametersOfOnBeforeInstall.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeInstall);
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeInstall, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeInstall);
            var methodOnBeforeInstallParametersTypes = new Type[] { typeof(IDictionary) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnBeforeInstall, methodOnBeforeInstallParametersTypes);

            // Assert
            methodOnBeforeInstallParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeInstall_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeInstall);
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeInstall, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_Internally(Type[] types)
        {
            var methodOnBeforeUninstallParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnBeforeUninstall, methodOnBeforeUninstallParametersTypes);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeUninstall);
            var savedState = this.CreateType<IDictionary>();
            var methodOnBeforeUninstallParametersTypes = new Type[] { typeof(IDictionary) };
            object[] parametersOfOnBeforeUninstall = { savedState };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeUninstall, methodOnBeforeUninstallParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayProxyServiceInstallerInstanceFixture, parametersOfOnBeforeUninstall);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnBeforeUninstall.ShouldNotBeNull();
            parametersOfOnBeforeUninstall.Length.ShouldBe(1);
            methodOnBeforeUninstallParametersTypes.Length.ShouldBe(1);
            methodOnBeforeUninstallParametersTypes.Length.ShouldBe(parametersOfOnBeforeUninstall.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeUninstall);
            var savedState = this.CreateType<IDictionary>();
            var methodOnBeforeUninstallParametersTypes = new Type[] { typeof(IDictionary) };
            object[] parametersOfOnBeforeUninstall = { savedState };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnBeforeUninstall, parametersOfOnBeforeUninstall, methodOnBeforeUninstallParametersTypes);

            // Assert
            parametersOfOnBeforeUninstall.ShouldNotBeNull();
            parametersOfOnBeforeUninstall.Length.ShouldBe(1);
            methodOnBeforeUninstallParametersTypes.Length.ShouldBe(1);
            methodOnBeforeUninstallParametersTypes.Length.ShouldBe(parametersOfOnBeforeUninstall.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeUninstall);
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeUninstall, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeUninstall);
            var methodOnBeforeUninstallParametersTypes = new Type[] { typeof(IDictionary) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnBeforeUninstall, methodOnBeforeUninstallParametersTypes);

            // Assert
            methodOnBeforeUninstallParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyServiceInstaller_OnBeforeUninstall_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnBeforeUninstall);
            var currentMethodInfo = this.GetMethodInfo(MethodOnBeforeUninstall, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}