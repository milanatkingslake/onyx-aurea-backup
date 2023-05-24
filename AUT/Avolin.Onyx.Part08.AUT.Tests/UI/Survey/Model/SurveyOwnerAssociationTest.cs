using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Survey.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.Model.SurveyOwnerAssociation" />)
    ///     and namespace <see cref="Onyx.UI.Survey.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SurveyOwnerAssociationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyOwnerAssociation" />)
        /// </summary>
        public SurveyOwnerAssociationTest() : base(typeof(SurveyOwnerAssociation))
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

        #region General Initializer : Class (SurveyOwnerAssociation) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyOwnerAssociationInstanceType;
        private SurveyOwnerAssociation _surveyOwnerAssociationInstance;
        private SurveyOwnerAssociation _surveyOwnerAssociationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyOwnerAssociation" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyOwnerAssociationInstanceType = typeof(SurveyOwnerAssociation);
            _surveyOwnerAssociationInstanceFixture = this.Create<SurveyOwnerAssociation>(false);
            _surveyOwnerAssociationInstance = _surveyOwnerAssociationInstanceFixture ?? this.Create<SurveyOwnerAssociation>(true);
            CurrentInstance = _surveyOwnerAssociationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerAssociation) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySurveyOwnerId = "SurveyOwnerId";
        private const string PropertySurveyOwnerType = "SurveyOwnerType";
        private const string PropertySurveyOwnerSecondaryId = "SurveyOwnerSecondaryId";
        private const string PropertySurveyOwnerName = "SurveyOwnerName";
        private const string PropertyReadOnlyAccess = "ReadOnlyAccess";
        private const string PropertyPrivateAccess = "PrivateAccess";
        private const string PropertyLocked = "Locked";
        private const string PropertySurvey = "Survey";
        private const string PropertyOnyxTimeStamp = "OnyxTimeStamp";
        private const string PropertySurveyOwnerQuestionResponse = "SurveyOwnerQuestionResponse";

        #endregion

        #endregion

        #region General Initializer : Class (SurveyOwnerAssociation) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerAssociation_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerAssociation) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerAssociation_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyOwnerAssociation) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyOwnerAssociation_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SurveyOwnerAssociation)

        #region General Initializer : Class (SurveyOwnerAssociation) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySurveyOwnerId)]
        [TestCase(PropertySurveyOwnerType)]
        [TestCase(PropertySurveyOwnerSecondaryId)]
        [TestCase(PropertySurveyOwnerName)]
        [TestCase(PropertyReadOnlyAccess)]
        [TestCase(PropertyPrivateAccess)]
        [TestCase(PropertyLocked)]
        [TestCase(PropertySurvey)]
        [TestCase(PropertyOnyxTimeStamp)]
        [TestCase(PropertySurveyOwnerQuestionResponse)]
        [Category("AUT Property")]
        public void AUT_SurveyOwnerAssociation_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SurveyOwnerAssociation) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyOwnerAssociation_Is_Instance_Present_Test()
        {
            // Assert
            _surveyOwnerAssociationInstanceType.ShouldNotBeNull();
            _surveyOwnerAssociationInstance.ShouldNotBeNull();
            _surveyOwnerAssociationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyOwnerAssociation) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyOwnerAssociation" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyOwnerAssociation_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyOwnerAssociationInstance.ShouldBeAssignableTo<SurveyOwnerAssociation>();
            _surveyOwnerAssociationInstanceFixture.ShouldBeAssignableTo<SurveyOwnerAssociation>();
            CurrentInstance.ShouldBeAssignableTo<SurveyOwnerAssociation>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyOwnerAssociation) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyOwnerAssociation_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyOwnerAssociation instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySurveyOwnerId)]
        [TestCase(PropertySurveyOwnerType)]
        [TestCase(PropertySurveyOwnerSecondaryId)]
        [TestCase(PropertySurveyOwnerName)]
        [TestCase(PropertyReadOnlyAccess)]
        [TestCase(PropertyPrivateAccess)]
        [TestCase(PropertyLocked)]
        [TestCase(PropertySurvey)]
        [TestCase(PropertyOnyxTimeStamp)]
        [TestCase(PropertySurveyOwnerQuestionResponse)]
        public void AUT_SurveyOwnerAssociation_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (Locked) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_Locked_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLocked);
            var propertyInfo = this.GetPropertyInfo(PropertyLocked);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (OnyxTimeStamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_OnyxTimeStamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxTimeStamp);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxTimeStamp);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (PrivateAccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_PrivateAccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrivateAccess);
            var propertyInfo = this.GetPropertyInfo(PropertyPrivateAccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (ReadOnlyAccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_ReadOnlyAccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReadOnlyAccess);
            var propertyInfo = this.GetPropertyInfo(PropertyReadOnlyAccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (Survey) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Survey_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurvey);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySurvey);
            Action currentAction = () => propertyInfo.SetValue(_surveyOwnerAssociationInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (Survey) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_Survey_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurvey);
            var propertyInfo = this.GetPropertyInfo(PropertySurvey);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (SurveyOwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_SurveyOwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (SurveyOwnerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_SurveyOwnerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerName);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (SurveyOwnerQuestionResponse) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_SurveyOwnerQuestionResponse_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerQuestionResponse);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerQuestionResponse);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (SurveyOwnerSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_SurveyOwnerSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SurveyOwnerAssociation) => Property (SurveyOwnerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SurveyOwnerAssociation_Public_Class_SurveyOwnerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySurveyOwnerType);
            var propertyInfo = this.GetPropertyInfo(PropertySurveyOwnerType);

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