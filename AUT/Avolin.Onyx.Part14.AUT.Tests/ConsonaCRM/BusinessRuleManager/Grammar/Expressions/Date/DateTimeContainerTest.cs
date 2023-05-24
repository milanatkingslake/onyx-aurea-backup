using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date.DateTimeContainer" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DateTimeContainerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DateTimeContainer" />)
        /// </summary>
        public DateTimeContainerTest() : base(typeof(DateTimeContainer))
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

        #region General Initializer : Class (DateTimeContainer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dateTimeContainerInstanceType;
        private DateTimeContainer _dateTimeContainerInstance;
        private DateTimeContainer _dateTimeContainerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DateTimeContainer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dateTimeContainerInstanceType = typeof(DateTimeContainer);
            _dateTimeContainerInstanceFixture = this.Create<DateTimeContainer>(false);
            _dateTimeContainerInstance = _dateTimeContainerInstanceFixture ?? this.Create<DateTimeContainer>(true);
            CurrentInstance = _dateTimeContainerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DateTimeContainer) Initializer

        #region Methods

        private const string MethodEvaluateDateTime = "EvaluateDateTime";

        #endregion

        #endregion

        #region General Initializer : Class (DateTimeContainer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DateTimeContainer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DateTimeContainer)

        #region General Initializer : Class (DateTimeContainer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateDateTime, 0)]
        [TestCase(MethodEvaluateDateTime, 1)]
        public void AUT_DateTimeContainer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DateTimeContainer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateTimeContainer_Is_Instance_Present_Test()
        {
            // Assert
            _dateTimeContainerInstanceType.ShouldNotBeNull();
            _dateTimeContainerInstance.ShouldNotBeNull();
            _dateTimeContainerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DateTimeContainer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateTimeContainer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dateTimeContainerInstance.ShouldBeAssignableTo<DateTimeContainer>();
            _dateTimeContainerInstanceFixture.ShouldBeAssignableTo<DateTimeContainer>();
            CurrentInstance.ShouldBeAssignableTo<DateTimeContainer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DateTimeContainer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DateTimeContainer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            DateTimeContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DateTimeContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dateTimeContainerInstance.ShouldNotBeNull();
            _dateTimeContainerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<DateTimeContainer>();
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            DateTimeContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new DateTimeContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _dateTimeContainerInstance.ShouldNotBeNull();
            _dateTimeContainerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) instance created

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Is_Created_Test()
        {
            // Assert
            _dateTimeContainerInstance.ShouldNotBeNull();
            _dateTimeContainerInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="DateTimeContainer" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_DateTimeContainer_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DateTimeContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DateTimeContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodDateTimeContainerParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDateTimeContainerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (DateTimeContainer) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="DateTimeContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateTimeContainer_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodDateTimeContainerParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodDateTimeContainerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _dateTimeContainerInstance.EvaluateDateTime(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = _dateTimeContainerInstance.EvaluateDateTime(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DateTime>(_dateTimeContainerInstanceFixture, out exception1, parametersOfEvaluateDateTime);
            var result2 = this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dateTimeContainerInstanceFixture, parametersOfEvaluateDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEvaluateDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => DateTimeContainer.EvaluateDateTime(pMetadataNode, pEngine, pDataNode, pNamespaceManager);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = DateTimeContainer.EvaluateDateTime(pMetadataNode, pEngine, pDataNode, pNamespaceManager);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateDateTime = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);
            var result2 = this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(4);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes));
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateDateTime = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dateTimeContainerInstanceFixture, parametersOfEvaluateDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(4);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateDateTime = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(4);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DateTimeContainer_EvaluateDateTime_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 1);
            const int parametersCount = 4;

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