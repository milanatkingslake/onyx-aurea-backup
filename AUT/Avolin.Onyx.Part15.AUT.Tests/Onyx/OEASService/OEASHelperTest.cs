using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OEASService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OEASService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OEASService.OEASHelper" />)
    ///     and namespace <see cref="Onyx.OEASService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OEASHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASHelper" />)
        /// </summary>
        public OEASHelperTest() : base(typeof(OEASHelper))
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

        #region General Initializer : Class (OEASHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OEASHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASHelperInstanceType = typeof(OEASHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASHelper) Initializer

        #region Methods

        private const string MethodConvertXmlTo2DArray = "ConvertXmlTo2DArray";
        private const string MethodConvertXmlTo1DArray = "ConvertXmlTo1DArray";
        private const string MethodGetValue = "GetValue";

        #endregion

        #endregion

        #region General Initializer : Class (OEASHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASHelper)

        #region General Initializer : Class (OEASHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodConvertXmlTo2DArray, 0)]
        [TestCase(MethodConvertXmlTo1DArray, 0)]
        [TestCase(MethodGetValue, 0)]
        public void AUT_OEASHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OEASHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEASHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _oEASHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var resourcesXml = this.CreateType<XElement>();

            // Act
            Action executeAction = () => OEASHelper.ConvertXmlTo2DArray(resourcesXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var resourcesXml = this.CreateType<XElement>();
            var returnedValue = default(object[,]);

            // Act
            Action executeAction = () => returnedValue = OEASHelper.ConvertXmlTo2DArray(resourcesXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,])  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo2DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo2DArray = { resourcesXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes);
            var result2 = this.GetResultOfMethod<object[,]>(MethodConvertXmlTo2DArray, parametersOfConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertXmlTo2DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo2DArray.Length.ShouldBe(1);
            methodConvertXmlTo2DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<object[,]>(MethodConvertXmlTo2DArray, parametersOfConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo2DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo2DArray = { resourcesXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertXmlTo2DArray);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertXmlTo2DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo2DArray.Length.ShouldBe(1);
            methodConvertXmlTo2DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo2DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo2DArray = { resourcesXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object[,]>(MethodConvertXmlTo2DArray, parametersOfConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes);

            // Assert
            parametersOfConvertXmlTo2DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo2DArray.Length.ShouldBe(1);
            methodConvertXmlTo2DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var methodConvertXmlTo2DArrayParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertXmlTo2DArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var methodConvertXmlTo2DArrayParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo2DArray, methodConvertXmlTo2DArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertXmlTo2DArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo2DArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlTo2DArray) (Return Type : object[,]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo2DArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo2DArray);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo2DArray, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertXmlTo1DArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var resourcesXml = this.CreateType<XElement>();

            // Act
            Action executeAction = () => OEASHelper.ConvertXmlTo1DArray(resourcesXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var resourcesXml = this.CreateType<XElement>();
            var returnedValue = default(object[]);

            // Act
            Action executeAction = () => returnedValue = OEASHelper.ConvertXmlTo1DArray(resourcesXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[])  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo1DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo1DArray = { resourcesXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);
            var result2 = this.GetResultOfMethod<object[]>(MethodConvertXmlTo1DArray, parametersOfConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertXmlTo1DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo1DArray.Length.ShouldBe(1);
            methodConvertXmlTo1DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<object[]>(MethodConvertXmlTo1DArray, parametersOfConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo1DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo1DArray = { resourcesXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfConvertXmlTo1DArray);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertXmlTo1DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo1DArray.Length.ShouldBe(1);
            methodConvertXmlTo1DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var resourcesXml = this.CreateType<XElement>();
            var methodConvertXmlTo1DArrayParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfConvertXmlTo1DArray = { resourcesXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object[]>(MethodConvertXmlTo1DArray, parametersOfConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);

            // Assert
            parametersOfConvertXmlTo1DArray.ShouldNotBeNull();
            parametersOfConvertXmlTo1DArray.Length.ShouldBe(1);
            methodConvertXmlTo1DArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var methodConvertXmlTo1DArrayParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertXmlTo1DArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var methodConvertXmlTo1DArrayParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertXmlTo1DArray, methodConvertXmlTo1DArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertXmlTo1DArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo1DArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertXmlTo1DArray) (Return Type : object[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_ConvertXmlTo1DArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertXmlTo1DArray);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertXmlTo1DArray, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASHelper_GetValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetValue, methodGetValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var document = this.CreateType<XDocument>();
            var xpath = this.CreateType<string>();

            // Act
            Action executeAction = () => OEASHelper.GetValue(document, xpath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var document = this.CreateType<XDocument>();
            var xpath = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = OEASHelper.GetValue(document, xpath);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var document = this.CreateType<XDocument>();
            var xpath = this.CreateType<string>();
            var methodGetValueParametersTypes = new Type[] { typeof(XDocument), typeof(string) };
            object[] parametersOfGetValue = { document, xpath };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetValue, methodGetValueParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetValue, methodGetValueParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetValue, parametersOfGetValue, methodGetValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetValue.ShouldNotBeNull();
            parametersOfGetValue.Length.ShouldBe(2);
            methodGetValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetValue, parametersOfGetValue, methodGetValueParametersTypes));
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var document = this.CreateType<XDocument>();
            var xpath = this.CreateType<string>();
            var methodGetValueParametersTypes = new Type[] { typeof(XDocument), typeof(string) };
            object[] parametersOfGetValue = { document, xpath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetValue, methodGetValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetValue.ShouldNotBeNull();
            parametersOfGetValue.Length.ShouldBe(2);
            methodGetValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var document = this.CreateType<XDocument>();
            var xpath = this.CreateType<string>();
            var methodGetValueParametersTypes = new Type[] { typeof(XDocument), typeof(string) };
            object[] parametersOfGetValue = { document, xpath };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetValue, parametersOfGetValue, methodGetValueParametersTypes);

            // Assert
            parametersOfGetValue.ShouldNotBeNull();
            parametersOfGetValue.Length.ShouldBe(2);
            methodGetValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var methodGetValueParametersTypes = new Type[] { typeof(XDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetValue, methodGetValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var methodGetValueParametersTypes = new Type[] { typeof(XDocument), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetValue, methodGetValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASHelper_GetValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetValue, 0);
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