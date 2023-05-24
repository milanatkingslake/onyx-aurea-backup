using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DoMore" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DoMoreTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DoMore" />)
        /// </summary>
        public DoMoreTest() : base(typeof(DoMore))
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

        #region General Initializer : Class (DoMore) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _doMoreInstanceType;
        private DoMore _doMoreInstance;
        private DoMore _doMoreInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DoMore" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doMoreInstanceType = typeof(DoMore);
            _doMoreInstanceFixture = this.Create<DoMore>(false);
            _doMoreInstance = _doMoreInstanceFixture ?? this.Create<DoMore>(true);
            CurrentInstance = _doMoreInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoMore) Initializer

        #region Methods

        private const string MethodGetDoMore = "GetDoMore";
        private const string MethodPromptUpdate = "PromptUpdate";
        private const string MethodGetDoMoreNavigator = "GetDoMoreNavigator";
        private const string MethodGetDoMoreCount = "GetDoMoreCount";
        private const string MethodGetDoMoreNavigatorCount = "GetDoMoreNavigatorCount";
        private const string MethodconstructLboParameter = "constructLboParameter";
        private const string MethodexecuteLbo = "executeLbo";
        private const string MethodPerformAction = "PerformAction";
        private const string MethodToByteArray = "ToByteArray";
        private const string MethodSaveByteArrayAsImage = "SaveByteArrayAsImage";
        private const string MethodBase64ToImage = "Base64ToImage";
        private const string MethodByteArrayToString = "ByteArrayToString";
        private const string MethodPromptRetrieve = "PromptRetrieve";
        private const string MethodRetrieveBySecondaryId = "RetrieveBySecondaryId";
        private const string MethodSetLboParamXml = "SetLboParamXml";
        private const string MethodPromptExecuteLBO = "PromptExecuteLBO";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (DoMore) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoMore_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DoMore) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoMore_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DoMore)

        #region General Initializer : Class (DoMore) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDoMore, 0)]
        [TestCase(MethodPromptUpdate, 0)]
        [TestCase(MethodGetDoMoreNavigator, 0)]
        [TestCase(MethodGetDoMoreCount, 0)]
        [TestCase(MethodGetDoMoreNavigatorCount, 0)]
        [TestCase(MethodconstructLboParameter, 0)]
        [TestCase(MethodexecuteLbo, 0)]
        [TestCase(MethodPerformAction, 0)]
        [TestCase(MethodToByteArray, 0)]
        [TestCase(MethodSaveByteArrayAsImage, 0)]
        [TestCase(MethodBase64ToImage, 0)]
        [TestCase(MethodByteArrayToString, 0)]
        [TestCase(MethodPromptRetrieve, 0)]
        [TestCase(MethodRetrieveBySecondaryId, 0)]
        [TestCase(MethodSetLboParamXml, 0)]
        [TestCase(MethodPromptExecuteLBO, 0)]
        public void AUT_DoMore_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DoMore) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_DoMore_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DoMore) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DoMore" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoMore_Is_Instance_Present_Test()
        {
            // Assert
            _doMoreInstanceType.ShouldNotBeNull();
            _doMoreInstance.ShouldNotBeNull();
            _doMoreInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DoMore) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DoMore" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DoMore_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _doMoreInstance.ShouldBeAssignableTo<DoMore>();
            _doMoreInstanceFixture.ShouldBeAssignableTo<DoMore>();
            CurrentInstance.ShouldBeAssignableTo<DoMore>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DoMore) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoMore_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            DoMore instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoMore(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doMoreInstance.ShouldNotBeNull();
            _doMoreInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DoMore>();
        }

        #endregion

        #region General Constructor : Class (DoMore) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DoMore_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            DoMore instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DoMore(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _doMoreInstance.ShouldNotBeNull();
            _doMoreInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDoMore) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var count = this.CreateType<bool>();

            // Act
            Action executeAction = () => _doMoreInstance.GetDoMore(count);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var count = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.GetDoMore(count);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var count = this.CreateType<bool>();
            var methodGetDoMoreParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfGetDoMore = { count };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMore, methodGetDoMoreParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfGetDoMore);
            var result2 = this.GetResultOfMethod<string>(MethodGetDoMore, parametersOfGetDoMore, methodGetDoMoreParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDoMore.ShouldNotBeNull();
            parametersOfGetDoMore.Length.ShouldBe(1);
            methodGetDoMoreParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var count = this.CreateType<bool>();
            var methodGetDoMoreParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfGetDoMore = { count };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDoMore, parametersOfGetDoMore, methodGetDoMoreParametersTypes);

            // Assert
            parametersOfGetDoMore.ShouldNotBeNull();
            parametersOfGetDoMore.Length.ShouldBe(1);
            methodGetDoMoreParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var methodGetDoMoreParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDoMore, methodGetDoMoreParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDoMoreParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var methodGetDoMoreParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDoMore, methodGetDoMoreParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDoMoreParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMore, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMore) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMore_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMore);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMore, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_PromptUpdate_Method_Call_Internally(Type[] types)
        {
            var methodPromptUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPromptUpdate, methodPromptUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);

            // Act
            Action executeAction = () => _doMoreInstance.PromptUpdate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.PromptUpdate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            Type [] methodPromptUpdateParametersTypes = null;
            object[] parametersOfPromptUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPromptUpdate, methodPromptUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfPromptUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodPromptUpdate, parametersOfPromptUpdate, methodPromptUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPromptUpdate.ShouldBeNull();
            methodPromptUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            Type [] methodPromptUpdateParametersTypes = null;
            object[] parametersOfPromptUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPromptUpdate, parametersOfPromptUpdate, methodPromptUpdateParametersTypes);

            // Assert
            parametersOfPromptUpdate.ShouldBeNull();
            methodPromptUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            Type [] methodPromptUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPromptUpdate, methodPromptUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPromptUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            Type [] methodPromptUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPromptUpdate, methodPromptUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPromptUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptUpdate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodPromptUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_GetDoMoreNavigator_Method_Call_Internally(Type[] types)
        {
            var methodGetDoMoreNavigatorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);

            // Act
            Action executeAction = () => _doMoreInstance.GetDoMoreNavigator();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.GetDoMoreNavigator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            Type [] methodGetDoMoreNavigatorParametersTypes = null;
            object[] parametersOfGetDoMoreNavigator = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfGetDoMoreNavigator);
            var result2 = this.GetResultOfMethod<string>(MethodGetDoMoreNavigator, parametersOfGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDoMoreNavigator.ShouldBeNull();
            methodGetDoMoreNavigatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            Type [] methodGetDoMoreNavigatorParametersTypes = null;
            object[] parametersOfGetDoMoreNavigator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDoMoreNavigator, parametersOfGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes);

            // Assert
            parametersOfGetDoMoreNavigator.ShouldBeNull();
            methodGetDoMoreNavigatorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            Type [] methodGetDoMoreNavigatorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDoMoreNavigatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            Type [] methodGetDoMoreNavigatorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigator, methodGetDoMoreNavigatorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDoMoreNavigatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigator) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreNavigator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_GetDoMoreCount_Method_Call_Internally(Type[] types)
        {
            var methodGetDoMoreCountParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDoMoreCount, methodGetDoMoreCountParametersTypes);
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);

            // Act
            Action executeAction = () => _doMoreInstance.GetDoMoreCount();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.GetDoMoreCount();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            Type [] methodGetDoMoreCountParametersTypes = null;
            object[] parametersOfGetDoMoreCount = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreCount, methodGetDoMoreCountParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfGetDoMoreCount);
            var result2 = this.GetResultOfMethod<string>(MethodGetDoMoreCount, parametersOfGetDoMoreCount, methodGetDoMoreCountParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDoMoreCount.ShouldBeNull();
            methodGetDoMoreCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            Type [] methodGetDoMoreCountParametersTypes = null;
            object[] parametersOfGetDoMoreCount = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDoMoreCount, parametersOfGetDoMoreCount, methodGetDoMoreCountParametersTypes);

            // Assert
            parametersOfGetDoMoreCount.ShouldBeNull();
            methodGetDoMoreCountParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            Type [] methodGetDoMoreCountParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDoMoreCount, methodGetDoMoreCountParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDoMoreCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            Type [] methodGetDoMoreCountParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDoMoreCount, methodGetDoMoreCountParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDoMoreCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreCount) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreCount_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreCount);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreCount, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_Internally(Type[] types)
        {
            var methodGetDoMoreNavigatorCountParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);

            // Act
            Action executeAction = () => _doMoreInstance.GetDoMoreNavigatorCount();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.GetDoMoreNavigatorCount();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            Type [] methodGetDoMoreNavigatorCountParametersTypes = null;
            object[] parametersOfGetDoMoreNavigatorCount = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfGetDoMoreNavigatorCount);
            var result2 = this.GetResultOfMethod<string>(MethodGetDoMoreNavigatorCount, parametersOfGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDoMoreNavigatorCount.ShouldBeNull();
            methodGetDoMoreNavigatorCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            Type [] methodGetDoMoreNavigatorCountParametersTypes = null;
            object[] parametersOfGetDoMoreNavigatorCount = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDoMoreNavigatorCount, parametersOfGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes);

            // Assert
            parametersOfGetDoMoreNavigatorCount.ShouldBeNull();
            methodGetDoMoreNavigatorCountParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            Type [] methodGetDoMoreNavigatorCountParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDoMoreNavigatorCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            Type [] methodGetDoMoreNavigatorCountParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDoMoreNavigatorCount, methodGetDoMoreNavigatorCountParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDoMoreNavigatorCountParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDoMoreNavigatorCount) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_GetDoMoreNavigatorCount_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDoMoreNavigatorCount);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDoMoreNavigatorCount, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_constructLboParameter_Method_Call_Internally(Type[] types)
        {
            var methodconstructLboParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconstructLboParameter, methodconstructLboParameterParametersTypes);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var lboName = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();

            // Act
            Action executeAction = () => _doMoreInstance.constructLboParameter(lboName, lboMethod);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var lboName = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var returnedValue = default(XmlDocument);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.constructLboParameter(lboName, lboMethod);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var lboName = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var methodconstructLboParameterParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfconstructLboParameter = { lboName, lboMethod };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodconstructLboParameter, methodconstructLboParameterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_doMoreInstanceFixture, out exception1, parametersOfconstructLboParameter);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodconstructLboParameter, parametersOfconstructLboParameter, methodconstructLboParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfconstructLboParameter.ShouldNotBeNull();
            parametersOfconstructLboParameter.Length.ShouldBe(2);
            methodconstructLboParameterParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var lboName = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var methodconstructLboParameterParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfconstructLboParameter = { lboName, lboMethod };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodconstructLboParameter, methodconstructLboParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_doMoreInstanceFixture, parametersOfconstructLboParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfconstructLboParameter.ShouldNotBeNull();
            parametersOfconstructLboParameter.Length.ShouldBe(2);
            methodconstructLboParameterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var lboName = this.CreateType<string>();
            var lboMethod = this.CreateType<string>();
            var methodconstructLboParameterParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfconstructLboParameter = { lboName, lboMethod };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodconstructLboParameter, parametersOfconstructLboParameter, methodconstructLboParameterParametersTypes);

            // Assert
            parametersOfconstructLboParameter.ShouldNotBeNull();
            parametersOfconstructLboParameter.Length.ShouldBe(2);
            methodconstructLboParameterParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var methodconstructLboParameterParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconstructLboParameter, methodconstructLboParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodconstructLboParameterParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var methodconstructLboParameterParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconstructLboParameter, methodconstructLboParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconstructLboParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodconstructLboParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (constructLboParameter) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_constructLboParameter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconstructLboParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodconstructLboParameter, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_executeLbo_Method_Call_Internally(Type[] types)
        {
            var methodexecuteLboParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_executeLbo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;
            object[] parametersOfexecuteLbo = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodexecuteLbo, methodexecuteLboParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfexecuteLbo);
            var result2 = this.GetResultOfMethod<string>(MethodexecuteLbo, parametersOfexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfexecuteLbo.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_executeLbo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;
            object[] parametersOfexecuteLbo = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodexecuteLbo, parametersOfexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            parametersOfexecuteLbo.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_executeLbo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_executeLbo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_executeLbo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            var currentMethodInfo = this.GetMethodInfo(MethodexecuteLbo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_PerformAction_Method_Call_Internally(Type[] types)
        {
            var methodPerformActionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPerformAction, methodPerformActionParametersTypes);
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);

            // Act
            Action executeAction = () => _doMoreInstance.PerformAction();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.PerformAction();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            Type [] methodPerformActionParametersTypes = null;
            object[] parametersOfPerformAction = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPerformAction, methodPerformActionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfPerformAction);
            var result2 = this.GetResultOfMethod<string>(MethodPerformAction, parametersOfPerformAction, methodPerformActionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPerformAction.ShouldBeNull();
            methodPerformActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            Type [] methodPerformActionParametersTypes = null;
            object[] parametersOfPerformAction = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPerformAction, parametersOfPerformAction, methodPerformActionParametersTypes);

            // Assert
            parametersOfPerformAction.ShouldBeNull();
            methodPerformActionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            Type [] methodPerformActionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPerformAction, methodPerformActionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPerformActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            Type [] methodPerformActionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPerformAction, methodPerformActionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPerformActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PerformAction) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PerformAction_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPerformAction);
            var currentMethodInfo = this.GetMethodInfo(MethodPerformAction, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_ToByteArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodToByteArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToByteArray, methodToByteArrayParametersTypes);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => DoMore.ToByteArray(value);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var value = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = DoMore.ToByteArray(value);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[])  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var value = this.CreateType<string>();
            var methodToByteArrayParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToByteArray = { value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToByteArray, methodToByteArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodToByteArray, methodToByteArrayParametersTypes);
            var result2 = this.GetResultOfMethod<byte[]>(MethodToByteArray, parametersOfToByteArray, methodToByteArrayParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToByteArray.ShouldNotBeNull();
            parametersOfToByteArray.Length.ShouldBe(1);
            methodToByteArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<byte[]>(MethodToByteArray, parametersOfToByteArray, methodToByteArrayParametersTypes));
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var value = this.CreateType<string>();
            var methodToByteArrayParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToByteArray = { value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToByteArray, methodToByteArrayParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_doMoreInstanceFixture, parametersOfToByteArray);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToByteArray.ShouldNotBeNull();
            parametersOfToByteArray.Length.ShouldBe(1);
            methodToByteArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var value = this.CreateType<string>();
            var methodToByteArrayParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfToByteArray = { value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodToByteArray, parametersOfToByteArray, methodToByteArrayParametersTypes);

            // Assert
            parametersOfToByteArray.ShouldNotBeNull();
            parametersOfToByteArray.Length.ShouldBe(1);
            methodToByteArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var methodToByteArrayParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToByteArray, methodToByteArrayParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToByteArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var methodToByteArrayParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToByteArray, methodToByteArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToByteArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var currentMethodInfo = this.GetMethodInfo(MethodToByteArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToByteArray) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ToByteArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToByteArray);
            var currentMethodInfo = this.GetMethodInfo(MethodToByteArray, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_SaveByteArrayAsImage_Method_Call_Internally(Type[] types)
        {
            var methodSaveByteArrayAsImageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveByteArrayAsImage, methodSaveByteArrayAsImageParametersTypes);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SaveByteArrayAsImage_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveByteArrayAsImage);
            var fullOutputPath = this.CreateType<string>();
            var base64String = this.CreateType<string>();
            var methodSaveByteArrayAsImageParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSaveByteArrayAsImage = { fullOutputPath, base64String };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveByteArrayAsImage, methodSaveByteArrayAsImageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_doMoreInstanceFixture, parametersOfSaveByteArrayAsImage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSaveByteArrayAsImage.ShouldNotBeNull();
            parametersOfSaveByteArrayAsImage.Length.ShouldBe(2);
            methodSaveByteArrayAsImageParametersTypes.Length.ShouldBe(2);
            methodSaveByteArrayAsImageParametersTypes.Length.ShouldBe(parametersOfSaveByteArrayAsImage.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SaveByteArrayAsImage_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveByteArrayAsImage);
            var fullOutputPath = this.CreateType<string>();
            var base64String = this.CreateType<string>();
            var methodSaveByteArrayAsImageParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSaveByteArrayAsImage = { fullOutputPath, base64String };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSaveByteArrayAsImage, parametersOfSaveByteArrayAsImage, methodSaveByteArrayAsImageParametersTypes);

            // Assert
            parametersOfSaveByteArrayAsImage.ShouldNotBeNull();
            parametersOfSaveByteArrayAsImage.Length.ShouldBe(2);
            methodSaveByteArrayAsImageParametersTypes.Length.ShouldBe(2);
            methodSaveByteArrayAsImageParametersTypes.Length.ShouldBe(parametersOfSaveByteArrayAsImage.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SaveByteArrayAsImage_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveByteArrayAsImage);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveByteArrayAsImage, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SaveByteArrayAsImage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveByteArrayAsImage);
            var methodSaveByteArrayAsImageParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveByteArrayAsImage, methodSaveByteArrayAsImageParametersTypes);

            // Assert
            methodSaveByteArrayAsImageParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveByteArrayAsImage) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SaveByteArrayAsImage_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveByteArrayAsImage);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveByteArrayAsImage, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_Base64ToImage_Method_Call_Internally(Type[] types)
        {
            var methodBase64ToImageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBase64ToImage, methodBase64ToImageParametersTypes);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var base64String = this.CreateType<string>();

            // Act
            Action executeAction = () => _doMoreInstance.Base64ToImage(base64String);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var base64String = this.CreateType<string>();
            var methodBase64ToImageParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64ToImage = { base64String };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBase64ToImage, methodBase64ToImageParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<System.Drawing.Image>(_doMoreInstanceFixture, parametersOfBase64ToImage);
            var result2 = this.GetResultOfMethod<System.Drawing.Image>(MethodBase64ToImage, parametersOfBase64ToImage, methodBase64ToImageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBase64ToImage.ShouldNotBeNull();
            parametersOfBase64ToImage.Length.ShouldBe(1);
            methodBase64ToImageParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var base64String = this.CreateType<string>();
            var methodBase64ToImageParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64ToImage = { base64String };

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Drawing.Image>(MethodBase64ToImage, parametersOfBase64ToImage, methodBase64ToImageParametersTypes);

            // Assert
            parametersOfBase64ToImage.ShouldNotBeNull();
            parametersOfBase64ToImage.Length.ShouldBe(1);
            methodBase64ToImageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var methodBase64ToImageParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBase64ToImage, methodBase64ToImageParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBase64ToImageParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var methodBase64ToImageParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBase64ToImage, methodBase64ToImageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBase64ToImageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64ToImage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Base64ToImage) (Return Type : System.Drawing.Image) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_Base64ToImage_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64ToImage);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64ToImage, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_ByteArrayToString_Method_Call_Internally(Type[] types)
        {
            var methodByteArrayToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodByteArrayToString, methodByteArrayToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var bytes = this.CreateType<byte[]>();
            var methodByteArrayToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfByteArrayToString = { bytes };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodByteArrayToString, methodByteArrayToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, out exception1, parametersOfByteArrayToString);
            var result2 = this.GetResultOfMethod<string>(MethodByteArrayToString, parametersOfByteArrayToString, methodByteArrayToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfByteArrayToString.ShouldNotBeNull();
            parametersOfByteArrayToString.Length.ShouldBe(1);
            methodByteArrayToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var bytes = this.CreateType<byte[]>();
            var methodByteArrayToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfByteArrayToString = { bytes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodByteArrayToString, methodByteArrayToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_doMoreInstanceFixture, parametersOfByteArrayToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfByteArrayToString.ShouldNotBeNull();
            parametersOfByteArrayToString.Length.ShouldBe(1);
            methodByteArrayToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var bytes = this.CreateType<byte[]>();
            var methodByteArrayToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfByteArrayToString = { bytes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodByteArrayToString, parametersOfByteArrayToString, methodByteArrayToStringParametersTypes);

            // Assert
            parametersOfByteArrayToString.ShouldNotBeNull();
            parametersOfByteArrayToString.Length.ShouldBe(1);
            methodByteArrayToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var methodByteArrayToStringParametersTypes = new Type[] { typeof(byte[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodByteArrayToString, methodByteArrayToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodByteArrayToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var methodByteArrayToStringParametersTypes = new Type[] { typeof(byte[]) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodByteArrayToString, methodByteArrayToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodByteArrayToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var currentMethodInfo = this.GetMethodInfo(MethodByteArrayToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ByteArrayToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_ByteArrayToString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodByteArrayToString);
            var currentMethodInfo = this.GetMethodInfo(MethodByteArrayToString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_PromptRetrieve_Method_Call_Internally(Type[] types)
        {
            var methodPromptRetrieveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPromptRetrieve, methodPromptRetrieveParametersTypes);
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);

            // Act
            Action executeAction = () => _doMoreInstance.PromptRetrieve();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.PromptRetrieve();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            Type [] methodPromptRetrieveParametersTypes = null;
            object[] parametersOfPromptRetrieve = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPromptRetrieve, methodPromptRetrieveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfPromptRetrieve);
            var result2 = this.GetResultOfMethod<string>(MethodPromptRetrieve, parametersOfPromptRetrieve, methodPromptRetrieveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPromptRetrieve.ShouldBeNull();
            methodPromptRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            Type [] methodPromptRetrieveParametersTypes = null;
            object[] parametersOfPromptRetrieve = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPromptRetrieve, parametersOfPromptRetrieve, methodPromptRetrieveParametersTypes);

            // Assert
            parametersOfPromptRetrieve.ShouldBeNull();
            methodPromptRetrieveParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            Type [] methodPromptRetrieveParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPromptRetrieve, methodPromptRetrieveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPromptRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            Type [] methodPromptRetrieveParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPromptRetrieve, methodPromptRetrieveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPromptRetrieveParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptRetrieve) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptRetrieve_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptRetrieve);
            var currentMethodInfo = this.GetMethodInfo(MethodPromptRetrieve, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_RetrieveBySecondaryId_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveBySecondaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);

            // Act
            Action executeAction = () => _doMoreInstance.RetrieveBySecondaryId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.RetrieveBySecondaryId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            Type [] methodRetrieveBySecondaryIdParametersTypes = null;
            object[] parametersOfRetrieveBySecondaryId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfRetrieveBySecondaryId);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveBySecondaryId, parametersOfRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveBySecondaryId.ShouldBeNull();
            methodRetrieveBySecondaryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            Type [] methodRetrieveBySecondaryIdParametersTypes = null;
            object[] parametersOfRetrieveBySecondaryId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveBySecondaryId, parametersOfRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes);

            // Assert
            parametersOfRetrieveBySecondaryId.ShouldBeNull();
            methodRetrieveBySecondaryIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            Type [] methodRetrieveBySecondaryIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveBySecondaryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            Type [] methodRetrieveBySecondaryIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveBySecondaryId, methodRetrieveBySecondaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveBySecondaryIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveBySecondaryId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_RetrieveBySecondaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveBySecondaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveBySecondaryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_SetLboParamXml_Method_Call_Internally(Type[] types)
        {
            var methodSetLboParamXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetLboParamXml, methodSetLboParamXmlParametersTypes);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SetLboParamXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);

            // Act
            Action executeAction = () => _doMoreInstance.SetLboParamXml();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SetLboParamXml_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            Type [] methodSetLboParamXmlParametersTypes = null;
            object[] parametersOfSetLboParamXml = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetLboParamXml, methodSetLboParamXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_doMoreInstanceFixture, parametersOfSetLboParamXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetLboParamXml.ShouldBeNull();
            methodSetLboParamXmlParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SetLboParamXml_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            Type [] methodSetLboParamXmlParametersTypes = null;
            object[] parametersOfSetLboParamXml = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetLboParamXml, parametersOfSetLboParamXml, methodSetLboParamXmlParametersTypes);

            // Assert
            parametersOfSetLboParamXml.ShouldBeNull();
            methodSetLboParamXmlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SetLboParamXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            Type [] methodSetLboParamXmlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetLboParamXml, methodSetLboParamXmlParametersTypes);

            // Assert
            methodSetLboParamXmlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_SetLboParamXml_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLboParamXml, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DoMore_PromptExecuteLBO_Method_Call_Internally(Type[] types)
        {
            var methodPromptExecuteLBOParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPromptExecuteLBO, methodPromptExecuteLBOParametersTypes);
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);

            // Act
            Action executeAction = () => _doMoreInstance.PromptExecuteLBO();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _doMoreInstance.PromptExecuteLBO();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            Type [] methodPromptExecuteLBOParametersTypes = null;
            object[] parametersOfPromptExecuteLBO = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPromptExecuteLBO, methodPromptExecuteLBOParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_doMoreInstanceFixture, parametersOfPromptExecuteLBO);
            var result2 = this.GetResultOfMethod<string>(MethodPromptExecuteLBO, parametersOfPromptExecuteLBO, methodPromptExecuteLBOParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPromptExecuteLBO.ShouldBeNull();
            methodPromptExecuteLBOParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            Type [] methodPromptExecuteLBOParametersTypes = null;
            object[] parametersOfPromptExecuteLBO = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPromptExecuteLBO, parametersOfPromptExecuteLBO, methodPromptExecuteLBOParametersTypes);

            // Assert
            parametersOfPromptExecuteLBO.ShouldBeNull();
            methodPromptExecuteLBOParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            Type [] methodPromptExecuteLBOParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPromptExecuteLBO, methodPromptExecuteLBOParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPromptExecuteLBOParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            Type [] methodPromptExecuteLBOParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPromptExecuteLBO, methodPromptExecuteLBOParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPromptExecuteLBOParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PromptExecuteLBO) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DoMore_PromptExecuteLBO_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPromptExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodPromptExecuteLBO, 0);

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