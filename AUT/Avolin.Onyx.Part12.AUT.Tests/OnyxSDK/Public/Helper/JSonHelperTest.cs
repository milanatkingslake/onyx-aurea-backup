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
using OnyxSDK.Public.Helper;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Helper.JSonHelper" />)
    ///     and namespace <see cref="OnyxSDK.Public.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class JSonHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="JSonHelper" />)
        /// </summary>
        public JSonHelperTest() : base(typeof(JSonHelper))
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

        #region General Initializer : Class (JSonHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _jSonHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="JSonHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _jSonHelperInstanceType = typeof(JSonHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (JSonHelper) Initializer

        #region Methods

        private const string MethodConvertXmlToJObject = "ConvertXmlToJObject";
        private const string MethodGetNullTextObject = "GetNullTextObject";
        private const string MethodGetJsonNodeInteger = "GetJsonNodeInteger";
        private const string MethodGetJsonNodeIntegerNoNull = "GetJsonNodeIntegerNoNull";
        private const string MethodGetJsonNodeBoolean = "GetJsonNodeBoolean";
        private const string MethodGetJsonNodeString = "GetJsonNodeString";
        private const string MethodGetJsonNodeValue = "GetJsonNodeValue";
        private const string MethodGetJsonNodePath = "GetJsonNodePath";
        private const string MethodGetRowSetData = "GetRowSetData";
        private const string MethodGetRowsData = "GetRowsData";
        private const string MethodGetColumnMappings = "GetColumnMappings";

        #endregion

        #endregion

        #region General Initializer : Class (JSonHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="JSonHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_JSonHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (JSonHelper)

        #region General Initializer : Class (JSonHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="JSonHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodConvertXmlToJObject, 0)]
        [TestCase(MethodGetNullTextObject, 0)]
        [TestCase(MethodGetJsonNodeInteger, 0)]
        [TestCase(MethodGetJsonNodeIntegerNoNull, 0)]
        [TestCase(MethodGetJsonNodeBoolean, 0)]
        [TestCase(MethodGetJsonNodeString, 0)]
        [TestCase(MethodGetJsonNodeValue, 0)]
        [TestCase(MethodGetJsonNodePath, 0)]
        [TestCase(MethodGetRowSetData, 0)]
        [TestCase(MethodGetRowsData, 0)]
        [TestCase(MethodGetColumnMappings, 0)]
        public void AUT_JSonHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (JSonHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="JSonHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_JSonHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _jSonHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var xmlData = this.CreateType<string>();

            // Act
            Action executeAction = () => JSonHelper.ConvertXmlToJObject(xmlData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var xmlData = this.CreateType<string>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.ConvertXmlToJObject(xmlData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var xmlData = this.CreateType<string>();
            var methodConvertXmlToJObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertXmlToJObject = { xmlData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes);
            var result2 = this.GetResultOfMethod<JObject>(MethodConvertXmlToJObject, parametersOfConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertXmlToJObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConvertXmlToJObject.ShouldNotBeNull();
            parametersOfConvertXmlToJObject.Length.ShouldBe(1);
            methodConvertXmlToJObjectParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var xmlData = this.CreateType<string>();
            var methodConvertXmlToJObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertXmlToJObject = { xmlData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodConvertXmlToJObject, parametersOfConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes);

            // Assert
            parametersOfConvertXmlToJObject.ShouldNotBeNull();
            parametersOfConvertXmlToJObject.Length.ShouldBe(1);
            methodConvertXmlToJObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var methodConvertXmlToJObjectParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertXmlToJObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var methodConvertXmlToJObjectParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertXmlToJObject, methodConvertXmlToJObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertXmlToJObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlToJObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlToJObject) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_ConvertXmlToJObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlToJObject);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlToJObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetNullTextObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => JSonHelper.GetNullTextObject(value);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var value = this.CreateType<string>();
            var returnedValue = default(JObject);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetNullTextObject(value);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var value = this.CreateType<string>();
            var methodGetNullTextObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNullTextObject = { value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes);
            var result2 = this.GetResultOfMethod<JObject>(MethodGetNullTextObject, parametersOfGetNullTextObject, methodGetNullTextObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNullTextObject.ShouldNotBeNull();
            parametersOfGetNullTextObject.Length.ShouldBe(1);
            methodGetNullTextObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<JObject>(MethodGetNullTextObject, parametersOfGetNullTextObject, methodGetNullTextObjectParametersTypes));
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var value = this.CreateType<string>();
            var methodGetNullTextObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNullTextObject = { value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNullTextObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNullTextObject.ShouldNotBeNull();
            parametersOfGetNullTextObject.Length.ShouldBe(1);
            methodGetNullTextObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var value = this.CreateType<string>();
            var methodGetNullTextObjectParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNullTextObject = { value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JObject>(MethodGetNullTextObject, parametersOfGetNullTextObject, methodGetNullTextObjectParametersTypes);

            // Assert
            parametersOfGetNullTextObject.ShouldNotBeNull();
            parametersOfGetNullTextObject.Length.ShouldBe(1);
            methodGetNullTextObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var methodGetNullTextObjectParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetNullTextObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var methodGetNullTextObjectParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNullTextObject, methodGetNullTextObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNullTextObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNullTextObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetNullTextObject) (Return Type : JObject) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetNullTextObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNullTextObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNullTextObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodeIntegerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeInteger, methodGetJsonNodeIntegerParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodeInteger(jObject, nodePath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var returnedValue = default(int?);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetJsonNodeInteger(jObject, nodePath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var methodGetJsonNodeIntegerParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfGetJsonNodeInteger = { jObject, nodePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeInteger, methodGetJsonNodeIntegerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodeInteger);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodeInteger.ShouldNotBeNull();
            parametersOfGetJsonNodeInteger.Length.ShouldBe(2);
            methodGetJsonNodeIntegerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var methodGetJsonNodeIntegerParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfGetJsonNodeInteger = { jObject, nodePath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int?>(MethodGetJsonNodeInteger, parametersOfGetJsonNodeInteger, methodGetJsonNodeIntegerParametersTypes);

            // Assert
            parametersOfGetJsonNodeInteger.ShouldNotBeNull();
            parametersOfGetJsonNodeInteger.Length.ShouldBe(2);
            methodGetJsonNodeIntegerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var methodGetJsonNodeIntegerParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeInteger, methodGetJsonNodeIntegerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodeIntegerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeInteger, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeInteger) (Return Type : int?) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeInteger_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeInteger, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodeIntegerNoNullParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodeIntegerNoNull(jObject, nodePath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfGetJsonNodeIntegerNoNull = { jObject, nodePath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);
            var result2 = this.GetResultOfMethod<int>(MethodGetJsonNodeIntegerNoNull, parametersOfGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetJsonNodeIntegerNoNull.ShouldNotBeNull();
            parametersOfGetJsonNodeIntegerNoNull.Length.ShouldBe(2);
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<int>(MethodGetJsonNodeIntegerNoNull, parametersOfGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes));
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfGetJsonNodeIntegerNoNull = { jObject, nodePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodeIntegerNoNull);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodeIntegerNoNull.ShouldNotBeNull();
            parametersOfGetJsonNodeIntegerNoNull.Length.ShouldBe(2);
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfGetJsonNodeIntegerNoNull = { jObject, nodePath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetJsonNodeIntegerNoNull, parametersOfGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);

            // Assert
            parametersOfGetJsonNodeIntegerNoNull.ShouldNotBeNull();
            parametersOfGetJsonNodeIntegerNoNull.Length.ShouldBe(2);
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var methodGetJsonNodeIntegerNoNullParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeIntegerNoNull, methodGetJsonNodeIntegerNoNullParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodeIntegerNoNullParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeIntegerNoNull, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeIntegerNoNull) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeIntegerNoNull_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeIntegerNoNull);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeIntegerNoNull, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodeBooleanParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsFalse = this.CreateType<bool>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodeBoolean(jObject, nodePath, nullIsFalse);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsFalse = this.CreateType<bool>();
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeBoolean = { jObject, nodePath, nullIsFalse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodGetJsonNodeBoolean, parametersOfGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetJsonNodeBoolean.ShouldNotBeNull();
            parametersOfGetJsonNodeBoolean.Length.ShouldBe(3);
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodGetJsonNodeBoolean, parametersOfGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes));
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsFalse = this.CreateType<bool>();
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeBoolean = { jObject, nodePath, nullIsFalse };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodeBoolean);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodeBoolean.ShouldNotBeNull();
            parametersOfGetJsonNodeBoolean.Length.ShouldBe(3);
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsFalse = this.CreateType<bool>();
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeBoolean = { jObject, nodePath, nullIsFalse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetJsonNodeBoolean, parametersOfGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);

            // Assert
            parametersOfGetJsonNodeBoolean.ShouldNotBeNull();
            parametersOfGetJsonNodeBoolean.Length.ShouldBe(3);
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var methodGetJsonNodeBooleanParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeBoolean, methodGetJsonNodeBooleanParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodeBooleanParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeBoolean, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeBoolean) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeBoolean_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeBoolean, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodeStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsEmpty = this.CreateType<bool>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodeString(jObject, nodePath, nullIsEmpty);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsEmpty = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetJsonNodeString(jObject, nodePath, nullIsEmpty);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsEmpty = this.CreateType<bool>();
            var methodGetJsonNodeStringParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeString = { jObject, nodePath, nullIsEmpty };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetJsonNodeString, parametersOfGetJsonNodeString, methodGetJsonNodeStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetJsonNodeString.ShouldNotBeNull();
            parametersOfGetJsonNodeString.Length.ShouldBe(3);
            methodGetJsonNodeStringParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetJsonNodeString, parametersOfGetJsonNodeString, methodGetJsonNodeStringParametersTypes));
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsEmpty = this.CreateType<bool>();
            var methodGetJsonNodeStringParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeString = { jObject, nodePath, nullIsEmpty };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodeString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodeString.ShouldNotBeNull();
            parametersOfGetJsonNodeString.Length.ShouldBe(3);
            methodGetJsonNodeStringParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var nullIsEmpty = this.CreateType<bool>();
            var methodGetJsonNodeStringParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            object[] parametersOfGetJsonNodeString = { jObject, nodePath, nullIsEmpty };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetJsonNodeString, parametersOfGetJsonNodeString, methodGetJsonNodeStringParametersTypes);

            // Assert
            parametersOfGetJsonNodeString.ShouldNotBeNull();
            parametersOfGetJsonNodeString.Length.ShouldBe(3);
            methodGetJsonNodeStringParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var methodGetJsonNodeStringParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodeStringParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var methodGetJsonNodeStringParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeString, methodGetJsonNodeStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodeStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeString, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeValue, methodGetJsonNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodeValue(jObject, nodePath, type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var type = this.CreateType<Type>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetJsonNodeValue(jObject, nodePath, type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var type = this.CreateType<Type>();
            var methodGetJsonNodeValueParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(Type) };
            object[] parametersOfGetJsonNodeValue = { jObject, nodePath, type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeValue, methodGetJsonNodeValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodeValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodeValue.ShouldNotBeNull();
            parametersOfGetJsonNodeValue.Length.ShouldBe(3);
            methodGetJsonNodeValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var jObject = this.CreateType<JObject>();
            var nodePath = this.CreateType<string>();
            var type = this.CreateType<Type>();
            var methodGetJsonNodeValueParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(Type) };
            object[] parametersOfGetJsonNodeValue = { jObject, nodePath, type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetJsonNodeValue, parametersOfGetJsonNodeValue, methodGetJsonNodeValueParametersTypes);

            // Assert
            parametersOfGetJsonNodeValue.ShouldNotBeNull();
            parametersOfGetJsonNodeValue.Length.ShouldBe(3);
            methodGetJsonNodeValueParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var methodGetJsonNodeValueParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeValue, methodGetJsonNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetJsonNodeValueParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var methodGetJsonNodeValueParametersTypes = new Type[] { typeof(JObject), typeof(string), typeof(Type) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodeValue, methodGetJsonNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodeValue) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodeValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodeValue, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetJsonNodePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var nodes = this.CreateType<string[]>();

            // Act
            Action executeAction = () => JSonHelper.GetJsonNodePath(nodes);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var nodes = this.CreateType<string[]>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetJsonNodePath(nodes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var nodes = this.CreateType<string[]>();
            var methodGetJsonNodePathParametersTypes = new Type[] { typeof(string[]) };
            object[] parametersOfGetJsonNodePath = { nodes };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetJsonNodePath, parametersOfGetJsonNodePath, methodGetJsonNodePathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetJsonNodePath.ShouldNotBeNull();
            parametersOfGetJsonNodePath.Length.ShouldBe(1);
            methodGetJsonNodePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetJsonNodePath, parametersOfGetJsonNodePath, methodGetJsonNodePathParametersTypes));
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var nodes = this.CreateType<string[]>();
            var methodGetJsonNodePathParametersTypes = new Type[] { typeof(string[]) };
            object[] parametersOfGetJsonNodePath = { nodes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetJsonNodePath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetJsonNodePath.ShouldNotBeNull();
            parametersOfGetJsonNodePath.Length.ShouldBe(1);
            methodGetJsonNodePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var nodes = this.CreateType<string[]>();
            var methodGetJsonNodePathParametersTypes = new Type[] { typeof(string[]) };
            object[] parametersOfGetJsonNodePath = { nodes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetJsonNodePath, parametersOfGetJsonNodePath, methodGetJsonNodePathParametersTypes);

            // Assert
            parametersOfGetJsonNodePath.ShouldNotBeNull();
            parametersOfGetJsonNodePath.Length.ShouldBe(1);
            methodGetJsonNodePathParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var methodGetJsonNodePathParametersTypes = new Type[] { typeof(string[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetJsonNodePathParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var methodGetJsonNodePathParametersTypes = new Type[] { typeof(string[]) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetJsonNodePath, methodGetJsonNodePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetJsonNodePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodePath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetJsonNodePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetJsonNodePath_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetJsonNodePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetJsonNodePath, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetRowSetData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRowSetDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRowSetData, methodGetRowSetDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var rowSet = this.CreateType<JToken>();
            var rawData = this.CreateType<bool>();

            // Act
            Action executeAction = () => JSonHelper.GetRowSetData(rowSet, rawData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var rowSet = this.CreateType<JToken>();
            var rawData = this.CreateType<bool>();
            var returnedValue = default(JArray);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetRowSetData(rowSet, rawData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var rowSet = this.CreateType<JToken>();
            var rawData = this.CreateType<bool>();
            var methodGetRowSetDataParametersTypes = new Type[] { typeof(JToken), typeof(bool) };
            object[] parametersOfGetRowSetData = { rowSet, rawData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowSetData, methodGetRowSetDataParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRowSetData, methodGetRowSetDataParametersTypes);
            var result2 = this.GetResultOfMethod<JArray>(MethodGetRowSetData, parametersOfGetRowSetData, methodGetRowSetDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRowSetData.ShouldNotBeNull();
            parametersOfGetRowSetData.Length.ShouldBe(2);
            methodGetRowSetDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<JArray>(MethodGetRowSetData, parametersOfGetRowSetData, methodGetRowSetDataParametersTypes));
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var rowSet = this.CreateType<JToken>();
            var rawData = this.CreateType<bool>();
            var methodGetRowSetDataParametersTypes = new Type[] { typeof(JToken), typeof(bool) };
            object[] parametersOfGetRowSetData = { rowSet, rawData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowSetData, methodGetRowSetDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRowSetData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRowSetData.ShouldNotBeNull();
            parametersOfGetRowSetData.Length.ShouldBe(2);
            methodGetRowSetDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var rowSet = this.CreateType<JToken>();
            var rawData = this.CreateType<bool>();
            var methodGetRowSetDataParametersTypes = new Type[] { typeof(JToken), typeof(bool) };
            object[] parametersOfGetRowSetData = { rowSet, rawData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JArray>(MethodGetRowSetData, parametersOfGetRowSetData, methodGetRowSetDataParametersTypes);

            // Assert
            parametersOfGetRowSetData.ShouldNotBeNull();
            parametersOfGetRowSetData.Length.ShouldBe(2);
            methodGetRowSetDataParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var methodGetRowSetDataParametersTypes = new Type[] { typeof(JToken), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRowSetData, methodGetRowSetDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRowSetDataParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var methodGetRowSetDataParametersTypes = new Type[] { typeof(JToken), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRowSetData, methodGetRowSetDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRowSetDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowSetData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRowSetData) (Return Type : JArray) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowSetData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowSetData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowSetData, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetRowsData_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetRowsDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRowsData, methodGetRowsDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var rows = this.CreateType<JToken>();
            var mappingData = this.CreateType<Dictionary<string, string>>();
            var rawData = this.CreateType<bool>();
            var methodGetRowsDataParametersTypes = new Type[] { typeof(JToken), typeof(Dictionary<string, string>), typeof(bool) };
            object[] parametersOfGetRowsData = { rows, mappingData, rawData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsData, methodGetRowsDataParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRowsData, methodGetRowsDataParametersTypes);
            var result2 = this.GetResultOfMethod<JArray>(MethodGetRowsData, parametersOfGetRowsData, methodGetRowsDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRowsData.ShouldNotBeNull();
            parametersOfGetRowsData.Length.ShouldBe(3);
            methodGetRowsDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<JArray>(MethodGetRowsData, parametersOfGetRowsData, methodGetRowsDataParametersTypes));
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var rows = this.CreateType<JToken>();
            var mappingData = this.CreateType<Dictionary<string, string>>();
            var rawData = this.CreateType<bool>();
            var methodGetRowsDataParametersTypes = new Type[] { typeof(JToken), typeof(Dictionary<string, string>), typeof(bool) };
            object[] parametersOfGetRowsData = { rows, mappingData, rawData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsData, methodGetRowsDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRowsData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRowsData.ShouldNotBeNull();
            parametersOfGetRowsData.Length.ShouldBe(3);
            methodGetRowsDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var rows = this.CreateType<JToken>();
            var mappingData = this.CreateType<Dictionary<string, string>>();
            var rawData = this.CreateType<bool>();
            var methodGetRowsDataParametersTypes = new Type[] { typeof(JToken), typeof(Dictionary<string, string>), typeof(bool) };
            object[] parametersOfGetRowsData = { rows, mappingData, rawData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<JArray>(MethodGetRowsData, parametersOfGetRowsData, methodGetRowsDataParametersTypes);

            // Assert
            parametersOfGetRowsData.ShouldNotBeNull();
            parametersOfGetRowsData.Length.ShouldBe(3);
            methodGetRowsDataParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var methodGetRowsDataParametersTypes = new Type[] { typeof(JToken), typeof(Dictionary<string, string>), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRowsData, methodGetRowsDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRowsDataParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var methodGetRowsDataParametersTypes = new Type[] { typeof(JToken), typeof(Dictionary<string, string>), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRowsData, methodGetRowsDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRowsDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRowsData) (Return Type : JArray) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetRowsData_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRowsData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRowsData, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetColumnMappingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetColumnMappings, methodGetColumnMappingsParametersTypes);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var columnDefinitions = this.CreateType<JToken>();

            // Act
            Action executeAction = () => JSonHelper.GetColumnMappings(columnDefinitions);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var columnDefinitions = this.CreateType<JToken>();
            var returnedValue = default(Dictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = JSonHelper.GetColumnMappings(columnDefinitions);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var columnDefinitions = this.CreateType<JToken>();
            var methodGetColumnMappingsParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetColumnMappings = { columnDefinitions };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnMappings, methodGetColumnMappingsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetColumnMappings, methodGetColumnMappingsParametersTypes);
            var result2 = this.GetResultOfMethod<Dictionary<string, string>>(MethodGetColumnMappings, parametersOfGetColumnMappings, methodGetColumnMappingsParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetColumnMappings);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetColumnMappings.ShouldNotBeNull();
            parametersOfGetColumnMappings.Length.ShouldBe(1);
            methodGetColumnMappingsParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var columnDefinitions = this.CreateType<JToken>();
            var methodGetColumnMappingsParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetColumnMappings = { columnDefinitions };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Dictionary<string, string>>(MethodGetColumnMappings, parametersOfGetColumnMappings, methodGetColumnMappingsParametersTypes);

            // Assert
            parametersOfGetColumnMappings.ShouldNotBeNull();
            parametersOfGetColumnMappings.Length.ShouldBe(1);
            methodGetColumnMappingsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var methodGetColumnMappingsParametersTypes = new Type[] { typeof(JToken) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetColumnMappings, methodGetColumnMappingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetColumnMappingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var methodGetColumnMappingsParametersTypes = new Type[] { typeof(JToken) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetColumnMappings, methodGetColumnMappingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetColumnMappingsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnMappings, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnMappings) (Return Type : Dictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JSonHelper_GetColumnMappings_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnMappings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnMappings, 0);
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