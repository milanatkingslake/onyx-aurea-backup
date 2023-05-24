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
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxIncident" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxIncidentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxIncident" />)
        /// </summary>
        public OnyxIncidentTest() : base(typeof(OnyxIncident))
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

        #region General Initializer : Class (OnyxIncident) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxIncidentInstanceType;
        private OnyxIncident _onyxIncidentInstance;
        private OnyxIncident _onyxIncidentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxIncident" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxIncidentInstanceType = typeof(OnyxIncident);
            _onyxIncidentInstanceFixture = this.Create<OnyxIncident>(false);
            _onyxIncidentInstance = _onyxIncidentInstanceFixture ?? this.Create<OnyxIncident>(true);
            CurrentInstance = _onyxIncidentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxIncident) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyHeading = "Heading";
        private const string PropertyPrimaryLBO = "PrimaryLBO";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyStatusId = "StatusId";
        private const string PropertyStatusDesc = "StatusDesc";
        private const string PropertySourceId = "SourceId";
        private const string PropertyCategoryId = "CategoryId";
        private const string PropertyOwnerId = "OwnerId";
        private const string PropertyOwnerSecondaryId = "OwnerSecondaryId";
        private const string PropertyOwnerType = "OwnerType";
        private const string PropertyPrimaryContactId = "PrimaryContactId";
        private const string PropertyPrimaryContactType = "PrimaryContactType";
        private const string PropertyProductId = "ProductId";
        private const string PropertyTrackingId = "TrackingId";
        private const string PropertyDescription = "Description";
        private const string PropertyAssignedTo = "AssignedTo";
        private const string PropertyScheduledAppointmentDateTime = "ScheduledAppointmentDateTime";
        private const string PropertyTypeId = "TypeId";
        private const string PropertyTypeDesc = "TypeDesc";
        private const string PropertyPriorityId = "PriorityId";
        private const string PropertyUser1 = "User1";
        private const string PropertyUser2 = "User2";
        private const string PropertyUser3 = "User3";
        private const string PropertyUser4 = "User4";
        private const string PropertyUser5 = "User5";
        private const string PropertyUser6 = "User6";
        private const string PropertyUser7 = "User7";
        private const string PropertyUser8 = "User8";
        private const string PropertyUser9 = "User9";
        private const string PropertyUser10 = "User10";
        private const string PropertyIncidentNode = "IncidentNode";
        private const string PropertyIncidentNodeNoCollections = "IncidentNodeNoCollections";
        private const string PropertyCSIncPrograms = "CSIncPrograms";

        #endregion

        #region Methods

        private const string MethodinitializeWithObjectXML = "initializeWithObjectXML";
        private const string MethodRetrieveFromOnyx = "RetrieveFromOnyx";
        private const string MethodRetrieveAuditLogFromOnyx = "RetrieveAuditLogFromOnyx";
        private const string MethodUpdateInOnyx = "UpdateInOnyx";
        private const string MethodInsertInOnyx = "InsertInOnyx";
        private const string MethodInsertWorkNote = "InsertWorkNote";
        private const string MethodRetrieveWorkNotes = "RetrieveWorkNotes";
        private const string MethodInsertAlert = "InsertAlert";
        private const string MethodCreateIncident = "CreateIncident";
        private const string MethodlogErrorToIntegrationLog = "logErrorToIntegrationLog";

        #endregion

        #region Fields

        private const string FieldstatusId = "statusId";
        private const string FieldpriorityId = "priorityId";
        private const string FieldsourceId = "sourceId";
        private const string FieldcategoryId = "categoryId";
        private const string FieldownerId = "ownerId";
        private const string FieldownerSecondaryId = "ownerSecondaryId";
        private const string FieldownerType = "ownerType";
        private const string FieldprimaryContactId = "primaryContactId";
        private const string FieldprimaryContactType = "primaryContactType";
        private const string FieldproductId = "productId";
        private const string FieldtrackingId = "trackingId";
        private const string Fielddescription = "description";
        private const string FieldassignedTo = "assignedTo";
        private const string FieldtypeId = "typeId";
        private const string FieldscheduledDate = "scheduledDate";
        private const string Fielduser1 = "user1";
        private const string Fielduser2 = "user2";
        private const string Fielduser3 = "user3";
        private const string Fielduser4 = "user4";
        private const string Fielduser5 = "user5";
        private const string Fielduser6 = "user6";
        private const string Fielduser7 = "user7";
        private const string Fielduser8 = "user8";
        private const string Fielduser9 = "user9";
        private const string Fielduser10 = "user10";
        private const string FieldinsertDate = "insertDate";
        private const string FieldincidentNode = "incidentNode";
        private const string FieldcollectionArr = "collectionArr";
        private const string FieldcollectionsDict = "collectionsDict";
        private const string FieldoSession = "oSession";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxIncident) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIncident_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxIncident) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIncident_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxIncident) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxIncident_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxIncident)

        #region General Initializer : Class (OnyxIncident) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodinitializeWithObjectXML, 0)]
        [TestCase(MethodRetrieveFromOnyx, 0)]
        [TestCase(MethodRetrieveAuditLogFromOnyx, 0)]
        [TestCase(MethodUpdateInOnyx, 0)]
        [TestCase(MethodInsertInOnyx, 0)]
        [TestCase(MethodInsertWorkNote, 0)]
        [TestCase(MethodRetrieveWorkNotes, 0)]
        [TestCase(MethodInsertAlert, 0)]
        [TestCase(MethodCreateIncident, 0)]
        [TestCase(MethodlogErrorToIntegrationLog, 0)]
        public void AUT_OnyxIncident_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxIncident) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyStatusId)]
        [TestCase(PropertyStatusDesc)]
        [TestCase(PropertySourceId)]
        [TestCase(PropertyCategoryId)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyPrimaryContactId)]
        [TestCase(PropertyPrimaryContactType)]
        [TestCase(PropertyProductId)]
        [TestCase(PropertyTrackingId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyScheduledAppointmentDateTime)]
        [TestCase(PropertyTypeId)]
        [TestCase(PropertyTypeDesc)]
        [TestCase(PropertyPriorityId)]
        [TestCase(PropertyUser1)]
        [TestCase(PropertyUser2)]
        [TestCase(PropertyUser3)]
        [TestCase(PropertyUser4)]
        [TestCase(PropertyUser5)]
        [TestCase(PropertyUser6)]
        [TestCase(PropertyUser7)]
        [TestCase(PropertyUser8)]
        [TestCase(PropertyUser9)]
        [TestCase(PropertyUser10)]
        [TestCase(PropertyIncidentNode)]
        [TestCase(PropertyIncidentNodeNoCollections)]
        [TestCase(PropertyCSIncPrograms)]
        [Category("AUT Property")]
        public void AUT_OnyxIncident_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxIncident) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldstatusId)]
        [TestCase(FieldpriorityId)]
        [TestCase(FieldsourceId)]
        [TestCase(FieldcategoryId)]
        [TestCase(FieldownerId)]
        [TestCase(FieldownerSecondaryId)]
        [TestCase(FieldownerType)]
        [TestCase(FieldprimaryContactId)]
        [TestCase(FieldprimaryContactType)]
        [TestCase(FieldproductId)]
        [TestCase(FieldtrackingId)]
        [TestCase(Fielddescription)]
        [TestCase(FieldassignedTo)]
        [TestCase(FieldtypeId)]
        [TestCase(FieldscheduledDate)]
        [TestCase(Fielduser1)]
        [TestCase(Fielduser2)]
        [TestCase(Fielduser3)]
        [TestCase(Fielduser4)]
        [TestCase(Fielduser5)]
        [TestCase(Fielduser6)]
        [TestCase(Fielduser7)]
        [TestCase(Fielduser8)]
        [TestCase(Fielduser9)]
        [TestCase(Fielduser10)]
        [TestCase(FieldinsertDate)]
        [TestCase(FieldincidentNode)]
        [TestCase(FieldcollectionArr)]
        [TestCase(FieldcollectionsDict)]
        [TestCase(FieldoSession)]
        [Category("AUT Fields")]
        public void AUT_OnyxIncident_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxIncident) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxIncident" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxIncident_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxIncidentInstance.ShouldBeAssignableTo<OnyxIncident>();
            _onyxIncidentInstanceFixture.ShouldBeAssignableTo<OnyxIncident>();
            CurrentInstance.ShouldBeAssignableTo<OnyxIncident>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxIncident) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxIncident" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIncident_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxIncident) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIncident" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIncident_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIncidentParametersTypes = new Type[] { typeof(int), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIncidentParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxIncident) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIncident" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIncident_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIncidentParametersTypes = new Type[] { typeof(String), typeof(OnyxSession), typeof(bool) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIncidentParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxIncident) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxIncident" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxIncident_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxIncidentParametersTypes = new Type[] { typeof(XmlNode), typeof(OnyxSession) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxIncidentParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxIncident) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyHeading)]
        [TestCase(PropertyPrimaryLBO)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyStatusId)]
        [TestCase(PropertyStatusDesc)]
        [TestCase(PropertySourceId)]
        [TestCase(PropertyCategoryId)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerSecondaryId)]
        [TestCase(PropertyOwnerType)]
        [TestCase(PropertyPrimaryContactId)]
        [TestCase(PropertyPrimaryContactType)]
        [TestCase(PropertyProductId)]
        [TestCase(PropertyTrackingId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyAssignedTo)]
        [TestCase(PropertyScheduledAppointmentDateTime)]
        [TestCase(PropertyTypeId)]
        [TestCase(PropertyTypeDesc)]
        [TestCase(PropertyPriorityId)]
        [TestCase(PropertyUser1)]
        [TestCase(PropertyUser2)]
        [TestCase(PropertyUser3)]
        [TestCase(PropertyUser4)]
        [TestCase(PropertyUser5)]
        [TestCase(PropertyUser6)]
        [TestCase(PropertyUser7)]
        [TestCase(PropertyUser8)]
        [TestCase(PropertyUser9)]
        [TestCase(PropertyUser10)]
        [TestCase(PropertyIncidentNode)]
        [TestCase(PropertyIncidentNodeNoCollections)]
        [TestCase(PropertyCSIncPrograms)]
        public void AUT_OnyxIncident_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxIncident) => Property (AssignedTo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_AssignedTo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssignedTo);
            var propertyInfo = this.GetPropertyInfo(PropertyAssignedTo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (CategoryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_CategoryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCategoryId);
            var propertyInfo = this.GetPropertyInfo(PropertyCategoryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (CSIncPrograms) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_CSIncPrograms_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCSIncPrograms);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCSIncPrograms);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (CSIncPrograms) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_CSIncPrograms_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCSIncPrograms);
            var propertyInfo = this.GetPropertyInfo(PropertyCSIncPrograms);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (Heading) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_Heading_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIncident) => Property (IncidentNode) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_IncidentNode_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncidentNode);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyIncidentNode);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (IncidentNode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_IncidentNode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncidentNode);
            var propertyInfo = this.GetPropertyInfo(PropertyIncidentNode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (IncidentNodeNoCollections) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_IncidentNodeNoCollections_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncidentNodeNoCollections);
            var propertyInfo = this.GetPropertyInfo(PropertyIncidentNodeNoCollections);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (ObjectType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_ObjectType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIncident) => Property (OwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_OwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (OwnerSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_OwnerSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (OwnerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_OwnerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerType);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (PrimaryContactId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_PrimaryContactId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (PrimaryContactType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_PrimaryContactType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactType);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (PrimaryLBO) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_PrimaryLBO_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryLBO);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryLBO);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (PrimaryLBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_PrimaryLBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxIncident) => Property (PriorityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_PriorityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPriorityId);
            var propertyInfo = this.GetPropertyInfo(PropertyPriorityId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (ProductId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_ProductId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProductId);
            var propertyInfo = this.GetPropertyInfo(PropertyProductId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (ScheduledAppointmentDateTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_ScheduledAppointmentDateTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScheduledAppointmentDateTime);
            var propertyInfo = this.GetPropertyInfo(PropertyScheduledAppointmentDateTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (SourceId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_SourceId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySourceId);
            var propertyInfo = this.GetPropertyInfo(PropertySourceId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (StatusDesc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_StatusDesc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusDesc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStatusDesc);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (StatusDesc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_StatusDesc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusDesc);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusDesc);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (StatusId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_StatusId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatusId);
            var propertyInfo = this.GetPropertyInfo(PropertyStatusId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (TrackingId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_TrackingId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTrackingId);
            var propertyInfo = this.GetPropertyInfo(PropertyTrackingId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (TypeDesc) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_TypeDesc_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeDesc);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTypeDesc);
            Action currentAction = () => propertyInfo.SetValue(_onyxIncidentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (TypeDesc) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_TypeDesc_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeDesc);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeDesc);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (TypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_TypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User1) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User1_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser1);
            var propertyInfo = this.GetPropertyInfo(PropertyUser1);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User10) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User10_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser10);
            var propertyInfo = this.GetPropertyInfo(PropertyUser10);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User2) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User2_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser2);
            var propertyInfo = this.GetPropertyInfo(PropertyUser2);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User3) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User3_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser3);
            var propertyInfo = this.GetPropertyInfo(PropertyUser3);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User4) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User4_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser4);
            var propertyInfo = this.GetPropertyInfo(PropertyUser4);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User5) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User5_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser5);
            var propertyInfo = this.GetPropertyInfo(PropertyUser5);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User6) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User6_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser6);
            var propertyInfo = this.GetPropertyInfo(PropertyUser6);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User7) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User7_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser7);
            var propertyInfo = this.GetPropertyInfo(PropertyUser7);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User8) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User8_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser8);
            var propertyInfo = this.GetPropertyInfo(PropertyUser8);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxIncident) => Property (User9) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxIncident_Public_Class_User9_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser9);
            var propertyInfo = this.GetPropertyInfo(PropertyUser9);

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
        public void AUT_OnyxIncident_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var incNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { incNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodinitializeWithObjectXML, methodinitializeWithObjectXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOfinitializeWithObjectXML);

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
        public void AUT_OnyxIncident_initializeWithObjectXML_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodinitializeWithObjectXML);
            var incNode = this.CreateType<XmlNode>();
            var methodinitializeWithObjectXMLParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfinitializeWithObjectXML = { incNode };

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
        public void AUT_OnyxIncident_initializeWithObjectXML_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_OnyxIncident_initializeWithObjectXML_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxIncident_initializeWithObjectXML_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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
        private void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);

            // Act
            Action executeAction = () => _onyxIncidentInstance.RetrieveFromOnyx();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxIncidentInstance.RetrieveFromOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFromOnyx);
            Type [] methodRetrieveFromOnyxParametersTypes = null;
            object[] parametersOfRetrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFromOnyx, methodRetrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxIncidentInstanceFixture, parametersOfRetrieveFromOnyx);
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
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_OnyxIncident_RetrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveAuditLogFromOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var sortOrder = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxIncidentInstance.RetrieveAuditLogFromOnyx(sortOrder);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var sortOrder = this.CreateType<string>();
            var returnedValue = default(XmlNode);

            // Act
            Action executeAction = () => returnedValue = _onyxIncidentInstance.RetrieveAuditLogFromOnyx(sortOrder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var sortOrder = this.CreateType<string>();
            var methodRetrieveAuditLogFromOnyxParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRetrieveAuditLogFromOnyx = { sortOrder };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_onyxIncidentInstanceFixture, parametersOfRetrieveAuditLogFromOnyx);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodRetrieveAuditLogFromOnyx, parametersOfRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveAuditLogFromOnyx.ShouldNotBeNull();
            parametersOfRetrieveAuditLogFromOnyx.Length.ShouldBe(1);
            methodRetrieveAuditLogFromOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var sortOrder = this.CreateType<string>();
            var methodRetrieveAuditLogFromOnyxParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfRetrieveAuditLogFromOnyx = { sortOrder };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodRetrieveAuditLogFromOnyx, parametersOfRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes);

            // Assert
            parametersOfRetrieveAuditLogFromOnyx.ShouldNotBeNull();
            parametersOfRetrieveAuditLogFromOnyx.Length.ShouldBe(1);
            methodRetrieveAuditLogFromOnyxParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var methodRetrieveAuditLogFromOnyxParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveAuditLogFromOnyxParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var methodRetrieveAuditLogFromOnyxParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveAuditLogFromOnyx, methodRetrieveAuditLogFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveAuditLogFromOnyxParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAuditLogFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveAuditLogFromOnyx) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveAuditLogFromOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAuditLogFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAuditLogFromOnyx, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_UpdateInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodUpdateInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxIncidentInstance.UpdateInOnyx(sParameters, addNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfUpdateInOnyx = { sParameters, addNodes };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOfUpdateInOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateInOnyx.ShouldNotBeNull();
            parametersOfUpdateInOnyx.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(parametersOfUpdateInOnyx.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var sParameters = this.CreateType<string>();
            var addNodes = this.CreateType<Dictionary<String, String>>();
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfUpdateInOnyx = { sParameters, addNodes };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateInOnyx, parametersOfUpdateInOnyx, methodUpdateInOnyxParametersTypes);

            // Assert
            parametersOfUpdateInOnyx.ShouldNotBeNull();
            parametersOfUpdateInOnyx.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(parametersOfUpdateInOnyx.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var methodUpdateInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateInOnyx, methodUpdateInOnyxParametersTypes);

            // Assert
            methodUpdateInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateInOnyx) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_UpdateInOnyx_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateInOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateInOnyx, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_InsertInOnyx_Method_Call_Internally(Type[] types)
        {
            var methodInsertInOnyxParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertInOnyx, methodInsertInOnyxParametersTypes);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();

            // Act
            Action executeAction = () => _onyxIncidentInstance.InsertInOnyx(sParameters, collectionNodes);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var returnedValue = default(OnyxIncident);

            // Act
            Action executeAction = () => returnedValue = _onyxIncidentInstance.InsertInOnyx(sParameters, collectionNodes);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
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
            var result1 = currentMethodInfo.GetResultMethodInfo<OnyxIncident>(_onyxIncidentInstanceFixture, parametersOfInsertInOnyx);
            var result2 = this.GetResultOfMethod<OnyxIncident>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

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

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertInOnyx);
            var sParameters = this.CreateType<string>();
            var collectionNodes = this.CreateType<Dictionary<String, String>>();
            var methodInsertInOnyxParametersTypes = new Type[] { typeof(String), typeof(Dictionary<String, String>) };
            object[] parametersOfInsertInOnyx = { sParameters, collectionNodes };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxIncident>(MethodInsertInOnyx, parametersOfInsertInOnyx, methodInsertInOnyxParametersTypes);

            // Assert
            parametersOfInsertInOnyx.ShouldNotBeNull();
            parametersOfInsertInOnyx.Length.ShouldBe(2);
            methodInsertInOnyxParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (InsertInOnyx) (Return Type : OnyxIncident) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertInOnyx_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (InsertWorkNote) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_InsertWorkNote_Method_Call_Internally(Type[] types)
        {
            var methodInsertWorkNoteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertWorkNote, methodInsertWorkNoteParametersTypes);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var note = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxIncidentInstance.InsertWorkNote(note);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var note = this.CreateType<string>();
            var methodInsertWorkNoteParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfInsertWorkNote = { note };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertWorkNote, methodInsertWorkNoteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOfInsertWorkNote);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertWorkNote.ShouldNotBeNull();
            parametersOfInsertWorkNote.Length.ShouldBe(1);
            methodInsertWorkNoteParametersTypes.Length.ShouldBe(1);
            methodInsertWorkNoteParametersTypes.Length.ShouldBe(parametersOfInsertWorkNote.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var note = this.CreateType<string>();
            var methodInsertWorkNoteParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfInsertWorkNote = { note };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertWorkNote, parametersOfInsertWorkNote, methodInsertWorkNoteParametersTypes);

            // Assert
            parametersOfInsertWorkNote.ShouldNotBeNull();
            parametersOfInsertWorkNote.Length.ShouldBe(1);
            methodInsertWorkNoteParametersTypes.Length.ShouldBe(1);
            methodInsertWorkNoteParametersTypes.Length.ShouldBe(parametersOfInsertWorkNote.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertWorkNote, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var methodInsertWorkNoteParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertWorkNote, methodInsertWorkNoteParametersTypes);

            // Assert
            methodInsertWorkNoteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertWorkNote) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertWorkNote_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertWorkNote);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertWorkNote, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveWorkNotesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);

            // Act
            Action executeAction = () => _onyxIncidentInstance.RetrieveWorkNotes();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxIncidentInstance.RetrieveWorkNotes();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            Type [] methodRetrieveWorkNotesParametersTypes = null;
            object[] parametersOfRetrieveWorkNotes = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxIncidentInstanceFixture, parametersOfRetrieveWorkNotes);
            var result2 = this.GetResultOfMethod<String>(MethodRetrieveWorkNotes, parametersOfRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveWorkNotes.ShouldBeNull();
            methodRetrieveWorkNotesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            Type [] methodRetrieveWorkNotesParametersTypes = null;
            object[] parametersOfRetrieveWorkNotes = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodRetrieveWorkNotes, parametersOfRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes);

            // Assert
            parametersOfRetrieveWorkNotes.ShouldBeNull();
            methodRetrieveWorkNotesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            Type [] methodRetrieveWorkNotesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveWorkNotesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            Type [] methodRetrieveWorkNotesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveWorkNotes, methodRetrieveWorkNotesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveWorkNotesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveWorkNotes) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_RetrieveWorkNotes_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveWorkNotes);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveWorkNotes, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_InsertAlert_Method_Call_Internally(Type[] types)
        {
            var methodInsertAlertParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertAlert, methodInsertAlertParametersTypes);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var alert = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxIncidentInstance.InsertAlert(alert);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var alert = this.CreateType<string>();
            var methodInsertAlertParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfInsertAlert = { alert };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertAlert, methodInsertAlertParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOfInsertAlert);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertAlert.ShouldNotBeNull();
            parametersOfInsertAlert.Length.ShouldBe(1);
            methodInsertAlertParametersTypes.Length.ShouldBe(1);
            methodInsertAlertParametersTypes.Length.ShouldBe(parametersOfInsertAlert.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var alert = this.CreateType<string>();
            var methodInsertAlertParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfInsertAlert = { alert };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertAlert, parametersOfInsertAlert, methodInsertAlertParametersTypes);

            // Assert
            parametersOfInsertAlert.ShouldNotBeNull();
            parametersOfInsertAlert.Length.ShouldBe(1);
            methodInsertAlertParametersTypes.Length.ShouldBe(1);
            methodInsertAlertParametersTypes.Length.ShouldBe(parametersOfInsertAlert.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertAlert, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var methodInsertAlertParametersTypes = new Type[] { typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertAlert, methodInsertAlertParametersTypes);

            // Assert
            methodInsertAlertParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertAlert) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_InsertAlert_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertAlert);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertAlert, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_CreateIncident_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateIncidentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateIncident, methodCreateIncidentParametersTypes);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var incident = this.CreateType<XElement>();

            // Act
            Action executeAction = () => OnyxIncident.CreateIncident(incident);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var incident = this.CreateType<XElement>();
            var returnedValue = default(OnyxIncident);

            // Act
            Action executeAction = () => returnedValue = OnyxIncident.CreateIncident(incident);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var incident = this.CreateType<XElement>();
            var methodCreateIncidentParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfCreateIncident = { incident };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncident, methodCreateIncidentParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateIncident, methodCreateIncidentParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxIncident>(MethodCreateIncident, parametersOfCreateIncident, methodCreateIncidentParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOfCreateIncident);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateIncident.ShouldNotBeNull();
            parametersOfCreateIncident.Length.ShouldBe(1);
            methodCreateIncidentParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var incident = this.CreateType<XElement>();
            var methodCreateIncidentParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfCreateIncident = { incident };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxIncident>(MethodCreateIncident, parametersOfCreateIncident, methodCreateIncidentParametersTypes);

            // Assert
            parametersOfCreateIncident.ShouldNotBeNull();
            parametersOfCreateIncident.Length.ShouldBe(1);
            methodCreateIncidentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var methodCreateIncidentParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateIncident, methodCreateIncidentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateIncidentParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var methodCreateIncidentParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateIncident, methodCreateIncidentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateIncidentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncident, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateIncident) (Return Type : OnyxIncident) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_CreateIncident_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateIncident);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateIncident, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_Internally(Type[] types)
        {
            var methodlogErrorToIntegrationLogParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodlogErrorToIntegrationLog, methodlogErrorToIntegrationLogParametersTypes);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogErrorToIntegrationLog);
            var errSource = this.CreateType<string>();
            var errMsg = this.CreateType<string>();
            var methodlogErrorToIntegrationLogParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOflogErrorToIntegrationLog = { errSource, errMsg };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodlogErrorToIntegrationLog, methodlogErrorToIntegrationLogParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxIncidentInstanceFixture, parametersOflogErrorToIntegrationLog);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOflogErrorToIntegrationLog.ShouldNotBeNull();
            parametersOflogErrorToIntegrationLog.Length.ShouldBe(2);
            methodlogErrorToIntegrationLogParametersTypes.Length.ShouldBe(2);
            methodlogErrorToIntegrationLogParametersTypes.Length.ShouldBe(parametersOflogErrorToIntegrationLog.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogErrorToIntegrationLog);
            var errSource = this.CreateType<string>();
            var errMsg = this.CreateType<string>();
            var methodlogErrorToIntegrationLogParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOflogErrorToIntegrationLog = { errSource, errMsg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodlogErrorToIntegrationLog, parametersOflogErrorToIntegrationLog, methodlogErrorToIntegrationLogParametersTypes);

            // Assert
            parametersOflogErrorToIntegrationLog.ShouldNotBeNull();
            parametersOflogErrorToIntegrationLog.Length.ShouldBe(2);
            methodlogErrorToIntegrationLogParametersTypes.Length.ShouldBe(2);
            methodlogErrorToIntegrationLogParametersTypes.Length.ShouldBe(parametersOflogErrorToIntegrationLog.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogErrorToIntegrationLog);
            var currentMethodInfo = this.GetMethodInfo(MethodlogErrorToIntegrationLog, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogErrorToIntegrationLog);
            var methodlogErrorToIntegrationLogParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodlogErrorToIntegrationLog, methodlogErrorToIntegrationLogParametersTypes);

            // Assert
            methodlogErrorToIntegrationLogParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (logErrorToIntegrationLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxIncident_logErrorToIntegrationLog_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodlogErrorToIntegrationLog);
            var currentMethodInfo = this.GetMethodInfo(MethodlogErrorToIntegrationLog, 0);

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