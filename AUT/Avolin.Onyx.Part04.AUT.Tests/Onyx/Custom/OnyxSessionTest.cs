using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.OnyxSession" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSessionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSession" />)
        /// </summary>
        public OnyxSessionTest() : base(typeof(OnyxSession))
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

        #region General Initializer : Class (OnyxSession) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSessionInstanceType;
        private OnyxSession _onyxSessionInstance;
        private OnyxSession _onyxSessionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSession" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSessionInstanceType = typeof(OnyxSession);
            _onyxSessionInstanceFixture = this.Create<OnyxSession>(false);
            _onyxSessionInstance = _onyxSessionInstanceFixture ?? this.Create<OnyxSession>(true);
            CurrentInstance = _onyxSessionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Initializer

        #region Properties

        private const string PropertyCurrentExecFolder = "CurrentExecFolder";
        private const string PropertySessionId = "SessionId";
        private const string PropertyTransactionId = "TransactionId";
        private const string PropertyInstitutionId = "InstitutionId";
        private const string PropertyAppName = "AppName";
        private const string PropertyContextUser = "ContextUser";
        private const string PropertySource = "Source";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertysiteId = "siteId";
        private const string PropertyInputXml = "InputXml";
        private const string PropertyIndividualSecondaryId = "IndividualSecondaryId";
        private const string PropertyIncidentSecondaryId = "IncidentSecondaryId";

        #endregion

        #region Fields

        private const string FieldsessionId = "sessionId";
        private const string FieldappName = "appName";
        private const string FielduserId = "userId";
        private const string Fieldsource = "source";
        private const string FieldlanguageCode = "languageCode";
        private const string FieldSiteId = "SiteId";
        private const string FieldtransactionId = "transactionId";
        private const string FieldinstitutionId = "institutionId";
        private const string FieldinXml = "inXml";
        private const string FieldincSecId = "incSecId";
        private const string FieldindSecId = "indSecId";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSession) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSession_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSession)

        #region General Initializer : Class (OnyxSession) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCurrentExecFolder)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyTransactionId)]
        [TestCase(PropertyInstitutionId)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyContextUser)]
        [TestCase(PropertySource)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertysiteId)]
        [TestCase(PropertyInputXml)]
        [TestCase(PropertyIndividualSecondaryId)]
        [TestCase(PropertyIncidentSecondaryId)]
        [Category("AUT Property")]
        public void AUT_OnyxSession_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSession) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsessionId)]
        [TestCase(FieldappName)]
        [TestCase(FielduserId)]
        [TestCase(Fieldsource)]
        [TestCase(FieldlanguageCode)]
        [TestCase(FieldSiteId)]
        [TestCase(FieldtransactionId)]
        [TestCase(FieldinstitutionId)]
        [TestCase(FieldinXml)]
        [TestCase(FieldincSecId)]
        [TestCase(FieldindSecId)]
        [Category("AUT Fields")]
        public void AUT_OnyxSession_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxSession) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSession" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSession_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSessionInstance.ShouldBeAssignableTo<OnyxSession>();
            _onyxSessionInstanceFixture.ShouldBeAssignableTo<OnyxSession>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSession>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSession) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCurrentExecFolder)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyTransactionId)]
        [TestCase(PropertyInstitutionId)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyContextUser)]
        [TestCase(PropertySource)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertysiteId)]
        [TestCase(PropertyInputXml)]
        [TestCase(PropertyIndividualSecondaryId)]
        [TestCase(PropertyIncidentSecondaryId)]
        public void AUT_OnyxSession_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSession) => Property (AppName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_AppName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppName);
            var propertyInfo = this.GetPropertyInfo(PropertyAppName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (ContextUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_ContextUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContextUser);
            var propertyInfo = this.GetPropertyInfo(PropertyContextUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (CurrentExecFolder) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_CurrentExecFolder_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentExecFolder);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentExecFolder);
            Action currentAction = () => propertyInfo.SetValue(_onyxSessionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (CurrentExecFolder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_CurrentExecFolder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentExecFolder);
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentExecFolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (IncidentSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_IncidentSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncidentSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyIncidentSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (IndividualSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_IndividualSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIndividualSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyIndividualSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (InputXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_InputXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInputXml);
            var propertyInfo = this.GetPropertyInfo(PropertyInputXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (InstitutionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_InstitutionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInstitutionId);
            var propertyInfo = this.GetPropertyInfo(PropertyInstitutionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionId);
            var propertyInfo = this.GetPropertyInfo(PropertySessionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (siteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_siteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysiteId);
            var propertyInfo = this.GetPropertyInfo(PropertysiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (Source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_Source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySource);
            var propertyInfo = this.GetPropertyInfo(PropertySource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSession) => Property (TransactionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSession_Public_Class_TransactionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTransactionId);
            var propertyInfo = this.GetPropertyInfo(PropertyTransactionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}