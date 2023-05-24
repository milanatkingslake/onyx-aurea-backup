using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxUser" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxUserTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxUser" />)
        /// </summary>
        public OnyxUserTest() : base(typeof(OnyxUser))
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

        #region General Initializer : Class (OnyxUser) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxUserInstanceType;
        private OnyxUser _onyxUserInstance;
        private OnyxUser _onyxUserInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxUser" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxUserInstanceType = typeof(OnyxUser);
            _onyxUserInstanceFixture = this.Create<OnyxUser>(false);
            _onyxUserInstance = _onyxUserInstanceFixture ?? this.Create<OnyxUser>(true);
            CurrentInstance = _onyxUserInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxUser) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyHeading = "Heading";
        private const string PropertyUserName = "UserName";
        private const string PropertyUserEmail = "UserEmail";
        private const string PropertyUserRetrieveXmlNode = "UserRetrieveXmlNode";

        #endregion

        #region Methods

        private const string MethodinitializeWithObjectXML = "initializeWithObjectXML";
        private const string MethodRetrieveFromOnyx = "RetrieveFromOnyx";

        #endregion

        #region Fields

        private const string FielduserName = "userName";
        private const string FielduserEmail = "userEmail";
        private const string FielduserRetXml = "userRetXml";
        private const string FieldoSession = "oSession";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxUser) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUser_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUser) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUser_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUser) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUser_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxUser)

        #region General Initializer : Class (OnyxUser) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodinitializeWithObjectXML, 0)]
        [TestCase(MethodRetrieveFromOnyx, 0)]
        public void AUT_OnyxUser_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxUser) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyUserEmail)]
        [TestCase(PropertyUserRetrieveXmlNode)]
        [Category("AUT Property")]
        public void AUT_OnyxUser_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxUser) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FielduserName)]
        [TestCase(FielduserEmail)]
        [TestCase(FielduserRetXml)]
        [TestCase(FieldoSession)]
        [Category("AUT Fields")]
        public void AUT_OnyxUser_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxUser) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUser_Is_Instance_Present_Test()
        {
            // Assert
            _onyxUserInstanceType.ShouldNotBeNull();
            _onyxUserInstance.ShouldNotBeNull();
            _onyxUserInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxUser) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUser_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxUserInstance.ShouldBeAssignableTo<OnyxUser>();
            _onyxUserInstanceFixture.ShouldBeAssignableTo<OnyxUser>();
            CurrentInstance.ShouldBeAssignableTo<OnyxUser>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxUser) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxUser instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxUser(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxUserInstance.ShouldNotBeNull();
            _onyxUserInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxUser>();
        }

        #endregion

        #region General Constructor : Class (OnyxUser) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxUser instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxUser(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxUserInstance.ShouldNotBeNull();
            _onyxUserInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxUser) instance created

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_Is_Created_Test()
        {
            // Assert
            _onyxUserInstance.ShouldNotBeNull();
            _onyxUserInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxUser) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxUser" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_OnyxUser_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxUser) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxUser" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxUser) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxUser" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxUserParametersTypes = new Type[] { typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxUserParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxUser) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxUser" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxUser_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxUserParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxUserParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxUser) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyUserEmail)]
        [TestCase(PropertyUserRetrieveXmlNode)]
        public void AUT_OnyxUser_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxUser) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeading);
            var propertyInfo = this.GetPropertyInfo(PropertyHeading);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxUserInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxUserInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxUser) => Property (UserEmail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_UserEmail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserEmail);
            var propertyInfo = this.GetPropertyInfo(PropertyUserEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (UserName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_UserName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserName);
            var propertyInfo = this.GetPropertyInfo(PropertyUserName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (UserRetrieveXmlNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_UserRetrieveXmlNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserRetrieveXmlNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUserRetrieveXmlNode);
            Action currentAction = () => propertyInfo.SetValue(_onyxUserInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxUser) => Property (UserRetrieveXmlNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxUser_Public_Class_UserRetrieveXmlNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserRetrieveXmlNode);
            var propertyInfo = this.GetPropertyInfo(PropertyUserRetrieveXmlNode);

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

        #region Method Call : (initializeWithObjectXML) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var userNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { userNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitializeWithObjectXML, methodinitializeWithObjectXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxUserInstanceFixture, parametersOfinitializeWithObjectXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfinitializeWithObjectXML.ShouldNotBeNull();
            parametersOfinitializeWithObjectXML.Length.ShouldBe(1);
            methodinitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            methodinitializeWithObjectXMLParametersTypes.Length.ShouldBe(parametersOfinitializeWithObjectXML.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (initializeWithObjectXML) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var userNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { userNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodinitializeWithObjectXML, parametersOfinitializeWithObjectXML, methodinitializeWithObjectXMLParametersTypes);

            // Assert
            parametersOfinitializeWithObjectXML.ShouldNotBeNull();
            parametersOfinitializeWithObjectXML.Length.ShouldBe(1);
            methodinitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            methodinitializeWithObjectXMLParametersTypes.Length.ShouldBe(parametersOfinitializeWithObjectXML.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initializeWithObjectXML) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_initializeWithObjectXML_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var currentMethodInfo = this.GetMethodInfo(MethodinitializeWithObjectXML, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (initializeWithObjectXML) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_initializeWithObjectXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodinitializeWithObjectXML, methodinitializeWithObjectXMLParametersTypes);

            // Assert
            methodinitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (initializeWithObjectXML) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_initializeWithObjectXML_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var currentMethodInfo = this.GetMethodInfo(MethodinitializeWithObjectXML, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);

            // Act
            Action executeAction = () => _onyxUserInstance.RetrieveFromOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxUserInstance.RetrieveFromOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;
            object[] parametersOfRetrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxUserInstanceFixture, parametersOfRetrieveFromOnyx);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodRetrieveFromOnyx, parametersOfRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFromOnyx.ShouldBeNull();
            methodRetrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;
            object[] parametersOfRetrieveFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodRetrieveFromOnyx, parametersOfRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            parametersOfRetrieveFromOnyx.ShouldBeNull();
            methodRetrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUser_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #endregion

        #endregion
    }
}