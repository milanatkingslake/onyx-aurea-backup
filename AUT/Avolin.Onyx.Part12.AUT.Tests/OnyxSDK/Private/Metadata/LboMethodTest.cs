using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using OnyxSDK.Public.Interface;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.LboMethod" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class LboMethodTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboMethod" />)
        /// </summary>
        public LboMethodTest() : base(typeof(LboMethod))
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

        #region General Initializer : Class (LboMethod) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboMethodInstanceType;
        private LboMethod _lboMethodInstance;
        private LboMethod _lboMethodInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboMethod" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboMethodInstanceType = typeof(LboMethod);
            _lboMethodInstanceFixture = this.Create<LboMethod>(false);
            _lboMethodInstance = _lboMethodInstanceFixture ?? this.Create<LboMethod>(true);
            CurrentInstance = _lboMethodInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboMethod) Initializer

        #region Methods

        private const string MethodGetMethodSortProperties = "GetMethodSortProperties";
        private const string MethodGetLboParameters = "GetLboParameters";
        private const string MethodExecuteJson = "ExecuteJson";
        private const string MethodExecuteXml = "ExecuteXml";
        private const string MethodGetJsonParameterStructure = "GetJsonParameterStructure";
        private const string MethodGetXmlParameterStructure = "GetXmlParameterStructure";

        #endregion

        #endregion

        #region General Initializer : Class (LboMethod) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboMethod" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethod_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboMethod) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LboMethod" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethod_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboMethod) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboMethod" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboMethod_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboMethod)

        #region General Initializer : Class (LboMethod) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboMethod" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMethodSortProperties, 0)]
        [TestCase(MethodGetLboParameters, 0)]
        [TestCase(MethodExecuteJson, 0)]
        [TestCase(MethodExecuteXml, 0)]
        [TestCase(MethodGetJsonParameterStructure, 0)]
        [TestCase(MethodGetXmlParameterStructure, 0)]
        public void AUT_LboMethod_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (LboMethod) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboMethod" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboMethod_Is_Instance_Present_Test()
        {
            // Assert
            _lboMethodInstanceType.ShouldNotBeNull();
            _lboMethodInstance.ShouldNotBeNull();
            _lboMethodInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LboMethod) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboMethod" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboMethod_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboMethodInstance.ShouldBeAssignableTo<LboMethod>();
            _lboMethodInstanceFixture.ShouldBeAssignableTo<LboMethod>();
            CurrentInstance.ShouldBeAssignableTo<LboMethod>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetMethodSortPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetMethodSortProperties = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboMethodSortProperty>>(_lboMethodInstanceFixture, out exception1, parametersOfGetMethodSortProperties);
            var result2 = this.GetResultOfMethod<IList<ILboMethodSortProperty>>(MethodGetMethodSortProperties, parametersOfGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMethodSortProperties.ShouldNotBeNull();
            parametersOfGetMethodSortProperties.Length.ShouldBe(1);
            methodGetMethodSortPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetMethodSortPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetMethodSortProperties = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboMethodInstanceFixture, parametersOfGetMethodSortProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMethodSortProperties.ShouldNotBeNull();
            parametersOfGetMethodSortProperties.Length.ShouldBe(1);
            methodGetMethodSortPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetMethodSortPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetMethodSortProperties = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboMethodSortProperty>>(MethodGetMethodSortProperties, parametersOfGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes);

            // Assert
            parametersOfGetMethodSortProperties.ShouldNotBeNull();
            parametersOfGetMethodSortProperties.Length.ShouldBe(1);
            methodGetMethodSortPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var methodGetMethodSortPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMethodSortPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var methodGetMethodSortPropertiesParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMethodSortProperties, methodGetMethodSortPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMethodSortPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodSortProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMethodSortProperties) (Return Type : IList<ILboMethodSortProperty>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetMethodSortProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodSortProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodSortProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboMethod_GetLboParameters_Method_Call_Internally(Type[] types)
        {
            var methodGetLboParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboParameters, methodGetLboParametersParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetLboParametersParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetLboParameters = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboParameters, methodGetLboParametersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboParameter>>(_lboMethodInstanceFixture, out exception1, parametersOfGetLboParameters);
            var result2 = this.GetResultOfMethod<IList<ILboParameter>>(MethodGetLboParameters, parametersOfGetLboParameters, methodGetLboParametersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetLboParameters.ShouldNotBeNull();
            parametersOfGetLboParameters.Length.ShouldBe(1);
            methodGetLboParametersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetLboParametersParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetLboParameters = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboParameters, methodGetLboParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboMethodInstanceFixture, parametersOfGetLboParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetLboParameters.ShouldNotBeNull();
            parametersOfGetLboParameters.Length.ShouldBe(1);
            methodGetLboParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetLboParametersParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetLboParameters = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboParameter>>(MethodGetLboParameters, parametersOfGetLboParameters, methodGetLboParametersParametersTypes);

            // Assert
            parametersOfGetLboParameters.ShouldNotBeNull();
            parametersOfGetLboParameters.Length.ShouldBe(1);
            methodGetLboParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var methodGetLboParametersParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboParameters, methodGetLboParametersParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetLboParametersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var methodGetLboParametersParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboParameters, methodGetLboParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetLboParameters) (Return Type : IList<ILboParameter>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetLboParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboParameters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboMethod_ExecuteJson_Method_Call_Internally(Type[] types)
        {
            var methodExecuteJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteJson, methodExecuteJsonParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteJson_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();

            // Act
            Action executeAction = () => _lboMethodInstance.ExecuteJson(onyxUserContext, inputData, customData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteJson_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = _lboMethodInstance.ExecuteJson(onyxUserContext, inputData, customData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteJson) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteJson_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var methodExecuteJsonParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(JObject), typeof(JObject) };
            object[] parametersOfExecuteJson = { onyxUserContext, inputData, customData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteJson, methodExecuteJsonParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<JObject>(_lboMethodInstanceFixture, parametersOfExecuteJson);
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
        public void AUT_LboMethod_ExecuteJson_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<JObject>();
            var customData = this.CreateType<JObject>();
            var methodExecuteJsonParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(JObject), typeof(JObject) };
            object[] parametersOfExecuteJson = { onyxUserContext, inputData, customData };

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
        public void AUT_LboMethod_ExecuteJson_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var methodExecuteJsonParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(JObject), typeof(JObject) };

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
        public void AUT_LboMethod_ExecuteJson_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteJson);
            var methodExecuteJsonParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(JObject), typeof(JObject) };
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
        public void AUT_LboMethod_ExecuteJson_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_LboMethod_ExecuteJson_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_LboMethod_ExecuteXml_Method_Call_Internally(Type[] types)
        {
            var methodExecuteXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteXml, methodExecuteXmlParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboMethodInstance.ExecuteXml(onyxUserContext, inputData, customData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboMethodInstance.ExecuteXml(onyxUserContext, inputData, customData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_ExecuteXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var methodExecuteXmlParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };
            object[] parametersOfExecuteXml = { onyxUserContext, inputData, customData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteXml, methodExecuteXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboMethodInstanceFixture, parametersOfExecuteXml);
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
        public void AUT_LboMethod_ExecuteXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var inputData = this.CreateType<string>();
            var customData = this.CreateType<string>();
            var methodExecuteXmlParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };
            object[] parametersOfExecuteXml = { onyxUserContext, inputData, customData };

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
        public void AUT_LboMethod_ExecuteXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var methodExecuteXmlParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };

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
        public void AUT_LboMethod_ExecuteXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteXml);
            var methodExecuteXmlParametersTypes = new Type[] { typeof(IOnyxUserContext), typeof(string), typeof(string) };
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
        public void AUT_LboMethod_ExecuteXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_LboMethod_ExecuteXml_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_LboMethod_GetJsonParameterStructure_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonParameterStructureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);

            // Act
            Action executeAction = () => _lboMethodInstance.GetJsonParameterStructure();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = _lboMethodInstance.GetJsonParameterStructure();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            Type [] methodGetJsonParameterStructureParametersTypes = null;
            object[] parametersOfGetJsonParameterStructure = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<JObject>(_lboMethodInstanceFixture, parametersOfGetJsonParameterStructure);
            var result2 = this.GetResultOfMethod<JObject>(MethodGetJsonParameterStructure, parametersOfGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetJsonParameterStructure.ShouldBeNull();
            methodGetJsonParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            Type [] methodGetJsonParameterStructureParametersTypes = null;
            object[] parametersOfGetJsonParameterStructure = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodGetJsonParameterStructure, parametersOfGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            parametersOfGetJsonParameterStructure.ShouldBeNull();
            methodGetJsonParameterStructureParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            Type [] methodGetJsonParameterStructureParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetJsonParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonParameterStructure);
            Type [] methodGetJsonParameterStructureParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonParameterStructure, methodGetJsonParameterStructureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonParameterStructure) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetJsonParameterStructure_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboMethod_GetXmlParameterStructure_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParameterStructureParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);

            // Act
            Action executeAction = () => _lboMethodInstance.GetXmlParameterStructure();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboMethodInstance.GetXmlParameterStructure();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            Type [] methodGetXmlParameterStructureParametersTypes = null;
            object[] parametersOfGetXmlParameterStructure = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboMethodInstanceFixture, parametersOfGetXmlParameterStructure);
            var result2 = this.GetResultOfMethod<string>(MethodGetXmlParameterStructure, parametersOfGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXmlParameterStructure.ShouldBeNull();
            methodGetXmlParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            Type [] methodGetXmlParameterStructureParametersTypes = null;
            object[] parametersOfGetXmlParameterStructure = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXmlParameterStructure, parametersOfGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            parametersOfGetXmlParameterStructure.ShouldBeNull();
            methodGetXmlParameterStructureParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            Type [] methodGetXmlParameterStructureParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXmlParameterStructure);
            Type [] methodGetXmlParameterStructureParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXmlParameterStructure, methodGetXmlParameterStructureParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParameterStructureParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXmlParameterStructure) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboMethod_GetXmlParameterStructure_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #endregion

        #endregion
    }
}