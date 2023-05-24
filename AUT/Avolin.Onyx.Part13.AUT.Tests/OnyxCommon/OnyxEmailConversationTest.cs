using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;
using Exception = System.Exception;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Outlook = Microsoft.Office.Interop.Outlook;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxEmailConversation" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxEmailConversationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxEmailConversation" />)
        /// </summary>
        public OnyxEmailConversationTest() : base(typeof(OnyxEmailConversation))
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

        #region General Initializer : Class (OnyxEmailConversation) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxEmailConversationInstanceType;
        private OnyxEmailConversation _onyxEmailConversationInstance;
        private OnyxEmailConversation _onyxEmailConversationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxEmailConversation" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxEmailConversationInstanceType = typeof(OnyxEmailConversation);
            _onyxEmailConversationInstanceFixture = this.Create<OnyxEmailConversation>(false);
            _onyxEmailConversationInstance = _onyxEmailConversationInstanceFixture ?? this.Create<OnyxEmailConversation>(true);
            CurrentInstance = _onyxEmailConversationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxEmailConversation) Initializer

        #region Properties

        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyTopic = "Topic";
        private const string PropertyExternalConvId = "ExternalConvId";
        private const string PropertySubscriber = "Subscriber";

        #endregion

        #region Methods

        private const string MethodSubscribeToConversation = "SubscribeToConversation";
        private const string MethodRetrieveFromOnyx = "RetrieveFromOnyx";
        private const string MethodSaveInOnyx = "SaveInOnyx";
        private const string MethodDeleteFromOnyx = "DeleteFromOnyx";

        #endregion

        #region Fields

        private const string Fieldtopic = "topic";
        private const string FieldconvId = "convId";
        private const string Fieldsubscriber = "subscriber";
        private const string FieldonyxThreadId = "onyxThreadId";
        private const string FieldprimaryId = "primaryId";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxEmailConversation) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailConversation_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEmailConversation) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailConversation_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEmailConversation) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEmailConversation_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxEmailConversation)

        #region General Initializer : Class (OnyxEmailConversation) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSubscribeToConversation, 0)]
        [TestCase(MethodRetrieveFromOnyx, 0)]
        [TestCase(MethodSaveInOnyx, 0)]
        [TestCase(MethodDeleteFromOnyx, 0)]
        public void AUT_OnyxEmailConversation_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxEmailConversation) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyTopic)]
        [TestCase(PropertyExternalConvId)]
        [TestCase(PropertySubscriber)]
        [Category("AUT Property")]
        public void AUT_OnyxEmailConversation_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxEmailConversation) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldtopic)]
        [TestCase(FieldconvId)]
        [TestCase(Fieldsubscriber)]
        [TestCase(FieldprimaryId)]
        [Category("AUT Fields")]
        public void AUT_OnyxEmailConversation_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxEmailConversation) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxEmailConversation" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEmailConversation_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxEmailConversationInstance.ShouldBeAssignableTo<OnyxEmailConversation>();
            _onyxEmailConversationInstanceFixture.ShouldBeAssignableTo<OnyxEmailConversation>();
            CurrentInstance.ShouldBeAssignableTo<OnyxEmailConversation>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxEmailConversation) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyTopic)]
        [TestCase(PropertyExternalConvId)]
        [TestCase(PropertySubscriber)]
        public void AUT_OnyxEmailConversation_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (ExternalConvId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_Public_Class_ExternalConvId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExternalConvId);
            var propertyInfo = this.GetPropertyInfo(PropertyExternalConvId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (PrimaryId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_PrimaryId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);
            Action currentAction = () => propertyInfo.SetValue(_onyxEmailConversationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxEmailConversationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (Subscriber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_Public_Class_Subscriber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubscriber);
            var propertyInfo = this.GetPropertyInfo(PropertySubscriber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxEmailConversation) => Property (Topic) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxEmailConversation_Public_Class_Topic_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTopic);
            var propertyInfo = this.GetPropertyInfo(PropertyTopic);

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

        #region Method Call : (SubscribeToConversation) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_Internally(Type[] types)
        {
            var methodSubscribeToConversationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSubscribeToConversation, methodSubscribeToConversationParametersTypes);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var outlookMail = this.CreateType<Outlook.MailItem>();
            var addToExistingThread = this.CreateType<bool>();

            // Act
            Action executeAction = () => _onyxEmailConversationInstance.SubscribeToConversation(outlookMail, addToExistingThread);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var outlookMail = this.CreateType<Outlook.MailItem>();
            var addToExistingThread = this.CreateType<bool>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxEmailConversationInstance.SubscribeToConversation(outlookMail, addToExistingThread);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var outlookMail = this.CreateType<Outlook.MailItem>();
            var addToExistingThread = this.CreateType<bool>();
            var methodSubscribeToConversationParametersTypes = new Type[] { typeof(Outlook.MailItem), typeof(bool) };
            object[] parametersOfSubscribeToConversation = { outlookMail, addToExistingThread };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSubscribeToConversation, methodSubscribeToConversationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxEmailConversationInstanceFixture, parametersOfSubscribeToConversation);
            var result2 = this.GetResultOfMethod<String>(MethodSubscribeToConversation, parametersOfSubscribeToConversation, methodSubscribeToConversationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSubscribeToConversation.ShouldNotBeNull();
            parametersOfSubscribeToConversation.Length.ShouldBe(2);
            methodSubscribeToConversationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var outlookMail = this.CreateType<Outlook.MailItem>();
            var addToExistingThread = this.CreateType<bool>();
            var methodSubscribeToConversationParametersTypes = new Type[] { typeof(Outlook.MailItem), typeof(bool) };
            object[] parametersOfSubscribeToConversation = { outlookMail, addToExistingThread };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodSubscribeToConversation, parametersOfSubscribeToConversation, methodSubscribeToConversationParametersTypes);

            // Assert
            parametersOfSubscribeToConversation.ShouldNotBeNull();
            parametersOfSubscribeToConversation.Length.ShouldBe(2);
            methodSubscribeToConversationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var methodSubscribeToConversationParametersTypes = new Type[] { typeof(Outlook.MailItem), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSubscribeToConversation, methodSubscribeToConversationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSubscribeToConversationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var methodSubscribeToConversationParametersTypes = new Type[] { typeof(Outlook.MailItem), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSubscribeToConversation, methodSubscribeToConversationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSubscribeToConversationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var currentMethodInfo = this.GetMethodInfo(MethodSubscribeToConversation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SubscribeToConversation) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SubscribeToConversation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSubscribeToConversation);
            var currentMethodInfo = this.GetMethodInfo(MethodSubscribeToConversation, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var convId = this.CreateType<string>();
            var userId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxEmailConversationInstance.RetrieveFromOnyx(convId, userId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var convId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxEmailConversationInstance.RetrieveFromOnyx(convId, userId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var convId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var methodRetrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfRetrieveFromOnyx = { convId, userId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxEmailConversationInstanceFixture, parametersOfRetrieveFromOnyx);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodRetrieveFromOnyx, parametersOfRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFromOnyx.ShouldNotBeNull();
            parametersOfRetrieveFromOnyx.Length.ShouldBe(2);
            methodRetrieveFromOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var convId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var methodRetrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfRetrieveFromOnyx = { convId, userId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodRetrieveFromOnyx, parametersOfRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            parametersOfRetrieveFromOnyx.ShouldNotBeNull();
            parametersOfRetrieveFromOnyx.Length.ShouldBe(2);
            methodRetrieveFromOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var methodRetrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFromOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var methodRetrieveFromOnyxParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFromOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_RetrieveFromOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailConversation_SaveInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodSaveInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveInOnyx, methodSaveInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SaveInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveInOnyx);

            // Act
            Action executeAction = () => _onyxEmailConversationInstance.SaveInOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SaveInOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveInOnyx);
            Type [] methodSaveInOnyxParametersTypes = null;
            object[] parametersOfSaveInOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveInOnyx, methodSaveInOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEmailConversationInstanceFixture, parametersOfSaveInOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSaveInOnyx.ShouldBeNull();
            methodSaveInOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SaveInOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveInOnyx);
            Type [] methodSaveInOnyxParametersTypes = null;
            object[] parametersOfSaveInOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSaveInOnyx, parametersOfSaveInOnyx, methodSaveInOnyxParametersTypes);

            // Assert
            parametersOfSaveInOnyx.ShouldBeNull();
            methodSaveInOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SaveInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveInOnyx);
            Type [] methodSaveInOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveInOnyx, methodSaveInOnyxParametersTypes);

            // Assert
            methodSaveInOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveInOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_SaveInOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveInOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodDeleteFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteFromOnyx, methodDeleteFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFromOnyx);

            // Act
            Action executeAction = () => _onyxEmailConversationInstance.DeleteFromOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFromOnyx);
            Type [] methodDeleteFromOnyxParametersTypes = null;
            object[] parametersOfDeleteFromOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFromOnyx, methodDeleteFromOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEmailConversationInstanceFixture, parametersOfDeleteFromOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteFromOnyx.ShouldBeNull();
            methodDeleteFromOnyxParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFromOnyx);
            Type [] methodDeleteFromOnyxParametersTypes = null;
            object[] parametersOfDeleteFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteFromOnyx, parametersOfDeleteFromOnyx, methodDeleteFromOnyxParametersTypes);

            // Assert
            parametersOfDeleteFromOnyx.ShouldBeNull();
            methodDeleteFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFromOnyx);
            Type [] methodDeleteFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteFromOnyx, methodDeleteFromOnyxParametersTypes);

            // Assert
            methodDeleteFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFromOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEmailConversation_DeleteFromOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFromOnyx, 0);

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