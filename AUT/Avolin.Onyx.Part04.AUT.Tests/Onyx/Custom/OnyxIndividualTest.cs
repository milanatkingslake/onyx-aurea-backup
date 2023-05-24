using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxIndividual" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxIndividualTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxIndividual" />)
        /// </summary>
        public OnyxIndividualTest() : base(typeof(OnyxIndividual))
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

        #region General Initializer : Class (OnyxIndividual) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxIndividualInstanceType;
        private OnyxIndividual _onyxIndividualInstance;
        private OnyxIndividual _onyxIndividualInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxIndividual" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxIndividualInstanceType = typeof(OnyxIndividual);
            _onyxIndividualInstanceFixture = this.Create<OnyxIndividual>(false);
            _onyxIndividualInstance = _onyxIndividualInstanceFixture ?? this.Create<OnyxIndividual>(true);
            CurrentInstance = _onyxIndividualInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxIndividual) Initializer

        #region Properties

        private const string PropertyHeading = "Heading";
        private const string PropertyCustomerName = "CustomerName";
        private const string PropertyPrimaryEmailAddress = "PrimaryEmailAddress";
        private const string PropertyPrimaryPhoneNumber = "PrimaryPhoneNumber";
        private const string PropertyPrimaryCountry = "PrimaryCountry";
        private const string PropertyObjectType = "ObjectType";
        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyFirstName = "FirstName";
        private const string PropertyLastName = "LastName";
        private const string PropertyCompanyName = "CompanyName";
        private const string PropertyTimestamp = "Timestamp";
        private const string PropertyIndividualNodeNoCollections = "IndividualNodeNoCollections";
        private const string PropertyIndividualRetrieveXmlNode = "IndividualRetrieveXmlNode";
        private const string PropertyPhones = "Phones";
        private const string PropertyAddresses = "Addresses";
        private const string PropertyEmailAddresses = "EmailAddresses";

        #endregion

        #region Methods

        private const string MethodInitializeWithObjectXML = "InitializeWithObjectXML";
        private const string MethodlogObjectDetails = "logObjectDetails";
        private const string MethodRetrieveFromOnyx = "RetrieveFromOnyx";
        private const string MethodupdateInOnyx = "updateInOnyx";
        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodCreateIndividual = "CreateIndividual";

        #endregion

        #region Fields

        private const string FieldFname = "Fname";
        private const string FieldLname = "Lname";
        private const string FieldTimeStamp = "TimeStamp";
        private const string FieldIndNode = "IndNode";
        private const string FieldPrimaryPhone = "PrimaryPhone";
        private const string FieldPrimaryEmail = "PrimaryEmail";
        private const string FieldcompanyName = "companyName";
        private const string FieldIndRetXml = "IndRetXml";
        private const string FieldCollArr = "CollArr";
        private const string FieldCollectionsDict = "CollectionsDict";
        private const string FieldoSession = "oSession";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxIndividual) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIndividual_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxIndividual) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIndividual_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxIndividual) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIndividual_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxIndividual)

        #region General Initializer : Class (OnyxIndividual) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeWithObjectXML, 0)]
        [TestCase(MethodlogObjectDetails, 0)]
        [TestCase(MethodRetrieveFromOnyx, 0)]
        [TestCase(MethodupdateInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodCreateIndividual, 0)]
        public void AUT_OnyxIndividual_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxIndividual) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyCustomerName)]
        [TestCase(PropertyPrimaryEmailAddress)]
        [TestCase(PropertyPrimaryPhoneNumber)]
        [TestCase(PropertyPrimaryCountry)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyFirstName)]
        [TestCase(PropertyLastName)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyIndividualNodeNoCollections)]
        [TestCase(PropertyIndividualRetrieveXmlNode)]
        [TestCase(PropertyPhones)]
        [TestCase(PropertyAddresses)]
        [TestCase(PropertyEmailAddresses)]
        [Category("AUT Property")]
        public void AUT_OnyxIndividual_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxIndividual) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldFname)]
        [TestCase(FieldLname)]
        [TestCase(FieldTimeStamp)]
        [TestCase(FieldIndNode)]
        [TestCase(FieldPrimaryPhone)]
        [TestCase(FieldPrimaryEmail)]
        [TestCase(FieldcompanyName)]
        [TestCase(FieldIndRetXml)]
        [TestCase(FieldCollArr)]
        [TestCase(FieldCollectionsDict)]
        [TestCase(FieldoSession)]
        [Category("AUT Fields")]
        public void AUT_OnyxIndividual_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxIndividual) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxIndividual_Is_Instance_Present_Test()
        {
            // Assert
            _onyxIndividualInstanceType.ShouldNotBeNull();
            _onyxIndividualInstance.ShouldNotBeNull();
            _onyxIndividualInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxIndividual) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxIndividual_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxIndividualInstance.ShouldBeAssignableTo<OnyxIndividual>();
            _onyxIndividualInstanceFixture.ShouldBeAssignableTo<OnyxIndividual>();
            CurrentInstance.ShouldBeAssignableTo<OnyxIndividual>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxIndividual) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxIndividual instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxIndividual(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxIndividualInstance.ShouldNotBeNull();
            _onyxIndividualInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxIndividual>();
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxIndividual instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxIndividual(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxIndividualInstance.ShouldNotBeNull();
            _onyxIndividualInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) instance created

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Is_Created_Test()
        {
            // Assert
            _onyxIndividualInstance.ShouldNotBeNull();
            _onyxIndividualInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxIndividual" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_OnyxIndividual_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxIndividual) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxIndividual" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIndividual" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIndividualParametersTypes = new Type[] { typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIndividualParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIndividual" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIndividualParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIndividualParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxIndividual) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIndividual" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIndividual_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIndividualParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIndividualParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxIndividual) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyCustomerName)]
        [TestCase(PropertyPrimaryEmailAddress)]
        [TestCase(PropertyPrimaryPhoneNumber)]
        [TestCase(PropertyPrimaryCountry)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyFirstName)]
        [TestCase(PropertyLastName)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyIndividualNodeNoCollections)]
        [TestCase(PropertyIndividualRetrieveXmlNode)]
        [TestCase(PropertyPhones)]
        [TestCase(PropertyAddresses)]
        [TestCase(PropertyEmailAddresses)]
        public void AUT_OnyxIndividual_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Addresses) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Addresses_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAddresses);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAddresses);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Addresses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_Addresses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAddresses);
            var propertyInfo = this.GetPropertyInfo(PropertyAddresses);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (CompanyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_CompanyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCompanyName);
            var propertyInfo = this.GetPropertyInfo(PropertyCompanyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (CustomerName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_CustomerName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomerName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomerName);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (CustomerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_CustomerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomerName);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomerName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (EmailAddresses) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_EmailAddresses_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEmailAddresses);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEmailAddresses);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (EmailAddresses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_EmailAddresses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEmailAddresses);
            var propertyInfo = this.GetPropertyInfo(PropertyEmailAddresses);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (FirstName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_FirstName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFirstName);
            var propertyInfo = this.GetPropertyInfo(PropertyFirstName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIndividual) => Property (IndividualNodeNoCollections) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_IndividualNodeNoCollections_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIndividualNodeNoCollections);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyIndividualNodeNoCollections);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (IndividualNodeNoCollections) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_IndividualNodeNoCollections_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIndividualNodeNoCollections);
            var propertyInfo = this.GetPropertyInfo(PropertyIndividualNodeNoCollections);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (IndividualRetrieveXmlNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_IndividualRetrieveXmlNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIndividualRetrieveXmlNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyIndividualRetrieveXmlNode);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (IndividualRetrieveXmlNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_IndividualRetrieveXmlNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIndividualRetrieveXmlNode);
            var propertyInfo = this.GetPropertyInfo(PropertyIndividualRetrieveXmlNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (LastName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_LastName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastName);
            var propertyInfo = this.GetPropertyInfo(PropertyLastName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Phones) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Phones_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPhones);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPhones);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Phones) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_Phones_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPhones);
            var propertyInfo = this.GetPropertyInfo(PropertyPhones);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryCountry) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_PrimaryCountry_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryCountry);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryCountry);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryCountry) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_PrimaryCountry_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryCountry);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryCountry);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryEmailAddress) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_PrimaryEmailAddress_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryEmailAddress);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryEmailAddress);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryPhoneNumber) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_PrimaryPhoneNumber_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryPhoneNumber);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryPhoneNumber);
            Action currentAction = () => propertyInfo.SetValue(_onyxIndividualInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (PrimaryPhoneNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_PrimaryPhoneNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryPhoneNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryPhoneNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIndividual) => Property (Timestamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIndividual_Public_Class_Timestamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTimestamp);
            var propertyInfo = this.GetPropertyInfo(PropertyTimestamp);

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

        #region Method Call : (InitializeWithObjectXML) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InitializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeWithObjectXML);
            var indNode = this.CreateType<XmlNode>();
            var methodInitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfInitializeWithObjectXML = { indNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeWithObjectXML, methodInitializeWithObjectXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIndividualInstanceFixture, parametersOfInitializeWithObjectXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInitializeWithObjectXML.ShouldNotBeNull();
            parametersOfInitializeWithObjectXML.Length.ShouldBe(1);
            methodInitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            methodInitializeWithObjectXMLParametersTypes.Length.ShouldBe(parametersOfInitializeWithObjectXML.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InitializeWithObjectXML) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InitializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeWithObjectXML);
            var indNode = this.CreateType<XmlNode>();
            var methodInitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfInitializeWithObjectXML = { indNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInitializeWithObjectXML, parametersOfInitializeWithObjectXML, methodInitializeWithObjectXMLParametersTypes);

            // Assert
            parametersOfInitializeWithObjectXML.ShouldNotBeNull();
            parametersOfInitializeWithObjectXML.Length.ShouldBe(1);
            methodInitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            methodInitializeWithObjectXMLParametersTypes.Length.ShouldBe(parametersOfInitializeWithObjectXML.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeWithObjectXML) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InitializeWithObjectXML_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeWithObjectXML);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeWithObjectXML, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InitializeWithObjectXML) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InitializeWithObjectXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeWithObjectXML);
            var methodInitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInitializeWithObjectXML, methodInitializeWithObjectXMLParametersTypes);

            // Assert
            methodInitializeWithObjectXMLParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InitializeWithObjectXML) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InitializeWithObjectXML_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInitializeWithObjectXML);
            var currentMethodInfo = this.GetMethodInfo(MethodInitializeWithObjectXML, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIndividual_logObjectDetails_Method_Call_Internally(Type[] types)
        {
            var methodlogObjectDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlogObjectDetails, methodlogObjectDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_logObjectDetails_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogObjectDetails);

            // Act
            Action executeAction = () => _onyxIndividualInstance.logObjectDetails();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_logObjectDetails_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogObjectDetails);
            Type [] methodlogObjectDetailsParametersTypes = null;
            object[] parametersOflogObjectDetails = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodlogObjectDetails, methodlogObjectDetailsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIndividualInstanceFixture, parametersOflogObjectDetails);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOflogObjectDetails.ShouldBeNull();
            methodlogObjectDetailsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_logObjectDetails_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogObjectDetails);
            Type [] methodlogObjectDetailsParametersTypes = null;
            object[] parametersOflogObjectDetails = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodlogObjectDetails, parametersOflogObjectDetails, methodlogObjectDetailsParametersTypes);

            // Assert
            parametersOflogObjectDetails.ShouldBeNull();
            methodlogObjectDetailsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_logObjectDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogObjectDetails);
            Type [] methodlogObjectDetailsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlogObjectDetails, methodlogObjectDetailsParametersTypes);

            // Assert
            methodlogObjectDetailsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logObjectDetails) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_logObjectDetails_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogObjectDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodlogObjectDetails, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);

            // Act
            Action executeAction = () => _onyxIndividualInstance.RetrieveFromOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxIndividualInstance.RetrieveFromOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;
            object[] parametersOfRetrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxIndividualInstanceFixture, parametersOfRetrieveFromOnyx);
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
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxIndividual_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (updateInOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIndividual_updateInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodupdateInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodupdateInOnyx, methodupdateInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxIndividualInstance.updateInOnyx(sParameters, addNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodupdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfupdateInOnyx = { sParameters, addNodes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodupdateInOnyx, methodupdateInOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIndividualInstanceFixture, parametersOfupdateInOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfupdateInOnyx.ShouldNotBeNull();
            parametersOfupdateInOnyx.Length.ShouldBe(2);
            methodupdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodupdateInOnyxParametersTypes.Length.ShouldBe(parametersOfupdateInOnyx.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodupdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfupdateInOnyx = { sParameters, addNodes };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodupdateInOnyx, parametersOfupdateInOnyx, methodupdateInOnyxParametersTypes);

            // Assert
            parametersOfupdateInOnyx.ShouldNotBeNull();
            parametersOfupdateInOnyx.Length.ShouldBe(2);
            methodupdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodupdateInOnyxParametersTypes.Length.ShouldBe(parametersOfupdateInOnyx.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateInOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var methodupdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodupdateInOnyx, methodupdateInOnyxParametersTypes);

            // Assert
            methodupdateInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (updateInOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_updateInOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodupdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodupdateInOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIndividual_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxIndividualInstance.InsertInOnyx(sParameters, collectionNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var returnedValue = default(OnyxIndividual);

            // Act
            Action executeAction = () => returnedValue = _onyxIndividualInstance.InsertInOnyx(sParameters, collectionNodes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfInsertInOnyx = { sParameters, collectionNodes };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, methodInsertInOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxIndividual>(_onyxIndividualInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OnyxIndividual>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(2);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfInsertInOnyx = { sParameters, collectionNodes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxIndividual>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(2);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIndividual) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_InsertInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertInOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateIndividualParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateIndividual, methodCreateIndividualParametersTypes);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var individual = this.CreateType<XElement>();
            var oSession = this.CreateType<OnyxSession>();

            // Act
            Action executeAction = () => OnyxIndividual.CreateIndividual(individual, oSession);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var individual = this.CreateType<XElement>();
            var oSession = this.CreateType<OnyxSession>();
            var returnedValue = default(OnyxIndividual);

            // Act
            Action executeAction = () => returnedValue = OnyxIndividual.CreateIndividual(individual, oSession);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var individual = this.CreateType<XElement>();
            var oSession = this.CreateType<OnyxSession>();
            var methodCreateIndividualParametersTypes = new Type[] { typeof(XElement), typeof(OnyxSession) };
            object[] parametersOfCreateIndividual = { individual, oSession };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIndividual, methodCreateIndividualParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateIndividual, methodCreateIndividualParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxIndividual>(MethodCreateIndividual, parametersOfCreateIndividual, methodCreateIndividualParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIndividualInstanceFixture, parametersOfCreateIndividual);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateIndividual.ShouldNotBeNull();
            parametersOfCreateIndividual.Length.ShouldBe(2);
            methodCreateIndividualParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var individual = this.CreateType<XElement>();
            var oSession = this.CreateType<OnyxSession>();
            var methodCreateIndividualParametersTypes = new Type[] { typeof(XElement), typeof(OnyxSession) };
            object[] parametersOfCreateIndividual = { individual, oSession };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxIndividual>(MethodCreateIndividual, parametersOfCreateIndividual, methodCreateIndividualParametersTypes);

            // Assert
            parametersOfCreateIndividual.ShouldNotBeNull();
            parametersOfCreateIndividual.Length.ShouldBe(2);
            methodCreateIndividualParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var methodCreateIndividualParametersTypes = new Type[] { typeof(XElement), typeof(OnyxSession) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateIndividual, methodCreateIndividualParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateIndividualParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var methodCreateIndividualParametersTypes = new Type[] { typeof(XElement), typeof(OnyxSession) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateIndividual, methodCreateIndividualParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateIndividualParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIndividual, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateIndividual) (Return Type : OnyxIndividual) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIndividual_CreateIndividual_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIndividual, 0);
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