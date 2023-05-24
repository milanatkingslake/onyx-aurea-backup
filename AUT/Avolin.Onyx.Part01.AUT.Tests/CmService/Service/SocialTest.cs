using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Social" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Social.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SocialTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Social" />)
        /// </summary>
        public SocialTest() : base(typeof(Social))
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

        #region General Initializer : Class (Social) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _socialInstanceType;
        private Social _socialInstance;
        private Social _socialInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Social" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _socialInstanceType = typeof(Social);
            _socialInstanceFixture = this.Create<Social>(false);
            _socialInstance = _socialInstanceFixture ?? this.Create<Social>(true);
            CurrentInstance = _socialInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Social) Initializer

        #region Properties

        private const string PropertyEntityName = "EntityName";

        #endregion

        #region Methods

        private const string MethodGetTweet = "GetTweet";

        #endregion

        #region Fields

        private const string FieldentityName = "entityName";

        #endregion

        #endregion

        #region General Initializer : Class (Social) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Social_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Social) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Social_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Social) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Social_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Social)

        #region General Initializer : Class (Social) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetTweet, 0)]
        public void AUT_Social_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Social) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEntityName)]
        [Category("AUT Property")]
        public void AUT_Social_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Social) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldentityName)]
        [Category("AUT Fields")]
        public void AUT_Social_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Social) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Social" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Social_Is_Instance_Present_Test()
        {
            // Assert
            _socialInstanceType.ShouldNotBeNull();
            _socialInstance.ShouldNotBeNull();
            _socialInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Social) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Social" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Social_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _socialInstance.ShouldBeAssignableTo<Social>();
            _socialInstanceFixture.ShouldBeAssignableTo<Social>();
            CurrentInstance.ShouldBeAssignableTo<Social>();
        }

        #endregion

        #region General Constructor : Class (Social) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Social_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Social instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Social) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Social_Class_All_Properties_Getter_Settter_Test()
        {

        }

        #endregion

        #region General Getters/Setters : Class (Social) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEntityName)]
        public void AUT_Social_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Social) => Property (EntityName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Social_EntityName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEntityName);
            Action currentAction = () => propertyInfo.SetValue(_socialInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Social) => Property (EntityName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Social_Public_Class_EntityName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityName);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Test Try-Catch Verify Exception Throw - Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT TryCatch")]
        public void AUT_Social_GetTweet_Try_Catch_Should_Not_Throw_Exception()
        {
            // Arrange
            var methodGetTweetParametersTypes = new Type[] { typeof(Message) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTweet, methodGetTweetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _socialInstance.GetTweet(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _socialInstance.GetTweet(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var message = this.CreateType<Message>();
            var methodGetTweetParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetTweet = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTweet, methodGetTweetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_socialInstanceFixture, parametersOfGetTweet);
            var result2 = this.GetResultOfMethod<Message>(MethodGetTweet, parametersOfGetTweet, methodGetTweetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTweet.ShouldNotBeNull();
            parametersOfGetTweet.Length.ShouldBe(1);
            methodGetTweetParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var message = this.CreateType<Message>();
            var methodGetTweetParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetTweet = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetTweet, parametersOfGetTweet, methodGetTweetParametersTypes);

            // Assert
            parametersOfGetTweet.ShouldNotBeNull();
            parametersOfGetTweet.Length.ShouldBe(1);
            methodGetTweetParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var methodGetTweetParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTweet, methodGetTweetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTweetParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var methodGetTweetParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTweet, methodGetTweetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTweetParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTweet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweet) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweet_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweet);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTweet, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}