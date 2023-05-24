using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Public.Core;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Core.OnyxUserContext" />)
    ///     and namespace <see cref="OnyxSDK.Public.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxUserContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxUserContext" />)
        /// </summary>
        public OnyxUserContextTest() : base(typeof(OnyxUserContext))
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

        #region General Initializer : Class (OnyxUserContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxUserContextInstanceType;
        private OnyxUserContext _onyxUserContextInstance;
        private OnyxUserContext _onyxUserContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxUserContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxUserContextInstanceType = typeof(OnyxUserContext);
            _onyxUserContextInstanceFixture = this.Create<OnyxUserContext>(false);
            _onyxUserContextInstance = _onyxUserContextInstanceFixture ?? this.Create<OnyxUserContext>(true);
            CurrentInstance = _onyxUserContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxUserContext) Initializer

        #region Methods

        private const string MethodLogout = "Logout";
        private const string MethodExecuteJson = "ExecuteJson";
        private const string MethodExecuteXml = "ExecuteXml";
        private const string MethodGetJsonParameterStructure = "GetJsonParameterStructure";
        private const string MethodGetXmlParameterStructure = "GetXmlParameterStructure";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxUserContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxUserContext)

        #region General Initializer : Class (OnyxUserContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogout, 0)]
        [TestCase(MethodExecuteJson, 0)]
        [TestCase(MethodExecuteXml, 0)]
        [TestCase(MethodGetJsonParameterStructure, 0)]
        [TestCase(MethodGetXmlParameterStructure, 0)]
        public void AUT_OnyxUserContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxUserContext) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxUserContext_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxUserContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxUserContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUserContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxUserContextInstance.ShouldBeAssignableTo<OnyxUserContext>();
            _onyxUserContextInstanceFixture.ShouldBeAssignableTo<OnyxUserContext>();
            CurrentInstance.ShouldBeAssignableTo<OnyxUserContext>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Logout) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_Logout_Method_Call_Internally(Type[] types)
        {
            var methodLogoutParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogout, methodLogoutParametersTypes);
        }

        #endregion

        #region Method Call : (Logout) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_Logout_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogout);

            // Act
            Action executeAction = () => _onyxUserContextInstance.Logout();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Logout) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_Logout_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogout);
            Type [] methodLogoutParametersTypes = null;
            object[] parametersOfLogout = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogout, methodLogoutParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxUserContextInstanceFixture, parametersOfLogout);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogout.ShouldBeNull();
            methodLogoutParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Logout) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_Logout_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogout);
            Type [] methodLogoutParametersTypes = null;
            object[] parametersOfLogout = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogout, parametersOfLogout, methodLogoutParametersTypes);

            // Assert
            parametersOfLogout.ShouldBeNull();
            methodLogoutParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Logout) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_Logout_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogout);
            Type [] methodLogoutParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogout, methodLogoutParametersTypes);

            // Assert
            methodLogoutParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Logout) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_Logout_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogout);
            var currentMethodInfo = this.GetMethodInfo(MethodLogout, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_ExecuteJson_Method_Call_Internally(Type[] types)
        {
            var methodExecuteJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteJson, methodExecuteJsonParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => _onyxUserContextInstance.ExecuteJson(lboMethod, inputData, customData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = _onyxUserContextInstance.ExecuteJson(lboMethod, inputData, customData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var methodExecuteJsonParametersTypes = new Type[] { typeof(ILboMethod), typeof(JObject), typeof(JObject) };
            object[] parametersOfExecuteJson = { lboMethod, inputData, customData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteJson, methodExecuteJsonParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<JObject>(_onyxUserContextInstanceFixture, parametersOfExecuteJson);
            var result2 = this.GetResultOfMethod<JObject>(MethodExecuteJson, parametersOfExecuteJson, methodExecuteJsonParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteJson.ShouldNotBeNull();
            parametersOfExecuteJson.Length.ShouldBe(3);
            methodExecuteJsonParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var methodExecuteJsonParametersTypes = new Type[] { typeof(ILboMethod), typeof(JObject), typeof(JObject) };
            object[] parametersOfExecuteJson = { lboMethod, inputData, customData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodExecuteJson, parametersOfExecuteJson, methodExecuteJsonParametersTypes);

            // Assert
            parametersOfExecuteJson.ShouldNotBeNull();
            parametersOfExecuteJson.Length.ShouldBe(3);
            methodExecuteJsonParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var methodExecuteJsonParametersTypes = new Type[] { typeof(ILboMethod), typeof(JObject), typeof(JObject) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteJson, methodExecuteJsonParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteJsonParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var methodExecuteJsonParametersTypes = new Type[] { typeof(ILboMethod), typeof(JObject), typeof(JObject) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteJson, methodExecuteJsonParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteJsonParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteJson, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteJson_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteJson, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_ExecuteXml_Method_Call_Internally(Type[] types)
        {
            var methodExecuteXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteXml, methodExecuteXmlParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserContextInstance.ExecuteXml(lboMethod, inputData, customData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxUserContextInstance.ExecuteXml(lboMethod, inputData, customData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var methodExecuteXmlParametersTypes = new Type[] { typeof(ILboMethod), typeof(string), typeof(string) };
            object[] parametersOfExecuteXml = { lboMethod, inputData, customData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteXml, methodExecuteXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxUserContextInstanceFixture, parametersOfExecuteXml);
            var result2 = this.GetResultOfMethod<string>(MethodExecuteXml, parametersOfExecuteXml, methodExecuteXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteXml.ShouldNotBeNull();
            parametersOfExecuteXml.Length.ShouldBe(3);
            methodExecuteXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var lboMethod = this.CreateType<ILboMethod>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var methodExecuteXmlParametersTypes = new Type[] { typeof(ILboMethod), typeof(string), typeof(string) };
            object[] parametersOfExecuteXml = { lboMethod, inputData, customData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecuteXml, parametersOfExecuteXml, methodExecuteXmlParametersTypes);

            // Assert
            parametersOfExecuteXml.ShouldNotBeNull();
            parametersOfExecuteXml.Length.ShouldBe(3);
            methodExecuteXmlParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var methodExecuteXmlParametersTypes = new Type[] { typeof(ILboMethod), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteXml, methodExecuteXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteXmlParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var methodExecuteXmlParametersTypes = new Type[] { typeof(ILboMethod), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteXml, methodExecuteXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_ExecuteXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteXml, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonParameterStructureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserContextInstance.GetJsonParameterStructure(lboObjectName, lboMethodName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = _onyxUserContextInstance.GetJsonParameterStructure(lboObjectName, lboMethodName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodGetJsonParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetJsonParameterStructure = { lboObjectName, lboMethodName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<JObject>(_onyxUserContextInstanceFixture, parametersOfGetJsonParameterStructure);
            var result2 = this.GetResultOfMethod<JObject>(MethodGetJsonParameterStructure, parametersOfGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetJsonParameterStructure.ShouldNotBeNull();
            parametersOfGetJsonParameterStructure.Length.ShouldBe(2);
            methodGetJsonParameterStructureParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodGetJsonParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetJsonParameterStructure = { lboObjectName, lboMethodName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodGetJsonParameterStructure, parametersOfGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            parametersOfGetJsonParameterStructure.ShouldNotBeNull();
            parametersOfGetJsonParameterStructure.Length.ShouldBe(2);
            methodGetJsonParameterStructureParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var methodGetJsonParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetJsonParameterStructureParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var methodGetJsonParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonParameterStructureParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonParameterStructure, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetJsonParameterStructure_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonParameterStructure, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParameterStructureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserContextInstance.GetXmlParameterStructure(lboObjectName, lboMethodName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _onyxUserContextInstance.GetXmlParameterStructure(lboObjectName, lboMethodName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodGetXmlParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetXmlParameterStructure = { lboObjectName, lboMethodName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_onyxUserContextInstanceFixture, parametersOfGetXmlParameterStructure);
            var result2 = this.GetResultOfMethod<string>(MethodGetXmlParameterStructure, parametersOfGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXmlParameterStructure.ShouldNotBeNull();
            parametersOfGetXmlParameterStructure.Length.ShouldBe(2);
            methodGetXmlParameterStructureParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var lboObjectName = this.CreateType<string>();
            var lboMethodName = this.CreateType<string>();
            var methodGetXmlParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetXmlParameterStructure = { lboObjectName, lboMethodName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXmlParameterStructure, parametersOfGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            parametersOfGetXmlParameterStructure.ShouldNotBeNull();
            parametersOfGetXmlParameterStructure.Length.ShouldBe(2);
            methodGetXmlParameterStructureParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var methodGetXmlParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParameterStructureParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var methodGetXmlParameterStructureParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParameterStructureParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlParameterStructure, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserContext_GetXmlParameterStructure_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlParameterStructure, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserContext_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}