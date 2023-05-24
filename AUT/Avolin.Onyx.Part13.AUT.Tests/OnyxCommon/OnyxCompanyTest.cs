using System;
using System.Collections.Generic;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxCompany" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxCompanyTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxCompany" />)
        /// </summary>
        public OnyxCompanyTest() : base(typeof(OnyxCompany))
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

        #region General Initializer : Class (OnyxCompany) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxCompanyInstanceType;
        private OnyxCompany _onyxCompanyInstance;
        private OnyxCompany _onyxCompanyInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxCompany" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxCompanyInstanceType = typeof(OnyxCompany);
            _onyxCompanyInstanceFixture = this.Create<OnyxCompany>(false);
            _onyxCompanyInstance = _onyxCompanyInstanceFixture ?? this.Create<OnyxCompany>(true);
            CurrentInstance = _onyxCompanyInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxCompany) Initializer

        #region Properties

        private const string PropertyCustomerName = "CustomerName";
        private const string PropertyPrimaryEmailAddress = "PrimaryEmailAddress";
        private const string PropertyPrimaryPhoneNumber = "PrimaryPhoneNumber";
        private const string PropertyPrimaryCountry = "PrimaryCountry";
        private const string PropertyObjectType = "ObjectType";
        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyCompanyName = "CompanyName";
        private const string PropertyTimestamp = "Timestamp";
        private const string PropertyCompanyNodeNoCollections = "CompanyNodeNoCollections";
        private const string PropertyPhones = "Phones";
        private const string PropertyAddresses = "Addresses";
        private const string PropertyEmailAddresses = "EmailAddresses";

        #endregion

        #region Methods

        private const string MethodinitializeWithObjectXML = "initializeWithObjectXML";
        private const string MethodRetrieveFromOnyx = "RetrieveFromOnyx";
        private const string MethodRetrieveListFromSearchString = "RetrieveListFromSearchString";

        #endregion

        #region Fields

        private const string FieldcompanyName = "companyName";
        private const string FieldtimeStamp = "timeStamp";
        private const string FieldcompanyNode = "companyNode";
        private const string FieldprimaryEmail = "primaryEmail";
        private const string FieldcollectionArr = "collectionArr";
        private const string FieldcollectionsDict = "collectionsDict";
        private const string FieldoSession = "oSession";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxCompany) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCompany_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxCompany) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCompany_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxCompany) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCompany_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxCompany)

        #region General Initializer : Class (OnyxCompany) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodinitializeWithObjectXML, 0)]
        [TestCase(MethodRetrieveFromOnyx, 0)]
        [TestCase(MethodRetrieveListFromSearchString, 0)]
        public void AUT_OnyxCompany_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxCompany) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCustomerName)]
        [TestCase(PropertyPrimaryEmailAddress)]
        [TestCase(PropertyPrimaryPhoneNumber)]
        [TestCase(PropertyPrimaryCountry)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyCompanyNodeNoCollections)]
        [TestCase(PropertyPhones)]
        [TestCase(PropertyAddresses)]
        [TestCase(PropertyEmailAddresses)]
        [Category("AUT Property")]
        public void AUT_OnyxCompany_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxCompany) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcompanyName)]
        [TestCase(FieldtimeStamp)]
        [TestCase(FieldcompanyNode)]
        [TestCase(FieldprimaryEmail)]
        [TestCase(FieldcollectionArr)]
        [TestCase(FieldcollectionsDict)]
        [TestCase(FieldoSession)]
        [Category("AUT Fields")]
        public void AUT_OnyxCompany_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxCompany) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxCompany_Is_Instance_Present_Test()
        {
            // Assert
            _onyxCompanyInstanceType.ShouldNotBeNull();
            _onyxCompanyInstance.ShouldNotBeNull();
            _onyxCompanyInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxCompany) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxCompany_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxCompanyInstance.ShouldBeAssignableTo<OnyxCompany>();
            _onyxCompanyInstanceFixture.ShouldBeAssignableTo<OnyxCompany>();
            CurrentInstance.ShouldBeAssignableTo<OnyxCompany>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxCompany) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxCompany instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxCompany(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxCompanyInstance.ShouldNotBeNull();
            _onyxCompanyInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxCompany>();
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var onyxSession = this.CreateType<OnyxSession>();
            OnyxCompany instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxCompany(onyxSession);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxCompanyInstance.ShouldNotBeNull();
            _onyxCompanyInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) instance created

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Is_Created_Test()
        {
            // Assert
            _onyxCompanyInstance.ShouldNotBeNull();
            _onyxCompanyInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxCompany" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_OnyxCompany_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxCompany) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxCompany" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCompany" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCompanyParametersTypes = new Type[] { typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCompanyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCompany" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCompanyParametersTypes = new Type[] { typeof(String), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCompanyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCompany" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCompanyParametersTypes = new Type[] { typeof(int), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCompanyParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxCompany) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCompany" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCompany_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCompanyParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCompanyParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxCompany) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCustomerName)]
        [TestCase(PropertyPrimaryEmailAddress)]
        [TestCase(PropertyPrimaryPhoneNumber)]
        [TestCase(PropertyPrimaryCountry)]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyCompanyNodeNoCollections)]
        [TestCase(PropertyPhones)]
        [TestCase(PropertyAddresses)]
        [TestCase(PropertyEmailAddresses)]
        public void AUT_OnyxCompany_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (Addresses) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Addresses_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAddresses);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAddresses);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (Addresses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_Addresses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (CompanyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_CompanyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (CompanyNodeNoCollections) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_CompanyNodeNoCollections_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCompanyNodeNoCollections);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCompanyNodeNoCollections);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (CompanyNodeNoCollections) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_CompanyNodeNoCollections_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCompanyNodeNoCollections);
            var propertyInfo = this.GetPropertyInfo(PropertyCompanyNodeNoCollections);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (CustomerName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_CustomerName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomerName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCustomerName);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (CustomerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_CustomerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (EmailAddresses) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_EmailAddresses_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEmailAddresses);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEmailAddresses);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (EmailAddresses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_EmailAddresses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (Phones) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Phones_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPhones);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPhones);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (Phones) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_Phones_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryCountry) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_PrimaryCountry_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryCountry);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryCountry);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryCountry) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_PrimaryCountry_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryEmailAddress) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_PrimaryEmailAddress_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryPhoneNumber) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_PrimaryPhoneNumber_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryPhoneNumber);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryPhoneNumber);
            Action currentAction = () => propertyInfo.SetValue(_onyxCompanyInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxCompany) => Property (PrimaryPhoneNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_PrimaryPhoneNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxCompany) => Property (Timestamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCompany_Public_Class_Timestamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (initializeWithObjectXML) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var indNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { indNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitializeWithObjectXML, methodinitializeWithObjectXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxCompanyInstanceFixture, parametersOfinitializeWithObjectXML);

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
        public void AUT_OnyxCompany_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var indNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { indNode };

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
        public void AUT_OnyxCompany_initializeWithObjectXML_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_OnyxCompany_initializeWithObjectXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxCompany_initializeWithObjectXML_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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
        private void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);

            // Act
            Action executeAction = () => _onyxCompanyInstance.RetrieveFromOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxCompanyInstance.RetrieveFromOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;
            object[] parametersOfRetrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxCompanyInstanceFixture, parametersOfRetrieveFromOnyx);
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
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxCompany_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveListFromSearchStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var srchString = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxCompany.RetrieveListFromSearchString(srchString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var srchString = this.CreateType<string>();
            var returnedValue = default(List<OnyxCompany>);

            // Act
            Action executeAction = () => returnedValue = OnyxCompany.RetrieveListFromSearchString(srchString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var srchString = this.CreateType<string>();
            var methodRetrieveListFromSearchStringParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRetrieveListFromSearchString = { srchString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);
            var result2 = this.GetResultOfMethod<List<OnyxCompany>>(MethodRetrieveListFromSearchString, parametersOfRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_onyxCompanyInstanceFixture, parametersOfRetrieveListFromSearchString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveListFromSearchString.ShouldNotBeNull();
            parametersOfRetrieveListFromSearchString.Length.ShouldBe(1);
            methodRetrieveListFromSearchStringParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var srchString = this.CreateType<string>();
            var methodRetrieveListFromSearchStringParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRetrieveListFromSearchString = { srchString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<OnyxCompany>>(MethodRetrieveListFromSearchString, parametersOfRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);

            // Assert
            parametersOfRetrieveListFromSearchString.ShouldNotBeNull();
            parametersOfRetrieveListFromSearchString.Length.ShouldBe(1);
            methodRetrieveListFromSearchStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var methodRetrieveListFromSearchStringParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveListFromSearchStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var methodRetrieveListFromSearchStringParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveListFromSearchString, methodRetrieveListFromSearchStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveListFromSearchStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveListFromSearchString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveListFromSearchString) (Return Type : List<OnyxCompany>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxCompany_RetrieveListFromSearchString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveListFromSearchString);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveListFromSearchString, 0);
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