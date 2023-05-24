using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="JsonWriter" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\JsonWriter.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class JsonWriterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="JsonWriter" />)
        /// </summary>
        public JsonWriterTest() : base(typeof(JsonWriter))
        { }

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

        #region General Initializer : Class (JsonWriter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _jsonWriterInstanceType;
        private JsonWriter _jsonWriterInstance;
        private JsonWriter _jsonWriterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="JsonWriter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _jsonWriterInstanceType = typeof(JsonWriter);
            _jsonWriterInstanceFixture = this.Create<JsonWriter>(false);
            _jsonWriterInstance = _jsonWriterInstanceFixture ?? this.Create<JsonWriter>(true);
            CurrentInstance = _jsonWriterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (JsonWriter) Initializer

        #region Methods

        private const string MethodOnWriteBodyContents = "OnWriteBodyContents";

        #endregion

        #region Fields

        private const string Field_message = "_message";
        private const string Field_rootNode = "_rootNode";

        #endregion

        #endregion

        #region General Initializer : Class (JsonWriter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_JsonWriter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (JsonWriter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_JsonWriter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (JsonWriter)

        #region General Initializer : Class (JsonWriter) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOnWriteBodyContents, 0)]
        public void AUT_JsonWriter_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (JsonWriter) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_message)]
        [TestCase(Field_rootNode)]
        [Category("AUT Fields")]
        public void AUT_JsonWriter_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (JsonWriter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_JsonWriter_Is_Instance_Present_Test()
        {
            // Assert
            _jsonWriterInstanceType.ShouldNotBeNull();
            _jsonWriterInstance.ShouldNotBeNull();
            _jsonWriterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (JsonWriter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="JsonWriter" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_JsonWriter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _jsonWriterInstance.ShouldBeAssignableTo<JsonWriter>();
            _jsonWriterInstanceFixture.ShouldBeAssignableTo<JsonWriter>();
            CurrentInstance.ShouldBeAssignableTo<JsonWriter>();
        }

        #endregion

        #region General Constructor : Class (JsonWriter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_JsonWriter_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var rootNode = this.CreateType<string>();
            JsonWriter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new JsonWriter(message, rootNode);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _jsonWriterInstance.ShouldNotBeNull();
            _jsonWriterInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<JsonWriter>();
        }

        #endregion

        #region General Constructor : Class (JsonWriter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_JsonWriter_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var rootNode = this.CreateType<string>();
            JsonWriter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new JsonWriter(message, rootNode);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _jsonWriterInstance.ShouldNotBeNull();
            _jsonWriterInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region Method Call : (OnWriteBodyContents) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JsonWriter_OnWriteBodyContents_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnWriteBodyContents);
            var writer = this.CreateType<XmlDictionaryWriter>();
            var methodOnWriteBodyContentsParametersTypes = new Type[] { typeof(XmlDictionaryWriter) };
            object[] parametersOfOnWriteBodyContents = { writer };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnWriteBodyContents, methodOnWriteBodyContentsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_jsonWriterInstanceFixture, parametersOfOnWriteBodyContents);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnWriteBodyContents.ShouldNotBeNull();
            parametersOfOnWriteBodyContents.Length.ShouldBe(1);
            methodOnWriteBodyContentsParametersTypes.Length.ShouldBe(1);
            methodOnWriteBodyContentsParametersTypes.Length.ShouldBe(parametersOfOnWriteBodyContents.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnWriteBodyContents) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JsonWriter_OnWriteBodyContents_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnWriteBodyContents);
            var writer = this.CreateType<XmlDictionaryWriter>();
            var methodOnWriteBodyContentsParametersTypes = new Type[] { typeof(XmlDictionaryWriter) };
            object[] parametersOfOnWriteBodyContents = { writer };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnWriteBodyContents, parametersOfOnWriteBodyContents, methodOnWriteBodyContentsParametersTypes);

            // Assert
            parametersOfOnWriteBodyContents.ShouldNotBeNull();
            parametersOfOnWriteBodyContents.Length.ShouldBe(1);
            methodOnWriteBodyContentsParametersTypes.Length.ShouldBe(1);
            methodOnWriteBodyContentsParametersTypes.Length.ShouldBe(parametersOfOnWriteBodyContents.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnWriteBodyContents) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JsonWriter_OnWriteBodyContents_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnWriteBodyContents);
            var currentMethodInfo = this.GetMethodInfo(MethodOnWriteBodyContents, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnWriteBodyContents) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JsonWriter_OnWriteBodyContents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnWriteBodyContents);
            var methodOnWriteBodyContentsParametersTypes = new Type[] { typeof(XmlDictionaryWriter) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnWriteBodyContents, methodOnWriteBodyContentsParametersTypes);

            // Assert
            methodOnWriteBodyContentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnWriteBodyContents) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_JsonWriter_OnWriteBodyContents_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnWriteBodyContents);
            var currentMethodInfo = this.GetMethodInfo(MethodOnWriteBodyContents, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
    }
}